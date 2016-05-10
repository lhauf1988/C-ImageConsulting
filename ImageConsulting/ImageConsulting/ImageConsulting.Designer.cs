namespace ImageConsulting
{
    partial class frmImageConsulting
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
            this.lblService = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTaxTip = new System.Windows.Forms.Label();
            this.lblSumTotal = new System.Windows.Forms.Label();
            this.lblTotalTaxTip = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnAddMakeover = new System.Windows.Forms.Button();
            this.txtMakeover = new System.Windows.Forms.TextBox();
            this.btnMinusMakeover = new System.Windows.Forms.Button();
            this.lblMakeover = new System.Windows.Forms.Label();
            this.btnMinusHairStyling = new System.Windows.Forms.Button();
            this.txtHairStyling = new System.Windows.Forms.TextBox();
            this.btnAddHairStyling = new System.Windows.Forms.Button();
            this.btnMinusManicure = new System.Windows.Forms.Button();
            this.txtManicure = new System.Windows.Forms.TextBox();
            this.btnAddManicure = new System.Windows.Forms.Button();
            this.btnMinusPerminantMakeup = new System.Windows.Forms.Button();
            this.txtPerminantMakeup = new System.Windows.Forms.TextBox();
            this.btnAddPerminantMakeup = new System.Windows.Forms.Button();
            this.lblHairStyling = new System.Windows.Forms.Label();
            this.lblManicure = new System.Windows.Forms.Label();
            this.lblPerminantMakeup = new System.Windows.Forms.Label();
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.rdb20 = new System.Windows.Forms.RadioButton();
            this.rdbNoDiscount = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(28, 21);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(48, 13);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Services";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Location = new System.Drawing.Point(24, 180);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(104, 29);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "Discount         (Please choose one)";
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(31, 345);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 23);
            this.btnSummary.TabIndex = 10;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(194, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(113, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTaxTip
            // 
            this.lblTaxTip.AutoSize = true;
            this.lblTaxTip.Location = new System.Drawing.Point(191, 388);
            this.lblTaxTip.Name = "lblTaxTip";
            this.lblTaxTip.Size = new System.Drawing.Size(28, 13);
            this.lblTaxTip.TabIndex = 13;
            this.lblTaxTip.Text = "0.00";
            // 
            // lblSumTotal
            // 
            this.lblSumTotal.AutoSize = true;
            this.lblSumTotal.Location = new System.Drawing.Point(98, 267);
            this.lblSumTotal.Name = "lblSumTotal";
            this.lblSumTotal.Size = new System.Drawing.Size(67, 13);
            this.lblSumTotal.TabIndex = 14;
            this.lblSumTotal.Text = "Sum Total: $";
            // 
            // lblTotalTaxTip
            // 
            this.lblTotalTaxTip.AutoSize = true;
            this.lblTotalTaxTip.Location = new System.Drawing.Point(85, 388);
            this.lblTotalTaxTip.Name = "lblTotalTaxTip";
            this.lblTotalTaxTip.Size = new System.Drawing.Size(109, 13);
            this.lblTotalTaxTip.TabIndex = 15;
            this.lblTotalTaxTip.Text = "Total With Tip/Tax: $";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(121, 300);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(67, 20);
            this.txtTip.TabIndex = 16;
            this.txtTip.Text = "0.00";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(85, 303);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(34, 13);
            this.lblTip.TabIndex = 17;
            this.lblTip.Text = "Tip  $";
            // 
            // btnAddMakeover
            // 
            this.btnAddMakeover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMakeover.Location = new System.Drawing.Point(72, 69);
            this.btnAddMakeover.Name = "btnAddMakeover";
            this.btnAddMakeover.Size = new System.Drawing.Size(24, 26);
            this.btnAddMakeover.TabIndex = 18;
            this.btnAddMakeover.Text = "+";
            this.btnAddMakeover.UseVisualStyleBackColor = true;
            this.btnAddMakeover.Click += new System.EventHandler(this.btnAddMakeover_Click);
            // 
            // txtMakeover
            // 
            this.txtMakeover.BackColor = System.Drawing.SystemColors.Control;
            this.txtMakeover.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMakeover.Location = new System.Drawing.Point(51, 76);
            this.txtMakeover.Name = "txtMakeover";
            this.txtMakeover.ReadOnly = true;
            this.txtMakeover.Size = new System.Drawing.Size(20, 13);
            this.txtMakeover.TabIndex = 19;
            this.txtMakeover.Text = "0";
            this.txtMakeover.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMinusMakeover
            // 
            this.btnMinusMakeover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusMakeover.Location = new System.Drawing.Point(27, 69);
            this.btnMinusMakeover.Name = "btnMinusMakeover";
            this.btnMinusMakeover.Size = new System.Drawing.Size(23, 26);
            this.btnMinusMakeover.TabIndex = 20;
            this.btnMinusMakeover.Text = "-";
            this.btnMinusMakeover.UseVisualStyleBackColor = true;
            this.btnMinusMakeover.Click += new System.EventHandler(this.btnMinusMakeover_Click);
            // 
            // lblMakeover
            // 
            this.lblMakeover.AutoSize = true;
            this.lblMakeover.Location = new System.Drawing.Point(28, 52);
            this.lblMakeover.Name = "lblMakeover";
            this.lblMakeover.Size = new System.Drawing.Size(88, 13);
            this.lblMakeover.TabIndex = 21;
            this.lblMakeover.Text = "Makeover ($125)";
            // 
            // btnMinusHairStyling
            // 
            this.btnMinusHairStyling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusHairStyling.Location = new System.Drawing.Point(27, 128);
            this.btnMinusHairStyling.Name = "btnMinusHairStyling";
            this.btnMinusHairStyling.Size = new System.Drawing.Size(23, 26);
            this.btnMinusHairStyling.TabIndex = 24;
            this.btnMinusHairStyling.Text = "-";
            this.btnMinusHairStyling.UseVisualStyleBackColor = true;
            this.btnMinusHairStyling.Click += new System.EventHandler(this.btnMinusHairStyling_Click);
            // 
            // txtHairStyling
            // 
            this.txtHairStyling.BackColor = System.Drawing.SystemColors.Control;
            this.txtHairStyling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHairStyling.Location = new System.Drawing.Point(51, 134);
            this.txtHairStyling.Name = "txtHairStyling";
            this.txtHairStyling.ReadOnly = true;
            this.txtHairStyling.Size = new System.Drawing.Size(20, 13);
            this.txtHairStyling.TabIndex = 23;
            this.txtHairStyling.Text = "0";
            this.txtHairStyling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddHairStyling
            // 
            this.btnAddHairStyling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHairStyling.Location = new System.Drawing.Point(72, 128);
            this.btnAddHairStyling.Name = "btnAddHairStyling";
            this.btnAddHairStyling.Size = new System.Drawing.Size(24, 26);
            this.btnAddHairStyling.TabIndex = 22;
            this.btnAddHairStyling.Text = "+";
            this.btnAddHairStyling.UseVisualStyleBackColor = true;
            this.btnAddHairStyling.Click += new System.EventHandler(this.btnAddHairStyling_Click);
            // 
            // btnMinusManicure
            // 
            this.btnMinusManicure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusManicure.Location = new System.Drawing.Point(147, 69);
            this.btnMinusManicure.Name = "btnMinusManicure";
            this.btnMinusManicure.Size = new System.Drawing.Size(23, 26);
            this.btnMinusManicure.TabIndex = 27;
            this.btnMinusManicure.Text = "-";
            this.btnMinusManicure.UseVisualStyleBackColor = true;
            this.btnMinusManicure.Click += new System.EventHandler(this.btnMinusManicure_Click);
            // 
            // txtManicure
            // 
            this.txtManicure.BackColor = System.Drawing.SystemColors.Control;
            this.txtManicure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtManicure.Location = new System.Drawing.Point(172, 74);
            this.txtManicure.Name = "txtManicure";
            this.txtManicure.ReadOnly = true;
            this.txtManicure.Size = new System.Drawing.Size(20, 13);
            this.txtManicure.TabIndex = 26;
            this.txtManicure.Text = "0";
            this.txtManicure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddManicure
            // 
            this.btnAddManicure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddManicure.Location = new System.Drawing.Point(194, 67);
            this.btnAddManicure.Name = "btnAddManicure";
            this.btnAddManicure.Size = new System.Drawing.Size(25, 26);
            this.btnAddManicure.TabIndex = 25;
            this.btnAddManicure.Text = "+";
            this.btnAddManicure.UseVisualStyleBackColor = true;
            this.btnAddManicure.Click += new System.EventHandler(this.btnAddManicure_Click);
            // 
            // btnMinusPerminantMakeup
            // 
            this.btnMinusPerminantMakeup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusPerminantMakeup.Location = new System.Drawing.Point(147, 129);
            this.btnMinusPerminantMakeup.Name = "btnMinusPerminantMakeup";
            this.btnMinusPerminantMakeup.Size = new System.Drawing.Size(23, 26);
            this.btnMinusPerminantMakeup.TabIndex = 30;
            this.btnMinusPerminantMakeup.Text = "-";
            this.btnMinusPerminantMakeup.UseVisualStyleBackColor = true;
            this.btnMinusPerminantMakeup.Click += new System.EventHandler(this.btnMinusPerminantMakeup_Click);
            // 
            // txtPerminantMakeup
            // 
            this.txtPerminantMakeup.BackColor = System.Drawing.SystemColors.Control;
            this.txtPerminantMakeup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPerminantMakeup.Location = new System.Drawing.Point(172, 135);
            this.txtPerminantMakeup.Name = "txtPerminantMakeup";
            this.txtPerminantMakeup.ReadOnly = true;
            this.txtPerminantMakeup.Size = new System.Drawing.Size(20, 13);
            this.txtPerminantMakeup.TabIndex = 29;
            this.txtPerminantMakeup.Text = "0";
            this.txtPerminantMakeup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddPerminantMakeup
            // 
            this.btnAddPerminantMakeup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerminantMakeup.Location = new System.Drawing.Point(194, 129);
            this.btnAddPerminantMakeup.Name = "btnAddPerminantMakeup";
            this.btnAddPerminantMakeup.Size = new System.Drawing.Size(25, 26);
            this.btnAddPerminantMakeup.TabIndex = 28;
            this.btnAddPerminantMakeup.Text = "+";
            this.btnAddPerminantMakeup.UseVisualStyleBackColor = true;
            this.btnAddPerminantMakeup.Click += new System.EventHandler(this.btnAddPerminantMakeup_Click);
            // 
            // lblHairStyling
            // 
            this.lblHairStyling.AutoSize = true;
            this.lblHairStyling.Location = new System.Drawing.Point(28, 113);
            this.lblHairStyling.Name = "lblHairStyling";
            this.lblHairStyling.Size = new System.Drawing.Size(87, 13);
            this.lblHairStyling.TabIndex = 31;
            this.lblHairStyling.Text = "Hair Styling ($60)";
            // 
            // lblManicure
            // 
            this.lblManicure.AutoSize = true;
            this.lblManicure.Location = new System.Drawing.Point(144, 52);
            this.lblManicure.Name = "lblManicure";
            this.lblManicure.Size = new System.Drawing.Size(78, 13);
            this.lblManicure.TabIndex = 32;
            this.lblManicure.Text = "Manicure ($35)";
            // 
            // lblPerminantMakeup
            // 
            this.lblPerminantMakeup.AutoSize = true;
            this.lblPerminantMakeup.Location = new System.Drawing.Point(144, 113);
            this.lblPerminantMakeup.Name = "lblPerminantMakeup";
            this.lblPerminantMakeup.Size = new System.Drawing.Size(129, 13);
            this.lblPerminantMakeup.TabIndex = 33;
            this.lblPerminantMakeup.Text = "Perminant Makeup ($200)";
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Location = new System.Drawing.Point(31, 225);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(45, 17);
            this.rdb10.TabIndex = 34;
            this.rdb10.TabStop = true;
            this.rdb10.Text = "10%";
            this.rdb10.UseVisualStyleBackColor = true;
            this.rdb10.CheckedChanged += new System.EventHandler(this.rdb10_CheckedChanged);
            // 
            // rdb20
            // 
            this.rdb20.AutoSize = true;
            this.rdb20.Location = new System.Drawing.Point(121, 225);
            this.rdb20.Name = "rdb20";
            this.rdb20.Size = new System.Drawing.Size(45, 17);
            this.rdb20.TabIndex = 35;
            this.rdb20.TabStop = true;
            this.rdb20.Text = "20%";
            this.rdb20.UseVisualStyleBackColor = true;
            this.rdb20.CheckedChanged += new System.EventHandler(this.rdb20_CheckedChanged);
            // 
            // rdbNoDiscount
            // 
            this.rdbNoDiscount.AutoSize = true;
            this.rdbNoDiscount.Location = new System.Drawing.Point(207, 225);
            this.rdbNoDiscount.Name = "rdbNoDiscount";
            this.rdbNoDiscount.Size = new System.Drawing.Size(84, 17);
            this.rdbNoDiscount.TabIndex = 36;
            this.rdbNoDiscount.TabStop = true;
            this.rdbNoDiscount.Text = "No Discount";
            this.rdbNoDiscount.UseVisualStyleBackColor = true;
            this.rdbNoDiscount.CheckedChanged += new System.EventHandler(this.rdbNoDiscount_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(162, 267);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(28, 13);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "0.00";
            // 
            // frmImageConsulting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(305, 426);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.rdbNoDiscount);
            this.Controls.Add(this.rdb20);
            this.Controls.Add(this.rdb10);
            this.Controls.Add(this.lblPerminantMakeup);
            this.Controls.Add(this.lblManicure);
            this.Controls.Add(this.lblHairStyling);
            this.Controls.Add(this.btnMinusPerminantMakeup);
            this.Controls.Add(this.txtPerminantMakeup);
            this.Controls.Add(this.btnAddPerminantMakeup);
            this.Controls.Add(this.btnMinusManicure);
            this.Controls.Add(this.txtManicure);
            this.Controls.Add(this.btnAddManicure);
            this.Controls.Add(this.btnMinusHairStyling);
            this.Controls.Add(this.txtHairStyling);
            this.Controls.Add(this.btnAddHairStyling);
            this.Controls.Add(this.lblMakeover);
            this.Controls.Add(this.btnMinusMakeover);
            this.Controls.Add(this.txtMakeover);
            this.Controls.Add(this.btnAddMakeover);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblTotalTaxTip);
            this.Controls.Add(this.lblSumTotal);
            this.Controls.Add(this.lblTaxTip);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblService);
            this.Name = "frmImageConsulting";
            this.Text = "Image Consulting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTaxTip;
        private System.Windows.Forms.Label lblSumTotal;
        private System.Windows.Forms.Label lblTotalTaxTip;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Button btnAddMakeover;
        private System.Windows.Forms.TextBox txtMakeover;
        private System.Windows.Forms.Button btnMinusMakeover;
        private System.Windows.Forms.Label lblMakeover;
        private System.Windows.Forms.Button btnMinusHairStyling;
        private System.Windows.Forms.TextBox txtHairStyling;
        private System.Windows.Forms.Button btnAddHairStyling;
        private System.Windows.Forms.Button btnMinusManicure;
        private System.Windows.Forms.TextBox txtManicure;
        private System.Windows.Forms.Button btnAddManicure;
        private System.Windows.Forms.Button btnMinusPerminantMakeup;
        private System.Windows.Forms.TextBox txtPerminantMakeup;
        private System.Windows.Forms.Button btnAddPerminantMakeup;
        private System.Windows.Forms.Label lblHairStyling;
        private System.Windows.Forms.Label lblManicure;
        private System.Windows.Forms.Label lblPerminantMakeup;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.RadioButton rdb20;
        private System.Windows.Forms.RadioButton rdbNoDiscount;
        private System.Windows.Forms.Label lblTotal;
    }
}

