namespace PharApp.Sale.Area
{
    partial class frmArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArea));
            tabManufactured = new TabControl();
            tabManageManufacturer = new TabPage();
            btnRegister = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewArea = new DataGridView();
            contextMenuStripArea = new ContextMenuStrip(components);
            updateAreaToolStripMenuItem = new ToolStripMenuItem();
            deleteAreaToolStripMenuItem = new ToolStripMenuItem();
            tabPage1 = new TabPage();
            btnRegisterBooker = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridViewBooker = new DataGridView();
            tabPage2 = new TabPage();
            button2 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridViewSupplier = new DataGridView();
            tabManufactured.SuspendLayout();
            tabManageManufacturer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArea).BeginInit();
            contextMenuStripArea.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooker).BeginInit();
            tabPage2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplier).BeginInit();
            SuspendLayout();
            // 
            // tabManufactured
            // 
            tabManufactured.Controls.Add(tabManageManufacturer);
            tabManufactured.Controls.Add(tabPage1);
            tabManufactured.Controls.Add(tabPage2);
            tabManufactured.Location = new Point(10, 9);
            tabManufactured.Margin = new Padding(3, 2, 3, 2);
            tabManufactured.Name = "tabManufactured";
            tabManufactured.SelectedIndex = 0;
            tabManufactured.Size = new Size(679, 320);
            tabManufactured.TabIndex = 1;
            // 
            // tabManageManufacturer
            // 
            tabManageManufacturer.Controls.Add(btnRegister);
            tabManageManufacturer.Controls.Add(tableLayoutPanel1);
            tabManageManufacturer.Location = new Point(4, 24);
            tabManageManufacturer.Margin = new Padding(3, 2, 3, 2);
            tabManageManufacturer.Name = "tabManageManufacturer";
            tabManageManufacturer.Padding = new Padding(3, 2, 3, 2);
            tabManageManufacturer.Size = new Size(671, 292);
            tabManageManufacturer.TabIndex = 0;
            tabManageManufacturer.Text = "Area";
            tabManageManufacturer.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(8, 17);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 22);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register Area";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridViewArea, 0, 0);
            tableLayoutPanel1.Location = new Point(5, 44);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(662, 247);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewArea
            // 
            dataGridViewArea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewArea.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewArea.BackgroundColor = Color.White;
            dataGridViewArea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArea.ContextMenuStrip = contextMenuStripArea;
            dataGridViewArea.Location = new Point(3, 2);
            dataGridViewArea.Margin = new Padding(3, 2, 3, 2);
            dataGridViewArea.MultiSelect = false;
            dataGridViewArea.Name = "dataGridViewArea";
            dataGridViewArea.RowHeadersWidth = 51;
            dataGridViewArea.Size = new Size(656, 242);
            dataGridViewArea.TabIndex = 0;
            dataGridViewArea.MouseClick += dataGridViewArea_MouseClick;
            // 
            // contextMenuStripArea
            // 
            contextMenuStripArea.ImageScalingSize = new Size(20, 20);
            contextMenuStripArea.Items.AddRange(new ToolStripItem[] { updateAreaToolStripMenuItem, deleteAreaToolStripMenuItem });
            contextMenuStripArea.Name = "contextMenuStripArea";
            contextMenuStripArea.Size = new Size(140, 48);
            // 
            // updateAreaToolStripMenuItem
            // 
            updateAreaToolStripMenuItem.Name = "updateAreaToolStripMenuItem";
            updateAreaToolStripMenuItem.Size = new Size(139, 22);
            updateAreaToolStripMenuItem.Text = "Update Area";
            // 
            // deleteAreaToolStripMenuItem
            // 
            deleteAreaToolStripMenuItem.Name = "deleteAreaToolStripMenuItem";
            deleteAreaToolStripMenuItem.Size = new Size(139, 22);
            deleteAreaToolStripMenuItem.Text = "Delete Area";
            deleteAreaToolStripMenuItem.Click += deleteAreaToolStripMenuItem_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRegisterBooker);
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(671, 292);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Booking Officer";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegisterBooker
            // 
            btnRegisterBooker.Location = new Point(8, 10);
            btnRegisterBooker.Margin = new Padding(3, 2, 3, 2);
            btnRegisterBooker.Name = "btnRegisterBooker";
            btnRegisterBooker.Size = new Size(130, 22);
            btnRegisterBooker.TabIndex = 3;
            btnRegisterBooker.Text = "Register Booker";
            btnRegisterBooker.UseVisualStyleBackColor = true;
            btnRegisterBooker.Click += btnRegisterBooker_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dataGridViewBooker, 0, 0);
            tableLayoutPanel2.Location = new Point(5, 37);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(662, 247);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // dataGridViewBooker
            // 
            dataGridViewBooker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooker.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewBooker.BackgroundColor = Color.White;
            dataGridViewBooker.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooker.ContextMenuStrip = contextMenuStripArea;
            dataGridViewBooker.Location = new Point(3, 2);
            dataGridViewBooker.Margin = new Padding(3, 2, 3, 2);
            dataGridViewBooker.MultiSelect = false;
            dataGridViewBooker.Name = "dataGridViewBooker";
            dataGridViewBooker.RowHeadersWidth = 51;
            dataGridViewBooker.Size = new Size(656, 242);
            dataGridViewBooker.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(671, 292);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "Supplier";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(8, 10);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(130, 22);
            button2.TabIndex = 3;
            button2.Text = "Register Supplier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dataGridViewSupplier, 0, 0);
            tableLayoutPanel3.Location = new Point(5, 37);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(662, 247);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // dataGridViewSupplier
            // 
            dataGridViewSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSupplier.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewSupplier.BackgroundColor = Color.White;
            dataGridViewSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSupplier.ContextMenuStrip = contextMenuStripArea;
            dataGridViewSupplier.Location = new Point(3, 2);
            dataGridViewSupplier.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSupplier.MultiSelect = false;
            dataGridViewSupplier.Name = "dataGridViewSupplier";
            dataGridViewSupplier.RowHeadersWidth = 51;
            dataGridViewSupplier.Size = new Size(656, 242);
            dataGridViewSupplier.TabIndex = 0;
            // 
            // frmArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabManufactured);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmArea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Area Registration";
            Load += frmArea_Load;
            tabManufactured.ResumeLayout(false);
            tabManageManufacturer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewArea).EndInit();
            contextMenuStripArea.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooker).EndInit();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabManufactured;
        private TabPage tabManageManufacturer;
        private Button btnRegister;
        private TableLayoutPanel tableLayoutPanel1;
        public DataGridView dataGridViewArea;
        private ContextMenuStrip contextMenuStripArea;
        private ToolStripMenuItem updateAreaToolStripMenuItem;
        private ToolStripMenuItem deleteAreaToolStripMenuItem;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        public DataGridView dataGridViewBooker;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel3;
        public DataGridView dataGridViewSupplier;
        private Button btnRegisterBooker;
    }
}