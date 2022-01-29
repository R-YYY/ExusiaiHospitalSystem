
namespace HospitalManagementSystem
{
    partial class FormDocSubArrangeWard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocSubArrangeWard));
            this.uiDataGridView_Ward = new Sunny.UI.UIDataGridView();
            this.WardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeBedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiButton_Confirm = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_Ward)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDataGridView_Ward
            // 
            this.uiDataGridView_Ward.AllowUserToAddRows = false;
            this.uiDataGridView_Ward.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView_Ward.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView_Ward.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView_Ward.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView_Ward.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView_Ward.ColumnHeadersHeight = 32;
            this.uiDataGridView_Ward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView_Ward.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WardID,
            this.FreeBedAmount,
            this.BedAmount});
            this.uiDataGridView_Ward.EnableHeadersVisualStyles = false;
            this.uiDataGridView_Ward.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridView_Ward.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView_Ward.Location = new System.Drawing.Point(62, 50);
            this.uiDataGridView_Ward.MultiSelect = false;
            this.uiDataGridView_Ward.Name = "uiDataGridView_Ward";
            this.uiDataGridView_Ward.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView_Ward.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView_Ward.RowHeadersWidth = 40;
            this.uiDataGridView_Ward.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.uiDataGridView_Ward.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView_Ward.RowTemplate.Height = 29;
            this.uiDataGridView_Ward.SelectedIndex = -1;
            this.uiDataGridView_Ward.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiDataGridView_Ward.ShowGridLine = true;
            this.uiDataGridView_Ward.Size = new System.Drawing.Size(594, 255);
            this.uiDataGridView_Ward.TabIndex = 0;
            this.uiDataGridView_Ward.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView_Ward_CellClick);
            // 
            // WardID
            // 
            this.WardID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WardID.FillWeight = 0.5F;
            this.WardID.HeaderText = "病房编号";
            this.WardID.MinimumWidth = 6;
            this.WardID.Name = "WardID";
            this.WardID.ReadOnly = true;
            // 
            // FreeBedAmount
            // 
            this.FreeBedAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FreeBedAmount.FillWeight = 0.25F;
            this.FreeBedAmount.HeaderText = "空床位数";
            this.FreeBedAmount.MinimumWidth = 6;
            this.FreeBedAmount.Name = "FreeBedAmount";
            this.FreeBedAmount.ReadOnly = true;
            // 
            // BedAmount
            // 
            this.BedAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BedAmount.FillWeight = 0.25F;
            this.BedAmount.HeaderText = "总床位数";
            this.BedAmount.MinimumWidth = 6;
            this.BedAmount.Name = "BedAmount";
            this.BedAmount.ReadOnly = true;
            // 
            // uiButton_Confirm
            // 
            this.uiButton_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Confirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_Confirm.Location = new System.Drawing.Point(307, 345);
            this.uiButton_Confirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Confirm.Name = "uiButton_Confirm";
            this.uiButton_Confirm.Size = new System.Drawing.Size(100, 35);
            this.uiButton_Confirm.TabIndex = 1;
            this.uiButton_Confirm.Text = "确定";
            this.uiButton_Confirm.Click += new System.EventHandler(this.uiButton_Confirm_Click);
            // 
            // FormDocSubArrangeWard
            // 
            this.AcceptButton = this.uiButton_Confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 422);
            this.Controls.Add(this.uiButton_Confirm);
            this.Controls.Add(this.uiDataGridView_Ward);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDocSubArrangeWard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择病房";
            this.Load += new System.EventHandler(this.ArrangeWradForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_Ward)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView_Ward;
        private Sunny.UI.UIButton uiButton_Confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn WardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeBedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedAmount;
    }
}