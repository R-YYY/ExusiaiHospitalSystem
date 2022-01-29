
namespace HospitalManagementSystem
{
    partial class FormDocSubChooseMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocSubChooseMedicine));
            this.uiDataGridView_Medicine = new Sunny.UI.UIDataGridView();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineSpecifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiButton_Confirm = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_Medicine)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDataGridView_Medicine
            // 
            this.uiDataGridView_Medicine.AllowUserToAddRows = false;
            this.uiDataGridView_Medicine.AllowUserToDeleteRows = false;
            this.uiDataGridView_Medicine.AllowUserToResizeColumns = false;
            this.uiDataGridView_Medicine.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView_Medicine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView_Medicine.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView_Medicine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView_Medicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView_Medicine.ColumnHeadersHeight = 32;
            this.uiDataGridView_Medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView_Medicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineID,
            this.MedicineName,
            this.MedicineSpecifications,
            this.MedicineStock,
            this.MedicinePrice});
            this.uiDataGridView_Medicine.EnableHeadersVisualStyles = false;
            this.uiDataGridView_Medicine.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridView_Medicine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView_Medicine.Location = new System.Drawing.Point(77, 58);
            this.uiDataGridView_Medicine.MultiSelect = false;
            this.uiDataGridView_Medicine.Name = "uiDataGridView_Medicine";
            this.uiDataGridView_Medicine.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView_Medicine.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView_Medicine.RowHeadersWidth = 40;
            this.uiDataGridView_Medicine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.uiDataGridView_Medicine.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView_Medicine.RowTemplate.Height = 29;
            this.uiDataGridView_Medicine.SelectedIndex = -1;
            this.uiDataGridView_Medicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiDataGridView_Medicine.ShowGridLine = true;
            this.uiDataGridView_Medicine.Size = new System.Drawing.Size(671, 234);
            this.uiDataGridView_Medicine.TabIndex = 0;
            this.uiDataGridView_Medicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView_Medicine_CellClick);
            // 
            // MedicineID
            // 
            this.MedicineID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineID.FillWeight = 0.2F;
            this.MedicineID.HeaderText = "药品编号";
            this.MedicineID.MinimumWidth = 6;
            this.MedicineID.Name = "MedicineID";
            this.MedicineID.ReadOnly = true;
            // 
            // MedicineName
            // 
            this.MedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineName.FillWeight = 0.3F;
            this.MedicineName.HeaderText = "药品名称";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.ReadOnly = true;
            // 
            // MedicineSpecifications
            // 
            this.MedicineSpecifications.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineSpecifications.FillWeight = 0.2F;
            this.MedicineSpecifications.HeaderText = "规格";
            this.MedicineSpecifications.MinimumWidth = 6;
            this.MedicineSpecifications.Name = "MedicineSpecifications";
            this.MedicineSpecifications.ReadOnly = true;
            // 
            // MedicineStock
            // 
            this.MedicineStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineStock.FillWeight = 0.15F;
            this.MedicineStock.HeaderText = "库存";
            this.MedicineStock.MinimumWidth = 6;
            this.MedicineStock.Name = "MedicineStock";
            this.MedicineStock.ReadOnly = true;
            // 
            // MedicinePrice
            // 
            this.MedicinePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicinePrice.FillWeight = 0.15F;
            this.MedicinePrice.HeaderText = "单价";
            this.MedicinePrice.MinimumWidth = 6;
            this.MedicinePrice.Name = "MedicinePrice";
            this.MedicinePrice.ReadOnly = true;
            // 
            // uiButton_Confirm
            // 
            this.uiButton_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Confirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_Confirm.Location = new System.Drawing.Point(344, 344);
            this.uiButton_Confirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Confirm.Name = "uiButton_Confirm";
            this.uiButton_Confirm.Size = new System.Drawing.Size(100, 35);
            this.uiButton_Confirm.TabIndex = 1;
            this.uiButton_Confirm.Text = "确定";
            this.uiButton_Confirm.Click += new System.EventHandler(this.uiButton_Confirm_Click);
            // 
            // FormDocSubChooseMedicine
            // 
            this.AcceptButton = this.uiButton_Confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 425);
            this.Controls.Add(this.uiButton_Confirm);
            this.Controls.Add(this.uiDataGridView_Medicine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDocSubChooseMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择药品";
            this.Load += new System.EventHandler(this.ChooseMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_Medicine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView_Medicine;
        private Sunny.UI.UIButton uiButton_Confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineSpecifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicinePrice;
    }
}