using System;
using System.Drawing;
using System.Windows.Forms;
using OracleHospital;

namespace HospitalManagementSystem {
    public partial class FormMainLogIn : Form {
        int identity;//身份标识，0代表医生；1代表病人
        bool Is_return;
        public FormMainLogIn(int x) {
            InitializeComponent();
            identity = x;
            Is_return = false;
            this.bunifuLabel_user_name.Text = "用户名";
            this.bunifuLabel_password.Text = "密码";
            this.bunifuButton_log_in.IdleBorderColor = Color.DodgerBlue;
            this.bunifuButton_log_in.IdleFillColor = Color.DodgerBlue;
            this.bunifuButton_register.IdleBorderColor = Color.DodgerBlue;
            this.bunifuButton_register.IdleFillColor = Color.DodgerBlue;
        }

        private void button_click_login_in(object sender, EventArgs e) {
            Functions functions = new Functions();
            if (identity == 0) {
                if (bunifuTextBox_user_name.Text.Trim() == "" || bunifuTextBox_password.Text.Trim() == "") {
                    MessageBox.Show("用户名或密码不能为空！");
                }
                else {
                    if (functions.DoctorSignin(
                        bunifuTextBox_user_name.Text, bunifuTextBox_password.Text).success) {
                        MessageBox.Show("登陆成功！");
                        FormInit.DoctorValue.ID = functions.DoctorSignin(
                            bunifuTextBox_user_name.Text, bunifuTextBox_password.Text).ID;
                        FormInit.DoctorValue.token = functions.DoctorSignin(
                            bunifuTextBox_user_name.Text, bunifuTextBox_password.Text).result;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else {
                        MessageBox.Show("用户名或密码错误！");
                    }
                }
            }
            else {
                if (bunifuTextBox_user_name.Text.Trim() == "" || bunifuTextBox_password.Text.Trim() == "") {
                    MessageBox.Show("用户名或密码不能为空！");
                }
                else {
                    if (functions.PatientSignin(
                        bunifuTextBox_user_name.Text, bunifuTextBox_password.Text).success) {
                        MessageBox.Show("登陆成功！");
                        FormInit.PatientValue.ID = functions.PatientSignin(
                            bunifuTextBox_user_name.Text, bunifuTextBox_password.Text).ID;
                        FormInit.PatientValue.token = functions.PatientSignin(
                            bunifuTextBox_user_name.Text, bunifuTextBox_password.Text).result;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else {
                        MessageBox.Show("用户名或密码错误！");
                    }
                }
            }
        }

        private void button_click_register(object sender, EventArgs e) {
            if (identity == 0) {
                FormMainSubDocRegister register_for_doctot = new FormMainSubDocRegister();
                register_for_doctot.Owner = this;
                this.Hide();
                register_for_doctot.ShowDialog();
                this.Show();
                register_for_doctot.Close();
            }
            else {
                FormMainSubPatRegister register_for_patient = new FormMainSubPatRegister();
                register_for_patient.Owner = this;
                this.Hide();
                register_for_patient.ShowDialog();
                this.Show();
                register_for_patient.Close();
            }
        }

        private void button_click_return_start_interface(object sender, EventArgs e) {
            Is_return = true;
            this.Hide();
        }

        public bool Show_Is_Return() {
            return Is_return;
        }
    }
}