using System.Collections.Generic;
using System.Windows.Forms;
using OracleHospital;

namespace HospitalManagementSystem {
    public partial class FormDocSubDetailedInformation : Form {
        public FormDocSubDetailedInformation(string Drugs_ID) {
            InitializeComponent();

            // 实例化function类
            Functions funcs = new Functions();
            // 调用api
            List<DrugInfo> drugInfos = funcs.GetDrugInfo();
            var drugInfo = drugInfos.Find(delegate (DrugInfo drug) { return drug.ID == Drugs_ID; });
            string department = funcs.GetPharmacyName(drugInfo.ID);
            uiTextBox1.Text = drugInfo.name;
            uiTextBox2.Text = drugInfo.stock.ToString();
            uiTextBox3.Text = drugInfo.price.ToString();
            uiTextBox5.Text = drugInfo.shelf_life.ToString() + "月";
            uiTextBox7.Text = drugInfo.usage;
            uiTextBox6.Text = department;
            uiRichTextBox1.Text = drugInfo.function;
            uiTextBox4.Text = drugInfo.date.ToString();
        }

    }
}