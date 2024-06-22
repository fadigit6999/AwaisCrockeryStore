namespace PharApp.Inventory
{
    partial class frmMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicine));
            tabControlMedicine = new TabControl();
            tabMedicine = new TabPage();
            txtSearch = new TextBox();
            label18 = new Label();
            dataGridViewMedicine = new DataGridView();
            contextMenuStripMedGrid = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            btnRegisterMedicine = new Button();
            tabMedicineType = new TabPage();
            dataGridViewMedicineType = new DataGridView();
            contextMenuStripType = new ContextMenuStrip(components);
            updateTypeToolStripMenuItem = new ToolStripMenuItem();
            deleteTypeToolStripMenuItem = new ToolStripMenuItem();
            btnRegisterType = new Button();
            tabCategory = new TabPage();
            dataGridViewMedicineCategory = new DataGridView();
            contextMenuStripCategory = new ContextMenuStrip(components);
            updateCategoryToolStripMenuItem = new ToolStripMenuItem();
            deleteCategoryToolStripMenuItem = new ToolStripMenuItem();
            btnRegisterCategory = new Button();
            tabMedicineUnit = new TabPage();
            dataGridViewMedicineUnit = new DataGridView();
            contextMenuStripUnitGrid = new ContextMenuStrip(components);
            updateMedicineToolStripMenuItem = new ToolStripMenuItem();
            deleteMedicineToolStripMenuItem = new ToolStripMenuItem();
            btnRegisterUnit = new Button();
            btnExportInventory = new Button();
            tabControlMedicine.SuspendLayout();
            tabMedicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicine).BeginInit();
            contextMenuStripMedGrid.SuspendLayout();
            tabMedicineType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicineType).BeginInit();
            contextMenuStripType.SuspendLayout();
            tabCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicineCategory).BeginInit();
            contextMenuStripCategory.SuspendLayout();
            tabMedicineUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicineUnit).BeginInit();
            contextMenuStripUnitGrid.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMedicine
            // 
            tabControlMedicine.Controls.Add(tabMedicine);
            tabControlMedicine.Controls.Add(tabMedicineType);
            tabControlMedicine.Controls.Add(tabCategory);
            tabControlMedicine.Controls.Add(tabMedicineUnit);
            tabControlMedicine.Location = new Point(3, -2);
            tabControlMedicine.Margin = new Padding(3, 2, 3, 2);
            tabControlMedicine.Name = "tabControlMedicine";
            tabControlMedicine.SelectedIndex = 0;
            tabControlMedicine.Size = new Size(1399, 660);
            tabControlMedicine.TabIndex = 0;
            // 
            // tabMedicine
            // 
            tabMedicine.Controls.Add(btnExportInventory);
            tabMedicine.Controls.Add(txtSearch);
            tabMedicine.Controls.Add(label18);
            tabMedicine.Controls.Add(dataGridViewMedicine);
            tabMedicine.Controls.Add(btnRegisterMedicine);
            tabMedicine.Location = new Point(4, 29);
            tabMedicine.Margin = new Padding(3, 2, 3, 2);
            tabMedicine.Name = "tabMedicine";
            tabMedicine.Padding = new Padding(3, 2, 3, 2);
            tabMedicine.Size = new Size(1391, 627);
            tabMedicine.TabIndex = 0;
            tabMedicine.Text = "Medicine";
            tabMedicine.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1008, 22);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(252, 27);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(949, 24);
            label18.Name = "label18";
            label18.Size = new Size(53, 20);
            label18.TabIndex = 5;
            label18.Text = "Search";
            // 
            // dataGridViewMedicine
            // 
            dataGridViewMedicine.AllowUserToAddRows = false;
            dataGridViewMedicine.AllowUserToDeleteRows = false;
            dataGridViewMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedicine.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMedicine.BackgroundColor = Color.White;
            dataGridViewMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedicine.ContextMenuStrip = contextMenuStripMedGrid;
            dataGridViewMedicine.Location = new Point(6, 60);
            dataGridViewMedicine.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMedicine.Name = "dataGridViewMedicine";
            dataGridViewMedicine.ReadOnly = true;
            dataGridViewMedicine.RowHeadersWidth = 51;
            dataGridViewMedicine.Size = new Size(1376, 562);
            dataGridViewMedicine.TabIndex = 0;
            dataGridViewMedicine.CellMouseClick += dataGridViewMedicine_CellMouseClick;
            dataGridViewMedicine.MouseClick += dataGridViewMedicine_MouseClick;
            // 
            // contextMenuStripMedGrid
            // 
            contextMenuStripMedGrid.ImageScalingSize = new Size(20, 20);
            contextMenuStripMedGrid.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, deleteToolStripMenuItem1 });
            contextMenuStripMedGrid.Name = "contextMenuStripMedGrid";
            contextMenuStripMedGrid.Size = new Size(193, 52);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(192, 24);
            deleteToolStripMenuItem.Text = "Update Medicine";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(192, 24);
            deleteToolStripMenuItem1.Text = "Delete Medicine";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // btnRegisterMedicine
            // 
            btnRegisterMedicine.Location = new Point(6, 18);
            btnRegisterMedicine.Margin = new Padding(3, 2, 3, 2);
            btnRegisterMedicine.Name = "btnRegisterMedicine";
            btnRegisterMedicine.Size = new Size(121, 30);
            btnRegisterMedicine.TabIndex = 1;
            btnRegisterMedicine.Text = "Register";
            btnRegisterMedicine.UseVisualStyleBackColor = true;
            btnRegisterMedicine.Click += btnRegisterMedicine_Click;
            // 
            // tabMedicineType
            // 
            tabMedicineType.Controls.Add(dataGridViewMedicineType);
            tabMedicineType.Controls.Add(btnRegisterType);
            tabMedicineType.Location = new Point(4, 29);
            tabMedicineType.Margin = new Padding(3, 2, 3, 2);
            tabMedicineType.Name = "tabMedicineType";
            tabMedicineType.Padding = new Padding(3, 2, 3, 2);
            tabMedicineType.Size = new Size(1391, 627);
            tabMedicineType.TabIndex = 1;
            tabMedicineType.Text = "Type";
            tabMedicineType.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMedicineType
            // 
            dataGridViewMedicineType.AllowUserToAddRows = false;
            dataGridViewMedicineType.AllowUserToDeleteRows = false;
            dataGridViewMedicineType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedicineType.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMedicineType.BackgroundColor = Color.White;
            dataGridViewMedicineType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedicineType.ContextMenuStrip = contextMenuStripType;
            dataGridViewMedicineType.Location = new Point(6, 56);
            dataGridViewMedicineType.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMedicineType.Name = "dataGridViewMedicineType";
            dataGridViewMedicineType.ReadOnly = true;
            dataGridViewMedicineType.RowHeadersWidth = 51;
            dataGridViewMedicineType.Size = new Size(1376, 568);
            dataGridViewMedicineType.TabIndex = 0;
            dataGridViewMedicineType.MouseClick += dataGridViewMedicineType_MouseClick;
            // 
            // contextMenuStripType
            // 
            contextMenuStripType.ImageScalingSize = new Size(20, 20);
            contextMenuStripType.Items.AddRange(new ToolStripItem[] { updateTypeToolStripMenuItem, deleteTypeToolStripMenuItem });
            contextMenuStripType.Name = "contextMenuStripType";
            contextMenuStripType.Size = new Size(163, 52);
            // 
            // updateTypeToolStripMenuItem
            // 
            updateTypeToolStripMenuItem.Name = "updateTypeToolStripMenuItem";
            updateTypeToolStripMenuItem.Size = new Size(162, 24);
            updateTypeToolStripMenuItem.Text = "Update Type";
            // 
            // deleteTypeToolStripMenuItem
            // 
            deleteTypeToolStripMenuItem.Name = "deleteTypeToolStripMenuItem";
            deleteTypeToolStripMenuItem.Size = new Size(162, 24);
            deleteTypeToolStripMenuItem.Text = "Delete Type";
            deleteTypeToolStripMenuItem.Click += deleteTypeToolStripMenuItem_Click;
            // 
            // btnRegisterType
            // 
            btnRegisterType.Location = new Point(16, 14);
            btnRegisterType.Margin = new Padding(3, 2, 3, 2);
            btnRegisterType.Name = "btnRegisterType";
            btnRegisterType.Size = new Size(121, 30);
            btnRegisterType.TabIndex = 2;
            btnRegisterType.Text = "Register";
            btnRegisterType.UseVisualStyleBackColor = true;
            btnRegisterType.Click += btnRegisterType_Click;
            // 
            // tabCategory
            // 
            tabCategory.Controls.Add(dataGridViewMedicineCategory);
            tabCategory.Controls.Add(btnRegisterCategory);
            tabCategory.Location = new Point(4, 29);
            tabCategory.Margin = new Padding(3, 2, 3, 2);
            tabCategory.Name = "tabCategory";
            tabCategory.Padding = new Padding(3, 2, 3, 2);
            tabCategory.Size = new Size(1391, 627);
            tabCategory.TabIndex = 2;
            tabCategory.Text = "Category";
            tabCategory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMedicineCategory
            // 
            dataGridViewMedicineCategory.AllowUserToAddRows = false;
            dataGridViewMedicineCategory.AllowUserToDeleteRows = false;
            dataGridViewMedicineCategory.AllowUserToOrderColumns = true;
            dataGridViewMedicineCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedicineCategory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMedicineCategory.BackgroundColor = Color.White;
            dataGridViewMedicineCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedicineCategory.ContextMenuStrip = contextMenuStripCategory;
            dataGridViewMedicineCategory.Location = new Point(6, 62);
            dataGridViewMedicineCategory.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMedicineCategory.Name = "dataGridViewMedicineCategory";
            dataGridViewMedicineCategory.ReadOnly = true;
            dataGridViewMedicineCategory.RowHeadersWidth = 51;
            dataGridViewMedicineCategory.Size = new Size(1382, 560);
            dataGridViewMedicineCategory.TabIndex = 0;
            dataGridViewMedicineCategory.MouseClick += dataGridViewMedicineCategory_MouseClick;
            // 
            // contextMenuStripCategory
            // 
            contextMenuStripCategory.ImageScalingSize = new Size(20, 20);
            contextMenuStripCategory.Items.AddRange(new ToolStripItem[] { updateCategoryToolStripMenuItem, deleteCategoryToolStripMenuItem });
            contextMenuStripCategory.Name = "contextMenuStripCategory";
            contextMenuStripCategory.Size = new Size(192, 52);
            // 
            // updateCategoryToolStripMenuItem
            // 
            updateCategoryToolStripMenuItem.Name = "updateCategoryToolStripMenuItem";
            updateCategoryToolStripMenuItem.Size = new Size(191, 24);
            updateCategoryToolStripMenuItem.Text = "Update Category";
            // 
            // deleteCategoryToolStripMenuItem
            // 
            deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            deleteCategoryToolStripMenuItem.Size = new Size(191, 24);
            deleteCategoryToolStripMenuItem.Text = "Delete Category";
            deleteCategoryToolStripMenuItem.Click += deleteCategoryToolStripMenuItem_Click;
            // 
            // btnRegisterCategory
            // 
            btnRegisterCategory.Location = new Point(9, 22);
            btnRegisterCategory.Margin = new Padding(3, 2, 3, 2);
            btnRegisterCategory.Name = "btnRegisterCategory";
            btnRegisterCategory.Size = new Size(121, 30);
            btnRegisterCategory.TabIndex = 2;
            btnRegisterCategory.Text = "Register";
            btnRegisterCategory.UseVisualStyleBackColor = true;
            btnRegisterCategory.Click += btnRegisterCategory_Click;
            // 
            // tabMedicineUnit
            // 
            tabMedicineUnit.Controls.Add(dataGridViewMedicineUnit);
            tabMedicineUnit.Controls.Add(btnRegisterUnit);
            tabMedicineUnit.Location = new Point(4, 29);
            tabMedicineUnit.Margin = new Padding(3, 2, 3, 2);
            tabMedicineUnit.Name = "tabMedicineUnit";
            tabMedicineUnit.Padding = new Padding(3, 2, 3, 2);
            tabMedicineUnit.Size = new Size(1391, 627);
            tabMedicineUnit.TabIndex = 3;
            tabMedicineUnit.Text = "Unit";
            tabMedicineUnit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMedicineUnit
            // 
            dataGridViewMedicineUnit.AllowUserToAddRows = false;
            dataGridViewMedicineUnit.AllowUserToDeleteRows = false;
            dataGridViewMedicineUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedicineUnit.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMedicineUnit.BackgroundColor = Color.White;
            dataGridViewMedicineUnit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedicineUnit.ContextMenuStrip = contextMenuStripUnitGrid;
            dataGridViewMedicineUnit.Location = new Point(9, 50);
            dataGridViewMedicineUnit.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMedicineUnit.Name = "dataGridViewMedicineUnit";
            dataGridViewMedicineUnit.ReadOnly = true;
            dataGridViewMedicineUnit.RowHeadersWidth = 51;
            dataGridViewMedicineUnit.Size = new Size(1373, 570);
            dataGridViewMedicineUnit.TabIndex = 0;
            dataGridViewMedicineUnit.CellMouseClick += dataGridViewMedicineUnit_CellMouseClick;
            dataGridViewMedicineUnit.MouseClick += dataGridViewMedicineUnit_MouseClick;
            // 
            // contextMenuStripUnitGrid
            // 
            contextMenuStripUnitGrid.ImageScalingSize = new Size(20, 20);
            contextMenuStripUnitGrid.Items.AddRange(new ToolStripItem[] { updateMedicineToolStripMenuItem, deleteMedicineToolStripMenuItem });
            contextMenuStripUnitGrid.Name = "contextMenuStripUnitGrid";
            contextMenuStripUnitGrid.Size = new Size(159, 52);
            // 
            // updateMedicineToolStripMenuItem
            // 
            updateMedicineToolStripMenuItem.Name = "updateMedicineToolStripMenuItem";
            updateMedicineToolStripMenuItem.Size = new Size(158, 24);
            updateMedicineToolStripMenuItem.Text = "Update Unit";
            // 
            // deleteMedicineToolStripMenuItem
            // 
            deleteMedicineToolStripMenuItem.Name = "deleteMedicineToolStripMenuItem";
            deleteMedicineToolStripMenuItem.Size = new Size(158, 24);
            deleteMedicineToolStripMenuItem.Text = "Delete Unit";
            deleteMedicineToolStripMenuItem.Click += deleteMedicineToolStripMenuItem_Click;
            // 
            // btnRegisterUnit
            // 
            btnRegisterUnit.Location = new Point(9, 16);
            btnRegisterUnit.Margin = new Padding(3, 2, 3, 2);
            btnRegisterUnit.Name = "btnRegisterUnit";
            btnRegisterUnit.Size = new Size(121, 30);
            btnRegisterUnit.TabIndex = 3;
            btnRegisterUnit.Text = "Register";
            btnRegisterUnit.UseVisualStyleBackColor = true;
            btnRegisterUnit.Click += btnRegisterUnit_Click;
            // 
            // btnExportInventory
            // 
            btnExportInventory.Image = (Image)resources.GetObject("btnExportInventory.Image");
            btnExportInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportInventory.Location = new Point(1266, 21);
            btnExportInventory.Name = "btnExportInventory";
            btnExportInventory.Size = new Size(116, 29);
            btnExportInventory.TabIndex = 7;
            btnExportInventory.Text = "Export";
            btnExportInventory.UseVisualStyleBackColor = true;
            btnExportInventory.Click += btnExportInventory_Click;
            // 
            // frmMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 662);
            Controls.Add(tabControlMedicine);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMedicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicines";
            Load += frmMedicine_Load;
            tabControlMedicine.ResumeLayout(false);
            tabMedicine.ResumeLayout(false);
            tabMedicine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicine).EndInit();
            contextMenuStripMedGrid.ResumeLayout(false);
            tabMedicineType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicineType).EndInit();
            contextMenuStripType.ResumeLayout(false);
            tabCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicineCategory).EndInit();
            contextMenuStripCategory.ResumeLayout(false);
            tabMedicineUnit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicineUnit).EndInit();
            contextMenuStripUnitGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public TabControl tabControlMedicine;
        public TabPage tabMedicine;
        private Button btnRegisterMedicine;
        public DataGridView dataGridViewMedicine;
        private TabPage tabMedicineType;
        private Button btnRegisterType;
        public DataGridView dataGridViewMedicineType;
        private TabPage tabCategory;
        private Button btnRegisterCategory;
        public DataGridView dataGridViewMedicineCategory;
        private TabPage tabMedicineUnit;
        private Button btnRegisterUnit;
        public DataGridView dataGridViewMedicineUnit;
        private ContextMenuStrip contextMenuStripMedGrid;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ContextMenuStrip contextMenuStripUnitGrid;
        private ToolStripMenuItem updateMedicineToolStripMenuItem;
        private ToolStripMenuItem deleteMedicineToolStripMenuItem;
        private ContextMenuStrip contextMenuStripCategory;
        private ToolStripMenuItem updateCategoryToolStripMenuItem;
        private ToolStripMenuItem deleteCategoryToolStripMenuItem;
        private ContextMenuStrip contextMenuStripType;
        private ToolStripMenuItem updateTypeToolStripMenuItem;
        private ToolStripMenuItem deleteTypeToolStripMenuItem;
        private TextBox txtSearch;
        private Label label18;
        private Button btnExportInventory;
    }
}