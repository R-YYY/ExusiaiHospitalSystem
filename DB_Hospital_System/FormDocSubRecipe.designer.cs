
namespace HospitalManagementSystem
{
    partial class FormDocSubRecipe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocSubRecipe));
            this.uiDataGridView_Take = new Sunny.UI.UIDataGridView();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineSpecifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiButton_Save = new Sunny.UI.UIButton();
            this.uiTextBox_Name = new Sunny.UI.UITextBox();
            this.uiTextBox_Content = new Sunny.UI.UITextBox();
            this.uiLabel_C = new Sunny.UI.UILabel();
            this.uiLabel_R = new Sunny.UI.UILabel();
            this.button_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_Take)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDataGridView_Take
            // 
            this.uiDataGridView_Take.AllowUserToAddRows = false;
            this.uiDataGridView_Take.AllowUserToDeleteRows = false;
            this.uiDataGridView_Take.AllowUserToResizeColumns = false;
            this.uiDataGridView_Take.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView_Take.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.uiDataGridView_Take.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView_Take.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView_Take.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.uiDataGridView_Take.ColumnHeadersHeight = 32;
            this.uiDataGridView_Take.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView_Take.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineName,
            this.MedicineNum,
            this.MedicineSpecifications,
            this.MedicinePrice});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView_Take.DefaultCellStyle = dataGridViewCellStyle10;
            this.uiDataGridView_Take.EnableHeadersVisualStyles = false;
            this.uiDataGridView_Take.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridView_Take.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView_Take.Location = new System.Drawing.Point(53, 133);
            this.uiDataGridView_Take.Margin = new System.Windows.Forms.Padding(2);
            this.uiDataGridView_Take.MultiSelect = false;
            this.uiDataGridView_Take.Name = "uiDataGridView_Take";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView_Take.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.uiDataGridView_Take.RowHeadersVisible = false;
            this.uiDataGridView_Take.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.uiDataGridView_Take.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.uiDataGridView_Take.RowTemplate.Height = 29;
            this.uiDataGridView_Take.SelectedIndex = -1;
            this.uiDataGridView_Take.ShowGridLine = true;
            this.uiDataGridView_Take.Size = new System.Drawing.Size(804, 271);
            this.uiDataGridView_Take.TabIndex = 0;
            this.uiDataGridView_Take.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView_Take_CellContentClick);
            this.uiDataGridView_Take.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView_Take_CellEndEdit);
            this.uiDataGridView_Take.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // MedicineName
            // 
            this.MedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineName.FillWeight = 0.4F;
            this.MedicineName.HeaderText = "药品名称";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.ReadOnly = true;
            this.MedicineName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MedicineNum
            // 
            this.MedicineNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.MedicineNum.DefaultCellStyle = dataGridViewCellStyle9;
            this.MedicineNum.FillWeight = 0.2F;
            this.MedicineNum.HeaderText = "数量";
            this.MedicineNum.MinimumWidth = 6;
            this.MedicineNum.Name = "MedicineNum";
            this.MedicineNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MedicineSpecifications
            // 
            this.MedicineSpecifications.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineSpecifications.FillWeight = 0.2F;
            this.MedicineSpecifications.HeaderText = "规格";
            this.MedicineSpecifications.MinimumWidth = 6;
            this.MedicineSpecifications.Name = "MedicineSpecifications";
            this.MedicineSpecifications.ReadOnly = true;
            this.MedicineSpecifications.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MedicinePrice
            // 
            this.MedicinePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicinePrice.FillWeight = 0.2F;
            this.MedicinePrice.HeaderText = "单价";
            this.MedicinePrice.MinimumWidth = 6;
            this.MedicinePrice.Name = "MedicinePrice";
            this.MedicinePrice.ReadOnly = true;
            this.MedicinePrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // uiButton_Save
            // 
            this.uiButton_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Save.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton_Save.Location = new System.Drawing.Point(707, 497);
            this.uiButton_Save.Margin = new System.Windows.Forms.Padding(2);
            this.uiButton_Save.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Save.Name = "uiButton_Save";
            this.uiButton_Save.Size = new System.Drawing.Size(81, 40);
            this.uiButton_Save.TabIndex = 1;
            this.uiButton_Save.Text = "保存";
            this.uiButton_Save.Click += new System.EventHandler(this.uiButton_Save_Click);
            // 
            // uiTextBox_Name
            // 
            this.uiTextBox_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_Name.FillColor = System.Drawing.Color.White;
            this.uiTextBox_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox_Name.Location = new System.Drawing.Point(53, 33);
            this.uiTextBox_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_Name.Maximum = 2147483647D;
            this.uiTextBox_Name.Minimum = -2147483648D;
            this.uiTextBox_Name.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_Name.Name = "uiTextBox_Name";
            this.uiTextBox_Name.Padding = new System.Windows.Forms.Padding(3);
            this.uiTextBox_Name.Size = new System.Drawing.Size(224, 40);
            this.uiTextBox_Name.TabIndex = 7;
            this.uiTextBox_Name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox_Name.Watermark = "请输入药品名称";
            this.uiTextBox_Name.DoEnter += new System.EventHandler(this.button_Search_Click);
            this.uiTextBox_Name.Leave += new System.EventHandler(this.uiTextBox_Name_Leave);
            this.uiTextBox_Name.Enter += new System.EventHandler(this.uiTextBox_Name_Enter);
            // 
            // uiTextBox_Content
            // 
            this.uiTextBox_Content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_Content.FillColor = System.Drawing.Color.White;
            this.uiTextBox_Content.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox_Content.Location = new System.Drawing.Point(135, 434);
            this.uiTextBox_Content.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_Content.Maximum = 2147483647D;
            this.uiTextBox_Content.Minimum = -2147483648D;
            this.uiTextBox_Content.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_Content.Multiline = true;
            this.uiTextBox_Content.Name = "uiTextBox_Content";
            this.uiTextBox_Content.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox_Content.Size = new System.Drawing.Size(485, 150);
            this.uiTextBox_Content.TabIndex = 9;
            this.uiTextBox_Content.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // uiLabel_C
            // 
            this.uiLabel_C.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_C.Location = new System.Drawing.Point(48, 434);
            this.uiLabel_C.Name = "uiLabel_C";
            this.uiLabel_C.Size = new System.Drawing.Size(69, 28);
            this.uiLabel_C.TabIndex = 10;
            this.uiLabel_C.Text = "医嘱";
            this.uiLabel_C.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_R
            // 
            this.uiLabel_R.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel_R.Location = new System.Drawing.Point(48, 99);
            this.uiLabel_R.Name = "uiLabel_R";
            this.uiLabel_R.Size = new System.Drawing.Size(100, 23);
            this.uiLabel_R.TabIndex = 11;
            this.uiLabel_R.Text = "药品清单";
            this.uiLabel_R.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Search
            // 
            this.button_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Search.BackgroundImage")));
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Search.Location = new System.Drawing.Point(306, 33);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(44, 40);
            this.button_Search.TabIndex = 8;
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // FormDocSubRecipe
            // 
            this.AcceptButton = this.uiButton_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(905, 640);
            this.Controls.Add(this.uiLabel_R);
            this.Controls.Add(this.uiLabel_C);
            this.Controls.Add(this.uiTextBox_Content);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.uiTextBox_Name);
            this.Controls.Add(this.uiButton_Save);
            this.Controls.Add(this.uiDataGridView_Take);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormDocSubRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "处方";
            this.Load += new System.EventHandler(this.RecipeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_Take)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView_Take;
        private Sunny.UI.UIButton uiButton_Save;
        private System.Windows.Forms.Button button_Search;
        private Sunny.UI.UITextBox uiTextBox_Name;
        private Sunny.UI.UITextBox uiTextBox_Content;
        private Sunny.UI.UILabel uiLabel_C;
        private Sunny.UI.UILabel uiLabel_R;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineSpecifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicinePrice;
    }
}