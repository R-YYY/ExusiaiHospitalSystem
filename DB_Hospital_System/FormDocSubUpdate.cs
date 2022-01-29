using OracleHospital;
using Sunny.UI;
using System;
using System.Windows.Forms;

namespace HospitalManagementSystem {
    public partial class FormDocSubUpdate : Form {

        private DoctorInfo Doc_info;

        Functions functions;
        Basic basic;
        string doctor_ID, token;
        FormDocInfo pform;
        public FormDocSubUpdate(string docID_tmp, string token_tmp, DoctorInfo info) {
            doctor_ID = docID_tmp;
            token = token_tmp;
            functions = new Functions();
            basic = new Basic();
            Doc_info = info;
            InitializeComponent();
            Initialize_department();
            Initialize_title();
            TextBox_name.Text = info.name;
            TextBox_age.Text = info.age.ToString();
            TextBox_intro.Text = info.introduction;
            if (info.sex == "male")
                uiRadioButton_doctor_sex_male.Checked = true;
            else if (info.sex == "female")
                uiRadioButton_doctor_sex_female.Checked = true;
            uiComboBox_doctor_department.Text = info.dept_name;
            uiComboBox_doctor_title.Text = info.title;
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
            if (uiComboBox_doctor_department.Text.Trim() == "") {
                MessageBox.Show("科室不能为空");
                return;
            }
            if (uiComboBox_doctor_title.Text.Trim() == "") {
                MessageBox.Show("职称不能为空");
                return;
            }
            if (TextBox_intro.Text.Trim() == "") {
                MessageBox.Show("简介不能为空");
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

            DoctorInfo doc_tmp = Doc_info;
            Doc_info.name = TextBox_name.Text;
            Doc_info.age = TextBox_age.Text.ToInt();
            Doc_info.introduction = TextBox_intro.Text;
            Doc_info.dept_name = uiComboBox_doctor_department.Text;
            Doc_info.title = uiComboBox_doctor_title.Text;
            if (uiRadioButton_doctor_sex_male.Checked == true)
                Doc_info.sex = "male";
            else Doc_info.sex = "female";

            functions.setDoctorInfo(doctor_ID, token, Doc_info);
            FormDocInfo pform = (FormDocInfo)this.Owner;
            pform.FormDocInfo_Enter(sender, e);
            this.Close();
        }

        private void TextBox_age_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9')) e.Handled = true;
            if (e.KeyChar == '\b') e.Handled = false;
        }

        private void TextBox_age_Leave(object sender, EventArgs e) {
            TextBox_age.Text = TextBox_age.Text.ToInt().ToString();
        }

        private void Btn_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}