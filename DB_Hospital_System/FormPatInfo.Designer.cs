namespace HospitalManagementSystem
{
    partial class FormPatInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatInfo));
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton_P = new Sunny.UI.UIButton();
            this.uiLabel_Sex = new Sunny.UI.UILabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiLabel_Money = new Sunny.UI.UILabel();
            this.uiLabel_M = new Sunny.UI.UILabel();
            this.uiLabel_Ward = new Sunny.UI.UILabel();
            this.uiLabel_Phone = new Sunny.UI.UILabel();
            this.uiLabel_Name = new Sunny.UI.UILabel();
            this.uiLabel_Age = new Sunny.UI.UILabel();
            this.uiLabel_W = new Sunny.UI.UILabel();
            this.uiLabel_A = new Sunny.UI.UILabel();
            this.uiLabel_P = new Sunny.UI.UILabel();
            this.uiLabel_S = new Sunny.UI.UILabel();
            this.uiLabel_N = new Sunny.UI.UILabel();
            this.uiLabel_Info = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.uiPanel2.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(486, 336);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 13;
            this.uiButton1.Text = "修改信息";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton_P
            // 
            this.uiButton_P.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_P.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_P.Location = new System.Drawing.Point(486, 278);
            this.uiButton_P.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_P.Name = "uiButton_P";
            this.uiButton_P.Size = new System.Drawing.Size(100, 35);
            this.uiButton_P.TabIndex = 13;
            this.uiButton_P.Text = "上传头像";
            this.uiButton_P.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // uiLabel_Sex
            // 
            this.uiLabel_Sex.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_Sex.Location = new System.Drawing.Point(168, 89);
            this.uiLabel_Sex.Name = "uiLabel_Sex";
            this.uiLabel_Sex.Size = new System.Drawing.Size(200, 29);
            this.uiLabel_Sex.TabIndex = 10;
            this.uiLabel_Sex.Text = "Sex";
            this.uiLabel_Sex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            this.panel1.Location = new System.Drawing.Point(461, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 210);
            this.panel1.TabIndex = 14;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.AutoSizeHeight = false;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(150, 210);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuPictureBox1.TabIndex = 9;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            this.bunifuPictureBox1.WaitOnLoad = true;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiLabel_Money);
            this.uiPanel2.Controls.Add(this.uiLabel_M);
            this.uiPanel2.Controls.Add(this.panel1);
            this.uiPanel2.Controls.Add(this.uiButton1);
            this.uiPanel2.Controls.Add(this.uiButton_P);
            this.uiPanel2.Controls.Add(this.uiLabel_Ward);
            this.uiPanel2.Controls.Add(this.uiLabel_Phone);
            this.uiPanel2.Controls.Add(this.uiLabel_Name);
            this.uiPanel2.Controls.Add(this.uiLabel_Age);
            this.uiPanel2.Controls.Add(this.uiLabel_Sex);
            this.uiPanel2.Controls.Add(this.uiLabel_W);
            this.uiPanel2.Controls.Add(this.uiLabel_A);
            this.uiPanel2.Controls.Add(this.uiLabel_P);
            this.uiPanel2.Controls.Add(this.uiLabel_S);
            this.uiPanel2.Controls.Add(this.uiLabel_N);
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(88, 84);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(691, 396);
            this.uiPanel2.TabIndex = 15;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel_Money
            // 
            this.uiLabel_Money.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_Money.Location = new System.Drawing.Point(168, 310);
            this.uiLabel_Money.Name = "uiLabel_Money";
            this.uiLabel_Money.Size = new System.Drawing.Size(200, 29);
            this.uiLabel_Money.TabIndex = 16;
            this.uiLabel_Money.Text = "Money";
            this.uiLabel_Money.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_M
            // 
            this.uiLabel_M.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_M.Location = new System.Drawing.Point(95, 310);
            this.uiLabel_M.Name = "uiLabel_M";
            this.uiLabel_M.Size = new System.Drawing.Size(95, 31);
            this.uiLabel_M.TabIndex = 15;
            this.uiLabel_M.Text = "余额：";
            this.uiLabel_M.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_Ward
            // 
            this.uiLabel_Ward.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_Ward.Location = new System.Drawing.Point(168, 254);
            this.uiLabel_Ward.Name = "uiLabel_Ward";
            this.uiLabel_Ward.Size = new System.Drawing.Size(200, 29);
            this.uiLabel_Ward.TabIndex = 12;
            this.uiLabel_Ward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_Phone
            // 
            this.uiLabel_Phone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_Phone.Location = new System.Drawing.Point(168, 199);
            this.uiLabel_Phone.Name = "uiLabel_Phone";
            this.uiLabel_Phone.Size = new System.Drawing.Size(200, 29);
            this.uiLabel_Phone.TabIndex = 12;
            this.uiLabel_Phone.Text = "Phone";
            this.uiLabel_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_Name
            // 
            this.uiLabel_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_Name.Location = new System.Drawing.Point(168, 34);
            this.uiLabel_Name.Name = "uiLabel_Name";
            this.uiLabel_Name.Size = new System.Drawing.Size(200, 29);
            this.uiLabel_Name.TabIndex = 9;
            this.uiLabel_Name.Text = "Name";
            this.uiLabel_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_Age
            // 
            this.uiLabel_Age.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_Age.Location = new System.Drawing.Point(168, 144);
            this.uiLabel_Age.Name = "uiLabel_Age";
            this.uiLabel_Age.Size = new System.Drawing.Size(200, 29);
            this.uiLabel_Age.TabIndex = 10;
            this.uiLabel_Age.Text = "Age";
            this.uiLabel_Age.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_W
            // 
            this.uiLabel_W.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_W.Location = new System.Drawing.Point(79, 254);
            this.uiLabel_W.Name = "uiLabel_W";
            this.uiLabel_W.Size = new System.Drawing.Size(95, 31);
            this.uiLabel_W.TabIndex = 5;
            this.uiLabel_W.Text = "病房号：";
            this.uiLabel_W.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_A
            // 
            this.uiLabel_A.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_A.Location = new System.Drawing.Point(95, 144);
            this.uiLabel_A.Name = "uiLabel_A";
            this.uiLabel_A.Size = new System.Drawing.Size(79, 29);
            this.uiLabel_A.TabIndex = 3;
            this.uiLabel_A.Text = "年龄：";
            this.uiLabel_A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_P
            // 
            this.uiLabel_P.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_P.Location = new System.Drawing.Point(79, 199);
            this.uiLabel_P.Margin = new System.Windows.Forms.Padding(0);
            this.uiLabel_P.Name = "uiLabel_P";
            this.uiLabel_P.Size = new System.Drawing.Size(95, 31);
            this.uiLabel_P.TabIndex = 5;
            this.uiLabel_P.Text = "手机号：";
            this.uiLabel_P.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_S
            // 
            this.uiLabel_S.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_S.Location = new System.Drawing.Point(95, 89);
            this.uiLabel_S.Name = "uiLabel_S";
            this.uiLabel_S.Size = new System.Drawing.Size(79, 29);
            this.uiLabel_S.TabIndex = 3;
            this.uiLabel_S.Text = "性别：";
            this.uiLabel_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_N
            // 
            this.uiLabel_N.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_N.Location = new System.Drawing.Point(95, 34);
            this.uiLabel_N.Name = "uiLabel_N";
            this.uiLabel_N.Size = new System.Drawing.Size(79, 29);
            this.uiLabel_N.TabIndex = 2;
            this.uiLabel_N.Text = "姓名：";
            this.uiLabel_N.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_Info
            // 
            this.uiLabel_Info.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.uiLabel_Info.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_Info.Location = new System.Drawing.Point(0, 0);
            this.uiLabel_Info.Name = "uiLabel_Info";
            this.uiLabel_Info.Size = new System.Drawing.Size(120, 46);
            this.uiLabel_Info.TabIndex = 0;
            this.uiLabel_Info.Text = "个人信息";
            this.uiLabel_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel_Info);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(883, 46);
            this.uiPanel1.TabIndex = 14;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPatInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 528);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPatInfo";
            this.Text = "Form2";
            this.Enter += new System.EventHandler(this.FormPatInfo_Enter);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton_P;
        private Sunny.UI.UILabel uiLabel_Sex;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel uiLabel_Phone;
        private Sunny.UI.UILabel uiLabel_Name;
        private Sunny.UI.UILabel uiLabel_Age;
        private Sunny.UI.UILabel uiLabel_A;
        private Sunny.UI.UILabel uiLabel_P;
        private Sunny.UI.UILabel uiLabel_S;
        private Sunny.UI.UILabel uiLabel_N;
        private Sunny.UI.UILabel uiLabel_Info;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel_Ward;
        private Sunny.UI.UILabel uiLabel_W;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Sunny.UI.UILabel uiLabel_Money;
        private Sunny.UI.UILabel uiLabel_M;
    }
}