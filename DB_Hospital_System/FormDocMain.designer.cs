
namespace HospitalManagementSystem
{
    partial class FormDocMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocMain));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiButton_doctor_logout = new Sunny.UI.UIButton();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Aside.LineColor = System.Drawing.Color.Black;
            this.Aside.Location = new System.Drawing.Point(0, 125);
            this.Aside.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Aside.Size = new System.Drawing.Size(228, 528);
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Header.Controls.Add(this.uiButton_doctor_logout);
            this.Header.Controls.Add(this.uiLabel2);
            this.Header.Controls.Add(this.uiAvatar1);
            this.Header.Controls.Add(this.uiLabel1);
            this.Header.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Header.Size = new System.Drawing.Size(1111, 90);
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiLabel1.Location = new System.Drawing.Point(3, 14);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(212, 52);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "医院管理系统";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(1008, 14);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar1.TabIndex = 1;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiLabel2.Location = new System.Drawing.Point(786, 31);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(54, 27);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "time";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton_doctor_logout
            // 
            this.uiButton_doctor_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_doctor_logout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiButton_doctor_logout.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_doctor_logout.Location = new System.Drawing.Point(243, 22);
            this.uiButton_doctor_logout.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_doctor_logout.Name = "uiButton_doctor_logout";
            this.uiButton_doctor_logout.Size = new System.Drawing.Size(100, 35);
            this.uiButton_doctor_logout.TabIndex = 3;
            this.uiButton_doctor_logout.Text = "注销";
            this.uiButton_doctor_logout.Click += new System.EventHandler(this.button_click_doctor_logout);
            // 
            // FormDocMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1111, 653);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDocMain";
            this.ShowIcon = true;
            this.Text = "Exusiai医疗卫生服务系统";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton_doctor_logout;
    }
}

