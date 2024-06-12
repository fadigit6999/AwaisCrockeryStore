namespace PharApp.Users
{
    partial class frmRegisterRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterRole));
            label11 = new Label();
            btnRegisterRole = new Button();
            label1 = new Label();
            txtUserRole = new TextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(35, 28);
            label11.Name = "label11";
            label11.Size = new Size(114, 32);
            label11.TabIndex = 0;
            label11.Text = "User Role";
            // 
            // btnRegisterRole
            // 
            btnRegisterRole.Location = new Point(35, 135);
            btnRegisterRole.Name = "btnRegisterRole";
            btnRegisterRole.Size = new Size(151, 29);
            btnRegisterRole.TabIndex = 2;
            btnRegisterRole.Text = "Register";
            btnRegisterRole.UseVisualStyleBackColor = true;
            btnRegisterRole.Click += btnRegisterRole_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 79);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Role Name";
            // 
            // txtUserRole
            // 
            txtUserRole.Location = new Point(35, 102);
            txtUserRole.Name = "txtUserRole";
            txtUserRole.Size = new Size(361, 27);
            txtUserRole.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(384, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmRegisterRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 211);
            Controls.Add(txtUserRole);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(btnClose);
            Controls.Add(btnRegisterRole);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegisterRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Role";
            Load += frmRegisterRole_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label11;
        private Button btnRegisterRole;
        private Label label1;
        private TextBox txtUserRole;
        private Button btnClose;
    }
}