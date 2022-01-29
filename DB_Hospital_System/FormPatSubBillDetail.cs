using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OracleHospital;

namespace HospitalManagementSystem {
    public partial class FormPatSubBillDetail : Form {
        string bill_ID, token;
        Functions functions = new Functions();
        public FormPatSubBillDetail(string bill_ID_tmp, string tmp_token) {
            InitializeComponent();
            token = tmp_token;
            bill_ID = bill_ID_tmp;
            Initmed();

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void bunifuButton_close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Initmed() {

            List<DrugsinRecipe> l = functions.getDrugsinRecipe(bill_ID);
            List<DrugInfo> drugInfos =  functions.GetDrugInfo();
            List<DrugInfo> DrugInfos = new List<DrugInfo>();

            //记录查询药品信息
            foreach (DrugsinRecipe d_id in l) {
                DrugInfo di = new DrugInfo();
                di = drugInfos.Find(delegate (DrugInfo drug) { return drug.ID == d_id.medicine_ID; });
                DrugInfos.Add(di);
            }
            double sum = 0;
            for (int i = 0; i < l.Count; i++) {
                this.bunifuDGV_medicine_bill.Rows.Add();
                this.bunifuDGV_medicine_bill.Rows[i].Cells[0].Value = DrugInfos[i].name;
                this.bunifuDGV_medicine_bill.Rows[i].Cells[1].Value = l[i].count;
                this.bunifuDGV_medicine_bill.Rows[i].Cells[2].Value = DrugInfos[i].price;
                sum += (double)l[i].count * (double)DrugInfos[i].price;
            }
            this.uiLabel2.Text += sum.ToString();
        }

    }
}