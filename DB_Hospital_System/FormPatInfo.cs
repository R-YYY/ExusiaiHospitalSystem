using System;
using System.Drawing;
using System.Windows.Forms;
using OracleHospital;
using Sunny.UI;

namespace HospitalManagementSystem {

    public partial class FormPatInfo : UIPage {
        Functions functions= new Functions();
        private ImageOperation imgop = new ImageOperation();
        private string patient_ID, token;
        PatientInfo patientInfo;
        public FormPatInfo(string patient_tmp_ID, string tmp_token) {
            patient_ID = patient_tmp_ID;
            token = tmp_token;
            InitializeComponent();

            patientInfo = functions.GetPatientInfo(patient_ID);
            uiLabel_Name.Text = patientInfo.name;
            uiLabel_Age.Text = patientInfo.age.ToString();

            if (patientInfo.sex == "male")
                uiLabel_Sex.Text = "男";
            else
                uiLabel_Sex.Text = "女";

            uiLabel_Phone.Text = patientInfo.phone_num;

            if (patientInfo.ward_ID != null && patientInfo.ward_ID != "0")
                uiLabel_Ward.Text = patientInfo.ward_ID;
            uiLabel_Money.Text = patientInfo.balance.ToString();

            if (patientInfo.ImageUrl.Length < 4) return;
            bunifuPictureBox1.Image = imgop.ZoomImage(
                ImageOperation.GetPicture(
                    @"http://101.133.237.83:8000/img/patient/" + patientInfo.ImageUrl),
                bunifuPictureBox1.Height, bunifuPictureBox1.Width);

        }

        private void bunifuButton1_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图片文件|*.png;*.jpg;*.jpge;*.bmp;*.gif";
            ofd.Title = "打开";
            if (ofd.ShowDialog() == DialogResult.OK) {
                string path = "/img/patient/";
                try {
                    imgop.update_img(ofd.FileName, ofd.SafeFileName, path);
                    functions.setImage(patient_ID, token, true, ofd.SafeFileName);
                    bunifuPictureBox1.Image = imgop.ZoomImage(
                        new Bitmap(ofd.FileName), bunifuPictureBox1.Height, bunifuPictureBox1.Width);
                }
                catch (Exception ex) {
                    MessageBox.Show(
                        ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void uiButton1_Click(object sender, EventArgs e) {
            FormPatSubUpdate f = new FormPatSubUpdate(patient_ID, token, patientInfo);
            f.Owner = this;
            f.ShowDialog();
        }
        public void FormPatInfo_Enter(object sender, EventArgs e) {

            patientInfo = functions.GetPatientInfo(patient_ID);
            uiLabel_Name.Text = patientInfo.name;
            uiLabel_Age.Text = patientInfo.age.ToString();

            if (patientInfo.sex == "male")
                uiLabel_Sex.Text = "男";
            else
                uiLabel_Sex.Text = "女";

            uiLabel_Phone.Text = patientInfo.phone_num;

            if (patientInfo.ward_ID != null && patientInfo.ward_ID != "0")
                uiLabel_Ward.Text = patientInfo.ward_ID;
            uiLabel_Money.Text = patientInfo.balance.ToString();

        }
    }
}