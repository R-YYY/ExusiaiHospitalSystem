using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OracleHospital;
using Sunny.UI;

namespace HospitalManagementSystem {
    public partial class FormPatReg : UIPage {
        Functions functions;
        private string patient_ID, token;
        private List<DoctorInfo> docInfoTmp;
        private List<DoctorInfo> currentShowDocInfo;
        private List<string> selectAllTitle = new List<string>();
        private List<string> selectAllDept = new List<string>();

        public FormPatReg(string patient_tmp_ID, string tmp_token) {
            patient_ID = patient_tmp_ID;
            token = tmp_token;
            InitializeComponent();
            functions = new Functions();
            this.bunifuDGV_registration.Columns[3].DefaultCellStyle.NullValue = "查看";
            this.bunifuDGV_registration.Columns[4].DefaultCellStyle.NullValue = "挂号";
            docInfoTmp = functions.getDoctorIntro();
            currentShowDocInfo = functions.getDoctorIntro();


            //selectAllTitle.Add(docInfoTmp[0].title);
            for (int i = 0; i < docInfoTmp.Count; i++) {
                currentShowDocInfo.Add(docInfoTmp[i]);
                this.bunifuDGV_registration.Rows.Add();
                this.bunifuDGV_registration.Rows[i].Cells[0].Value = docInfoTmp[i].dept_name;
                this.bunifuDGV_registration.Rows[i].Cells[1].Value = docInfoTmp[i].name;
                this.bunifuDGV_registration.Rows[i].Cells[2].Value = docInfoTmp[i].title;
                this.bunifuDGV_registration.Rows[i].Cells[0].Style.ForeColor = Color.Black;
                this.bunifuDGV_registration.Rows[i].Cells[1].Style.ForeColor = Color.Black;
                this.bunifuDGV_registration.Rows[i].Cells[2].Style.ForeColor = Color.Black;
                //this.bunifuDGV_registration.Columns[0] = docInfoTmp.
                int check = 0;
                int checkTwo = 0;
                for (int j = 0; j < selectAllTitle.Count; j++) {
                    if (selectAllTitle[j] == docInfoTmp[i].title) {
                        check++;
                    }
                }
                if (check == 0) {
                    selectAllTitle.Add(docInfoTmp[i].title);
                }

                for (int j = 0; j < selectAllDept.Count; j++) {
                    if (selectAllDept[j] == docInfoTmp[i].dept_name) {
                        checkTwo++;
                    }
                }
                if (checkTwo == 0) {
                    selectAllDept.Add(docInfoTmp[i].dept_name);
                }

            }
            comboBox_title.Items.Add("所有");
            comboBox_dept.Items.Add("所有");
            for (int j = 0; j < selectAllTitle.Count; j++) {
                comboBox_title.Items.Add(selectAllTitle[j]);
            }
            for (int j = 0; j < selectAllDept.Count; j++) {
                comboBox_dept.Items.Add(selectAllDept[j]);
            }
            // comboBox_title.Items.Add("院长");


        }

        private Form activeForm = null;
        private void openChildForm(Form childForm) {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bunifuDGV_registration_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 3) {
                //currentShowDocInfo[e.RowIndex];
                DoctorInfo docShow = currentShowDocInfo[e.RowIndex];
                openChildForm(new FormPatSubDoctorInfo(patient_ID, token, docShow.age, docShow.title, docShow.name, docShow.dept_name, docShow.introduction, docShow.sex, docShow.ImageUrl));
            }
            if (e.ColumnIndex == 4) {
                Random Ra = new Random(DateTime.Now.Millisecond);
                int randWindow = Ra.Next(1, 5);
                //docInfoTmp
                string docID_Tmp = currentShowDocInfo[e.RowIndex].ID;
                int check = functions.Registration(patient_ID, token, randWindow.ToString(), docID_Tmp);
                if (check == 1) {
                    MessageBox.Show("挂号成功！");
                }
                else MessageBox.Show("今天已挂过该医生！");
                //MessageBox.Show(randWindow.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            currentShowDocInfo.Clear();
            this.bunifuDGV_registration.Rows.Clear();
            int j = 0;
            //   if (comboBox_title.SelectedItem == null)
            //      MessageBox.Show("yes");//comboBox_title.SelectedItem.ToString());
            for (int i = 0; i < docInfoTmp.Count; i++) {
                if (docInfoTmp[i].dept_name != comboBox_dept.SelectedItem.ToString() && comboBox_dept.SelectedItem.ToString() != "所有") continue;
                if (comboBox_title.SelectedItem != null) {
                    if (docInfoTmp[i].title != comboBox_title.SelectedItem.ToString() && comboBox_title.SelectedItem.ToString() != "所有") continue;
                }
                //if (docInfoTmp[i].dept_name != comboBox_dept.SelectedItem.ToString() && comboBox_dept.SelectedItem.ToString() != "所有") continue;
                currentShowDocInfo.Add(docInfoTmp[i]);
                this.bunifuDGV_registration.Rows.Add();
                this.bunifuDGV_registration.Rows[j].Cells[0].Value = docInfoTmp[i].dept_name;
                this.bunifuDGV_registration.Rows[j].Cells[1].Value = docInfoTmp[i].name;
                this.bunifuDGV_registration.Rows[j].Cells[2].Value = docInfoTmp[i].title;
                this.bunifuDGV_registration.Rows[j].Cells[0].Style.ForeColor = Color.Black;
                this.bunifuDGV_registration.Rows[j].Cells[1].Style.ForeColor = Color.Black;
                this.bunifuDGV_registration.Rows[j].Cells[2].Style.ForeColor = Color.Black;
                j++;

            }


            //MessageBox.Show(comboBox_dept.SelectedItem.ToString());
        }


        private void comboBox_title_SelectedIndexChanged(object sender, EventArgs e) {
            currentShowDocInfo.Clear();
            this.bunifuDGV_registration.Rows.Clear();
            int j = 0;
            //   if (comboBox_title.SelectedItem == null)
            //      MessageBox.Show("yes");//comboBox_title.SelectedItem.ToString());
            for (int i = 0; i < docInfoTmp.Count; i++) {
                if (docInfoTmp[i].title != comboBox_title.SelectedItem.ToString() && comboBox_title.SelectedItem.ToString() != "所有") continue;
                if (comboBox_dept.SelectedItem != null) {
                    if (docInfoTmp[i].dept_name != comboBox_dept.SelectedItem.ToString() && comboBox_dept.SelectedItem.ToString() != "所有") continue;
                }
                //if (docInfoTmp[i].dept_name != comboBox_dept.SelectedItem.ToString() && comboBox_dept.SelectedItem.ToString() != "所有") continue;
                currentShowDocInfo.Add(docInfoTmp[i]);
                this.bunifuDGV_registration.Rows.Add();
                this.bunifuDGV_registration.Rows[j].Cells[0].Value = docInfoTmp[i].dept_name;
                this.bunifuDGV_registration.Rows[j].Cells[1].Value = docInfoTmp[i].name;
                this.bunifuDGV_registration.Rows[j].Cells[2].Value = docInfoTmp[i].title;
                this.bunifuDGV_registration.Rows[j].Cells[0].Style.ForeColor = Color.Black;
                this.bunifuDGV_registration.Rows[j].Cells[1].Style.ForeColor = Color.Black;
                this.bunifuDGV_registration.Rows[j].Cells[2].Style.ForeColor = Color.Black;
                j++;

            }

        }
    }
}