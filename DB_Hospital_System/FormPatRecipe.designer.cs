
namespace HospitalManagementSystem {
    partial class FormPatRecipe {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_recipe = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescription_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docker_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getDrug = new System.Windows.Forms.DataGridViewButtonColumn();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel_Info = new Sunny.UI.UILabel();
            this.button_Flush = new System.Windows.Forms.Button();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recipe)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_recipe
            // 
            this.dgv_recipe.AllowCustomTheming = false;
            this.dgv_recipe.AllowUserToAddRows = false;
            this.dgv_recipe.AllowUserToDeleteRows = false;
            this.dgv_recipe.AllowUserToResizeColumns = false;
            this.dgv_recipe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_recipe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_recipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_recipe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_recipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_recipe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_recipe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_recipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_recipe.ColumnHeadersHeight = 40;
            this.dgv_recipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.prescription_ID,
            this.docker_ID,
            this.create_time,
            this.text,
            this.getDrug});
            this.dgv_recipe.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_recipe.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_recipe.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_recipe.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_recipe.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_recipe.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_recipe.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_recipe.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_recipe.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_recipe.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_recipe.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_recipe.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_recipe.CurrentTheme.Name = null;
            this.dgv_recipe.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_recipe.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_recipe.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_recipe.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_recipe.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_recipe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_recipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_recipe.EnableHeadersVisualStyles = false;
            this.dgv_recipe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_recipe.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_recipe.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_recipe.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_recipe.Location = new System.Drawing.Point(0, 0);
            this.dgv_recipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_recipe.Name = "dgv_recipe";
            this.dgv_recipe.ReadOnly = true;
            this.dgv_recipe.RowHeadersVisible = false;
            this.dgv_recipe.RowHeadersWidth = 51;
            this.dgv_recipe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_recipe.RowTemplate.Height = 40;
            this.dgv_recipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_recipe.Size = new System.Drawing.Size(900, 454);
            this.dgv_recipe.TabIndex = 2;
            this.dgv_recipe.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgv_recipe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_recipe_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 50;
            // 
            // prescription_ID
            // 
            this.prescription_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.prescription_ID.Frozen = true;
            this.prescription_ID.HeaderText = "处方ID";
            this.prescription_ID.MinimumWidth = 6;
            this.prescription_ID.Name = "prescription_ID";
            this.prescription_ID.ReadOnly = true;
            this.prescription_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prescription_ID.Width = 125;
            // 
            // docker_ID
            // 
            this.docker_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.docker_ID.Frozen = true;
            this.docker_ID.HeaderText = "医生ID";
            this.docker_ID.MinimumWidth = 6;
            this.docker_ID.Name = "docker_ID";
            this.docker_ID.ReadOnly = true;
            this.docker_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.docker_ID.Width = 125;
            // 
            // create_time
            // 
            this.create_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.create_time.Frozen = true;
            this.create_time.HeaderText = "创建时间";
            this.create_time.MinimumWidth = 6;
            this.create_time.Name = "create_time";
            this.create_time.ReadOnly = true;
            this.create_time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.create_time.Width = 125;
            // 
            // text
            // 
            this.text.HeaderText = "处方内容";
            this.text.MinimumWidth = 6;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // getDrug
            // 
            this.getDrug.HeaderText = "";
            this.getDrug.MinimumWidth = 6;
            this.getDrug.Name = "getDrug";
            this.getDrug.ReadOnly = true;
            this.getDrug.Text = "查看药品";
            this.getDrug.UseColumnTextForButtonValue = true;
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
            this.uiPanel1.Size = new System.Drawing.Size(900, 46);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 17;
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
            this.uiLabel_Info.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_Info.TabIndex = 0;
            this.uiLabel_Info.Text = "我的处方";
            this.uiLabel_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Flush
            // 
            this.button_Flush.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.flush;
            this.button_Flush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Flush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Flush.Location = new System.Drawing.Point(126, 3);
            this.button_Flush.Name = "button_Flush";
            this.button_Flush.Size = new System.Drawing.Size(41, 40);
            this.button_Flush.TabIndex = 9;
            this.button_Flush.UseVisualStyleBackColor = true;
            this.button_Flush.Click += new System.EventHandler(this.button_Flush_Click);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.dgv_recipe);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 46);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(900, 454);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.TabIndex = 18;
            this.uiPanel2.Text = "uiPanel2";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPatRecipe
            // 
            this.AcceptButton = this.button_Flush;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPatRecipe";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "Form1";
            this.Enter += new System.EventHandler(this.button_Flush_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recipe)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_recipe;
        private System.Windows.Forms.Button button_Flush;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel_Info;
        private Sunny.UI.UIPanel uiPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescription_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn docker_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewButtonColumn getDrug;
    }
}