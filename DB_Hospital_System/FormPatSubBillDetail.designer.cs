namespace HospitalManagementSystem
{
    partial class FormPatSubBillDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatSubBillDetail));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuDGV_medicine_bill = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuButton_close = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDGV_medicine_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDGV_medicine_bill
            // 
            this.bunifuDGV_medicine_bill.AllowCustomTheming = false;
            this.bunifuDGV_medicine_bill.AllowUserToAddRows = false;
            this.bunifuDGV_medicine_bill.AllowUserToDeleteRows = false;
            this.bunifuDGV_medicine_bill.AllowUserToResizeColumns = false;
            this.bunifuDGV_medicine_bill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDGV_medicine_bill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDGV_medicine_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDGV_medicine_bill.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.bunifuDGV_medicine_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDGV_medicine_bill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDGV_medicine_bill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDGV_medicine_bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDGV_medicine_bill.ColumnHeadersHeight = 40;
            this.bunifuDGV_medicine_bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicine,
            this.amount,
            this.price});
            this.bunifuDGV_medicine_bill.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.bunifuDGV_medicine_bill.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDGV_medicine_bill.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDGV_medicine_bill.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.bunifuDGV_medicine_bill.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDGV_medicine_bill.CurrentTheme.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDGV_medicine_bill.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.bunifuDGV_medicine_bill.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDGV_medicine_bill.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDGV_medicine_bill.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDGV_medicine_bill.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDGV_medicine_bill.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDGV_medicine_bill.CurrentTheme.Name = null;
            this.bunifuDGV_medicine_bill.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDGV_medicine_bill.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDGV_medicine_bill.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDGV_medicine_bill.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.bunifuDGV_medicine_bill.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDGV_medicine_bill.DefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuDGV_medicine_bill.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuDGV_medicine_bill.EnableHeadersVisualStyles = false;
            this.bunifuDGV_medicine_bill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.bunifuDGV_medicine_bill.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDGV_medicine_bill.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDGV_medicine_bill.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDGV_medicine_bill.Location = new System.Drawing.Point(0, 0);
            this.bunifuDGV_medicine_bill.Name = "bunifuDGV_medicine_bill";
            this.bunifuDGV_medicine_bill.RowHeadersVisible = false;
            this.bunifuDGV_medicine_bill.RowHeadersWidth = 51;
            this.bunifuDGV_medicine_bill.RowTemplate.Height = 40;
            this.bunifuDGV_medicine_bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDGV_medicine_bill.Size = new System.Drawing.Size(400, 370);
            this.bunifuDGV_medicine_bill.TabIndex = 0;
            this.bunifuDGV_medicine_bill.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DodgerBlue;
            this.bunifuDGV_medicine_bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            // 
            // medicine
            // 
            this.medicine.HeaderText = "药品";
            this.medicine.MinimumWidth = 6;
            this.medicine.Name = "medicine";
            this.medicine.ReadOnly = true;
            // 
            // amount
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.amount.DefaultCellStyle = dataGridViewCellStyle3;
            this.amount.HeaderText = "数量";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // price
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.price.DefaultCellStyle = dataGridViewCellStyle4;
            this.price.HeaderText = "单价";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // bunifuButton_close
            // 
            this.bunifuButton_close.AllowAnimations = true;
            this.bunifuButton_close.AllowMouseEffects = true;
            this.bunifuButton_close.AllowToggling = false;
            this.bunifuButton_close.AnimationSpeed = 200;
            this.bunifuButton_close.AutoGenerateColors = false;
            this.bunifuButton_close.AutoRoundBorders = false;
            this.bunifuButton_close.AutoSizeLeftIcon = true;
            this.bunifuButton_close.AutoSizeRightIcon = true;
            this.bunifuButton_close.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton_close.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton_close.BackgroundImage")));
            this.bunifuButton_close.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton_close.ButtonText = "关闭";
            this.bunifuButton_close.ButtonTextMarginLeft = 0;
            this.bunifuButton_close.ColorContrastOnClick = 45;
            this.bunifuButton_close.ColorContrastOnHover = 45;
            this.bunifuButton_close.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton_close.CustomizableEdges = borderEdges1;
            this.bunifuButton_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bunifuButton_close.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton_close.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton_close.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton_close.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuButton_close.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton_close.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton_close.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton_close.IconMarginLeft = 11;
            this.bunifuButton_close.IconPadding = 10;
            this.bunifuButton_close.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton_close.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton_close.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton_close.IconSize = 25;
            this.bunifuButton_close.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton_close.IdleBorderRadius = 20;
            this.bunifuButton_close.IdleBorderThickness = 1;
            this.bunifuButton_close.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton_close.IdleIconLeftImage = null;
            this.bunifuButton_close.IdleIconRightImage = null;
            this.bunifuButton_close.IndicateFocus = false;
            this.bunifuButton_close.Location = new System.Drawing.Point(154, 415);
            this.bunifuButton_close.Name = "bunifuButton_close";
            this.bunifuButton_close.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton_close.OnDisabledState.BorderRadius = 20;
            this.bunifuButton_close.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton_close.OnDisabledState.BorderThickness = 1;
            this.bunifuButton_close.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton_close.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton_close.OnDisabledState.IconLeftImage = null;
            this.bunifuButton_close.OnDisabledState.IconRightImage = null;
            this.bunifuButton_close.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton_close.onHoverState.BorderRadius = 20;
            this.bunifuButton_close.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton_close.onHoverState.BorderThickness = 1;
            this.bunifuButton_close.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton_close.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton_close.onHoverState.IconLeftImage = null;
            this.bunifuButton_close.onHoverState.IconRightImage = null;
            this.bunifuButton_close.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton_close.OnIdleState.BorderRadius = 20;
            this.bunifuButton_close.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton_close.OnIdleState.BorderThickness = 1;
            this.bunifuButton_close.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton_close.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuButton_close.OnIdleState.IconLeftImage = null;
            this.bunifuButton_close.OnIdleState.IconRightImage = null;
            this.bunifuButton_close.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton_close.OnPressedState.BorderRadius = 20;
            this.bunifuButton_close.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton_close.OnPressedState.BorderThickness = 1;
            this.bunifuButton_close.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton_close.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton_close.OnPressedState.IconLeftImage = null;
            this.bunifuButton_close.OnPressedState.IconRightImage = null;
            this.bunifuButton_close.Size = new System.Drawing.Size(84, 39);
            this.bunifuButton_close.TabIndex = 3;
            this.bunifuButton_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton_close.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton_close.TextMarginLeft = 0;
            this.bunifuButton_close.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton_close.UseDefaultRadiusAndThickness = true;
            this.bunifuButton_close.Click += new System.EventHandler(this.bunifuButton_close_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(236, 369);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(164, 43);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "总价：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPatSubBillDetail
            // 
            this.AcceptButton = this.bunifuButton_close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.bunifuButton_close;
            this.ClientSize = new System.Drawing.Size(400, 485);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.bunifuButton_close);
            this.Controls.Add(this.bunifuDGV_medicine_bill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPatSubBillDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账单详情";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDGV_medicine_bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDGV_medicine_bill;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton_close;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}