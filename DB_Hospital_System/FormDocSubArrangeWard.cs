using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OracleHospital;

namespace HospitalManagementSystem {
    public partial class FormDocSubArrangeWard : Form {
        readonly Functions functions = new Functions();
        private int currentRow; //选中行
        private readonly string Doctor_ID;
        private List<WardInfo> WardInfos;

        public FormDocSubArrangeWard(string D_id) {
            Doctor_ID = D_id;
            InitializeComponent();
        }

        private void ArrangeWradForm_Load(object sender, EventArgs e) {
            //添加查看信息按钮
            //addBtn();

            //表格中显示数据
            showData();

            //病房列表不可排序
            for (int i = 0; i < uiDataGridView_Ward.Columns.Count; i++) {
                uiDataGridView_Ward.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void showData() {
            //默认选中第一行
            currentRow = 0;
            WardInfos = new List<WardInfo>();

            //查询医生所在科室的所有病房
            WardInfos = functions.getWard();

            //查找医生科室
            var dis = functions.getDoctorIntro();
            string dept_name = dis.Find(delegate (DoctorInfo info) { return info.ID == Doctor_ID; }).dept_name;

            //在处方中筛选当日挂号病人并记录病人信息
            foreach (var wi in WardInfos)
                if (wi.free_bed_amount > 0 && wi.dept_name == dept_name)  //选择病房条件
                {
                    int index = uiDataGridView_Ward.Rows.Add();
                    uiDataGridView_Ward.Rows[index].Cells["WardID"].Value = wi.Ward_ID;
                    uiDataGridView_Ward.Rows[index].Cells["FreeBedAmount"].Value = wi.free_bed_amount.ToString();
                    uiDataGridView_Ward.Rows[index].Cells["BedAmount"].Value = wi.bed_amount.ToString();
                }
        }

        private void addBtn() {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "WardBtn";//添加按钮的名字
            btn.HeaderText = "查看信息";//添加按钮列的列名称
            btn.DefaultCellStyle.NullValue = "查看信息";//添加按钮显示的名字
            uiDataGridView_Ward.Columns.Add(btn);//在dataGridView1的最后一列添加按钮
        }

        private void uiButton_Confirm_Click(object sender, EventArgs e) {
            if (uiDataGridView_Ward.Rows.Count > 0) {
                FormDocRegister registerForm = (FormDocRegister)this.Owner;
                registerForm.Ward_ID = uiDataGridView_Ward.Rows[currentRow].Cells["WardID"].Value.ToString();
            }
            this.Close();
        }

        private void uiDataGridView_Ward_CellClick(object sender, DataGridViewCellEventArgs e) {
            //防止点击列标题返回-1
            if (e.RowIndex == -1)
                return;

            currentRow = e.RowIndex;
        }
    }
}