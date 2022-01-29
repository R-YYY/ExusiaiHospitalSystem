using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;
using OracleHospital;

namespace HospitalManagementSystem {
    public partial class FormDocRegister : UIPage {
        Functions functions = new Functions();

        //医生相关信息
        DateTime dt;  //时间
        private string Doctor_ID;  //医生id
        private string token;  //医生token
        private List<RecipeInfo> RecipeInfos;  //所有处方信息

        //就诊病人信息
        private PatientInfo PatientInfo;  //就诊病人的信息
        public List<string> takeMedicine;  //就诊病人的处方药品信息，不在数据库中
        public List<int> takeNum;  //就诊病人的处方药品数量
        public string Ward_ID;  //医生为就诊病人选择的住院信息，不在数据库中
        public string Recipe_Content;  //就诊病人的医嘱，不在数据库中

        //控件点击变量
        private int currentRow;  //挂号列表选中行
        private bool uiTextBox_NameHasText;  //搜索框是否有输入文字
        private bool uiTextBox_HistoryChanged;  //病史框文字是否改变

        public FormDocRegister(string D_id, string t) {
            Doctor_ID = D_id;
            token = t;

            //控件点击、输出变量
            currentRow = -1;
            Ward_ID = "";
            Recipe_Content = "";
            uiTextBox_HistoryChanged = false;
            takeMedicine = new List<string>();
            RecipeInfos = new List<RecipeInfo>();
            takeNum = new List<int>();

            //加载控件
            InitializeComponent();
            showData();
            uiPanel_Info.Hide();
        }

        private void RegisterForm_Initialize(object sender, EventArgs e) {
            //搜索框提示
            initTextBox();
        }

        //显示挂号列表信息
        private void showData() {
            dt = DateTime.Now;
            RecipeInfos.Clear();

            //查询医生的所有处方
            RecipeInfos = functions.getRecipe(Doctor_ID, token, false);

            //清空表格
            while (uiDataGridView_List.Rows.Count != 0)
                uiDataGridView_List.Rows.RemoveAt(0);

            //不可排序
            for (int i = 0; i < uiDataGridView_List.Columns.Count; i++)
                uiDataGridView_List.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            for (int i = 0; i < RecipeInfos.Count; i++) {
                if (RecipeInfos[i].state == "unfinished" && 
                    RecipeInfos[i].Doctor_ID == Doctor_ID && 
                    RecipeInfos[i].recipe_date.ToShortDateString().ToString() == 
                    dt.ToShortDateString().ToString()) {
                    PatientInfo pi = new PatientInfo();
                    pi = functions.GetPatientInfo(RecipeInfos[i].Patient_ID);
                    int index = uiDataGridView_List.Rows.Add();
                    uiDataGridView_List.Rows[index].Cells["PatientID"].Value = pi.ID;
                    uiDataGridView_List.Rows[index].Cells["PatientName"].Value = pi.name;
                    uiDataGridView_List.Rows[index].Cells["date"].Value = RecipeInfos[i].recipe_date.ToString("HH:mm:ss");
                }
                else {
                    RecipeInfos.Remove(RecipeInfos[i]);
                    i--;
                }
            }
        }

        //刷新挂号列表
        private void button_Flush_Click(object sender, EventArgs e) {
            showData();
        }

        //初始化搜索框提示
        private void initTextBox() {
            uiTextBox_Name.Text = "请输入挂号姓名";
            uiTextBox_Name.ForeColor = Color.Gray;
            uiTextBox_NameHasText = false;
        }

        //搜索框内容改变，正常显示
        private void uiTextBox_Name_Enter(object sender, EventArgs e) {
            if (uiTextBox_NameHasText == false)
                uiTextBox_Name.Text = "";
            uiTextBox_Name.ForeColor = Color.Black;
        }

        //搜索框没有聚焦且搜索框为空，显示搜索框提示
        private void uiTextBox_Name_Leave(object sender, EventArgs e) {
            if (uiTextBox_Name.Text == "") {
                uiTextBox_Name.Text = "请输入挂号姓名";
                uiTextBox_Name.ForeColor = Color.Gray;
                uiTextBox_NameHasText = false;
            }
            else uiTextBox_NameHasText = true;
        }

        //搜索框内容改变，显示所有挂号信息
        private void uiTextBox_Name_TextChanged(object sender, EventArgs e) {
            if (uiTextBox_Name.Text.ToString() == String.Empty)
                foreach (DataGridViewRow dgvRow in uiDataGridView_List.Rows)
                    dgvRow.Visible = true;
        }

        //查找挂号病人
        private void button_Search_Click(object sender, EventArgs e) {
            if (uiTextBox_NameHasText) {
                foreach (DataGridViewRow dgvRow in uiDataGridView_List.Rows) {
                    if (dgvRow.Cells["PatientName"].Value.ToString() != uiTextBox_Name.Text.ToString())
                        dgvRow.Visible = false;
                    else dgvRow.Visible = true;
                }
            }
        }

        //填写处方按钮
        private void uiButton_Recipe_Click(object sender, EventArgs e) {
            FormDocSubRecipe recipeForm = new FormDocSubRecipe(takeMedicine,takeNum);
            recipeForm.Owner = this;
            recipeForm.ShowDialog();
        }

        //安排住院按钮
        private void uiButton_Ward_Click(object sender, EventArgs e) {
            FormDocSubArrangeWard arrangeWradForm = new FormDocSubArrangeWard(Doctor_ID);
            arrangeWradForm.Owner = this;
            arrangeWradForm.ShowDialog();
        }

        //选中挂号信息
        private void uiDataGridView_List_CellClick(object sender, DataGridViewCellEventArgs e) {
            //防止点击列标题返回-1
            if (e.RowIndex == -1)
                return;

            //当前病人就诊信息是否改变
            if (e.RowIndex != currentRow && 
                (uiTextBox_HistoryChanged || Ward_ID != "" || 
                takeMedicine.Count != 0 || Recipe_Content != "")) {
                if (MessageBox.Show("当前就诊病人信息尚未保存，是否保存？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                    //保存当前病人就诊信息
                    uiButton_Finish_Click(new object(), new EventArgs());
                }
            }

            //挂号列表选中病人
            currentRow = uiDataGridView_List.CurrentCell.RowIndex;

            //更新当前就诊病人信息
            PatientInfo = functions.GetPatientInfo(RecipeInfos[currentRow].Patient_ID);

            //右方显示新选中的病人信息
            showPatientInfo();
        }

        //显示病人信息
        private void showPatientInfo() {
            uiPanel_Info.Show();
            uiLabel_Name.Text = PatientInfo.name;
            uiLabel_Age.Text = PatientInfo.age.ToString();
            uiLabel_Sex.Text = PatientInfo.sex == "female" ? "女" : "男";
            uiTextBox_History.Text = PatientInfo.MedicalHistory;

            //初始化变量
            takeMedicine = new List<string>();
            takeNum = new List<int>();
            uiTextBox_HistoryChanged = false;
            Ward_ID = "";
            Recipe_Content = "";
        }

        //提交就诊信息
        private void uiButton_Finish_Click(object sender, EventArgs e) {
            //更新数据库病人病史
            functions.setPatientHistory(Doctor_ID, token, PatientInfo.ID, uiTextBox_History.Text.ToString());

            //更新recipe的医嘱
            functions.setRecipe(Doctor_ID, token, RecipeInfos[currentRow].Recipe_ID, Recipe_Content == "" ? "无" : Recipe_Content);

            //更新数据库take表
            if (takeMedicine.Count > 0) {
                functions.addDrugsinRecipe(RecipeInfos[currentRow].Recipe_ID, takeMedicine,takeNum);
                //生成账单
                double fee = 0;
                
                DrugInfo di;
                List<DrugInfo> DrugInfos = functions.GetDrugInfo();
                for (int i = 0; i < takeMedicine.Count; i++) {
                    di = find(DrugInfos, takeMedicine[i]);
                    fee += (double)di.price * takeNum[i];
                }
                /*
                foreach (string tm in takeMedicine) {
                    di = find(DrugInfos, tm);
                    fee += (double)di.price;
                }
                */
                functions.insertBill(RecipeInfos[currentRow].Recipe_ID, PatientInfo.ID, fee);
            }

            //更新病人住院表
            if (Ward_ID != "")
                functions.setWardID(Doctor_ID, token, PatientInfo.ID, Ward_ID);

            //从表格中删除这个病人的信息
            DataGridViewRow drv = uiDataGridView_List.Rows[currentRow];
            uiDataGridView_List.Rows.Remove(drv);
            RecipeInfos.Remove(RecipeInfos[currentRow]);

            //就诊结束，恢复初始状态
            currentRow = -1;

            uiPanel_Info.Hide();
        }

        //查找药品信息
        private DrugInfo find(List<DrugInfo> DrugInfos, string id) {
            DrugInfo drugInfo = new DrugInfo();
            foreach (var di in DrugInfos)
                if (di.ID == id) {
                    drugInfo = di;
                    break;
                }
            return drugInfo;
        }

        private void uiTextBox_History_KeyPress(object sender, KeyPressEventArgs e) {
            uiTextBox_HistoryChanged = true;
        }
    }
}