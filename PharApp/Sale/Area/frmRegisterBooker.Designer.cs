namespace PharApp.Sale.Area
{
    partial class frmRegisterBooker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterBooker));
            richTxtNotes = new RichTextBox();
            btnRegisterAddOther = new Button();
            btnClose = new Button();
            btnRegister = new Button();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            SuspendLayout();
            // 
            // richTxtNotes
            // 
            richTxtNotes.Location = new Point(28, 272);
            richTxtNotes.Name = "richTxtNotes";
            richTxtNotes.Size = new Size(326, 70);
            richTxtNotes.TabIndex = 4;
            richTxtNotes.Text = "";
            // 
            // btnRegisterAddOther
            // 
            btnRegisterAddOther.Location = new Point(141, 358);
            btnRegisterAddOther.Name = "btnRegisterAddOther";
            btnRegisterAddOther.Size = new Size(213, 29);
            btnRegisterAddOther.TabIndex = 6;
            btnRegisterAddOther.Text = "Register and Add Other";
            btnRegisterAddOther.UseVisualStyleBackColor = true;
            btnRegisterAddOther.Click += btnRegisterAddOther_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(33, 393);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(33, 358);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(34, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(326, 27);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 249);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 27;
            label3.Text = "Notes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 71);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 30;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 25;
            label1.Text = "Register Booker";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 126);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 30;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(34, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 27);
            txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 191);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 30;
            label5.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(34, 211);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(326, 27);
            txtPhone.TabIndex = 3;
            // 
            // frmRegisterBooker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 437);
            Controls.Add(richTxtNotes);
            Controls.Add(btnRegisterAddOther);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegisterBooker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Booker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTxtNotes;
        private Button btnRegisterAddOther;
        private Button btnClose;
        private Button btnRegister;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPhone;
    }
}