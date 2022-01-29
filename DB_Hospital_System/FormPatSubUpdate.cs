using OracleHospital;
using Sunny.UI;
using System;
using System.Windows.Forms;

namespace HospitalManagementSystem {
    public partial class FormPatSubUpdate : Form {

        private PatientInfo Pat_info;
        string patient_ID, token;
        FormPatInfo pform;
        Functions functions = new Functions();
        public FormPatSubUpdate(string id, string token_tmp, PatientInfo info) {
            Pat_info = info;
            patient_ID = id;
            token = token_tmp;
            InitializeComponent();
            TextBox_name.Text = info.name;
            TextBox_age.Text = info.age.ToString();
            if (info.sex == "male")
                uiRadioButton_doctor_sex_male.Checked = true;
            else if (info.sex == "female")
                uiRadioButton_doctor_sex_female.Checked = true;
        }


        private void Btn_submit_Click(object sender, EventArgs e) {

            if (TextBox_name.Text.Trim() == "") {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if (uiRadioButton_doctor_sex_male.Checked == false &&
                uiRadioButton_doctor_sex_female.Checked == false) {
                MessageBox.Show("性别不能为空");
                return;
            }
            if (TextBox_age.Text.Trim() == "") {
                MessageBox.Show("年龄不能为空");
                return;
            }
            //姓名不能包含空格且长度不超过20个字节
            string temp_name = TextBox_name.Text;
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
            string Age = TextBox_age.Text;
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

            Pat_info.name = TextBox_name.Text;
            Pat_info.age = TextBox_age.Text.ToInt();
            if (uiRadioButton_doctor_sex_male.Checked == true)
                Pat_info.sex = "male";
            else Pat_info.sex = "female";


            functions.setPatientInfo(patient_ID, token, Pat_info);

            FormPatInfo pForm = (FormPatInfo)this.Owner;
            pForm.FormPatInfo_Enter(sender, e);
            this.Close();
        }

        private void TextBox_age_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9')) e.Handled = true;
            if (e.KeyChar == '\b') e.Handled = false;
        }

        private void Btn_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}