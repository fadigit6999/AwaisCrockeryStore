namespace PharApp.Account
{
    partial class frmRegisterAdjustmentAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterAdjustmentAccount));
            cmbType = new ComboBox();
            cmbParty = new ComboBox();
            btnRegister = new Button();
            lblLastName = new Label();
            label1 = new Label();
            label11 = new Label();
            txtTransactionId = new TextBox();
            label2 = new Label();
            txtTotalAmount = new TextBox();
            label3 = new Label();
            label4 = new Label();
            richtxtRemarks = new RichTextBox();
            SuspendLayout();
            // 
            // cmbType
            // 
            cmbType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(30, 116);
            cmbType.Margin = new Padding(3, 2, 3, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(314, 23);
            cmbType.TabIndex = 1;
            // 
            // cmbParty
            // 
            cmbParty.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbParty.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbParty.FormattingEnabled = true;
            cmbParty.Location = new Point(30, 64);
            cmbParty.Margin = new Padding(3, 2, 3, 2);
            cmbParty.Name = "cmbParty";
            cmbParty.Size = new Size(314, 23);
            cmbParty.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(30, 328);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(132, 24);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(30, 99);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(94, 15);
            lblLastName.TabIndex = 29;
            lblLastName.Text = "Transaction Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 47);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 30;
            label1.Text = "Account";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(20, 10);
            label11.Name = "label11";
            label11.Size = new Size(182, 25);
            label11.TabIndex = 31;
            label11.Text = "Adjustment Account";
            // 
            // txtTransactionId
            // 
            txtTransactionId.Location = new Point(30, 164);
            txtTransactionId.Margin = new Padding(3, 2, 3, 2);
            txtTransactionId.Name = "txtTransactionId";
            txtTransactionId.ReadOnly = true;
            txtTransactionId.Size = new Size(312, 23);
            txtTransactionId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 147);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 38;
            label2.Text = "Transaction Id";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(30, 210);
            txtTotalAmount.Margin = new Padding(3, 2, 3, 2);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(312, 23);
            txtTotalAmount.TabIndex = 3;
            txtTotalAmount.KeyPress += txtTotalAmount_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 193);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 38;
            label3.Text = "Total Deposit Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 239);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 38;
            label4.Text = "Remarks";
            // 
            // richtxtRemarks
            // 
            richtxtRemarks.Location = new Point(30, 257);
            richtxtRemarks.Name = "richtxtRemarks";
            richtxtRemarks.Size = new Size(310, 64);
            richtxtRemarks.TabIndex = 4;
            richtxtRemarks.Text = "";
            // 
            // frmRegisterAdjustmentAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 362);
            Controls.Add(richtxtRemarks);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTotalAmount);
            Controls.Add(txtTransactionId);
            Controls.Add(cmbType);
            Controls.Add(cmbParty);
            Controls.Add(btnRegister);
            Controls.Add(lblLastName);
            Controls.Add(label1);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegisterAdjustmentAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adjustment Account";
            Load += frmRegisterAdjustmentAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox cmbType;
        public ComboBox cmbParty;
        private Button btnRegister;
        private Label lblLastName;
        private Label label1;
        private Label label11;
        private TextBox txtTransactionId;
        private Label label2;
        private TextBox txtTotalAmount;
        private Label label3;
        private Label label4;
        private RichTextBox richtxtRemarks;
    }
}