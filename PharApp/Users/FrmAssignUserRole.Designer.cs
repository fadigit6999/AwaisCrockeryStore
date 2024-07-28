namespace PharApp.Users
{
    partial class FrmAssignUserRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssignUserRole));
            label11 = new Label();
            btnRegisterRole = new Button();
            label1 = new Label();
            btnClose = new Button();
            cmbType = new ComboBox();
            cmbRole = new ComboBox();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(12, 11);
            label11.Name = "label11";
            label11.Size = new Size(151, 25);
            label11.TabIndex = 0;
            label11.Text = "Assign User Role";
            // 
            // btnRegisterRole
            // 
            btnRegisterRole.Location = new Point(31, 103);
            btnRegisterRole.Margin = new Padding(3, 2, 3, 2);
            btnRegisterRole.Name = "btnRegisterRole";
            btnRegisterRole.Size = new Size(132, 26);
            btnRegisterRole.TabIndex = 2;
            btnRegisterRole.Text = "Assign";
            btnRegisterRole.UseVisualStyleBackColor = true;
            btnRegisterRole.Click += btnRegisterRole_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 59);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Role Name";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(258, 11);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(31, 22);
            btnClose.TabIndex = 8;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cmbType
            // 
            cmbType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(48, 242);
            cmbType.Margin = new Padding(3, 2, 3, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(163, 23);
            cmbType.TabIndex = 8;
            // 
            // cmbRole
            // 
            cmbRole.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbRole.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(31, 76);
            cmbRole.Margin = new Padding(3, 2, 3, 2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(258, 23);
            cmbRole.TabIndex = 9;
            // 
            // FrmAssignUserRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 153);
            Controls.Add(cmbRole);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(btnClose);
            Controls.Add(btnRegisterRole);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAssignUserRole";
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
        private Button btnClose;
        private ComboBox cmbType;
        private ComboBox cmbRole;
    }
}