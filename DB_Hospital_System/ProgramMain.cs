using System;
using System.Windows.Forms;

namespace HospitalManagementSystem {
    static class ProgramMain {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]

        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMainLogIn doctor_log_in;    //医生登录窗口，用0代表
            FormMainLogIn patient_log_in;   //病人登录窗口，用1代表
            FormInit app_interface = new FormInit();
            app_interface.ShowDialog();
            if (app_interface.Select_Result() == 0) {
                //如果是医生登录
                doctor_log_in = new FormMainLogIn(0);
                app_interface.Close();
                doctor_log_in.ShowDialog();
                if (doctor_log_in.Show_Is_Return()) {
                    Application.Restart();
                }
                if (doctor_log_in.DialogResult == DialogResult.OK) {
                    string ID = HospitalManagementSystem.FormInit.DoctorValue.ID;
                    string token = HospitalManagementSystem.FormInit.DoctorValue.token;
                    HospitalManagementSystem.FormDocMain doctor_main_menu = 
                        new FormDocMain(ID, token);
                    doctor_main_menu.ShowDialog();
                }
                else {
                    Application.Exit();
                }
            }
            else {
                //如果是患者登录
                patient_log_in = new FormMainLogIn(1);
                app_interface.Close();
                patient_log_in.ShowDialog();
                if (patient_log_in.Show_Is_Return()) {
                    Application.Restart();
                }
                if (patient_log_in.DialogResult == DialogResult.OK) {
                    string ID = HospitalManagementSystem.FormInit.PatientValue.ID;
                    string token = HospitalManagementSystem.FormInit.PatientValue.token;
                    HospitalManagementSystem.FormPatMain patient_main_menu = 
                        new FormPatMain(ID, token);
                    patient_main_menu.ShowDialog();
                }
                else {
                    Application.Exit();
                }
            }
        }
    }
}