using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OracleHospital;
using System.Drawing.Printing;
using System.IO;
using System.Drawing.Drawing2D;
using Sunny.UI;

namespace HospitalManagementSystem {
    public partial class FormPatMyBill : UIPage {
        private string token, patient_ID;
        private int rowNum = 0;
        Functions functions;
        PrintDocument printDocument;
        public FormPatMyBill(string patient_tmp_ID, string tmp_token) {
            functions = new Functions();
            patient_ID = patient_tmp_ID;
            token = tmp_token;
            InitializeComponent();
            InitializeDGV();
            InitPrintDocument();

        }
        private void InitializeDGV() {

            List<BillInfo> billInfo = functions.getBill(patient_ID, token);
            this.bunifuDGV_myBill.Columns[5].DefaultCellStyle.NullValue = "支付";
            this.bunifuDGV_myBill.Columns[6].DefaultCellStyle.NullValue = "查看";
            this.bunifuDGV_myBill.Columns[7].DefaultCellStyle.NullValue = "打印";
            this.bunifuDGV_myBill.Columns[8].DefaultCellStyle.NullValue = "打印预览";

            for (int i = 0; i < billInfo.Count; i++) {
                this.bunifuDGV_myBill.Rows.Add();
                this.bunifuDGV_myBill.Rows[i].Cells[0].Value = billInfo[i].Bill_ID;
                this.bunifuDGV_myBill.Rows[i].Cells[1].Value = functions.GetPatientInfo(patient_ID).name;
                this.bunifuDGV_myBill.Rows[i].Cells[2].Value = billInfo[i].date;
                this.bunifuDGV_myBill.Rows[i].Cells[3].Value = billInfo[i].fee;
                this.bunifuDGV_myBill.Rows[i].Cells[4].Value = billInfo[i].state;
            }
            this.bunifuDGV_myBill.Sort(this.bunifuDGV_myBill.Columns[4], ListSortDirection.Ascending);

        }

        private void InitPrintDocument() {
            printDocument = new PrintDocument();
            //指定打印机
            printDocument.PrinterSettings.PrinterName = "某个打印机？";
            //设置页边距
            printDocument.PrinterSettings.DefaultPageSettings.Margins.Left = 0;
            printDocument.PrinterSettings.DefaultPageSettings.Margins.Top = 0;
            printDocument.PrinterSettings.DefaultPageSettings.Margins.Right = 0;
            printDocument.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0;
            //设置尺寸大小
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 595, 842);
        }

        private void bunifuDGV_myBill_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            rowNum = e.RowIndex;
            int col = e.ColumnIndex;
            int row = e.RowIndex;


            //支付
            if (col == 5 && this.bunifuDGV_myBill.Rows[row].Cells[col - 1].Value.ToString() != null && this.bunifuDGV_myBill.Rows[row].Cells[col - 1].Value.ToString() == "未付款") {
                if (functions.GetPatientInfo(patient_ID).balance >= 
                    this.bunifuDGV_myBill.Rows[row].Cells[3].Value.ToString().ToFloat()) {
                    MessageBox.Show("支付成功！");
                    this.bunifuDGV_myBill.Rows[row].Cells[col - 1].Value = "已付款";
                    functions.payBill(
                        patient_ID, token, this.bunifuDGV_myBill.Rows[row].Cells[0].Value.ToString(), 
                        this.bunifuDGV_myBill.Rows[row].Cells[3].Value.ToString().ToFloat());

                }
                else {
                    MessageBox.Show("很抱歉，您的余额不足，支付失败。");
                }
            }
            if (col == 6) {
                FormPatSubBillDetail f = new FormPatSubBillDetail(
                    this.bunifuDGV_myBill.Rows[row].Cells[0].Value.ToString(), token);
                f.Show();
            }
            //打印
            if (col == 7) {
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

            //预览
            if (col == 8) {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument;
                string printContent = "";
                for (int i = 0; i < 5; i++)
                    printContent += this.bunifuDGV_myBill.Columns[i].HeaderCell.Value + ":" + this.bunifuDGV_myBill.Rows[rowNum].Cells[i].Value + "\n";
                StringReader lineReader = new StringReader(printContent);
                try {
                    printPreviewDialog.ShowDialog();
                }
                catch (Exception excep) {
                    MessageBox.Show(excep.Message, "打印出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            string printContent = "";
            for (int i = 0; i < 5; i++)
                printContent += this.bunifuDGV_myBill.Columns[i].HeaderCell.Value + ":" + this.bunifuDGV_myBill.Rows[rowNum].Cells[i].Value + "\n";
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

            while (bunifuDGV_myBill.Rows.Count != 0)
                bunifuDGV_myBill.Rows.RemoveAt(0);
            InitializeDGV();
            InitPrintDocument();
        }
    }
}