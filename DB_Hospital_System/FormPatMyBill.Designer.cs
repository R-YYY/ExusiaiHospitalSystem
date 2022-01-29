namespace HospitalManagementSystem
{
    partial class FormPatMyBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDGV_myBill = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel_Info = new Sunny.UI.UILabel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.button_Flush = new System.Windows.Forms.Button();
            this.billID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.preview = new System.Windows.Forms.DataGridViewButtonColumn();
            this.checkInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDGV_myBill)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDGV_myBill
            // 
            this.bunifuDGV_myBill.AllowCustomTheming = false;
            this.bunifuDGV_myBill.AllowUserToAddRows = false;
            this.bunifuDGV_myBill.AllowUserToDeleteRows = false;
            this.bunifuDGV_myBill.AllowUserToResizeColumns = false;
            this.bunifuDGV_myBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDGV_myBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDGV_myBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDGV_myBill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuDGV_myBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDGV_myBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDGV_myBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDGV_myBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDGV_myBill.ColumnHeadersHeight = 40;
            this.bunifuDGV_myBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billID,
            this.patientName,
            this.date,
            this.fee,
            this.state,
            this.pay,
            this.print,
            this.preview,
            this.checkInfo});
            this.bunifuDGV_myBill.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDGV_myBill.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDGV_myBill.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDGV_myBill.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDGV_myBill.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDGV_myBill.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDGV_myBill.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDGV_myBill.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDGV_myBill.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDGV_myBill.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDGV_myBill.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDGV_myBill.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDGV_myBill.CurrentTheme.Name = null;
            this.bunifuDGV_myBill.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDGV_myBill.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDGV_myBill.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDGV_myBill.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDGV_myBill.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDGV_myBill.DefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuDGV_myBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuDGV_myBill.EnableHeadersVisualStyles = false;
            this.bunifuDGV_myBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDGV_myBill.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDGV_myBill.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDGV_myBill.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDGV_myBill.Location = new System.Drawing.Point(0, 0);
            this.bunifuDGV_myBill.Name = "bunifuDGV_myBill";
            this.bunifuDGV_myBill.ReadOnly = true;
            this.bunifuDGV_myBill.RowHeadersVisible = false;
            this.bunifuDGV_myBill.RowHeadersWidth = 51;
            this.bunifuDGV_myBill.RowTemplate.Height = 40;
            this.bunifuDGV_myBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDGV_myBill.Size = new System.Drawing.Size(893, 583);
            this.bunifuDGV_myBill.TabIndex = 3;
            this.bunifuDGV_myBill.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDGV_myBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDGV_myBill_CellContentClick);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel_Info);
            this.uiPanel1.Controls.Add(this.button_Flush);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(893, 46);
            this.uiPanel1.TabIndex = 15;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_Info
            // 
            this.uiLabel_Info.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.uiLabel_Info.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_Info.Location = new System.Drawing.Point(0, 0);
            this.uiLabel_Info.Name = "uiLabel_Info";
            this.uiLabel_Info.Size = new System.Drawing.Size(120, 46);
            this.uiLabel_Info.TabIndex = 0;
            this.uiLabel_Info.Text = "我的账单";
            this.uiLabel_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.bunifuDGV_myBill);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 46);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(893, 583);
            this.uiPanel2.TabIndex = 16;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Flush
            // 
            this.button_Flush.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.flush;
            this.button_Flush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Flush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Flush.Location = new System.Drawing.Point(126, 3);
            this.button_Flush.Name = "button_Flush";
            this.button_Flush.Size = new System.Drawing.Size(41, 40);
            this.button_Flush.TabIndex = 10;
            this.button_Flush.UseVisualStyleBackColor = true;
            this.button_Flush.Click += new System.EventHandler(this.button_Flush_Click);
            // 
            // billID
            // 
            this.billID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.billID.DefaultCellStyle = dataGridViewCellStyle3;
            this.billID.FillWeight = 12.5F;
            this.billID.HeaderText = "账单号";
            this.billID.MinimumWidth = 6;
            this.billID.Name = "billID";
            this.billID.ReadOnly = true;
            this.billID.Width = 116;
            // 
            // patientName
            // 
            this.patientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.patientName.DefaultCellStyle = dataGridViewCellStyle4;
            this.patientName.FillWeight = 12.5F;
            this.patientName.HeaderText = "患者";
            this.patientName.MinimumWidth = 6;
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            this.patientName.Width = 116;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.date.DefaultCellStyle = dataGridViewCellStyle5;
            this.date.FillWeight = 12.5F;
            this.date.HeaderText = "日期";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 116;
            // 
            // fee
            // 
            this.fee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fee.DefaultCellStyle = dataGridViewCellStyle6;
            this.fee.FillWeight = 12.5F;
            this.fee.HeaderText = "费用";
            this.fee.MinimumWidth = 6;
            this.fee.Name = "fee";
            this.fee.ReadOnly = true;
            this.fee.Width = 116;
            // 
            // state
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.state.DefaultCellStyle = dataGridViewCellStyle7;
            this.state.FillWeight = 12.5F;
            this.state.HeaderText = "支付状态";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // pay
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pay.DefaultCellStyle = dataGridViewCellStyle8;
            this.pay.FillWeight = 12.5F;
            this.pay.HeaderText = "";
            this.pay.MinimumWidth = 6;
            this.pay.Name = "pay";
            this.pay.ReadOnly = true;
            this.pay.Text = "支付";
            // 
            // print
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.print.DefaultCellStyle = dataGridViewCellStyle9;
            this.print.FillWeight = 12.5F;
            this.print.HeaderText = "";
            this.print.MinimumWidth = 6;
            this.print.Name = "print";
            this.print.ReadOnly = true;
            this.print.Text = "打印";
            // 
            // preview
            // 
            this.preview.FillWeight = 12.5F;
            this.preview.HeaderText = "";
            this.preview.MinimumWidth = 6;
            this.preview.Name = "preview";
            this.preview.ReadOnly = true;
            // 
            // checkInfo
            // 
            this.checkInfo.HeaderText = "";
            this.checkInfo.MinimumWidth = 6;
            this.checkInfo.Name = "checkInfo";
            this.checkInfo.ReadOnly = true;
            this.checkInfo.ToolTipText = "查看账单";
            this.checkInfo.UseColumnTextForButtonValue = true;
            // 
            // FormPatMyBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 629);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Name = "FormPatMyBill";
            this.Text = "MyBillForm";
            this.Enter += new System.EventHandler(this.button_Flush_Click);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDGV_myBill)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDGV_myBill;
        private System.Windows.Forms.Button button_Flush;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel_Info;
        private Sunny.UI.UIPanel uiPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn billID;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewButtonColumn pay;
        private System.Windows.Forms.DataGridViewButtonColumn print;
        private System.Windows.Forms.DataGridViewButtonColumn preview;
        private System.Windows.Forms.DataGridViewButtonColumn checkInfo;
    }
}