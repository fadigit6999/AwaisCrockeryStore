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
            tabPageAdjustmentAccount = new TabPage();
            btnRefreshAdjustementAccount = new Button();
            dataGridViewAdjustementAccount = new DataGridView();
            label3 = new Label();
            txtSearchAdjustementAccount = new TextBox();
            btnRegisterAdjustmentAccount = new Button();
            tabPageAdjustmentDeposit = new TabPage();
            btnRefreshAdjustmentDepositGrid = new Button();
            label4 = new Label();
            txtAdjustmentDepositSearch = new TextBox();
            dataGridViewAdjustmentDepositGrid = new DataGridView();
            btnAdjustmentDeposit = new Button();
            tabAccountControl.SuspendLayout();
            tabAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accountGrid).BeginInit();
            tabDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)depositGrid).BeginInit();
            tabPageAdjustmentAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdjustementAccount).BeginInit();
            tabPageAdjustmentDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdjustmentDepositGrid).BeginInit();
            SuspendLayout();
            // 
            // tabAccountControl
            // 
            tabAccountControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabAccountControl.Controls.Add(tabAccount);
            tabAccountControl.Controls.Add(tabDeposit);
            tabAccountControl.Controls.Add(tabPageAdjustmentAccount);
            tabAccountControl.Controls.Add(tabPageAdjustmentDeposit);
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
            // tabPageAdjustmentAccount
            // 
            tabPageAdjustmentAccount.Controls.Add(btnRefreshAdjustementAccount);
            tabPageAdjustmentAccount.Controls.Add(dataGridViewAdjustementAccount);
            tabPageAdjustmentAccount.Controls.Add(label3);
            tabPageAdjustmentAccount.Controls.Add(txtSearchAdjustementAccount);
            tabPageAdjustmentAccount.Controls.Add(btnRegisterAdjustmentAccount);
            tabPageAdjustmentAccount.Location = new Point(4, 24);
            tabPageAdjustmentAccount.Name = "tabPageAdjustmentAccount";
            tabPageAdjustmentAccount.Padding = new Padding(3);
            tabPageAdjustmentAccount.Size = new Size(925, 461);
            tabPageAdjustmentAccount.TabIndex = 4;
            tabPageAdjustmentAccount.Text = "Adjustment Account";
            tabPageAdjustmentAccount.UseVisualStyleBackColor = true;
            // 
            // btnRefreshAdjustementAccount
            // 
            btnRefreshAdjustementAccount.BackgroundImage = (Image)resources.GetObject("btnRefreshAdjustementAccount.BackgroundImage");
            btnRefreshAdjustementAccount.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefreshAdjustementAccount.Location = new Point(199, 5);
            btnRefreshAdjustementAccount.Margin = new Padding(3, 2, 3, 2);
            btnRefreshAdjustementAccount.Name = "btnRefreshAdjustementAccount";
            btnRefreshAdjustementAccount.Size = new Size(30, 25);
            btnRefreshAdjustementAccount.TabIndex = 11;
            btnRefreshAdjustementAccount.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdjustementAccount
            // 
            dataGridViewAdjustementAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAdjustementAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAdjustementAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAdjustementAccount.BackgroundColor = Color.White;
            dataGridViewAdjustementAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdjustementAccount.Location = new Point(3, 34);
            dataGridViewAdjustementAccount.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAdjustementAccount.Name = "dataGridViewAdjustementAccount";
            dataGridViewAdjustementAccount.ReadOnly = true;
            dataGridViewAdjustementAccount.RowHeadersWidth = 51;
            dataGridViewAdjustementAccount.Size = new Size(915, 422);
            dataGridViewAdjustementAccount.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(659, 10);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 10;
            label3.Text = "Search";
            // 
            // txtSearchAdjustementAccount
            // 
            txtSearchAdjustementAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchAdjustementAccount.Location = new Point(708, 6);
            txtSearchAdjustementAccount.Margin = new Padding(3, 2, 3, 2);
            txtSearchAdjustementAccount.Name = "txtSearchAdjustementAccount";
            txtSearchAdjustementAccount.Size = new Size(213, 23);
            txtSearchAdjustementAccount.TabIndex = 9;
            // 
            // btnRegisterAdjustmentAccount
            // 
            btnRegisterAdjustmentAccount.Location = new Point(6, 5);
            btnRegisterAdjustmentAccount.Margin = new Padding(3, 2, 3, 2);
            btnRegisterAdjustmentAccount.Name = "btnRegisterAdjustmentAccount";
            btnRegisterAdjustmentAccount.Size = new Size(188, 25);
            btnRegisterAdjustmentAccount.TabIndex = 8;
            btnRegisterAdjustmentAccount.Text = "Register Adjustment Account";
            btnRegisterAdjustmentAccount.UseVisualStyleBackColor = true;
            btnRegisterAdjustmentAccount.Click += btnRegisterAdjustmentAccount_Click;
            // 
            // tabPageAdjustmentDeposit
            // 
            tabPageAdjustmentDeposit.Controls.Add(btnRefreshAdjustmentDepositGrid);
            tabPageAdjustmentDeposit.Controls.Add(label4);
            tabPageAdjustmentDeposit.Controls.Add(txtAdjustmentDepositSearch);
            tabPageAdjustmentDeposit.Controls.Add(dataGridViewAdjustmentDepositGrid);
            tabPageAdjustmentDeposit.Controls.Add(btnAdjustmentDeposit);
            tabPageAdjustmentDeposit.Location = new Point(4, 24);
            tabPageAdjustmentDeposit.Name = "tabPageAdjustmentDeposit";
            tabPageAdjustmentDeposit.Size = new Size(925, 461);
            tabPageAdjustmentDeposit.TabIndex = 5;
            tabPageAdjustmentDeposit.Text = "Adjustment Deposit";
            tabPageAdjustmentDeposit.UseVisualStyleBackColor = true;
            // 
            // btnRefreshAdjustmentDepositGrid
            // 
            btnRefreshAdjustmentDepositGrid.BackgroundImage = (Image)resources.GetObject("btnRefreshAdjustmentDepositGrid.BackgroundImage");
            btnRefreshAdjustmentDepositGrid.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefreshAdjustmentDepositGrid.Location = new Point(191, 4);
            btnRefreshAdjustmentDepositGrid.Margin = new Padding(3, 2, 3, 2);
            btnRefreshAdjustmentDepositGrid.Name = "btnRefreshAdjustmentDepositGrid";
            btnRefreshAdjustmentDepositGrid.Size = new Size(30, 25);
            btnRefreshAdjustmentDepositGrid.TabIndex = 12;
            btnRefreshAdjustmentDepositGrid.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(656, 10);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 11;
            label4.Text = "Search";
            // 
            // txtAdjustmentDepositSearch
            // 
            txtAdjustmentDepositSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAdjustmentDepositSearch.Location = new Point(705, 6);
            txtAdjustmentDepositSearch.Margin = new Padding(3, 2, 3, 2);
            txtAdjustmentDepositSearch.Name = "txtAdjustmentDepositSearch";
            txtAdjustmentDepositSearch.Size = new Size(213, 23);
            txtAdjustmentDepositSearch.TabIndex = 10;
            // 
            // dataGridViewAdjustmentDepositGrid
            // 
            dataGridViewAdjustmentDepositGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAdjustmentDepositGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAdjustmentDepositGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAdjustmentDepositGrid.BackgroundColor = Color.White;
            dataGridViewAdjustmentDepositGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdjustmentDepositGrid.Location = new Point(4, 33);
            dataGridViewAdjustmentDepositGrid.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAdjustmentDepositGrid.Name = "dataGridViewAdjustmentDepositGrid";
            dataGridViewAdjustmentDepositGrid.ReadOnly = true;
            dataGridViewAdjustmentDepositGrid.RowHeadersWidth = 51;
            dataGridViewAdjustmentDepositGrid.Size = new Size(917, 424);
            dataGridViewAdjustmentDepositGrid.TabIndex = 8;
            // 
            // btnAdjustmentDeposit
            // 
            btnAdjustmentDeposit.Location = new Point(8, 5);
            btnAdjustmentDeposit.Margin = new Padding(3, 2, 3, 2);
            btnAdjustmentDeposit.Name = "btnAdjustmentDeposit";
            btnAdjustmentDeposit.Size = new Size(178, 24);
            btnAdjustmentDeposit.TabIndex = 9;
            btnAdjustmentDeposit.Text = "Register Adjustment Deposit";
            btnAdjustmentDeposit.UseVisualStyleBackColor = true;
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
            Load += frmAccountDeposit_Load;
            tabAccountControl.ResumeLayout(false);
            tabAccount.ResumeLayout(false);
            tabAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accountGrid).EndInit();
            tabDeposit.ResumeLayout(false);
            tabDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)depositGrid).EndInit();
            tabPageAdjustmentAccount.ResumeLayout(false);
            tabPageAdjustmentAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdjustementAccount).EndInit();
            tabPageAdjustmentDeposit.ResumeLayout(false);
            tabPageAdjustmentDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdjustmentDepositGrid).EndInit();
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
        private TabPage tabPageAdjustmentAccount;
        private Button btnRefreshAdjustementAccount;
        public DataGridView dataGridViewAdjustementAccount;
        private Label label3;
        private TextBox txtSearchAdjustementAccount;
        private Button btnRegisterAdjustmentAccount;
        private TabPage tabPageAdjustmentDeposit;
        private Button btnRefreshAdjustmentDepositGrid;
        private Label label4;
        private TextBox txtAdjustmentDepositSearch;
        public DataGridView dataGridViewAdjustmentDepositGrid;
        private Button btnAdjustmentDeposit;
    }
}