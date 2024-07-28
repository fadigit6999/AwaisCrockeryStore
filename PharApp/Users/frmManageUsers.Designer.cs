namespace PharApp.Users
{
    partial class frmManageUsers
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabUserControl = new TabControl();
            tabPageUserRegistration = new TabPage();
            registeredUserGrid = new DataGridView();
            contextMenuStripUsers = new ContextMenuStrip(components);
            deleteUserToolStripMenuItem = new ToolStripMenuItem();
            enableUserToolStripMenuItem = new ToolStripMenuItem();
            disableUserToolStripMenuItem = new ToolStripMenuItem();
            assignUserRoleToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            txtSearch = new TextBox();
            btnAssignUserRole = new Button();
            btnUserRegistration = new Button();
            tabPageUserRoles = new TabPage();
            userRolesGrid = new DataGridView();
            contextMenuStripRole = new ContextMenuStrip(components);
            deleteRoleToolStripMenuItem = new ToolStripMenuItem();
            btnRegisterRoles = new Button();
            tabUserControl.SuspendLayout();
            tabPageUserRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)registeredUserGrid).BeginInit();
            contextMenuStripUsers.SuspendLayout();
            tabPageUserRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userRolesGrid).BeginInit();
            contextMenuStripRole.SuspendLayout();
            SuspendLayout();
            // 
            // tabUserControl
            // 
            tabUserControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabUserControl.Controls.Add(tabPageUserRegistration);
            tabUserControl.Controls.Add(tabPageUserRoles);
            tabUserControl.Location = new Point(5, 5);
            tabUserControl.Margin = new Padding(3, 2, 3, 2);
            tabUserControl.Name = "tabUserControl";
            tabUserControl.SelectedIndex = 0;
            tabUserControl.Size = new Size(844, 447);
            tabUserControl.TabIndex = 1;
            // 
            // tabPageUserRegistration
            // 
            tabPageUserRegistration.BackColor = Color.White;
            tabPageUserRegistration.Controls.Add(registeredUserGrid);
            tabPageUserRegistration.Controls.Add(label1);
            tabPageUserRegistration.Controls.Add(txtSearch);
            tabPageUserRegistration.Controls.Add(btnAssignUserRole);
            tabPageUserRegistration.Controls.Add(btnUserRegistration);
            tabPageUserRegistration.Location = new Point(4, 24);
            tabPageUserRegistration.Margin = new Padding(3, 2, 3, 2);
            tabPageUserRegistration.Name = "tabPageUserRegistration";
            tabPageUserRegistration.Padding = new Padding(3, 2, 3, 2);
            tabPageUserRegistration.Size = new Size(836, 419);
            tabPageUserRegistration.TabIndex = 2;
            tabPageUserRegistration.Text = "Registration";
            // 
            // registeredUserGrid
            // 
            registeredUserGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            registeredUserGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            registeredUserGrid.BackgroundColor = Color.White;
            registeredUserGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registeredUserGrid.ContextMenuStrip = contextMenuStripUsers;
            registeredUserGrid.Location = new Point(9, 60);
            registeredUserGrid.Margin = new Padding(3, 2, 3, 2);
            registeredUserGrid.Name = "registeredUserGrid";
            registeredUserGrid.ReadOnly = true;
            registeredUserGrid.RowHeadersWidth = 51;
            registeredUserGrid.Size = new Size(822, 358);
            registeredUserGrid.TabIndex = 0;
            registeredUserGrid.MouseClick += registeredUserGrid_MouseClick;
            // 
            // contextMenuStripUsers
            // 
            contextMenuStripUsers.ImageScalingSize = new Size(20, 20);
            contextMenuStripUsers.Items.AddRange(new ToolStripItem[] { deleteUserToolStripMenuItem, enableUserToolStripMenuItem, disableUserToolStripMenuItem, assignUserRoleToolStripMenuItem });
            contextMenuStripUsers.Name = "contextMenuStripUsers";
            contextMenuStripUsers.Size = new Size(162, 92);
            // 
            // deleteUserToolStripMenuItem
            // 
            deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            deleteUserToolStripMenuItem.Size = new Size(161, 22);
            deleteUserToolStripMenuItem.Text = "Delete User";
            // 
            // enableUserToolStripMenuItem
            // 
            enableUserToolStripMenuItem.Name = "enableUserToolStripMenuItem";
            enableUserToolStripMenuItem.Size = new Size(161, 22);
            enableUserToolStripMenuItem.Text = "Enable User";
            // 
            // disableUserToolStripMenuItem
            // 
            disableUserToolStripMenuItem.Name = "disableUserToolStripMenuItem";
            disableUserToolStripMenuItem.Size = new Size(161, 22);
            disableUserToolStripMenuItem.Text = "Disable User";
            // 
            // assignUserRoleToolStripMenuItem
            // 
            assignUserRoleToolStripMenuItem.Name = "assignUserRoleToolStripMenuItem";
            assignUserRoleToolStripMenuItem.Size = new Size(161, 22);
            assignUserRoleToolStripMenuItem.Text = "Assign User Role";
            assignUserRoleToolStripMenuItem.Click += assignUserRoleToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(546, 23);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(598, 21);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(213, 23);
            txtSearch.TabIndex = 2;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // btnAssignUserRole
            // 
            btnAssignUserRole.Location = new Point(137, 20);
            btnAssignUserRole.Margin = new Padding(3, 2, 3, 2);
            btnAssignUserRole.Name = "btnAssignUserRole";
            btnAssignUserRole.Size = new Size(126, 22);
            btnAssignUserRole.TabIndex = 1;
            btnAssignUserRole.Text = "Assign User Role";
            btnAssignUserRole.UseVisualStyleBackColor = true;
            btnAssignUserRole.Click += btnUserRegistration_Click;
            // 
            // btnUserRegistration
            // 
            btnUserRegistration.Location = new Point(9, 21);
            btnUserRegistration.Margin = new Padding(3, 2, 3, 2);
            btnUserRegistration.Name = "btnUserRegistration";
            btnUserRegistration.Size = new Size(116, 22);
            btnUserRegistration.TabIndex = 1;
            btnUserRegistration.Text = "Register User";
            btnUserRegistration.UseVisualStyleBackColor = true;
            btnUserRegistration.Click += btnUserRegistration_Click;
            // 
            // tabPageUserRoles
            // 
            tabPageUserRoles.Controls.Add(userRolesGrid);
            tabPageUserRoles.Controls.Add(btnRegisterRoles);
            tabPageUserRoles.Location = new Point(4, 24);
            tabPageUserRoles.Margin = new Padding(3, 2, 3, 2);
            tabPageUserRoles.Name = "tabPageUserRoles";
            tabPageUserRoles.Padding = new Padding(3, 2, 3, 2);
            tabPageUserRoles.Size = new Size(836, 419);
            tabPageUserRoles.TabIndex = 3;
            tabPageUserRoles.Text = "User Roles";
            tabPageUserRoles.UseVisualStyleBackColor = true;
            // 
            // userRolesGrid
            // 
            userRolesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userRolesGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            userRolesGrid.BackgroundColor = Color.White;
            userRolesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userRolesGrid.ContextMenuStrip = contextMenuStripRole;
            userRolesGrid.Location = new Point(5, 55);
            userRolesGrid.Margin = new Padding(3, 2, 3, 2);
            userRolesGrid.Name = "userRolesGrid";
            userRolesGrid.ReadOnly = true;
            userRolesGrid.RowHeadersWidth = 51;
            userRolesGrid.Size = new Size(826, 363);
            userRolesGrid.TabIndex = 0;
            // 
            // contextMenuStripRole
            // 
            contextMenuStripRole.ImageScalingSize = new Size(20, 20);
            contextMenuStripRole.Items.AddRange(new ToolStripItem[] { deleteRoleToolStripMenuItem });
            contextMenuStripRole.Name = "contextMenuStripRole";
            contextMenuStripRole.Size = new Size(134, 26);
            // 
            // deleteRoleToolStripMenuItem
            // 
            deleteRoleToolStripMenuItem.Name = "deleteRoleToolStripMenuItem";
            deleteRoleToolStripMenuItem.Size = new Size(133, 22);
            deleteRoleToolStripMenuItem.Text = "Delete Role";
            // 
            // btnRegisterRoles
            // 
            btnRegisterRoles.Location = new Point(8, 15);
            btnRegisterRoles.Margin = new Padding(3, 2, 3, 2);
            btnRegisterRoles.Name = "btnRegisterRoles";
            btnRegisterRoles.Size = new Size(125, 22);
            btnRegisterRoles.TabIndex = 0;
            btnRegisterRoles.Text = "Register Roles";
            btnRegisterRoles.UseVisualStyleBackColor = true;
            btnRegisterRoles.Click += btnRegisterRoles_Click;
            // 
            // frmManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(853, 461);
            Controls.Add(tabUserControl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sytem Users";
            Load += frmManageUsers_Load;
            tabUserControl.ResumeLayout(false);
            tabPageUserRegistration.ResumeLayout(false);
            tabPageUserRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)registeredUserGrid).EndInit();
            contextMenuStripUsers.ResumeLayout(false);
            tabPageUserRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userRolesGrid).EndInit();
            contextMenuStripRole.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabControl tabUserControl;
        private TabPage tabPageUserRegistration;
        private TabPage tabPageUserRoles;
        private Button btnUserRegistration;
        private TableLayoutPanel tableLayoutPanelUserGrid;
        public DataGridView registeredUserGrid;
        private Label label1;
        private TextBox txtSearch;
        private Button btnAssignUserRole;
        private TableLayoutPanel tableLayoutPanel1;
        public DataGridView userRolesGrid;
        private Button btnRegisterRoles;
        private ContextMenuStrip contextMenuStripUsers;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private ToolStripMenuItem enableUserToolStripMenuItem;
        private ToolStripMenuItem disableUserToolStripMenuItem;
        private ContextMenuStrip contextMenuStripRole;
        private ToolStripMenuItem deleteRoleToolStripMenuItem;
        private ToolStripMenuItem assignUserRoleToolStripMenuItem;
    }
}