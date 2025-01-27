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
            txtDebit = new TextBox();
            label8 = new Label();
            label12 = new Label();
            richtxtRemarks = new RichTextBox();
            label5 = new Label();
            cmbDepositType = new ComboBox();
            label10 = new Label();
            txtCredit = new TextBox();
            SuspendLayout();
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(23, 532);
            btnDeposit.Margin = new Padding(3, 2, 3, 2);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(313, 33);
            btnDeposit.TabIndex = 10;
            btnDeposit.Text = "&Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(22, 281);
            txtBankName.Margin = new Padding(3, 2, 3, 2);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(314, 23);
            txtBankName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 264);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 10;
            label2.Text = "Bank Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 50);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 12;
            label3.Text = "Deposit Date";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(22, 135);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(38, 15);
            lblLastName.TabIndex = 13;
            lblLastName.Text = "&TRXID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 91);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 14;
            label1.Text = "&Account ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(12, 8);
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
            cmbAccountId.Location = new Point(22, 108);
            cmbAccountId.Margin = new Padding(3, 2, 3, 2);
            cmbAccountId.Name = "cmbAccountId";
            cmbAccountId.Size = new Size(314, 23);
            cmbAccountId.TabIndex = 1;
            cmbAccountId.SelectedIndexChanged += cmbAccountId_SelectedIndexChanged;
            // 
            // cmbInvoiceno
            // 
            cmbInvoiceno.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbInvoiceno.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbInvoiceno.FormattingEnabled = true;
            cmbInvoiceno.Location = new Point(22, 152);
            cmbInvoiceno.Margin = new Padding(3, 2, 3, 2);
            cmbInvoiceno.Name = "cmbInvoiceno";
            cmbInvoiceno.Size = new Size(314, 23);
            cmbInvoiceno.TabIndex = 2;
            cmbInvoiceno.SelectedIndexChanged += cmbInvoiceno_SelectedIndexChanged;
            // 
            // dateTimeDeposit
            // 
            dateTimeDeposit.Format = DateTimePickerFormat.Short;
            dateTimeDeposit.Location = new Point(22, 67);
            dateTimeDeposit.Margin = new Padding(3, 2, 3, 2);
            dateTimeDeposit.Name = "dateTimeDeposit";
            dateTimeDeposit.Size = new Size(314, 23);
            dateTimeDeposit.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 223);
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
            cmbPaymentMethod.Location = new Point(21, 240);
            cmbPaymentMethod.Margin = new Padding(3, 2, 3, 2);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(315, 23);
            cmbPaymentMethod.TabIndex = 4;
            // 
            // txtCheckNo
            // 
            txtCheckNo.Location = new Point(22, 324);
            txtCheckNo.Margin = new Padding(3, 2, 3, 2);
            txtCheckNo.Name = "txtCheckNo";
            txtCheckNo.Size = new Size(315, 23);
            txtCheckNo.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 307);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 33;
            label7.Text = "Check No";
            // 
            // txtDebit
            // 
            txtDebit.Location = new Point(23, 372);
            txtDebit.Margin = new Padding(3, 2, 3, 2);
            txtDebit.Name = "txtDebit";
            txtDebit.Size = new Size(312, 23);
            txtDebit.TabIndex = 7;
            txtDebit.KeyPress += txtDebit_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 353);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 35;
            label8.Text = "&Debit Amount";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 442);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 41;
            label12.Text = "Narration";
            // 
            // richtxtRemarks
            // 
            richtxtRemarks.Location = new Point(24, 460);
            richtxtRemarks.Name = "richtxtRemarks";
            richtxtRemarks.Size = new Size(312, 67);
            richtxtRemarks.TabIndex = 9;
            richtxtRemarks.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 182);
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
            cmbDepositType.Location = new Point(21, 199);
            cmbDepositType.Margin = new Padding(3, 2, 3, 2);
            cmbDepositType.Name = "cmbDepositType";
            cmbDepositType.Size = new Size(315, 23);
            cmbDepositType.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 396);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 35;
            label10.Text = "&Credit Amount";
            // 
            // txtCredit
            // 
            txtCredit.Location = new Point(23, 414);
            txtCredit.Margin = new Padding(3, 2, 3, 2);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(312, 23);
            txtCredit.TabIndex = 8;
            txtCredit.KeyPress += txtCredit_KeyPress;
            // 
            // frmDeposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 577);
            Controls.Add(richtxtRemarks);
            Controls.Add(label12);
            Controls.Add(txtCredit);
            Controls.Add(label10);
            Controls.Add(txtDebit);
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
        private TextBox txtDebit;
        private Label label8;
        private Label label12;
        private RichTextBox richtxtRemarks;
        private Label label5;
        public ComboBox cmbDepositType;
        private Label label10;
        private TextBox txtCredit;
    }
}