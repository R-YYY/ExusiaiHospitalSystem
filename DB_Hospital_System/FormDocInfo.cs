using System;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;
using OracleHospital;

namespace HospitalManagementSystem {
    public partial class FormDocInfo : UIPage {
        private readonly string Doctor_ID, token;
        private readonly Functions functions = new Functions();
        private readonly ImageOperation imgop = new ImageOperation();
        private DoctorInfo DoctorInfo = new DoctorInfo();
        public FormDocInfo(string d_id, string t_tmp) {
            Doctor_ID = d_id;
            token = t_tmp;
            InitializeComponent();
            var dis = functions.getDoctorIntro();
            DoctorInfo = dis.Find(delegate (DoctorInfo info) { return info.ID == Doctor_ID; });

            uiLabel_Age.Text = DoctorInfo.age.ToString();
            uiLabel_Dept.Text = DoctorInfo.dept_name;
            uiLabel_Name.Text = DoctorInfo.name;
            uiLabel_Title.Text = DoctorInfo.title;
            uiLabel_Intro.Text = DoctorInfo.introduction;
            uiLabel_Intro.TextAlign = ContentAlignment.TopLeft;
            if (DoctorInfo.sex == "male")
                uiLabel_Sex.Text = "男";
            else uiLabel_Sex.Text = "女";

            if (DoctorInfo.ImageUrl.Length < 4) return;
            pictureBox1.Image = imgop.ZoomImage(
                ImageOperation.GetPicture(
                    @"http://101.133.237.83:8000/img/doctor/" + DoctorInfo.ImageUrl),
                pictureBox1.Height, pictureBox1.Width);

        }

        public void reload() {
            var dis = functions.getDoctorIntro();
            DoctorInfo = dis.Find(delegate (DoctorInfo info) { return info.ID == Doctor_ID; });
            uiLabel_Age.Text = DoctorInfo.age.ToString();
            uiLabel_Dept.Text = DoctorInfo.dept_name;
            uiLabel_Name.Text = DoctorInfo.name;
            uiLabel_Title.Text = DoctorInfo.title;
            uiLabel_Intro.Text = DoctorInfo.introduction;
            uiLabel_Intro.TextAlign = ContentAlignment.TopLeft;
            if (DoctorInfo.sex == "male")
                uiLabel_Sex.Text = "男";
            else uiLabel_Sex.Text = "女";
        }

        private void uiButton1_Click(object sender, EventArgs e) {
            FormDocSubUpdate f = new FormDocSubUpdate(Doctor_ID, token, DoctorInfo);
            f.Owner = this;
            f.ShowDialog();
        }

        public void FormDocInfo_Enter(object sender, EventArgs e) {
            
            var dis = functions.getDoctorIntro();
            DoctorInfo = dis.Find(delegate (DoctorInfo info) { return info.ID == Doctor_ID; });
            uiLabel_Age.Text = DoctorInfo.age.ToString();
            uiLabel_Dept.Text = DoctorInfo.dept_name;
            uiLabel_Name.Text = DoctorInfo.name;
            uiLabel_Title.Text = DoctorInfo.title;
            uiLabel_Intro.Text = DoctorInfo.introduction;
            uiLabel_Intro.TextAlign = ContentAlignment.TopLeft;
            if (DoctorInfo.sex == "male")
                uiLabel_Sex.Text = "男";
            else uiLabel_Sex.Text = "女";
        }

        private void uiButton_P_Click(object sender, EventArgs e) {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图片文件|*.png;*.jpg;*.jpge;*.bmp;*.gif";
            ofd.Title = "打开";
            if (ofd.ShowDialog() == DialogResult.OK) {
                string path = "/img/doctor/";
                try {
                    imgop.update_img(ofd.FileName, ofd.SafeFileName, path);
                    functions.setImage(Doctor_ID, token, false, ofd.SafeFileName);
                    pictureBox1.Image = imgop.ZoomImage(
                        new Bitmap(ofd.FileName), pictureBox1.Height, pictureBox1.Width);
                }
                catch (Exception ex) {
                    MessageBox.Show(
                        ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}