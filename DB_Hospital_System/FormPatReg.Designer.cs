namespace HospitalManagementSystem
{
    partial class FormPatReg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuDGV_registration = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dept_name_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor_name_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.panelChildForm = new Sunny.UI.UIPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.comboBox_title = new Sunny.UI.UIComboBox();
            this.comboBox_dept = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel_Info = new Sunny.UI.UILabel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDGV_registration)).BeginInit();
            this.uiPanel2.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(228, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 1;
            // 
            // bunifuDGV_registration
            // 
            this.bunifuDGV_registration.AllowCustomTheming = false;
            this.bunifuDGV_registration.AllowUserToAddRows = false;
            this.bunifuDGV_registration.AllowUserToDeleteRows = false;
            this.bunifuDGV_registration.AllowUserToResizeColumns = false;
            this.bunifuDGV_registration.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDGV_registration.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDGV_registration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDGV_registration.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuDGV_registration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDGV_registration.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDGV_registration.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDGV_registration.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDGV_registration.ColumnHeadersHeight = 40;
            this.bunifuDGV_registration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dept_name_grid,
            this.doctor_name_grid,
            this.title_grid,
            this.pay,
            this.print});
            this.bunifuDGV_registration.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDGV_registration.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDGV_registration.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDGV_registration.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDGV_registration.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDGV_registration.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDGV_registration.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDGV_registration.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDGV_registration.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDGV_registration.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDGV_registration.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDGV_registration.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDGV_registration.CurrentTheme.Name = null;
            this.bunifuDGV_registration.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDGV_registration.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDGV_registration.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDGV_registration.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDGV_registration.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDGV_registration.DefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuDGV_registration.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuDGV_registration.EnableHeadersVisualStyles = false;
            this.bunifuDGV_registration.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDGV_registration.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDGV_registration.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDGV_registration.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDGV_registration.Location = new System.Drawing.Point(0, 0);
            this.bunifuDGV_registration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuDGV_registration.Name = "bunifuDGV_registration";
            this.bunifuDGV_registration.ReadOnly = true;
            this.bunifuDGV_registration.RowHeadersVisible = false;
            this.bunifuDGV_registration.RowHeadersWidth = 51;
            this.bunifuDGV_registration.RowTemplate.Height = 40;
            this.bunifuDGV_registration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDGV_registration.Size = new System.Drawing.Size(436, 754);
            this.bunifuDGV_registration.TabIndex = 12;
            this.bunifuDGV_registration.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDGV_registration.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDGV_registration_CellContentClick);
            // 
            // dept_name_grid
            // 
            this.dept_name_grid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dept_name_grid.HeaderText = "科室";
            this.dept_name_grid.MinimumWidth = 6;
            this.dept_name_grid.Name = "dept_name_grid";
            this.dept_name_grid.ReadOnly = true;
            this.dept_name_grid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dept_name_grid.Width = 56;
            // 
            // doctor_name_grid
            // 
            this.doctor_name_grid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.doctor_name_grid.HeaderText = "医生";
            this.doctor_name_grid.MinimumWidth = 6;
            this.doctor_name_grid.Name = "doctor_name_grid";
            this.doctor_name_grid.ReadOnly = true;
            this.doctor_name_grid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.doctor_name_grid.Width = 56;
            // 
            // title_grid
            // 
            this.title_grid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.title_grid.HeaderText = "职称";
            this.title_grid.MinimumWidth = 6;
            this.title_grid.Name = "title_grid";
            this.title_grid.ReadOnly = true;
            this.title_grid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.title_grid.Width = 56;
            // 
            // pay
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pay.DefaultCellStyle = dataGridViewCellStyle3;
            this.pay.HeaderText = "";
            this.pay.MinimumWidth = 6;
            this.pay.Name = "pay";
            this.pay.ReadOnly = true;
            this.pay.Text = "支付";
            // 
            // print
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.print.DefaultCellStyle = dataGridViewCellStyle4;
            this.print.HeaderText = "";
            this.print.MinimumWidth = 6;
            this.print.Name = "print";
            this.print.ReadOnly = true;
            this.print.Text = "打印";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(16, 1);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 39);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "选择科室";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelChildForm.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(564, 754);
            this.panelChildForm.TabIndex = 14;
            this.panelChildForm.Text = null;
            this.panelChildForm.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.comboBox_title);
            this.uiPanel2.Controls.Add(this.comboBox_dept);
            this.uiPanel2.Controls.Add(this.uiLabel2);
            this.uiPanel2.Controls.Add(this.uiLabel1);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(120, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(880, 46);
            this.uiPanel2.TabIndex = 0;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_title
            // 
            this.comboBox_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comboBox_title.FillColor = System.Drawing.Color.White;
            this.comboBox_title.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comboBox_title.Location = new System.Drawing.Point(333, 6);
            this.comboBox_title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_title.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboBox_title.Name = "comboBox_title";
            this.comboBox_title.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBox_title.Size = new System.Drawing.Size(113, 34);
            this.comboBox_title.TabIndex = 2;
            this.comboBox_title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBox_title.SelectedIndexChanged += new System.EventHandler(this.comboBox_title_SelectedIndexChanged);
            // 
            // comboBox_dept
            // 
            this.comboBox_dept.FillColor = System.Drawing.Color.White;
            this.comboBox_dept.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comboBox_dept.Location = new System.Drawing.Point(119, 5);
            this.comboBox_dept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_dept.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboBox_dept.Name = "comboBox_dept";
            this.comboBox_dept.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBox_dept.Size = new System.Drawing.Size(113, 34);
            this.comboBox_dept.TabIndex = 1;
            this.comboBox_dept.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBox_dept.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(239, 2);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 39);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "选择职称";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiPanel2);
            this.uiPanel1.Controls.Add(this.uiLabel_Info);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1000, 46);
            this.uiPanel1.TabIndex = 18;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_Info
            // 
            this.uiLabel_Info.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.uiLabel_Info.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiLabel_Info.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_Info.Location = new System.Drawing.Point(0, 0);
            this.uiLabel_Info.Name = "uiLabel_Info";
            this.uiLabel_Info.Size = new System.Drawing.Size(120, 46);
            this.uiLabel_Info.TabIndex = 0;
            this.uiLabel_Info.Text = "挂号";
            this.uiLabel_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.uiPanel4);
            this.uiPanel3.Controls.Add(this.label2);
            this.uiPanel3.Controls.Add(this.bunifuDGV_registration);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(0, 46);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(1000, 754);
            this.uiPanel3.TabIndex = 19;
            this.uiPanel3.Text = "uiPanel3";
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel4
            // 
            this.uiPanel4.Controls.Add(this.panelChildForm);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(436, 0);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Size = new System.Drawing.Size(564, 754);
            this.uiPanel4.TabIndex = 15;
            this.uiPanel4.Text = "uiPanel4";
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPatReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.uiPanel3);
            this.Controls.Add(this.uiPanel1);
            this.Name = "FormPatReg";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDGV_registration)).EndInit();
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.uiPanel3.PerformLayout();
            this.uiPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDGV_registration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_name_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor_name_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn title_grid;
        private System.Windows.Forms.DataGridViewButtonColumn pay;
        private System.Windows.Forms.DataGridViewButtonColumn print;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel panelChildForm;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIComboBox comboBox_dept;
        private Sunny.UI.UIComboBox comboBox_title;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel_Info;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel uiPanel4;
    }
}