namespace PharApp.Account
{
    partial class frmRegisterAdjustmentDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterAdjustmentDeposit));
            richtxtRemarks = new RichTextBox();
            label12 = new Label();
            txtBalance = new TextBox();
            label9 = new Label();
            txtPaidAmount = new TextBox();
            label8 = new Label();
            txtCheckNo = new TextBox();
            label7 = new Label();
            label5 = new Label();
            cmbPaymentMethod = new ComboBox();
            label6 = new Label();
            dateTimeDeposit = new DateTimePicker();
            cmbTransactionId = new ComboBox();
            cmbAccountId = new ComboBox();
            btnDeposit = new Button();
            txtBankName = new TextBox();
            label2 = new Label();
            txtTotalAmount = new TextBox();
            label4 = new Label();
            lblInvoiceNotPaid = new Label();
            lblInvoicePaid = new Label();
            label3 = new Label();
            lblLastName = new Label();
            label1 = new Label();
            label11 = new Label();
            txtTransactionType = new TextBox();
            SuspendLayout();
            // 
            // richtxtRemarks
            // 
            richtxtRemarks.Location = new Point(26, 493);
            richtxtRemarks.Name = "richtxtRemarks";
            richtxtRemarks.Size = new Size(312, 91);
            richtxtRemarks.TabIndex = 68;
            richtxtRemarks.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 475);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 67;
            label12.Text = "Remarks";
            // 
            // txtBalance
            // 
            txtBalance.Enabled = false;
            txtBalance.Location = new Point(26, 447);
            txtBalance.Margin = new Padding(3, 2, 3, 2);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(312, 23);
            txtBalance.TabIndex = 66;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 430);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 65;
            label9.Text = "&Balance (Rs.)";
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Location = new Point(26, 401);
            txtPaidAmount.Margin = new Padding(3, 2, 3, 2);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.Size = new Size(312, 23);
            txtPaidAmount.TabIndex = 64;
            txtPaidAmount.KeyPress += txtPaidAmount_KeyPress;
            txtPaidAmount.KeyUp += txtPaidAmount_KeyUp;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 384);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 63;
            label8.Text = "Paid Amount";
            // 
            // txtCheckNo
            // 
            txtCheckNo.Location = new Point(26, 356);
            txtCheckNo.Margin = new Padding(3, 2, 3, 2);
            txtCheckNo.Name = "txtCheckNo";
            txtCheckNo.Size = new Size(315, 23);
            txtCheckNo.TabIndex = 62;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 339);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 61;
            label7.Text = "Check No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 214);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 57;
            label5.Text = "&Deposit Type";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPaymentMethod.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(25, 272);
            cmbPaymentMethod.Margin = new Padding(3, 2, 3, 2);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(315, 23);
            cmbPaymentMethod.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 255);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 58;
            label6.Text = "Payment Method";
            // 
            // dateTimeDeposit
            // 
            dateTimeDeposit.Format = DateTimePickerFormat.Short;
            dateTimeDeposit.Location = new Point(26, 60);
            dateTimeDeposit.Margin = new Padding(3, 2, 3, 2);
            dateTimeDeposit.Name = "dateTimeDeposit";
            dateTimeDeposit.Size = new Size(314, 23);
            dateTimeDeposit.TabIndex = 43;
            // 
            // cmbTransactionId
            // 
            cmbTransactionId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTransactionId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbTransactionId.FormattingEnabled = true;
            cmbTransactionId.Location = new Point(26, 145);
            cmbTransactionId.Margin = new Padding(3, 2, 3, 2);
            cmbTransactionId.Name = "cmbTransactionId";
            cmbTransactionId.Size = new Size(314, 23);
            cmbTransactionId.TabIndex = 45;
            cmbTransactionId.SelectedIndexChanged += cmbInvoiceno_SelectedIndexChanged;
            // 
            // cmbAccountId
            // 
            cmbAccountId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbAccountId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbAccountId.FormattingEnabled = true;
            cmbAccountId.Location = new Point(26, 101);
            cmbAccountId.Margin = new Padding(3, 2, 3, 2);
            cmbAccountId.Name = "cmbAccountId";
            cmbAccountId.Size = new Size(314, 23);
            cmbAccountId.TabIndex = 44;
            cmbAccountId.SelectedIndexChanged += cmbAccountId_SelectedIndexChanged;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(27, 593);
            btnDeposit.Margin = new Padding(3, 2, 3, 2);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(313, 33);
            btnDeposit.TabIndex = 56;
            btnDeposit.Text = "&Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(26, 313);
            txtBankName.Margin = new Padding(3, 2, 3, 2);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(314, 23);
            txtBankName.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 296);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 48;
            label2.Text = "Bank Name";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Enabled = false;
            txtTotalAmount.Location = new Point(26, 189);
            txtTotalAmount.Margin = new Padding(3, 2, 3, 2);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(314, 23);
            txtTotalAmount.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 172);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 49;
            label4.Text = "Total Amount";
            // 
            // lblInvoiceNotPaid
            // 
            lblInvoiceNotPaid.AutoSize = true;
            lblInvoiceNotPaid.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoiceNotPaid.ForeColor = Color.Red;
            lblInvoiceNotPaid.Location = new Point(230, 9);
            lblInvoiceNotPaid.Name = "lblInvoiceNotPaid";
            lblInvoiceNotPaid.Size = new Size(108, 25);
            lblInvoiceNotPaid.TabIndex = 52;
            lblInvoiceNotPaid.Text = "Not Paid";
            lblInvoiceNotPaid.Visible = false;
            // 
            // lblInvoicePaid
            // 
            lblInvoicePaid.AutoSize = true;
            lblInvoicePaid.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoicePaid.ForeColor = Color.FromArgb(0, 192, 0);
            lblInvoicePaid.Location = new Point(280, 10);
            lblInvoicePaid.Name = "lblInvoicePaid";
            lblInvoicePaid.Size = new Size(61, 25);
            lblInvoicePaid.TabIndex = 51;
            lblInvoicePaid.Text = "Paid";
            lblInvoicePaid.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 43);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 50;
            label3.Text = "Deposit Date";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(26, 128);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(80, 15);
            lblLastName.TabIndex = 53;
            lblLastName.Text = "&Transaction Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 84);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 54;
            label1.Text = "&Account ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(16, 10);
            label11.Name = "label11";
            label11.Size = new Size(177, 25);
            label11.TabIndex = 55;
            label11.Text = "Adjustment Deposit";
            // 
            // txtTransactionType
            // 
            txtTransactionType.Enabled = false;
            txtTransactionType.Location = new Point(26, 231);
            txtTransactionType.Margin = new Padding(3, 2, 3, 2);
            txtTransactionType.Name = "txtTransactionType";
            txtTransactionType.ReadOnly = true;
            txtTransactionType.Size = new Size(314, 23);
            txtTransactionType.TabIndex = 69;
            // 
            // frmRegisterAdjustmentDeposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 634);
            Controls.Add(txtTransactionType);
            Controls.Add(richtxtRemarks);
            Controls.Add(label12);
            Controls.Add(txtBalance);
            Controls.Add(label9);
            Controls.Add(txtPaidAmount);
            Controls.Add(label8);
            Controls.Add(txtCheckNo);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(label6);
            Controls.Add(dateTimeDeposit);
            Controls.Add(cmbTransactionId);
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
            Name = "frmRegisterAdjustmentDeposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adjustment Deposits";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richtxtRemarks;
        private Label label12;
        private TextBox txtBalance;
        private Label label9;
        private TextBox txtPaidAmount;
        private Label label8;
        private TextBox txtCheckNo;
        private Label label7;
        private Label label5;
        public ComboBox cmbPaymentMethod;
        private Label label6;
        private DateTimePicker dateTimeDeposit;
        public ComboBox cmbTransactionId;
        public ComboBox cmbAccountId;
        private Button btnDeposit;
        private TextBox txtBankName;
        private Label label2;
        private TextBox txtTotalAmount;
        private Label label4;
        private Label lblInvoiceNotPaid;
        private Label lblInvoicePaid;
        private Label label3;
        private Label lblLastName;
        private Label label1;
        private Label label11;
        private TextBox txtTransactionType;
    }
}