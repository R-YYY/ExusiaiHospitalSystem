using System;
using System.Windows.Forms;
using OracleHospital;
using Sunny.UI;

namespace HospitalManagementSystem {
    public partial class FormMainSubPatRegister : Form {
        public FormMainSubPatRegister() {
            InitializeComponent();
        }

        private void Register_for_patient_closed(object sender, FormClosedEventArgs e) {
            this.Owner.Close();
        }

        private void button_click_return_to_patient_log_in(object sender, EventArgs e) {
            this.Hide();
        }

        private void button_click_for_doctor_register(object sender, EventArgs e) {
            //输入内容不能为空
            if (uiTextBox_patient_name.Text.Trim() == "") {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if (uiRadioButton_patient_sex_male.Checked == false &&
                uiRadioButton_patient_sex_female.Checked == false) {
                MessageBox.Show("性别不能为空");
                return;
            }
            if (uiTextBox_patient_age.Text.Trim() == "") {
                MessageBox.Show("年龄不能为空");
                return;
            }
            if (uiTextBox_patient_phone_number.Text.Trim() == "") {
                MessageBox.Show("电话号码不能为空");
                return;
            }
            if (uiTextBox_patient_password.Text.Trim() == "") {
                MessageBox.Show("密码不能为空");
                return;
            }
            if (uiTextBox_patient_confirm_password.Text.Trim() == "") {
                MessageBox.Show("确认密码不能为空");
                return;
            }
            //姓名不能包含空格且长度不超过20个字节
            string temp_name = uiTextBox_patient_name.Text;
            int name_length = temp_name.Length;
            if (name_length > 20) {
                MessageBox.Show("姓名长度过长，请重新输入姓名");
                return;
            }
            else {
                for (int i = 0; i < name_length; i++) {
                    if (temp_name[i] == ' ') {
                        MessageBox.Show("姓名不能包含空格，请重新输入姓名");
                        return;
                    }
                }
            }
            //年龄必须是数字且首位不能是0
            string Age = uiTextBox_patient_age.Text;
            for (int i = 0; i < Age.Length; i++) {
                if (Age[i] <= '9' && Age[i] >= '0') {
                    if (i == 0 && Age[i] == '0') {
                        MessageBox.Show("年龄输入格式错误，请重新输入年龄");
                        return;
                    }
                }
                else {
                    MessageBox.Show("年龄输入格式错误，请重新输入年龄");
                    return;
                }
            }
            //电话号码必须为11位且都是数字
            string phone_number = uiTextBox_patient_phone_number.Text;
            if (phone_number.Length != 11) {
                MessageBox.Show("电话号码长度只能为11位，请重新输入电话号码");
                return;
            }
            else {
                for (int i = 0; i < 11; i++) {
                    if (phone_number[i] > '9' || phone_number[i] < '0') {
                        MessageBox.Show("电话号码输入格式错误，请重新输入电话号码");
                        return;
                    }
                }
            }
            //密码输入长度最少6位，最长20位，且不能包含空格
            int password_length = uiTextBox_patient_password.Text.Length;
            string temp_password = uiTextBox_patient_password.Text;
            if (password_length < 6 || password_length > 20) {
                MessageBox.Show("密码输入长度最少6位，最长20位，请重新输入密码");
                return;
            }
            else {
                for (int i = 0; i < password_length; i++) {
                    if (temp_password[i] == ' ') {
                        MessageBox.Show("密码输入不能包含空格，请重新输入密码");
                        return;
                    }
                }
            }
            //验证两次输入的密码
            if (temp_password != uiTextBox_patient_confirm_password.Text) {
                MessageBox.Show("两次输入密码不符");
                return;
            }
            PatientInfo patient = new PatientInfo {
                ID = "0",
                ward_ID = "0",
                MedicalHistory = "0",
                ImageUrl = " ",
                name = temp_name,
                balance = 0,
                phone_num = phone_number,
                password = temp_password,
                age = uiTextBox_patient_age.Text.ToInt()
            };
            if (uiRadioButton_patient_sex_male.Checked) {
                patient.sex = "male";
            }
            else {
                patient.sex = "female";
            }
            Functions functions = new Functions();
            string ID = functions.PatientSignup(patient);
            //返回注册提示信息
            switch (ID) {
                case "0": {
                        MessageBox.Show("注册失败！");
                        return;
                    }
                case "-1": {
                        MessageBox.Show("该用户已存在！请重新注册！");
                        return;
                    }
                default: {
                        MessageBox.Show("注册成功！ID是" + ID);
                        this.Hide();
                        break;
                    }
            }
        }

        private void uiTextBox_patient_age_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9')) e.Handled = true;
            if (e.KeyChar == '\b') e.Handled = false;
        }
    }
}