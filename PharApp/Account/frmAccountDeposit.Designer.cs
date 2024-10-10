namespace PharApp.Account
{
    partial class frmAccountDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountDeposit));
            tabAccountControl = new TabControl();
            tabAccount = new TabPage();
            btnRefresh = new Button();
            accountGrid = new DataGridView();
            label1 = new Label();
            txtSearchAccount = new TextBox();
            btnAccount = new Button();
            tabDeposit = new TabPage();
            btnRefreshDeposit = new Button();
            label2 = new Label();
            txtSearchDeposit = new TextBox();
            depositGrid = new DataGridView();
            btnDeposit = new Button();
            tabAccountControl.SuspendLayout();
            tabAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accountGrid).BeginInit();
            tabDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)depositGrid).BeginInit();
            SuspendLayout();
            // 
            // tabAccountControl
            // 
            tabAccountControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabAccountControl.Controls.Add(tabAccount);
            tabAccountControl.Controls.Add(tabDeposit);
            tabAccountControl.Location = new Point(1, 1);
            tabAccountControl.Margin = new Padding(3, 2, 3, 2);
            tabAccountControl.Name = "tabAccountControl";
            tabAccountControl.SelectedIndex = 0;
            tabAccountControl.Size = new Size(933, 489);
            tabAccountControl.TabIndex = 2;
            // 
            // tabAccount
            // 
            tabAccount.BackColor = Color.White;
            tabAccount.Controls.Add(btnRefresh);
            tabAccount.Controls.Add(accountGrid);
            tabAccount.Controls.Add(label1);
            tabAccount.Controls.Add(txtSearchAccount);
            tabAccount.Controls.Add(btnAccount);
            tabAccount.Location = new Point(4, 24);
            tabAccount.Margin = new Padding(3, 2, 3, 2);
            tabAccount.Name = "tabAccount";
            tabAccount.Padding = new Padding(3, 2, 3, 2);
            tabAccount.Size = new Size(925, 461);
            tabAccount.TabIndex = 2;
            tabAccount.Text = "Account";
            tabAccount.Click += tabAccount_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefresh.Location = new Point(148, 4);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(30, 25);
            btnRefresh.TabIndex = 6;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // accountGrid
            // 
            accountGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            accountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            accountGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            accountGrid.BackgroundColor = Color.White;
            accountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountGrid.Location = new Point(4, 33);
            accountGrid.Margin = new Padding(3, 2, 3, 2);
            accountGrid.Name = "accountGrid";
            accountGrid.ReadOnly = true;
            accountGrid.RowHeadersWidth = 51;
            accountGrid.Size = new Size(915, 422);
            accountGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(660, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Search";
            // 
            // txtSearchAccount
            // 
            txtSearchAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchAccount.Location = new Point(709, 5);
            txtSearchAccount.Margin = new Padding(3, 2, 3, 2);
            txtSearchAccount.Name = "txtSearchAccount";
            txtSearchAccount.Size = new Size(213, 23);
            txtSearchAccount.TabIndex = 2;
            txtSearchAccount.KeyUp += txtSearchAccount_KeyUp;
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(7, 4);
            btnAccount.Margin = new Padding(3, 2, 3, 2);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(137, 25);
            btnAccount.TabIndex = 1;
            btnAccount.Text = "Register Account";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // tabDeposit
            // 
            tabDeposit.Controls.Add(btnRefreshDeposit);
            tabDeposit.Controls.Add(label2);
            tabDeposit.Controls.Add(txtSearchDeposit);
            tabDeposit.Controls.Add(depositGrid);
            tabDeposit.Controls.Add(btnDeposit);
            tabDeposit.Location = new Point(4, 24);
            tabDeposit.Margin = new Padding(3, 2, 3, 2);
            tabDeposit.Name = "tabDeposit";
            tabDeposit.Padding = new Padding(3, 2, 3, 2);
            tabDeposit.Size = new Size(925, 461);
            tabDeposit.TabIndex = 3;
            tabDeposit.Text = "Deposits";
            tabDeposit.UseVisualStyleBackColor = true;
            // 
            // btnRefreshDeposit
            // 
            btnRefreshDeposit.BackgroundImage = (Image)resources.GetObject("btnRefreshDeposit.BackgroundImage");
            btnRefreshDeposit.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefreshDeposit.Location = new Point(138, 5);
            btnRefreshDeposit.Margin = new Padding(3, 2, 3, 2);
            btnRefreshDeposit.Name = "btnRefreshDeposit";
            btnRefreshDeposit.Size = new Size(30, 25);
            btnRefreshDeposit.TabIndex = 7;
            btnRefreshDeposit.UseVisualStyleBackColor = true;
            btnRefreshDeposit.Click += btnRefreshDeposit_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(655, 11);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Search";
            // 
            // txtSearchDeposit
            // 
            txtSearchDeposit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchDeposit.Location = new Point(704, 7);
            txtSearchDeposit.Margin = new Padding(3, 2, 3, 2);
            txtSearchDeposit.Name = "txtSearchDeposit";
            txtSearchDeposit.Size = new Size(213, 23);
            txtSearchDeposit.TabIndex = 4;
            txtSearchDeposit.KeyUp += textSearchDeposit_KeyUp;
            // 
            // depositGrid
            // 
            depositGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            depositGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            depositGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            depositGrid.BackgroundColor = Color.White;
            depositGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            depositGrid.Location = new Point(3, 34);
            depositGrid.Margin = new Padding(3, 2, 3, 2);
            depositGrid.Name = "depositGrid";
            depositGrid.ReadOnly = true;
            depositGrid.RowHeadersWidth = 51;
            depositGrid.Size = new Size(917, 424);
            depositGrid.TabIndex = 0;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(7, 6);
            btnDeposit.Margin = new Padding(3, 2, 3, 2);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(125, 22);
            btnDeposit.TabIndex = 0;
            btnDeposit.Text = "Register Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // frmAccountDeposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 490);
            Controls.Add(tabAccountControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAccountDeposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company Account Management";
            tabAccountControl.ResumeLayout(false);
            tabAccount.ResumeLayout(false);
            tabAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accountGrid).EndInit();
            tabDeposit.ResumeLayout(false);
            tabDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)depositGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAccountControl;
        private TabPage tabAccount;
        public DataGridView accountGrid;
        private Label label1;
        private TextBox txtSearchAccount;
        private Button btnAccount;
        private TabPage tabDeposit;
        public DataGridView depositGrid;
        private Button btnRegisterRoles;
        private Button btnDeposit;
        private Label label2;
        private TextBox txtSearchDeposit;
        private Button btnRefresh;
        private Button btnRefreshDeposit;
    }
}