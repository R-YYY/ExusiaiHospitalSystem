using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sunny.UI;
using OracleHospital;
using System.ComponentModel;

namespace HospitalManagementSystem {
    public partial class FormDocMedicine : UIPage {
        public string Doctor_ID;
        public string token;
        public string Medicine_ID;
        List<DrugInfo> drugInfos;
        Functions funcs = new Functions();

        public FormDocMedicine() {
            InitializeComponent();
            AddBtn();

            // 实例化function类
            // 调用api
            drugInfos = funcs.GetDrugInfo();
            addData(drugInfos);
        }

        private void AddBtn() {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "MedicineBtn";//添加按钮的名字
            btn.HeaderText = "详细信息";//添加按钮列的列名称
            btn.DefaultCellStyle.NullValue = "查看";//添加按钮显示的名字
            uiDataGridView1.Columns.Add(btn);//在dataGridView1的最后一列添加按钮
        }

        private void uiDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {
            if (uiDataGridView1.Columns[e.ColumnIndex].Name == "MedicineBtn" && e.RowIndex >= 0) {
                DataGridViewColumn column = uiDataGridView1.Columns[e.ColumnIndex];
                // 找到要传到详细信息页面的药品ID
                Medicine_ID = uiDataGridView1.Rows[e.RowIndex].Cells["MedicineID"].Value.ToString();
                Form childForm = new FormDocSubDetailedInformation(Medicine_ID);
                childForm.ShowDialog();

            }
        }

        private void uiDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e) {

            if (uiDataGridView1.Columns[e.ColumnIndex].Name == "MedicineNum" && e.RowIndex >= 0) {
                    DataGridViewColumn column = uiDataGridView1.Columns[e.ColumnIndex];
                // 找到要传到详细信息页面的药品ID
                Medicine_ID = uiDataGridView1.Rows[e.RowIndex].Cells["MedicineID"].Value.ToString();
                int MedicineNum = uiDataGridView1.Rows[e.RowIndex].Cells["MedicineNum"].Value.ToString().ToInt();

                List<DrugInfo> drugInfos = funcs.GetDrugInfo();
                var drugInfo = drugInfos.Find(delegate (DrugInfo drug) { return drug.ID == Medicine_ID; });
                drugInfo.stock = MedicineNum;
                funcs.setDrugInfo(Medicine_ID, drugInfo);

            }
        }

        private void button_Flush_Click(object sender, EventArgs e) {

            drugInfos.Clear();
            while (uiDataGridView1.Rows.Count != 0)
                uiDataGridView1.Rows.RemoveAt(0);

            // 实例化function类
            drugInfos = funcs.GetDrugInfo();
            // 调用api
            addData(drugInfos);
        }

        private void uiTextBox_Name_TextChanged(object sender, EventArgs e) {
            while (uiDataGridView1.Rows.Count != 0)
                uiDataGridView1.Rows.RemoveAt(0);
            List<DrugInfo> drugs = new List<DrugInfo>();
            if (uiTextBox_Name.Text.Trim() == "")
                drugs = drugInfos;
            else foreach (DrugInfo di in drugInfos)
                    if (di.name.Contains(uiTextBox_Name.Text.ToString()))
                        drugs.Add(di);
            addData(drugs);

        }
        private void addData(List<DrugInfo> drugs) {
            foreach (DrugInfo drugInfo in drugs) {
                string a, b, c;
                a = drugInfo.ID;
                b = drugInfo.name;
                c = drugInfo.stock.ToString();
                string[] str = { a, b, c };
                uiDataGridView1.Rows.Add(str);
            }
            this.uiDataGridView1.Sort(this.uiDataGridView1.Columns[0], ListSortDirection.Ascending);
        }
    }
}