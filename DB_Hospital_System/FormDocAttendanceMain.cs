using System;
using System.Collections.Generic;
using Sunny.UI;
using OracleHospital;

namespace HospitalManagementSystem {
    public partial class FormDocAttendanceMain : UIPage {
        Functions myFunctions = new Functions();
        private string Doctor_ID;
        private string token;

        public FormDocAttendanceMain(string ID, string tok) {
            Doctor_ID = ID;
            token = tok;
            InitializeComponent();
            check();
        }

        private void check() {
            //var intro = myFunctions.getDoctorIntro();//返回所有的医生信息
            //var result = intro.Find(delegate (DoctorInfo info) { return info.ID == Doctor_ID; });//从所有的医生信息中找到ID为Doctor_ID的医生信息
            List<AttendenceInfo> attendenceInfo;
            attendenceInfo = myFunctions.getAttendenceSheets(
                Doctor_ID, token, DateTime.Now.Year, DateTime.Now.Month);//返回本月的所有考勤记录

            //在本月所有考勤记录中找到今天的考勤记录，检查今天的考勤有没有完成
            foreach (AttendenceInfo ai in attendenceInfo) {
                //如果考勤记录中有考勤记录，就说明今天的考勤已完成
                if (ai.day == DateTime.Now.Day) {          
                    this.uiButton1.Text = "今日考勤已完成";
                    this.uiLabel2.Text = "已完成";
                    return;
                }
            }
        }
        //点击“查看”历史考勤按钮，弹出本月历史考勤信息的界面
        private void uiButton2_Click(object sender, EventArgs e) {
            FormDocSubHistoryAttendanceSheet historyAttendanceSheetForm = 
                new FormDocSubHistoryAttendanceSheet(Doctor_ID, token);
            historyAttendanceSheetForm.ShowDialog();
        }

        private void uiButton1_Click(object sender, EventArgs e) {
            //如果按钮上显示的是“今日考勤已完成”，点击按钮后展示的是今天考勤已完成的提示界面
            if (uiButton1.Text == "今日考勤已完成") {
                FormDocSubTodayAttendanceFinished todayAttendanceFinishedForm = 
                    new FormDocSubTodayAttendanceFinished();
                todayAttendanceFinishedForm.ShowDialog();
            }
            //如果按钮上显示的是“点击此处考勤”，即今日考勤未完成
            else {
                FormDocSubVerifyAttendance verifyAttendanceForm = 
                    new FormDocSubVerifyAttendance(Doctor_ID, token);//创建考勤打卡界面
                //第四步：初始化事件
                verifyAttendanceForm.setFormLabel2Value += 
                    new setLabel2Value(verifyAttendanceForm_setFormLabel2Value);
                verifyAttendanceForm.setFormButton1Value += 
                    new setButton1Value(verifyAttendanceForm_setFormButton1Value);

                verifyAttendanceForm.ShowDialog();
            }


        }

        //第五步：实现事件
        void verifyAttendanceForm_setFormLabel2Value(string label2Value) {
            //具体实现
            this.uiLabel2.Text = label2Value;

        }
        void verifyAttendanceForm_setFormButton1Value(string button1Value) {
            this.uiButton1.Text = button1Value;
        }

    }
}