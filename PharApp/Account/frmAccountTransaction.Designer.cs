namespace PharApp.Account
{
    partial class frmAccountTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountTransaction));
            richtxtRemarks = new RichTextBox();
            label4 = new Label();
            label2 = new Label();
            txtTransactionId = new TextBox();
            cmbType = new ComboBox();
            cmbParty = new ComboBox();
            btnTransactionRegister = new Button();
            lblLastName = new Label();
            label1 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // richtxtRemarks
            // 
            richtxtRemarks.Location = new Point(30, 215);
            richtxtRemarks.Name = "richtxtRemarks";
            richtxtRemarks.Size = new Size(310, 64);
            richtxtRemarks.TabIndex = 43;
            richtxtRemarks.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 197);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 48;
            label4.Text = "Remarks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 147);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 50;
            label2.Text = "Transaction Id";
            // 
            // txtTransactionId
            // 
            txtTransactionId.Location = new Point(30, 164);
            txtTransactionId.Margin = new Padding(3, 2, 3, 2);
            txtTransactionId.Name = "txtTransactionId";
            txtTransactionId.ReadOnly = true;
            txtTransactionId.Size = new Size(312, 23);
            txtTransactionId.TabIndex = 41;
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
            cmbType.TabIndex = 40;
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
            cmbParty.TabIndex = 39;
            // 
            // btnTransactionRegister
            // 
            btnTransactionRegister.Location = new Point(30, 284);
            btnTransactionRegister.Margin = new Padding(3, 2, 3, 2);
            btnTransactionRegister.Name = "btnTransactionRegister";
            btnTransactionRegister.Size = new Size(132, 24);
            btnTransactionRegister.TabIndex = 44;
            btnTransactionRegister.Text = "Register";
            btnTransactionRegister.UseVisualStyleBackColor = true;
            btnTransactionRegister.Click += btnTransactionRegister_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(30, 99);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(94, 15);
            lblLastName.TabIndex = 45;
            lblLastName.Text = "Transaction Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 47);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 46;
            label1.Text = "Account";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(20, 10);
            label11.Name = "label11";
            label11.Size = new Size(180, 25);
            label11.TabIndex = 47;
            label11.Text = "Register Transaction";
            // 
            // frmAccountTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 323);
            Controls.Add(richtxtRemarks);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtTransactionId);
            Controls.Add(cmbType);
            Controls.Add(cmbParty);
            Controls.Add(btnTransactionRegister);
            Controls.Add(lblLastName);
            Controls.Add(label1);
            Controls.Add(label11);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAccountTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaction Account";
            Load += frmAccountTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richtxtRemarks;
        private Label label4;
        private Label label2;
        private TextBox txtTransactionId;
        public ComboBox cmbType;
        public ComboBox cmbParty;
        private Button btnTransactionRegister;
        private Label lblLastName;
        private Label label1;
        private Label label11;
    }
}