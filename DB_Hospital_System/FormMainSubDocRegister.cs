using System;
using System.Windows.Forms;
using OracleHospital;
using Sunny.UI;

namespace HospitalManagementSystem {
    public partial class FormMainSubDocRegister : Form {
        public FormMainSubDocRegister() {
            InitializeComponent();
            Initialize_department();
            Initialize_title();
        }

        private void Initialize_department() {
            uiComboBox_doctor_department.Items.Add("呼吸内科");
            uiComboBox_doctor_department.Items.Add("心血管内科");
            uiComboBox_doctor_department.Items.Add("妇产科");
            uiComboBox_doctor_department.Items.Add("儿科综合");
            uiComboBox_doctor_department.Items.Add("外科");
            uiComboBox_doctor_department.Items.Add("耳鼻喉科");
            uiComboBox_doctor_department.Items.Add("呼吸外科");
            uiComboBox_doctor_department.Items.Add("心血管外科");
            uiComboBox_doctor_department.Items.Add("临床基因组诊疗科");
            uiComboBox_doctor_department.Items.Add("骨科");
        }

        private void Initialize_title() {
            uiComboBox_doctor_title.Items.Add("住院医师");
            uiComboBox_doctor_title.Items.Add("主治医师");
            uiComboBox_doctor_title.Items.Add("副主任医师");
            uiComboBox_doctor_title.Items.Add("主任医师");
        }

        private void Register_for_doctor_closed(object sender, FormClosedEventArgs e) {
            this.Owner.Close();
        }

        private void button_click_return_to_doctor_log_in(object sender, EventArgs e) {
            this.Hide();
        }

        private void button_click_for_doctor_register(object sender, EventArgs e) {
            //所输入内容不能为空
            if (uiTextBox_doctor_name.Text.Trim() == "") {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if (uiRadioButton_doctor_sex_male.Checked == false && uiRadioButton_doctor_sex_female.Checked == false) {
                MessageBox.Show("性别不能为空");
                return;
            }
            if (uiTextBox_doctor_age.Text.Trim() == "") {
                MessageBox.Show("年龄不能为空");
                return;
            }
            if (uiComboBox_doctor_department.Text.Trim() == "") {
                MessageBox.Show("科室不能为空");
                return;
            }
            if (uiComboBox_doctor_title.Text.Trim() == "") {
                MessageBox.Show("职称不能为空");
                return;
            }
            if (uiTextBox_doctor_phone_number.Text.Trim() == "") {
                MessageBox.Show("电话号码不能为空");
                return;
            }
            if (uiTextBox_register_code.Text.Trim() == "") {
                MessageBox.Show("注册码不能为空");
                return;
            }
            if (uiTextBox_doctor_password.Text.Trim() == "") {
                MessageBox.Show("密码不能为空");
                return;
            }
            if (uiTextBox_doctor_confirm_password.Text.Trim() == "") {
                MessageBox.Show("确认密码不能为空");
                return;
            }
            if (uiTextBox_doctor_introduction.Text.Trim() == "") {
                MessageBox.Show("简介不能为空");
                return;
            }
            //姓名不能包含空格且长度不超过20个字节
            string temp_name = uiTextBox_doctor_name.Text;
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
            string Age = uiTextBox_doctor_age.Text;
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
            string phone_number = uiTextBox_doctor_phone_number.Text;
            if (phone_number.Length != 11) {
                MessageBox.Show("电话号码长度错误，请重新输入电话号码");
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
            int password_length = uiTextBox_doctor_password.Text.Length;
            string temp_password = uiTextBox_doctor_password.Text;
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
            if (temp_password != uiTextBox_doctor_confirm_password.Text) {
                MessageBox.Show("两次输入密码不符");
                return;
            }
            DoctorInfo doctor = new DoctorInfo {
                ImageUrl = " ",
                ID = "0",
                name = temp_name,
                age = uiTextBox_doctor_age.Text.ToInt(),
                dept_name = uiComboBox_doctor_department.Text.Trim(),
                title = uiComboBox_doctor_title.Text.Trim(),
                phone_num = phone_number,
                password = temp_password,
                introduction = uiTextBox_doctor_introduction.Text.Trim()
            };
            if (uiRadioButton_doctor_sex_male.Checked)
                doctor.sex = "male";
            else doctor.sex = "female";

            Functions functions = new Functions();
            string ID = functions.DoctorSignup(doctor, uiTextBox_register_code.Text);
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
                case "-2": {
                        MessageBox.Show("注册码有误！注册失败！");
                        return;
                    }
                default: {
                        MessageBox.Show("注册成功！ID是" + ID);
                        this.Hide();
                        break;
                    }
            }
        }

        //限制输入数字事件
        private void uiTextBox_doctor_age_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9')) e.Handled = true;
            if (e.KeyChar == '\b') e.Handled = false;
        }
    }
}