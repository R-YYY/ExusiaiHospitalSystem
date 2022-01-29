using System;
using System.Windows.Forms;
using OracleHospital;
namespace HospitalManagementSystem {


    public partial class FormPatSubDoctorInfo : Form {
        Functions functions;
        ImageOperation imgop;
        string patient_ID, token;
        public FormPatSubDoctorInfo(
            string patient_tmp_ID, string tmp_token, int age,
            string title, string name, string dept,
            string introduction, string sex, string url) {
            InitializeComponent();
            functions = new Functions();
            imgop = new ImageOperation();
            patient_ID = patient_tmp_ID;
            token = tmp_token;
            label_age.Text = age.ToString();
            if (sex == "male") label_sex.Text = "男";
            else label_sex.Text = "女";
            label_title.Text = title;
            label_introduction.Text = introduction;
            label_name.Text = name;
            label_dept.Text = dept;

            if (url.Length < 4) return;
            bunifuPictureBox1.Image = imgop.ZoomImage(
                ImageOperation.GetPicture(
                    @"http://101.133.237.83:8000/img/doctor/" + url),
                bunifuPictureBox1.Height, bunifuPictureBox1.Width);
        }
        private void bunifuThinBtn_close_Click(object sender, EventArgs e) {
            this.Close();
        }
        
    }
}