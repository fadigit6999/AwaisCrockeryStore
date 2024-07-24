namespace PharApp.Inventory
{
    partial class frmRegisterType
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
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnRegisterAddOther = new Button();
            btnRegister = new Button();
            btnClose = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(39, 68);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 52);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Type Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(37, 15);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 3;
            label1.Text = "Register Type";
            // 
            // btnRegisterAddOther
            // 
            btnRegisterAddOther.Location = new Point(127, 93);
            btnRegisterAddOther.Margin = new Padding(3, 2, 3, 2);
            btnRegisterAddOther.Name = "btnRegisterAddOther";
            btnRegisterAddOther.Size = new Size(172, 22);
            btnRegisterAddOther.TabIndex = 3;
            btnRegisterAddOther.Text = "Register and Add Other";
            btnRegisterAddOther.UseVisualStyleBackColor = true;
            btnRegisterAddOther.Click += btnRegisterAddOther_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(39, 93);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(82, 22);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(39, 127);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(39, 93);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmRegisterType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 166);
            Controls.Add(btnRegisterAddOther);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegister);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegisterType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Type";
            Load += frmRegisterType_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Button btnRegisterAddOther;
        private Button btnRegister;
        private Button btnClose;
        private Button btnUpdate;
    }
}