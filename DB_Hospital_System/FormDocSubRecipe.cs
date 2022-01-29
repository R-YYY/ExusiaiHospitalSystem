using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;
using OracleHospital;
using System.Linq;

namespace HospitalManagementSystem {
    public partial class FormDocSubRecipe : Form {
        Functions functions = new Functions();
        private int currentRow;  //选中行
        private List<DrugInfo> DrugInfos;  //所有药品信息
        private List<string> takeMedicine;  //添加的药品id
        private List<int> takeNum;
        private List<int> takeStock;

        private bool uiTextBox_NameHasText;  //搜索框是否有输入文字
        private DataGridViewTextBoxEditingControl CellEdit = null;  //控制编辑datagridview单元格

        public FormDocSubRecipe(List<string> M, List<int> N) {
            DrugInfos = new List<DrugInfo>();
            DrugInfos = functions.GetDrugInfo();
            takeMedicine = new List<string>();
            takeNum = new List<int>();
            takeStock = new List<int>();

            for (int i = 0; i < M.Count; i++) {
                takeMedicine.Add(M[i]);
                takeNum.Add(N[i]);
            }
            //takeNum = N;
            //takeMedicine = L;
            InitializeComponent();
        }

        private void RecipeForm_Load(object sender, EventArgs e) {
            //药品清单中显示处方已添加的药品
            //foreach (string tm in takeMedicine) 
                for(int i = 0; i < takeMedicine.Count(); i++) {
                DrugInfo di = find(takeMedicine[i]);

                takeStock.Add(di.stock);

                //药品清单中添加药品
                int index = uiDataGridView_Take.Rows.Add();
                uiDataGridView_Take.Rows[index].Cells["MedicineName"].Value = di.name;
                uiDataGridView_Take.Rows[index].Cells["MedicineNum"].Value = takeNum[i];
                uiDataGridView_Take.Rows[index].Cells["MedicineSpecifications"].Value = di.usage;
                uiDataGridView_Take.Rows[index].Cells["MedicinePrice"].Value = di.price;
            }

            FormDocRegister registerForm = (FormDocRegister)this.Owner;
            uiTextBox_Content.Text = registerForm.Recipe_Content;

            //药品清单不可排序
            for (int i = 0; i < uiDataGridView_Take.Columns.Count; i++)
                uiDataGridView_Take.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

            //药品清单中添加删除button
            addBtn();

            //搜索框提示
            initTextBox();
        }

        //所有药品中查找药品
        private DrugInfo find(string id) {
            DrugInfo drugInfo = new DrugInfo();
            foreach (var di in DrugInfos)
                if (di.ID == id) {
                    drugInfo = di;
                    break;
                }
            return drugInfo;
        }

        // 初始化搜索框提示
        private void initTextBox() {
            uiTextBox_Name.Text = "请输入药品名称";
            uiTextBox_Name.ForeColor = Color.Gray;
            uiTextBox_NameHasText = false;
        }

        //搜索框正常输入
        private void uiTextBox_Name_Enter(object sender, EventArgs e) {
            if (uiTextBox_NameHasText == false)
                uiTextBox_Name.Text = "";
            uiTextBox_Name.ForeColor = Color.Black;
        }

        //搜索框提示
        private void uiTextBox_Name_Leave(object sender, EventArgs e) {
            if (uiTextBox_Name.Text == "") {
                uiTextBox_Name.Text = "请输入药品名称查询";
                uiTextBox_Name.ForeColor = Color.Gray;
                uiTextBox_NameHasText = false;
            }
            else uiTextBox_NameHasText = true;
        }

        // 添加删除药品button
        private void addBtn() {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "MedicineBtn";//添加按钮的名字
            btn.HeaderText = "操作";//添加按钮列的列名称
            btn.DefaultCellStyle.NullValue = "删除";//添加按钮显示的名字
            uiDataGridView_Take.Columns.Add(btn);//在dataGridView1的最后一列添加按钮
        }

        //删除药品button的功能
        private void uiDataGridView_Take_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //防止点击列标题返回-1
            if (e.RowIndex == -1)
                return;
            if (uiDataGridView_Take.CurrentCell.ColumnIndex == 4) {
                currentRow = uiDataGridView_Take.CurrentCell.RowIndex;
                DataGridViewRow drv = uiDataGridView_Take.Rows[e.RowIndex];
                uiDataGridView_Take.Rows.Remove(drv);
                takeMedicine.Remove(takeMedicine[e.RowIndex]);
                takeNum.Remove(takeNum[e.RowIndex]);
                takeStock.Remove(takeStock[e.RowIndex]);
            }
        }

        //查找药品
        private void button_Search_Click(object sender, EventArgs e) {
            //查找药品
            List<DrugInfo> drugs = new List<DrugInfo>();
            if (uiTextBox_NameHasText == false)
                drugs = DrugInfos;
            else foreach (DrugInfo di in DrugInfos)
                if (di.name.Contains(uiTextBox_Name.Text.ToString()))
                    drugs.Add(di);

            FormDocSubChooseMedicine chooseMedicine = new FormDocSubChooseMedicine(drugs);
            chooseMedicine.addMedicine += new addMedicineHandle(ChooseMedicine_addMedicineHandle);  //添加药品的回调函数
            chooseMedicine.ShowDialog();
        }

        //选择药品窗口（ChooseMedicine）的添加药品回调函数
        void ChooseMedicine_addMedicineHandle(DataGridViewRow drv) {
            //首先判断药品清单中有无搜索药品
            foreach (DataGridViewRow dgvRow in uiDataGridView_Take.Rows)
                if (dgvRow.Cells["MedicineName"].Value.ToString() == drv.Cells["MedicineName"].Value.ToString()) {
                    MessageBox.Show("药品清单中已添加过该药品，请直接修改数量！", "提示");
                    return;
                }

            takeNum.Add(1);
            takeStock.Add(Convert.ToInt32(drv.Cells["MedicineStock"].Value.ToString()));
            takeMedicine.Add(drv.Cells["MedicineID"].Value.ToString());

            //表格中显示
            int index = uiDataGridView_Take.Rows.Add();
            uiDataGridView_Take.Rows[index].Cells["MedicineName"].Value = drv.Cells["MedicineName"].Value;
            uiDataGridView_Take.Rows[index].Cells["MedicineNum"].Value = "1";
            uiDataGridView_Take.Rows[index].Cells["MedicineSpecifications"].Value = drv.Cells["MedicineSpecifications"].Value;
            uiDataGridView_Take.Rows[index].Cells["MedicinePrice"].Value = drv.Cells["MedicinePrice"].Value;
        }

        //保存处方信息
        private void uiButton_Save_Click(object sender, EventArgs e) {
            FormDocRegister registerForm = (FormDocRegister)this.Owner;
            //registerForm.takeNum.Clear();
            //registerForm.takeMedicine.Clear();
            registerForm.takeNum = takeNum;
            registerForm.takeMedicine = takeMedicine;
            registerForm.Recipe_Content = uiTextBox_Content.Text.ToString();
            this.Close();
        }

        //限制药品数量只能输入整数且小于库存数
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
            if (uiDataGridView_Take.CurrentCell.ColumnIndex == 1)//获取当前处于活动状态的单元格索引
            {
                CellEdit = (DataGridViewTextBoxEditingControl)e.Control;
                CellEdit.SelectAll();
                CellEdit.KeyPress += Cells_KeyPress; //绑定事件
            }
        }

        //限制输入数字事件
        private void Cells_KeyPress(object sender, KeyPressEventArgs e) //自定义事件
        {
            if (uiDataGridView_Take.CurrentCellAddress.X == 1)//获取当前处于活动状态的单元格索引
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9')) e.Handled = true;
                if (e.KeyChar == '\b') e.Handled = false;
            }
        }

        private void uiDataGridView_Take_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex < 0) return;
            uiDataGridView_Take.Rows[e.RowIndex].Cells["MedicineNum"].Value = 
                uiDataGridView_Take.Rows[e.RowIndex].Cells["MedicineNum"].Value.ToString().ToInt().ToString();
            if (uiDataGridView_Take.Rows[e.RowIndex].Cells["MedicineNum"].Value.ToString().ToInt() <= 0) {
                uiDataGridView_Take.Rows[e.RowIndex].Cells["MedicineNum"].Value = "1";
                takeNum[e.RowIndex] = 1;
            }
            else if (Convert.ToInt32(
                uiDataGridView_Take.Rows[e.RowIndex].Cells["MedicineNum"].Value.ToString()) >
                    takeStock[e.RowIndex]) {
                uiDataGridView_Take.Rows[e.RowIndex].Cells["MedicineNum"].Value =
                    takeStock[e.RowIndex].ToString();
                takeNum[e.RowIndex] = takeStock[e.RowIndex];
            }
            else takeNum[e.RowIndex] = uiDataGridView_Take.Rows[e.RowIndex].Cells["MedicineNum"].Value.ToString().ToInt();
        }
    }
}