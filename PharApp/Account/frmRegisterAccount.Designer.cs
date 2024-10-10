namespace PharApp.Account
{
    partial class frmRegisterAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterAccount));
            button1 = new Button();
            lblLastName = new Label();
            label1 = new Label();
            label11 = new Label();
            cmbParty = new ComboBox();
            cmbType = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(20, 140);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(132, 24);
            button1.TabIndex = 26;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAccount_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(20, 90);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(31, 15);
            lblLastName.TabIndex = 12;
            lblLastName.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 46);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 15;
            label1.Text = "Account Party";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(12, 9);
            label11.Name = "label11";
            label11.Size = new Size(81, 25);
            label11.TabIndex = 17;
            label11.Text = "Account";
            // 
            // cmbParty
            // 
            cmbParty.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbParty.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbParty.FormattingEnabled = true;
            cmbParty.Location = new Point(22, 63);
            cmbParty.Margin = new Padding(3, 2, 3, 2);
            cmbParty.Name = "cmbParty";
            cmbParty.Size = new Size(314, 23);
            cmbParty.TabIndex = 27;
            // 
            // cmbType
            // 
            cmbType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(22, 109);
            cmbType.Margin = new Padding(3, 2, 3, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(314, 23);
            cmbType.TabIndex = 28;
            // 
            // frmRegisterAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 175);
            Controls.Add(cmbType);
            Controls.Add(cmbParty);
            Controls.Add(button1);
            Controls.Add(lblLastName);
            Controls.Add(label1);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegisterAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Account";
            Load += frmRegisterAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label lblLastName;
        private Label label1;
        private Label label11;
        private ComboBox cmbManufacturer;
        public ComboBox cmbParty;
        public ComboBox cmbType;
    }
}