
namespace HospitalManagementSystem
{
    partial class FormInit
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInit));
            this.bunifuTileButton_select_doctor = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton_select_patient = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTileButton_select_doctor
            // 
            this.bunifuTileButton_select_doctor.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton_select_doctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuTileButton_select_doctor.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton_select_doctor.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton_select_doctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton_select_doctor.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton_select_doctor.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton_select_doctor.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton_select_doctor.Image")));
            this.bunifuTileButton_select_doctor.ImagePosition = 20;
            this.bunifuTileButton_select_doctor.ImageZoom = 50;
            this.bunifuTileButton_select_doctor.LabelPosition = 41;
            this.bunifuTileButton_select_doctor.LabelText = "医生";
            this.bunifuTileButton_select_doctor.Location = new System.Drawing.Point(461, 201);
            this.bunifuTileButton_select_doctor.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton_select_doctor.Name = "bunifuTileButton_select_doctor";
            this.bunifuTileButton_select_doctor.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton_select_doctor.TabIndex = 0;
            this.bunifuTileButton_select_doctor.Click += new System.EventHandler(this.Select_Doctor);
            // 
            // bunifuTileButton_select_patient
            // 
            this.bunifuTileButton_select_patient.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton_select_patient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuTileButton_select_patient.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton_select_patient.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton_select_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton_select_patient.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton_select_patient.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton_select_patient.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton_select_patient.Image")));
            this.bunifuTileButton_select_patient.ImagePosition = 20;
            this.bunifuTileButton_select_patient.ImageZoom = 50;
            this.bunifuTileButton_select_patient.LabelPosition = 41;
            this.bunifuTileButton_select_patient.LabelText = "患者";
            this.bunifuTileButton_select_patient.Location = new System.Drawing.Point(648, 201);
            this.bunifuTileButton_select_patient.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton_select_patient.Name = "bunifuTileButton_select_patient";
            this.bunifuTileButton_select_patient.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton_select_patient.TabIndex = 1;
            this.bunifuTileButton_select_patient.Click += new System.EventHandler(this.Select_Patient);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.bunifuPictureBox1.BorderRadius = 79;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(530, 371);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(159, 159);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 2;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // FormInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.bunifuTileButton_select_patient);
            this.Controls.Add(this.bunifuTileButton_select_doctor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormInit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exusiai医疗卫生服务系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Start_Interface_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton_select_doctor;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton_select_patient;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}

