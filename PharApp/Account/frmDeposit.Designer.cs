namespace PharApp.Account
{
    partial class frmDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeposit));
            btnDeposit = new Button();
            txtBankName = new TextBox();
            label2 = new Label();
            txtTotalAmount = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lblLastName = new Label();
            label1 = new Label();
            label11 = new Label();
            cmbAccountId = new ComboBox();
            cmbInvoiceno = new ComboBox();
            dateTimeDeposit = new DateTimePicker();
            label6 = new Label();
            cmbPaymentMethod = new ComboBox();
            txtCheckNo = new TextBox();
            label7 = new Label();
            txtPaidAmount = new TextBox();
            label8 = new Label();
            txtBalance = new TextBox();
            label9 = new Label();
            label12 = new Label();
            richtxtRemarks = new RichTextBox();
            label5 = new Label();
            cmbDepositType = new ComboBox();
            lblInvoicePaid = new Label();
            lblInvoiceNotPaid = new Label();
            SuspendLayout();
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(23, 592);
            btnDeposit.Margin = new Padding(3, 2, 3, 2);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(313, 33);
            btnDeposit.TabIndex = 22;
            btnDeposit.Text = "&Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(22, 312);
            txtBankName.Margin = new Padding(3, 2, 3, 2);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(314, 23);
            txtBankName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 295);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 10;
            label2.Text = "Bank Name";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Enabled = false;
            txtTotalAmount.Location = new Point(22, 188);
            txtTotalAmount.Margin = new Padding(3, 2, 3, 2);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(314, 23);
            txtTotalAmount.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 171);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 11;
            label4.Text = "Total Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 42);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 12;
            label3.Text = "Deposit Date";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(22, 127);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(64, 15);
            lblLastName.TabIndex = 13;
            lblLastName.Text = "&Invoice No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 83);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 14;
            label1.Text = "&Account ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(12, 9);
            label11.Name = "label11";
            label11.Size = new Size(150, 25);
            label11.TabIndex = 15;
            label11.Text = "Account Deposit";
            // 
            // cmbAccountId
            // 
            cmbAccountId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbAccountId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbAccountId.FormattingEnabled = true;
            cmbAccountId.Location = new Point(22, 100);
            cmbAccountId.Margin = new Padding(3, 2, 3, 2);
            cmbAccountId.Name = "cmbAccountId";
            cmbAccountId.Size = new Size(314, 23);
            cmbAccountId.TabIndex = 2;
            cmbAccountId.SelectedIndexChanged += cmbAccountId_SelectedIndexChanged;
            // 
            // cmbInvoiceno
            // 
            cmbInvoiceno.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbInvoiceno.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbInvoiceno.FormattingEnabled = true;
            cmbInvoiceno.Location = new Point(22, 144);
            cmbInvoiceno.Margin = new Padding(3, 2, 3, 2);
            cmbInvoiceno.Name = "cmbInvoiceno";
            cmbInvoiceno.Size = new Size(314, 23);
            cmbInvoiceno.TabIndex = 3;
            cmbInvoiceno.SelectedIndexChanged += cmbInvoiceno_SelectedIndexChanged;
            // 
            // dateTimeDeposit
            // 
            dateTimeDeposit.Format = DateTimePickerFormat.Short;
            dateTimeDeposit.Location = new Point(22, 59);
            dateTimeDeposit.Margin = new Padding(3, 2, 3, 2);
            dateTimeDeposit.Name = "dateTimeDeposit";
            dateTimeDeposit.Size = new Size(314, 23);
            dateTimeDeposit.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 254);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 31;
            label6.Text = "Payment Method";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPaymentMethod.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(21, 271);
            cmbPaymentMethod.Margin = new Padding(3, 2, 3, 2);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(315, 23);
            cmbPaymentMethod.TabIndex = 32;
            // 
            // txtCheckNo
            // 
            txtCheckNo.Location = new Point(22, 355);
            txtCheckNo.Margin = new Padding(3, 2, 3, 2);
            txtCheckNo.Name = "txtCheckNo";
            txtCheckNo.Size = new Size(315, 23);
            txtCheckNo.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 338);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 33;
            label7.Text = "Check No";
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Location = new Point(22, 400);
            txtPaidAmount.Margin = new Padding(3, 2, 3, 2);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.Size = new Size(312, 23);
            txtPaidAmount.TabIndex = 36;
            txtPaidAmount.KeyPress += txtPaidAmount_KeyPress;
            txtPaidAmount.KeyUp += txtPaidAmount_KeyUp;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 383);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 35;
            label8.Text = "Paid Amount";
            // 
            // txtBalance
            // 
            txtBalance.Enabled = false;
            txtBalance.Location = new Point(22, 446);
            txtBalance.Margin = new Padding(3, 2, 3, 2);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(312, 23);
            txtBalance.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 429);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 37;
            label9.Text = "&Balance (Rs.)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 474);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 41;
            label12.Text = "Remarks";
            // 
            // richtxtRemarks
            // 
            richtxtRemarks.Location = new Point(22, 492);
            richtxtRemarks.Name = "richtxtRemarks";
            richtxtRemarks.Size = new Size(312, 91);
            richtxtRemarks.TabIndex = 42;
            richtxtRemarks.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 213);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 31;
            label5.Text = "&Deposit Type";
            // 
            // cmbDepositType
            // 
            cmbDepositType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbDepositType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDepositType.FormattingEnabled = true;
            cmbDepositType.Location = new Point(21, 230);
            cmbDepositType.Margin = new Padding(3, 2, 3, 2);
            cmbDepositType.Name = "cmbDepositType";
            cmbDepositType.Size = new Size(315, 23);
            cmbDepositType.TabIndex = 32;
            // 
            // lblInvoicePaid
            // 
            lblInvoicePaid.AutoSize = true;
            lblInvoicePaid.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoicePaid.ForeColor = Color.FromArgb(0, 192, 0);
            lblInvoicePaid.Location = new Point(276, 9);
            lblInvoicePaid.Name = "lblInvoicePaid";
            lblInvoicePaid.Size = new Size(61, 25);
            lblInvoicePaid.TabIndex = 12;
            lblInvoicePaid.Text = "Paid";
            lblInvoicePaid.Visible = false;
            // 
            // lblInvoiceNotPaid
            // 
            lblInvoiceNotPaid.AutoSize = true;
            lblInvoiceNotPaid.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoiceNotPaid.ForeColor = Color.Red;
            lblInvoiceNotPaid.Location = new Point(226, 8);
            lblInvoiceNotPaid.Name = "lblInvoiceNotPaid";
            lblInvoiceNotPaid.Size = new Size(108, 25);
            lblInvoiceNotPaid.TabIndex = 12;
            lblInvoiceNotPaid.Text = "Not Paid";
            lblInvoiceNotPaid.Visible = false;
            // 
            // frmDeposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 634);
            Controls.Add(richtxtRemarks);
            Controls.Add(label12);
            Controls.Add(txtBalance);
            Controls.Add(label9);
            Controls.Add(txtPaidAmount);
            Controls.Add(label8);
            Controls.Add(txtCheckNo);
            Controls.Add(label7);
            Controls.Add(cmbDepositType);
            Controls.Add(label5);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(label6);
            Controls.Add(dateTimeDeposit);
            Controls.Add(cmbInvoiceno);
            Controls.Add(cmbAccountId);
            Controls.Add(btnDeposit);
            Controls.Add(txtBankName);
            Controls.Add(label2);
            Controls.Add(txtTotalAmount);
            Controls.Add(label4);
            Controls.Add(lblInvoiceNotPaid);
            Controls.Add(lblInvoicePaid);
            Controls.Add(label3);
            Controls.Add(lblLastName);
            Controls.Add(label1);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDeposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Deposit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeposit;
        private TextBox txtBankName;
        private Label label2;
        private TextBox txtTotalAmount;
        private Label label4;
        private Label label3;
        private Label lblLastName;
        private Label label1;
        private Label label11;
        public ComboBox cmbAccountId;
        public ComboBox cmbInvoiceno;
        private DateTimePicker dateTimeDeposit;
        private Label label6;
        public ComboBox cmbPaymentMethod;
        private TextBox txtCheckNo;
        private Label label7;
        private TextBox txtPaidAmount;
        private Label label8;
        private TextBox txtBalance;
        private Label label9;
        private Label label12;
        private RichTextBox richtxtRemarks;
        private Label label5;
        public ComboBox cmbDepositType;
        private Label lblInvoicePaid;
        private Label lblInvoiceNotPaid;
    }
}