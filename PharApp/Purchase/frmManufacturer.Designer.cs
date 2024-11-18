namespace PharApp.Purchase
{
    partial class frmManufacturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManufacturer));
            tabManufactured = new TabControl();
            tabManageManufacturer = new TabPage();
            dataGridViewManufacturer = new DataGridView();
            contextMenuStripManufac = new ContextMenuStrip(components);
            updateManufToolStripMenuItem = new ToolStripMenuItem();
            deleteManufToolStripMenuItem = new ToolStripMenuItem();
            btnRegister = new Button();
            txtSearch = new TextBox();
            label18 = new Label();
            tabManufactured.SuspendLayout();
            tabManageManufacturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManufacturer).BeginInit();
            contextMenuStripManufac.SuspendLayout();
            SuspendLayout();
            // 
            // tabManufactured
            // 
            tabManufactured.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabManufactured.Controls.Add(tabManageManufacturer);
            tabManufactured.Location = new Point(3, 4);
            tabManufactured.Margin = new Padding(3, 2, 3, 2);
            tabManufactured.Name = "tabManufactured";
            tabManufactured.SelectedIndex = 0;
            tabManufactured.Size = new Size(696, 333);
            tabManufactured.TabIndex = 0;
            // 
            // tabManageManufacturer
            // 
            tabManageManufacturer.Controls.Add(txtSearch);
            tabManageManufacturer.Controls.Add(label18);
            tabManageManufacturer.Controls.Add(dataGridViewManufacturer);
            tabManageManufacturer.Controls.Add(btnRegister);
            tabManageManufacturer.Location = new Point(4, 24);
            tabManageManufacturer.Margin = new Padding(3, 2, 3, 2);
            tabManageManufacturer.Name = "tabManageManufacturer";
            tabManageManufacturer.Padding = new Padding(3, 2, 3, 2);
            tabManageManufacturer.Size = new Size(688, 305);
            tabManageManufacturer.TabIndex = 0;
            tabManageManufacturer.Text = "Manufacturer";
            tabManageManufacturer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewManufacturer
            // 
            dataGridViewManufacturer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewManufacturer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewManufacturer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewManufacturer.BackgroundColor = Color.White;
            dataGridViewManufacturer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewManufacturer.ContextMenuStrip = contextMenuStripManufac;
            dataGridViewManufacturer.Location = new Point(3, 39);
            dataGridViewManufacturer.Margin = new Padding(3, 2, 3, 2);
            dataGridViewManufacturer.MultiSelect = false;
            dataGridViewManufacturer.Name = "dataGridViewManufacturer";
            dataGridViewManufacturer.ReadOnly = true;
            dataGridViewManufacturer.RowHeadersWidth = 51;
            dataGridViewManufacturer.Size = new Size(682, 264);
            dataGridViewManufacturer.TabIndex = 0;
            dataGridViewManufacturer.MouseClick += dataGridViewManufacturer_MouseClick;
            // 
            // contextMenuStripManufac
            // 
            contextMenuStripManufac.ImageScalingSize = new Size(20, 20);
            contextMenuStripManufac.Items.AddRange(new ToolStripItem[] { updateManufToolStripMenuItem, deleteManufToolStripMenuItem });
            contextMenuStripManufac.Name = "contextMenuStripManufac";
            contextMenuStripManufac.Size = new Size(138, 48);
            // 
            // updateManufToolStripMenuItem
            // 
            updateManufToolStripMenuItem.Name = "updateManufToolStripMenuItem";
            updateManufToolStripMenuItem.Size = new Size(137, 22);
            updateManufToolStripMenuItem.Text = "Update Mfg";
            updateManufToolStripMenuItem.Click += updateManufToolStripMenuItem_Click;
            // 
            // deleteManufToolStripMenuItem
            // 
            deleteManufToolStripMenuItem.Name = "deleteManufToolStripMenuItem";
            deleteManufToolStripMenuItem.Size = new Size(137, 22);
            deleteManufToolStripMenuItem.Text = "Delete Mfg";
            deleteManufToolStripMenuItem.Click += deleteManufToolStripMenuItem_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(8, 9);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(82, 22);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(460, 10);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 23);
            txtSearch.TabIndex = 8;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Calibri", 12F);
            label18.Location = new Point(402, 12);
            label18.Name = "label18";
            label18.Size = new Size(56, 19);
            label18.TabIndex = 7;
            label18.Text = "&Search:";
            // 
            // frmManufacturer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabManufactured);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmManufacturer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Company Manufacturer";
            tabManufactured.ResumeLayout(false);
            tabManageManufacturer.ResumeLayout(false);
            tabManageManufacturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManufacturer).EndInit();
            contextMenuStripManufac.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabManufactured;
        private TabPage tabManageManufacturer;
        private Button btnRegister;
        private ContextMenuStrip contextMenuStripManufac;
        private ToolStripMenuItem updateManufToolStripMenuItem;
        private ToolStripMenuItem deleteManufToolStripMenuItem;
        public DataGridView dataGridViewManufacturer;
        private TextBox txtSearch;
        private Label label18;
    }
}