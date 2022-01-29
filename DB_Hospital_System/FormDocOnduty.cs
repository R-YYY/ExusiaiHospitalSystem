using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Sunny.UI;

namespace HospitalManagementSystem {
    public partial class FormDocOnduty : UIPage {
        public string Doctor_ID;
        public string token;
        public int year;
        public int month;
        public int day;
        private int flag = 0;

        public FormDocOnduty(string Doctor_ID, string token) {
            InitializeComponent();
            this.Doctor_ID = Doctor_ID;
            this.token = token;
        }

        private void ChooseDateButton_Click(object sender, EventArgs e) {
            if (flag == 0) {
                monthCalendar1.Show();
                flag = 1;
            }
            else {
                monthCalendar1.Hide();
                flag = 0;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) {
            //将选择的日期显示在文本框中
            DateBox.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void checkButton_Click_1(object sender, EventArgs e) {
            //分割日期字符串，并转化为int
            string[] sArray = DateBox.Text.Split('/');
            year = Convert.ToInt32(sArray[0]);
            month = Convert.ToInt32(sArray[1]);
            day = Convert.ToInt32(sArray[2]);

            //调用api
            OracleHospital.Functions funcs = new OracleHospital.Functions();
            List<OracleHospital.OndutyInfo> ondutyInfos = funcs.getOnduty(Doctor_ID, token, year, month, day);
            DataTable dt = new DataTable();
            dt.Columns.Add("值班时间", typeof(string));
            dt.Columns.Add("值班科室", typeof(string));
            dt.Columns.Add("值班状态", typeof(string));
            foreach (OracleHospital.OndutyInfo ondutyInfo in ondutyInfos) {
                string a, b, c;
                a = ondutyInfo.onduty_date.ToString().Replace('-', '/');
                b = ondutyInfo.dept_name;
                c = ondutyInfo.state.ToString();
                string[] str = { a, b, c };
                dt.Rows.Add(str);
                //uiDataGridView1.Rows.Add(str);
            }
            uiDataGridView1.DataSource = dt;


        }
    }
}
