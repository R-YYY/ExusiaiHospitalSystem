using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OracleHospital;

namespace HospitalManagementSystem {
    public partial class FormDocSubHistoryAttendanceSheet : Form {
        private string Doctor_ID;
        private string token;

        Functions myFunctions = new Functions();
        List<AttendenceInfo> myAttendenceInfo = new List<AttendenceInfo>();

        //***************************************************
        int compare(AttendenceInfo a1, AttendenceInfo a2) {
            if (a1.day > a2.day)
                return 1;
            else if (a1.day == a2.day)
                return 0;
            else return -1;
        }



        public FormDocSubHistoryAttendanceSheet(string ID, string tok) {
            Doctor_ID = ID;
            token = tok;
            InitializeComponent();

            var intro = myFunctions.getDoctorIntro();//获得所有医生的信息
            var result = intro.Find(delegate (DoctorInfo info) { return info.ID == Doctor_ID; });//找到该医生

            uiLabel3.Text = Doctor_ID;
            uiLabel5.Text = result.name;

            myAttendenceInfo = myFunctions.getAttendenceSheets(Doctor_ID, token, DateTime.Now.Year, DateTime.Now.Month);
            //********************************
            myAttendenceInfo.Sort(compare);

            int day = DateTime.Now.Day;
            int i = 1, j = 0;
            while (i <= day || j < myAttendenceInfo.Count) {
                if (j < myAttendenceInfo.Count && myAttendenceInfo[j].day == i) {
                    int index = uiDataGridView1.Rows.Add();
                    uiDataGridView1.Rows[index].Cells["Column1"].Value = DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + myAttendenceInfo[j].day;
                    uiDataGridView1.Rows[index].Cells["Column2"].Value = myAttendenceInfo[j].state;
                    i++;
                    j++;
                }
                else {
                    int index = uiDataGridView1.Rows.Add();
                    uiDataGridView1.Rows[index].Cells["Column1"].Value = DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + i.ToString();
                    uiDataGridView1.Rows[index].Cells["Column2"].Value = "缺勤";
                    i++;
                }
            }
        }

        private void uiButton1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}