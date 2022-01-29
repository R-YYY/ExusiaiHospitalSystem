using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OracleHospital;

namespace HospitalManagementSystem {
    public delegate void addMedicineHandle(DataGridViewRow drv);
    public partial class FormDocSubChooseMedicine : Form {
        public addMedicineHandle addMedicine;  //委托

        private int currentRow;   //当前选中行
        private List<DrugInfo> searchDrugInfos;  //查找药品信息

        public FormDocSubChooseMedicine(List<DrugInfo> di) {
            currentRow = 0;
            searchDrugInfos = new List<DrugInfo>();
            searchDrugInfos = di;
            InitializeComponent();
        }

        private void ChooseMedicine_Load(object sender, EventArgs e) {
            //显示数据
            foreach (var di in searchDrugInfos) {
                if (di.stock == 0)
                    continue;
                int index = uiDataGridView_Medicine.Rows.Add();
                uiDataGridView_Medicine.Rows[index].Cells["MedicineID"].Value = di.ID;
                uiDataGridView_Medicine.Rows[index].Cells["MedicineName"].Value = di.name;
                uiDataGridView_Medicine.Rows[index].Cells["MedicineSpecifications"].Value = di.usage;
                uiDataGridView_Medicine.Rows[index].Cells["MedicineStock"].Value = di.stock.ToString();
                uiDataGridView_Medicine.Rows[index].Cells["MedicinePrice"].Value = di.price.ToString();
            }
        }

        //确定选择药品
        private void uiButton_Confirm_Click(object sender, EventArgs e) {
            if (uiDataGridView_Medicine.Rows.Count > 0) {
                DataGridViewRow drv = uiDataGridView_Medicine.Rows[currentRow];
                addMedicine(drv);
            }
            this.Close();
        }

        //表格中选择药品
        private void uiDataGridView_Medicine_CellClick(object sender, DataGridViewCellEventArgs e) {
            //防止点击列标题返回-1
            if (e.RowIndex == -1)
                return;

            currentRow = uiDataGridView_Medicine.CurrentCell.RowIndex;
        }
    }
}