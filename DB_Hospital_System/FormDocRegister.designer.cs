
namespace HospitalManagementSystem
{
    partial class FormDocRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocRegister));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel_List = new Sunny.UI.UILabel();
            this.uiTextBox_Name = new Sunny.UI.UITextBox();
            this.uiDataGridView_List = new Sunny.UI.UIDataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiPanel_Info = new Sunny.UI.UIPanel();
            this.uiButton_Finish = new Sunny.UI.UIButton();
            this.uiButton_Ward = new Sunny.UI.UIButton();
            this.uiButton_Recipe = new Sunny.UI.UIButton();
            this.uiTextBox_History = new Sunny.UI.UITextBox();
            this.uiLabel_H = new Sunny.UI.UILabel();
            this.uiLabel_Sex = new Sunny.UI.UILabel();
            this.uiLabel_Name = new Sunny.UI.UILabel();
            this.uiLabel_Age = new Sunny.UI.UILabel();
            this.uiLabel_N = new Sunny.UI.UILabel();
            this.uiLabel_S = new Sunny.UI.UILabel();
            this.uiLabel_A = new Sunny.UI.UILabel();
            this.button_Flush = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_List)).BeginInit();
            this.uiPanel_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel_List);
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(883, 46);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_List
            // 
            this.uiLabel_List.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.uiLabel_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiLabel_List.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_List.Location = new System.Drawing.Point(0, 0);
            this.uiLabel_List.Name = "uiLabel_List";
            this.uiLabel_List.Size = new System.Drawing.Size(120, 46);
            this.uiLabel_List.TabIndex = 0;
            this.uiLabel_List.Text = "挂号列表";
            this.uiLabel_List.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTextBox_Name
            // 
            this.uiTextBox_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_Name.FillColor = System.Drawing.Color.White;
            this.uiTextBox_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox_Name.Location = new System.Drawing.Point(41, 76);
            this.uiTextBox_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_Name.Maximum = 2147483647D;
            this.uiTextBox_Name.Minimum = -2147483648D;
            this.uiTextBox_Name.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_Name.Name = "uiTextBox_Name";
            this.uiTextBox_Name.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_Name.Size = new System.Drawing.Size(163, 40);
            this.uiTextBox_Name.TabIndex = 5;
            this.uiTextBox_Name.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.uiTextBox_Name.Watermark = "";
            this.uiTextBox_Name.DoEnter += new System.EventHandler(this.button_Search_Click);
            this.uiTextBox_Name.TextChanged += new System.EventHandler(this.uiTextBox_Name_TextChanged);
            this.uiTextBox_Name.Leave += new System.EventHandler(this.uiTextBox_Name_Leave);
            this.uiTextBox_Name.Enter += new System.EventHandler(this.uiTextBox_Name_Enter);
            // 
            // uiDataGridView_List
            // 
            this.uiDataGridView_List.AllowUserToAddRows = false;
            this.uiDataGridView_List.AllowUserToDeleteRows = false;
            this.uiDataGridView_List.AllowUserToResizeColumns = false;
            this.uiDataGridView_List.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView_List.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView_List.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView_List.ColumnHeadersHeight = 32;
            this.uiDataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.PatientName,
            this.date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView_List.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView_List.EnableHeadersVisualStyles = false;
            this.uiDataGridView_List.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridView_List.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView_List.Location = new System.Drawing.Point(41, 133);
            this.uiDataGridView_List.MultiSelect = false;
            this.uiDataGridView_List.Name = "uiDataGridView_List";
            this.uiDataGridView_List.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView_List.RowHeadersVisible = false;
            this.uiDataGridView_List.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.uiDataGridView_List.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView_List.RowTemplate.Height = 29;
            this.uiDataGridView_List.SelectedIndex = -1;
            this.uiDataGridView_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiDataGridView_List.ShowGridLine = true;
            this.uiDataGridView_List.Size = new System.Drawing.Size(304, 358);
            this.uiDataGridView_List.TabIndex = 2;
            this.uiDataGridView_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView_List_CellClick);
            // 
            // PatientID
            // 
            this.PatientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PatientID.FillWeight = 0.35F;
            this.PatientID.HeaderText = "病人编号";
            this.PatientID.MinimumWidth = 6;
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PatientName.FillWeight = 0.25F;
            this.PatientName.HeaderText = "姓名";
            this.PatientName.MinimumWidth = 6;
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.FillWeight = 0.4F;
            this.date.HeaderText = "挂号时间";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // uiPanel_Info
            // 
            this.uiPanel_Info.Controls.Add(this.uiButton_Finish);
            this.uiPanel_Info.Controls.Add(this.uiButton_Ward);
            this.uiPanel_Info.Controls.Add(this.uiButton_Recipe);
            this.uiPanel_Info.Controls.Add(this.uiTextBox_History);
            this.uiPanel_Info.Controls.Add(this.uiLabel_H);
            this.uiPanel_Info.Controls.Add(this.uiLabel_Sex);
            this.uiPanel_Info.Controls.Add(this.uiLabel_Name);
            this.uiPanel_Info.Controls.Add(this.uiLabel_Age);
            this.uiPanel_Info.Controls.Add(this.uiLabel_N);
            this.uiPanel_Info.Controls.Add(this.uiLabel_S);
            this.uiPanel_Info.Controls.Add(this.uiLabel_A);
            this.uiPanel_Info.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel_Info.Location = new System.Drawing.Point(389, 101);
            this.uiPanel_Info.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel_Info.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_Info.Name = "uiPanel_Info";
            this.uiPanel_Info.Size = new System.Drawing.Size(458, 390);
            this.uiPanel_Info.TabIndex = 7;
            this.uiPanel_Info.Text = null;
            this.uiPanel_Info.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton_Finish
            // 
            this.uiButton_Finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Finish.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_Finish.Location = new System.Drawing.Point(323, 327);
            this.uiButton_Finish.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Finish.Name = "uiButton_Finish";
            this.uiButton_Finish.Size = new System.Drawing.Size(100, 35);
            this.uiButton_Finish.TabIndex = 22;
            this.uiButton_Finish.Text = "保存提交";
            this.uiButton_Finish.Click += new System.EventHandler(this.uiButton_Finish_Click);
            // 
            // uiButton_Ward
            // 
            this.uiButton_Ward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Ward.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_Ward.Location = new System.Drawing.Point(177, 327);
            this.uiButton_Ward.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Ward.Name = "uiButton_Ward";
            this.uiButton_Ward.Size = new System.Drawing.Size(100, 35);
            this.uiButton_Ward.TabIndex = 21;
            this.uiButton_Ward.Text = "安排住院";
            this.uiButton_Ward.Click += new System.EventHandler(this.uiButton_Ward_Click);
            // 
            // uiButton_Recipe
            // 
            this.uiButton_Recipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Recipe.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_Recipe.Location = new System.Drawing.Point(38, 327);
            this.uiButton_Recipe.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Recipe.Name = "uiButton_Recipe";
            this.uiButton_Recipe.Size = new System.Drawing.Size(100, 35);
            this.uiButton_Recipe.TabIndex = 20;
            this.uiButton_Recipe.Text = "填写处方";
            this.uiButton_Recipe.Click += new System.EventHandler(this.uiButton_Recipe_Click);
            // 
            // uiTextBox_History
            // 
            this.uiTextBox_History.AutoScroll = true;
            this.uiTextBox_History.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_History.FillColor = System.Drawing.Color.White;
            this.uiTextBox_History.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox_History.Location = new System.Drawing.Point(89, 96);
            this.uiTextBox_History.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_History.Maximum = 2147483647D;
            this.uiTextBox_History.Minimum = -2147483648D;
            this.uiTextBox_History.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_History.Multiline = true;
            this.uiTextBox_History.Name = "uiTextBox_History";
            this.uiTextBox_History.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_History.Size = new System.Drawing.Size(326, 197);
            this.uiTextBox_History.TabIndex = 19;
            this.uiTextBox_History.Text = "History";
            this.uiTextBox_History.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.uiTextBox_History.Watermark = "";
            this.uiTextBox_History.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uiTextBox_History_KeyPress);
            // 
            // uiLabel_H
            // 
            this.uiLabel_H.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_H.Location = new System.Drawing.Point(22, 96);
            this.uiLabel_H.Name = "uiLabel_H";
            this.uiLabel_H.Size = new System.Drawing.Size(79, 31);
            this.uiLabel_H.TabIndex = 18;
            this.uiLabel_H.Text = "病史：";
            this.uiLabel_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_Sex
            // 
            this.uiLabel_Sex.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_Sex.Location = new System.Drawing.Point(360, 30);
            this.uiLabel_Sex.Name = "uiLabel_Sex";
            this.uiLabel_Sex.Size = new System.Drawing.Size(63, 31);
            this.uiLabel_Sex.TabIndex = 17;
            this.uiLabel_Sex.Text = "Sex";
            this.uiLabel_Sex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_Name
            // 
            this.uiLabel_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_Name.Location = new System.Drawing.Point(84, 32);
            this.uiLabel_Name.Name = "uiLabel_Name";
            this.uiLabel_Name.Size = new System.Drawing.Size(94, 29);
            this.uiLabel_Name.TabIndex = 15;
            this.uiLabel_Name.Text = "Name";
            this.uiLabel_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_Age
            // 
            this.uiLabel_Age.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_Age.Location = new System.Drawing.Point(222, 31);
            this.uiLabel_Age.Name = "uiLabel_Age";
            this.uiLabel_Age.Size = new System.Drawing.Size(67, 29);
            this.uiLabel_Age.TabIndex = 16;
            this.uiLabel_Age.Text = "Age";
            this.uiLabel_Age.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_N
            // 
            this.uiLabel_N.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_N.Location = new System.Drawing.Point(22, 32);
            this.uiLabel_N.Name = "uiLabel_N";
            this.uiLabel_N.Size = new System.Drawing.Size(79, 29);
            this.uiLabel_N.TabIndex = 12;
            this.uiLabel_N.Text = "姓名：";
            this.uiLabel_N.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_S
            // 
            this.uiLabel_S.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_S.Location = new System.Drawing.Point(305, 30);
            this.uiLabel_S.Name = "uiLabel_S";
            this.uiLabel_S.Size = new System.Drawing.Size(79, 31);
            this.uiLabel_S.TabIndex = 14;
            this.uiLabel_S.Text = "性别：";
            this.uiLabel_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_A
            // 
            this.uiLabel_A.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_A.Location = new System.Drawing.Point(172, 32);
            this.uiLabel_A.Name = "uiLabel_A";
            this.uiLabel_A.Size = new System.Drawing.Size(79, 29);
            this.uiLabel_A.TabIndex = 13;
            this.uiLabel_A.Text = "年龄：";
            this.uiLabel_A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Flush
            // 
            this.button_Flush.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.flush;
            this.button_Flush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Flush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Flush.Location = new System.Drawing.Point(304, 76);
            this.button_Flush.Name = "button_Flush";
            this.button_Flush.Size = new System.Drawing.Size(41, 40);
            this.button_Flush.TabIndex = 8;
            this.button_Flush.UseVisualStyleBackColor = true;
            this.button_Flush.Click += new System.EventHandler(this.button_Flush_Click);
            // 
            // button_Search
            // 
            this.button_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Search.BackgroundImage")));
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Search.Location = new System.Drawing.Point(236, 76);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(41, 40);
            this.button_Search.TabIndex = 6;
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // FormDocRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 528);
            this.Controls.Add(this.button_Flush);
            this.Controls.Add(this.uiPanel_Info);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.uiTextBox_Name);
            this.Controls.Add(this.uiDataGridView_List);
            this.Controls.Add(this.uiPanel1);
            this.Name = "FormDocRegister";
            this.Initialize += new System.EventHandler(this.RegisterForm_Initialize);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_List)).EndInit();
            this.uiPanel_Info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel_List;
        private Sunny.UI.UITextBox uiTextBox_Name;
        private Sunny.UI.UIDataGridView uiDataGridView_List;
        private System.Windows.Forms.Button button_Search;
        private Sunny.UI.UIPanel uiPanel_Info;
        private Sunny.UI.UILabel uiLabel_N;
        private Sunny.UI.UILabel uiLabel_Sex;
        private Sunny.UI.UILabel uiLabel_Name;
        private Sunny.UI.UILabel uiLabel_Age;
        private Sunny.UI.UILabel uiLabel_A;
        private Sunny.UI.UITextBox uiTextBox_History;
        private Sunny.UI.UILabel uiLabel_H;
        private Sunny.UI.UILabel uiLabel_S;
        private Sunny.UI.UIButton uiButton_Ward;
        private Sunny.UI.UIButton uiButton_Recipe;
        private Sunny.UI.UIButton uiButton_Finish;
        private System.Windows.Forms.Button button_Flush;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}