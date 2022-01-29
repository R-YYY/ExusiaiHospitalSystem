using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sunny.UI;
using OracleHospital;

namespace HospitalManagementSystem {
    public partial class FormDocSearchBed : UIPage {


        private int currentRow; //选中行

        Functions myFunctions = new Functions();
        List<WardInfo> myWardInfo = new List<WardInfo>();

        //***************************************************
        int compare(WardInfo a1, WardInfo a2) {
            if (String.Compare(a1.Ward_ID, a2.Ward_ID) > 0)
                return 1;
            else if (a1.Ward_ID == a2.Ward_ID)
                return 0;
            else return -1;
        }

        public FormDocSearchBed() {
            InitializeComponent();
            AddBtn();//添加“查看”按钮

        }

        private void AddBtn() {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "WardBtn";//添加按钮的名字
            btn.HeaderText = "病房详情";//添加按钮列的列名称
            btn.DefaultCellStyle.NullValue = "查看";//添加按钮显示的名字
            uiDataGridView1.Columns.Add(btn);//在dataGridView1的最后一列添加按钮
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //防止点击列标题返回-1
            if (e.RowIndex == -1)
                return;

            currentRow = e.RowIndex;

            if (uiDataGridView1.Columns[e.ColumnIndex].Name == "WardBtn" && e.RowIndex >= 0) {
                string wardID = uiDataGridView1.Rows[currentRow].Cells["Column1"].Value.ToString();
                FormDocSubWardDetailed wardDetailedForm = new FormDocSubWardDetailed(wardID);
                wardDetailedForm.ShowDialog();
            }

        }

        private void SearchBedForm_Initialize(object sender, EventArgs e) {
            showData();//表格中显示数据
        }

        private void showData() {
            //清空表格
            while (uiDataGridView1.Rows.Count != 0)
                uiDataGridView1.Rows.RemoveAt(0);

            currentRow = 0;
            myWardInfo = myFunctions.getWard();
            //********************************
            myWardInfo.Sort(compare);

            foreach (var wi in myWardInfo) {
                int index = uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[index].Cells["Column1"].Value = wi.Ward_ID;
                uiDataGridView1.Rows[index].Cells["WardBtn"].Value = "查看";

            }
        }
    }
}