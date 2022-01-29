using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OracleHospital;
using System.Drawing.Printing;
using System.IO;
using Sunny.UI;

namespace HospitalManagementSystem {
    public partial class FormPatMyReg : UIPage {
        //List<RegisterInfo> getRegisters(string Patient_ID, string token)
        Functions functions;
        private string patient_ID, token;
        private List<RegisterInfo> RegTmp;
        private List<RecipeInfo> recipeTmp;
        private List<DoctorInfo> docTmp;
        private int rowNum = 0;
        PrintDocument printDocument;

        public FormPatMyReg(string patient_tmp_ID, string tmp_token) {
            InitializeComponent();
            InitPrintDocument();
            this.bunifuDGV_myReg.Columns[3].DefaultCellStyle.NullValue = "打印";
            this.bunifuDGV_myReg.Columns[4].DefaultCellStyle.NullValue = "打印预览";
            patient_ID = patient_tmp_ID;
            token = tmp_token;
            functions = new Functions();
            //this.bunifuDGV_myReg.Rows.Add();

            RegTmp = functions.getRegisters(patient_ID, tmp_token);
            recipeTmp = functions.getRecipe(patient_ID, tmp_token, true);
            docTmp = functions.getDoctorIntro();
            int k = -1;
            for (int i = RegTmp.Count - 1; i >= 0; i--) {
                k++;
                this.bunifuDGV_myReg.Rows.Add();
                this.bunifuDGV_myReg.Rows[k].Cells[0].Value = RegTmp[i].time.ToString();
                //this.bunifuDGV_myReg.Rows[i].Cells[1].Value = RegTmp[i].
                this.bunifuDGV_myReg.Rows[k].Cells[2].Value = RegTmp[i].Window_ID;
                this.bunifuDGV_myReg.Rows[k].Cells[0].Style.ForeColor = Color.Black;
                this.bunifuDGV_myReg.Rows[k].Cells[1].Style.ForeColor = Color.Black;
                this.bunifuDGV_myReg.Rows[k].Cells[2].Style.ForeColor = Color.Black;
                //this.bunifuDGV_registration.Columns[0] = docInfoTmp.
                string findDocID = "";


                for (int j = recipeTmp.Count - 1; j >= 0; j--) {
                    if (recipeTmp[j].Patient_ID == RegTmp[i].Patient_ID && recipeTmp[j].recipe_date == RegTmp[i].time) {
                        findDocID = recipeTmp[j].Doctor_ID;
                        break;
                    }
                }
                for (int j = 0; j < docTmp.Count; j++) {
                    if (findDocID == docTmp[j].ID) {
                        this.bunifuDGV_myReg.Rows[k].Cells[1].Value = docTmp[j].name;
                        break;
                    }
                }
            }
        }

        private void InitPrintDocument() {
            printDocument = new PrintDocument();
            //指定打印机
            printDocument.PrinterSettings.PrinterName = "本地打印机";
            //设置页边距
            printDocument.PrinterSettings.DefaultPageSettings.Margins.Left = 0;
            printDocument.PrinterSettings.DefaultPageSettings.Margins.Top = 0;
            printDocument.PrinterSettings.DefaultPageSettings.Margins.Right = 0;
            printDocument.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0;
            //设置尺寸大小
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 595, 842);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e) {
            string printContent = "";
            for (int i = 0; i < 5; i++)
                printContent += this.bunifuDGV_myReg.Columns[i].HeaderCell.Value + ":" + this.bunifuDGV_myReg.Rows[rowNum].Cells[i].Value + "\n";
            Font printFont = new Font("宋体", 12, System.Drawing.FontStyle.Regular);
            Brush printColor = System.Drawing.Brushes.Black;
            Single pointY = 10f;

            e.Graphics.DrawString(printContent, printFont, printColor, 10f, pointY);

            //设置字体
            printFont = new Font("宋体", 12, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            e.Graphics.DrawString(printContent, printFont, printColor, 10f, pointY += 20f);

            e.Graphics.ScaleTransform(1.0f, 1.0f);
            e.HasMorePages = false;
        }

        private void button_Flush_Click(object sender, EventArgs e) {

            RegTmp.Clear();
            recipeTmp.Clear();
            docTmp.Clear();

            while (bunifuDGV_myReg.Rows.Count != 0)
                bunifuDGV_myReg.Rows.RemoveAt(0);


            this.bunifuDGV_myReg.Columns[3].DefaultCellStyle.NullValue = "打印";
            this.bunifuDGV_myReg.Columns[4].DefaultCellStyle.NullValue = "打印预览";
            functions = new Functions();
            //this.bunifuDGV_myReg.Rows.Add();

            RegTmp = functions.getRegisters(patient_ID, token);
            recipeTmp = functions.getRecipe(patient_ID, token, true);
            docTmp = functions.getDoctorIntro();
            int k = -1;
            for (int i = RegTmp.Count - 1; i >= 0; i--) {
                k++;
                this.bunifuDGV_myReg.Rows.Add();
                this.bunifuDGV_myReg.Rows[k].Cells[0].Value = RegTmp[i].time.ToString();
                //this.bunifuDGV_myReg.Rows[i].Cells[1].Value = RegTmp[i].
                this.bunifuDGV_myReg.Rows[k].Cells[2].Value = RegTmp[i].Window_ID;
                this.bunifuDGV_myReg.Rows[k].Cells[0].Style.ForeColor = Color.Black;
                this.bunifuDGV_myReg.Rows[k].Cells[1].Style.ForeColor = Color.Black;
                this.bunifuDGV_myReg.Rows[k].Cells[2].Style.ForeColor = Color.Black;
                //this.bunifuDGV_registration.Columns[0] = docInfoTmp.
                string findDocID = "";


                for (int j = recipeTmp.Count - 1; j >= 0; j--) {
                    if (recipeTmp[j].Patient_ID == RegTmp[i].Patient_ID && recipeTmp[j].recipe_date == RegTmp[i].time) {
                        findDocID = recipeTmp[j].Doctor_ID;
                        break;
                    }
                }
                for (int j = 0; j < docTmp.Count; j++) {
                    if (findDocID == docTmp[j].ID) {
                        this.bunifuDGV_myReg.Rows[k].Cells[1].Value = docTmp[j].name;
                        break;
                    }
                }

            }
        }

        private void FormPatMyReg_Load(object sender, EventArgs e) {
            button_Flush_Click(sender, e);
        }

        private void bunifuDGV_myReg_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            rowNum = e.RowIndex;

            //打印
            if (e.ColumnIndex == 3) {
                printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                try {
                    printDocument.Print();
                    MessageBox.Show("打印成功！");
                }
                catch (Exception excep) {
                    MessageBox.Show(excep.Message, "打印出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    printDocument.Dispose();
                }
            }

            if (e.ColumnIndex == 4) {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument;
                string printContent = "";
                for (int i = 0; i < 5; i++)
                    printContent += this.bunifuDGV_myReg.Columns[i].HeaderCell.Value + ":" + this.bunifuDGV_myReg.Rows[rowNum].Cells[i].Value + "\n";
                StringReader lineReader = new StringReader(printContent);
                try {
                    printPreviewDialog.ShowDialog();
                }
                catch (Exception excep) {
                    MessageBox.Show(excep.Message, "打印出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}