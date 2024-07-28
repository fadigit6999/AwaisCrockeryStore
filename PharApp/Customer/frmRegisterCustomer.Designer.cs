namespace PharApp.Customer
{
    partial class frmRegisterCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterCustomer));
            btnRegistration = new Button();
            txtPhoneno = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtFristName = new TextBox();
            label1 = new Label();
            label11 = new Label();
            label3 = new Label();
            txtType = new TextBox();
            label5 = new Label();
            txtAddress = new RichTextBox();
            btnRegisterAdd = new Button();
            label6 = new Label();
            cmbCustomerCategory = new ComboBox();
            label7 = new Label();
            txtDSL = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // btnRegistration
            // 
            btnRegistration.Location = new Point(28, 412);
            btnRegistration.Margin = new Padding(3, 2, 3, 2);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(132, 22);
            btnRegistration.TabIndex = 26;
            btnRegistration.Text = "Register";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // txtPhoneno
            // 
            txtPhoneno.Location = new Point(29, 255);
            txtPhoneno.Margin = new Padding(3, 2, 3, 2);
            txtPhoneno.Name = "txtPhoneno";
            txtPhoneno.Size = new Size(319, 23);
            txtPhoneno.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 238);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 11;
            label2.Text = "Phone No";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(28, 207);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(316, 23);
            txtEmail.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 190);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 14;
            label4.Text = "Email";
            // 
            // txtFristName
            // 
            txtFristName.Location = new Point(28, 68);
            txtFristName.Margin = new Padding(3, 2, 3, 2);
            txtFristName.Name = "txtFristName";
            txtFristName.Size = new Size(316, 23);
            txtFristName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 15;
            label1.Text = "First Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(21, 22);
            label11.Name = "label11";
            label11.Size = new Size(198, 25);
            label11.TabIndex = 17;
            label11.Text = "Customer Registration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 281);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 11;
            label3.Text = "Type";
            // 
            // txtType
            // 
            txtType.Location = new Point(28, 298);
            txtType.Margin = new Padding(3, 2, 3, 2);
            txtType.Name = "txtType";
            txtType.Size = new Size(319, 23);
            txtType.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 326);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 27;
            label5.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(30, 344);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(318, 65);
            txtAddress.TabIndex = 28;
            txtAddress.Text = "";
            // 
            // btnRegisterAdd
            // 
            btnRegisterAdd.Location = new Point(165, 412);
            btnRegisterAdd.Margin = new Padding(3, 2, 3, 2);
            btnRegisterAdd.Name = "btnRegisterAdd";
            btnRegisterAdd.Size = new Size(178, 22);
            btnRegisterAdd.TabIndex = 26;
            btnRegisterAdd.Text = "Register And Add Other";
            btnRegisterAdd.UseVisualStyleBackColor = true;
            btnRegisterAdd.Click += btnRegisterAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 98);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 15;
            label6.Text = "Customer Category";
            // 
            // cmbCustomerCategory
            // 
            cmbCustomerCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCustomerCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCustomerCategory.FormattingEnabled = true;
            cmbCustomerCategory.Location = new Point(29, 115);
            cmbCustomerCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCustomerCategory.Name = "cmbCustomerCategory";
            cmbCustomerCategory.Size = new Size(316, 23);
            cmbCustomerCategory.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 143);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 14;
            label7.Text = "DSL";
            // 
            // txtDSL
            // 
            txtDSL.Location = new Point(27, 160);
            txtDSL.Margin = new Padding(3, 2, 3, 2);
            txtDSL.Name = "txtDSL";
            txtDSL.Size = new Size(316, 23);
            txtDSL.TabIndex = 22;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(29, 412);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 22);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmRegisterCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 445);
            Controls.Add(cmbCustomerCategory);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(btnRegisterAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegistration);
            Controls.Add(txtType);
            Controls.Add(label3);
            Controls.Add(txtPhoneno);
            Controls.Add(label2);
            Controls.Add(txtDSL);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtFristName);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegisterCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Registration";
            Load += frmRegisterCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label11;
        private Label label3;
       
        private Label label2;
        private Label label4;

        private Button btnRegistration;
        private TextBox txtPhoneno;
        private TextBox txtEmail;
        private TextBox txtFristName;
        private TextBox txtType;
        private Label label5;
        private RichTextBox txtAddress;
        private Button btnRegisterAdd;
        private Label label6;
        private ComboBox cmbCustomerCategory;
        private Label label7;
        private TextBox txtDSL;
        private Button btnUpdate;
    }
}