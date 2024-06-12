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
            btnRegister = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewManufacturer = new DataGridView();
            contextMenuStripManufac = new ContextMenuStrip(components);
            updateManufToolStripMenuItem = new ToolStripMenuItem();
            deleteManufToolStripMenuItem = new ToolStripMenuItem();
            tabManufactured.SuspendLayout();
            tabManageManufacturer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManufacturer).BeginInit();
            contextMenuStripManufac.SuspendLayout();
            SuspendLayout();
            // 
            // tabManufactured
            // 
            tabManufactured.Controls.Add(tabManageManufacturer);
            tabManufactured.Location = new Point(12, 12);
            tabManufactured.Name = "tabManufactured";
            tabManufactured.SelectedIndex = 0;
            tabManufactured.Size = new Size(776, 426);
            tabManufactured.TabIndex = 0;
            // 
            // tabManageManufacturer
            // 
            tabManageManufacturer.Controls.Add(btnRegister);
            tabManageManufacturer.Controls.Add(tableLayoutPanel1);
            tabManageManufacturer.Location = new Point(4, 29);
            tabManageManufacturer.Name = "tabManageManufacturer";
            tabManageManufacturer.Padding = new Padding(3);
            tabManageManufacturer.Size = new Size(768, 393);
            tabManageManufacturer.TabIndex = 0;
            tabManageManufacturer.Text = "Manufacturer";
            tabManageManufacturer.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(9, 23);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridViewManufacturer, 0, 0);
            tableLayoutPanel1.Location = new Point(6, 58);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(756, 329);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewManufacturer
            // 
            dataGridViewManufacturer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewManufacturer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewManufacturer.BackgroundColor = Color.White;
            dataGridViewManufacturer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewManufacturer.ContextMenuStrip = contextMenuStripManufac;
            dataGridViewManufacturer.Location = new Point(3, 3);
            dataGridViewManufacturer.MultiSelect = false;
            dataGridViewManufacturer.Name = "dataGridViewManufacturer";
            dataGridViewManufacturer.ReadOnly = true;
            dataGridViewManufacturer.RowHeadersWidth = 51;
            dataGridViewManufacturer.Size = new Size(750, 323);
            dataGridViewManufacturer.TabIndex = 0;
            dataGridViewManufacturer.MouseClick += dataGridViewManufacturer_MouseClick;
            // 
            // contextMenuStripManufac
            // 
            contextMenuStripManufac.ImageScalingSize = new Size(20, 20);
            contextMenuStripManufac.Items.AddRange(new ToolStripItem[] { updateManufToolStripMenuItem, deleteManufToolStripMenuItem });
            contextMenuStripManufac.Name = "contextMenuStripManufac";
            contextMenuStripManufac.Size = new Size(177, 52);
            // 
            // updateManufToolStripMenuItem
            // 
            updateManufToolStripMenuItem.Name = "updateManufToolStripMenuItem";
            updateManufToolStripMenuItem.Size = new Size(176, 24);
            updateManufToolStripMenuItem.Text = "Update Manuf.";
            // 
            // deleteManufToolStripMenuItem
            // 
            deleteManufToolStripMenuItem.Name = "deleteManufToolStripMenuItem";
            deleteManufToolStripMenuItem.Size = new Size(176, 24);
            deleteManufToolStripMenuItem.Text = "Delete Manuf.";
            deleteManufToolStripMenuItem.Click += deleteManufToolStripMenuItem_Click;
            // 
            // frmManufacturer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabManufactured);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmManufacturer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manufacturer";
            tabManufactured.ResumeLayout(false);
            tabManageManufacturer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewManufacturer).EndInit();
            contextMenuStripManufac.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabManufactured;
        private TabPage tabManageManufacturer;
        private Button btnRegister;
        private TableLayoutPanel tableLayoutPanel1;
        public DataGridView dataGridViewManufacturer;
        private ContextMenuStrip contextMenuStripManufac;
        private ToolStripMenuItem updateManufToolStripMenuItem;
        private ToolStripMenuItem deleteManufToolStripMenuItem;
    }
}