using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OracleHospital;

namespace HospitalManagementSystem {
    public partial class FormDocSubWardDetailed : Form {
        Functions myFunctions = new Functions();
        List<PatientInfo> wardPatients = new List<PatientInfo>();
        List<WardInfo> myWardInfo = new List<WardInfo>();

        public FormDocSubWardDetailed(string myward_ID) {
            InitializeComponent();
            var wardList = myFunctions.getWard();
            var myward = wardList.Find(delegate (WardInfo wardinfo) { return wardinfo.Ward_ID == myward_ID; });
            uiLabel6.Text = myward.Ward_ID;
            uiLabel7.Text = myward.dept_name;
            uiLabel8.Text = myward.bed_amount.ToString();
            uiLabel9.Text = myward.free_bed_amount.ToString();
            wardPatients = myFunctions.getWardPatient(myward_ID);
            uiTextBox1.Text = "";
            if (wardPatients.Count == 0) {
                uiTextBox1.Text = "无";
            }
            else {
                for (int i = 0; i < wardPatients.Count; i++) {
                    if (wardPatients[i].sex == "male") {
                        uiTextBox1.Text = uiTextBox1.Text + wardPatients[i].name + " " + "男" + " " + wardPatients[i].age + System.Environment.NewLine;
                    }
                    else {
                        uiTextBox1.Text = uiTextBox1.Text + wardPatients[i].name + " " + "女" + " " + wardPatients[i].age + System.Environment.NewLine;
                    }
                }
            }
        }
        private void uiButton1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}