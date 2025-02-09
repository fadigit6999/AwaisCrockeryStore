﻿namespace PharApp.Inventory
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
            btnExportInventory = new Button();
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
            updateUnitToolStripMenuItem = new ToolStripMenuItem();
            deleteMedicineToolStripMenuItem = new ToolStripMenuItem();
            btnRegisterUnit = new Button();
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
            tabControlMedicine.Location = new Point(2, 1);
            tabControlMedicine.Margin = new Padding(3, 2, 3, 2);
            tabControlMedicine.Name = "tabControlMedicine";
            tabControlMedicine.SelectedIndex = 0;
            tabControlMedicine.Size = new Size(1198, 494);
            tabControlMedicine.TabIndex = 0;
            // 
            // tabMedicine
            // 
            tabMedicine.Controls.Add(btnExportInventory);
            tabMedicine.Controls.Add(txtSearch);
            tabMedicine.Controls.Add(label18);
            tabMedicine.Controls.Add(dataGridViewMedicine);
            tabMedicine.Controls.Add(btnRegisterMedicine);
            tabMedicine.Location = new Point(4, 24);
            tabMedicine.Margin = new Padding(3, 2, 3, 2);
            tabMedicine.Name = "tabMedicine";
            tabMedicine.Padding = new Padding(3, 2, 3, 2);
            tabMedicine.Size = new Size(1190, 466);
            tabMedicine.TabIndex = 0;
            tabMedicine.Text = "Item";
            tabMedicine.UseVisualStyleBackColor = true;
            // 
            // btnExportInventory
            // 
            btnExportInventory.Image = (Image)resources.GetObject("btnExportInventory.Image");
            btnExportInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportInventory.Location = new Point(1078, 13);
            btnExportInventory.Margin = new Padding(3, 2, 3, 2);
            btnExportInventory.Name = "btnExportInventory";
            btnExportInventory.Size = new Size(102, 22);
            btnExportInventory.TabIndex = 7;
            btnExportInventory.Text = "Export";
            btnExportInventory.UseVisualStyleBackColor = true;
            btnExportInventory.Click += btnExportInventory_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(852, 13);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 23);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(800, 17);
            label18.Name = "label18";
            label18.Size = new Size(42, 15);
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
            dataGridViewMedicine.Location = new Point(0, 45);
            dataGridViewMedicine.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMedicine.Name = "dataGridViewMedicine";
            dataGridViewMedicine.ReadOnly = true;
            dataGridViewMedicine.RowHeadersWidth = 51;
            dataGridViewMedicine.Size = new Size(1190, 422);
            dataGridViewMedicine.TabIndex = 0;
            dataGridViewMedicine.CellMouseClick += dataGridViewMedicine_CellMouseClick;
            dataGridViewMedicine.MouseClick += dataGridViewMedicine_MouseClick;
            // 
            // contextMenuStripMedGrid
            // 
            contextMenuStripMedGrid.ImageScalingSize = new Size(20, 20);
            contextMenuStripMedGrid.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, deleteToolStripMenuItem1 });
            contextMenuStripMedGrid.Name = "contextMenuStripMedGrid";
            contextMenuStripMedGrid.Size = new Size(165, 48);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(164, 22);
            deleteToolStripMenuItem.Text = "Update Medicine";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(164, 22);
            deleteToolStripMenuItem1.Text = "Delete Medicine";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // btnRegisterMedicine
            // 
            btnRegisterMedicine.Location = new Point(11, 14);
            btnRegisterMedicine.Margin = new Padding(3, 2, 3, 2);
            btnRegisterMedicine.Name = "btnRegisterMedicine";
            btnRegisterMedicine.Size = new Size(106, 22);
            btnRegisterMedicine.TabIndex = 1;
            btnRegisterMedicine.Text = "Register";
            btnRegisterMedicine.UseVisualStyleBackColor = true;
            btnRegisterMedicine.Click += btnRegisterMedicine_Click;
            // 
            // tabMedicineType
            // 
            tabMedicineType.Controls.Add(dataGridViewMedicineType);
            tabMedicineType.Controls.Add(btnRegisterType);
            tabMedicineType.Location = new Point(4, 24);
            tabMedicineType.Margin = new Padding(3, 2, 3, 2);
            tabMedicineType.Name = "tabMedicineType";
            tabMedicineType.Padding = new Padding(3, 2, 3, 2);
            tabMedicineType.Size = new Size(1190, 466);
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
            dataGridViewMedicineType.Location = new Point(5, 42);
            dataGridViewMedicineType.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMedicineType.Name = "dataGridViewMedicineType";
            dataGridViewMedicineType.ReadOnly = true;
            dataGridViewMedicineType.RowHeadersWidth = 51;
            dataGridViewMedicineType.Size = new Size(1185, 426);
            dataGridViewMedicineType.TabIndex = 0;
            dataGridViewMedicineType.MouseClick += dataGridViewMedicineType_MouseClick;
            // 
            // contextMenuStripType
            // 
            contextMenuStripType.ImageScalingSize = new Size(20, 20);
            contextMenuStripType.Items.AddRange(new ToolStripItem[] { updateTypeToolStripMenuItem, deleteTypeToolStripMenuItem });
            contextMenuStripType.Name = "contextMenuStripType";
            contextMenuStripType.Size = new Size(181, 70);
            // 
            // updateTypeToolStripMenuItem
            // 
            updateTypeToolStripMenuItem.Name = "updateTypeToolStripMenuItem";
            updateTypeToolStripMenuItem.Size = new Size(180, 22);
            updateTypeToolStripMenuItem.Text = "Update Type";
            updateTypeToolStripMenuItem.Click += updateTypeToolStripMenuItem_Click;
            // 
            // deleteTypeToolStripMenuItem
            // 
            deleteTypeToolStripMenuItem.Name = "deleteTypeToolStripMenuItem";
            deleteTypeToolStripMenuItem.Size = new Size(180, 22);
            deleteTypeToolStripMenuItem.Text = "Delete Type";
            deleteTypeToolStripMenuItem.Click += deleteTypeToolStripMenuItem_Click;
            // 
            // btnRegisterType
            // 
            btnRegisterType.Location = new Point(14, 10);
            btnRegisterType.Margin = new Padding(3, 2, 3, 2);
            btnRegisterType.Name = "btnRegisterType";
            btnRegisterType.Size = new Size(106, 22);
            btnRegisterType.TabIndex = 2;
            btnRegisterType.Text = "Register";
            btnRegisterType.UseVisualStyleBackColor = true;
            btnRegisterType.Click += btnRegisterType_Click;
            // 
            // tabCategory
            // 
            tabCategory.Controls.Add(dataGridViewMedicineCategory);
            tabCategory.Controls.Add(btnRegisterCategory);
            tabCategory.Location = new Point(4, 24);
            tabCategory.Margin = new Padding(3, 2, 3, 2);
            tabCategory.Name = "tabCategory";
            tabCategory.Padding = new Padding(3, 2, 3, 2);
            tabCategory.Size = new Size(1190, 466);
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
            dataGridViewMedicineCategory.Location = new Point(2, 46);
            dataGridViewMedicineCategory.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMedicineCategory.Name = "dataGridViewMedicineCategory";
            dataGridViewMedicineCategory.ReadOnly = true;
            dataGridViewMedicineCategory.RowHeadersWidth = 51;
            dataGridViewMedicineCategory.Size = new Size(1185, 420);
            dataGridViewMedicineCategory.TabIndex = 0;
            dataGridViewMedicineCategory.MouseClick += dataGridViewMedicineCategory_MouseClick;
            // 
            // contextMenuStripCategory
            // 
            contextMenuStripCategory.ImageScalingSize = new Size(20, 20);
            contextMenuStripCategory.Items.AddRange(new ToolStripItem[] { updateCategoryToolStripMenuItem, deleteCategoryToolStripMenuItem });
            contextMenuStripCategory.Name = "contextMenuStripCategory";
            contextMenuStripCategory.Size = new Size(164, 48);
            // 
            // updateCategoryToolStripMenuItem
            // 
            updateCategoryToolStripMenuItem.Name = "updateCategoryToolStripMenuItem";
            updateCategoryToolStripMenuItem.Size = new Size(163, 22);
            updateCategoryToolStripMenuItem.Text = "Update Category";
            updateCategoryToolStripMenuItem.Click += updateCategoryToolStripMenuItem_Click;
            // 
            // deleteCategoryToolStripMenuItem
            // 
            deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            deleteCategoryToolStripMenuItem.Size = new Size(163, 22);
            deleteCategoryToolStripMenuItem.Text = "Delete Category";
            deleteCategoryToolStripMenuItem.Click += deleteCategoryToolStripMenuItem_Click;
            // 
            // btnRegisterCategory
            // 
            btnRegisterCategory.Location = new Point(8, 14);
            btnRegisterCategory.Margin = new Padding(3, 2, 3, 2);
            btnRegisterCategory.Name = "btnRegisterCategory";
            btnRegisterCategory.Size = new Size(106, 22);
            btnRegisterCategory.TabIndex = 2;
            btnRegisterCategory.Text = "Register";
            btnRegisterCategory.UseVisualStyleBackColor = true;
            btnRegisterCategory.Click += btnRegisterCategory_Click;
            // 
            // tabMedicineUnit
            // 
            tabMedicineUnit.Controls.Add(dataGridViewMedicineUnit);
            tabMedicineUnit.Controls.Add(btnRegisterUnit);
            tabMedicineUnit.Location = new Point(4, 24);
            tabMedicineUnit.Margin = new Padding(3, 2, 3, 2);
            tabMedicineUnit.Name = "tabMedicineUnit";
            tabMedicineUnit.Padding = new Padding(3, 2, 3, 2);
            tabMedicineUnit.Size = new Size(1190, 466);
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
            dataGridViewMedicineUnit.Location = new Point(0, 37);
            dataGridViewMedicineUnit.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMedicineUnit.Name = "dataGridViewMedicineUnit";
            dataGridViewMedicineUnit.ReadOnly = true;
            dataGridViewMedicineUnit.RowHeadersWidth = 51;
            dataGridViewMedicineUnit.Size = new Size(1190, 429);
            dataGridViewMedicineUnit.TabIndex = 0;
            dataGridViewMedicineUnit.CellMouseClick += dataGridViewMedicineUnit_CellMouseClick;
            dataGridViewMedicineUnit.MouseClick += dataGridViewMedicineUnit_MouseClick;
            // 
            // contextMenuStripUnitGrid
            // 
            contextMenuStripUnitGrid.ImageScalingSize = new Size(20, 20);
            contextMenuStripUnitGrid.Items.AddRange(new ToolStripItem[] { updateUnitToolStripMenuItem, deleteMedicineToolStripMenuItem });
            contextMenuStripUnitGrid.Name = "contextMenuStripUnitGrid";
            contextMenuStripUnitGrid.Size = new Size(138, 48);
            // 
            // updateUnitToolStripMenuItem
            // 
            updateUnitToolStripMenuItem.Name = "updateUnitToolStripMenuItem";
            updateUnitToolStripMenuItem.Size = new Size(137, 22);
            updateUnitToolStripMenuItem.Text = "Update Unit";
            updateUnitToolStripMenuItem.Click += updateUnitToolStripMenuItem_Click;
            // 
            // deleteMedicineToolStripMenuItem
            // 
            deleteMedicineToolStripMenuItem.Name = "deleteMedicineToolStripMenuItem";
            deleteMedicineToolStripMenuItem.Size = new Size(137, 22);
            deleteMedicineToolStripMenuItem.Text = "Delete Unit";
            deleteMedicineToolStripMenuItem.Click += deleteMedicineToolStripMenuItem_Click;
            // 
            // btnRegisterUnit
            // 
            btnRegisterUnit.Location = new Point(8, 9);
            btnRegisterUnit.Margin = new Padding(3, 2, 3, 2);
            btnRegisterUnit.Name = "btnRegisterUnit";
            btnRegisterUnit.Size = new Size(106, 22);
            btnRegisterUnit.TabIndex = 3;
            btnRegisterUnit.Text = "Register";
            btnRegisterUnit.UseVisualStyleBackColor = true;
            btnRegisterUnit.Click += btnRegisterUnit_Click;
            // 
            // frmMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 496);
            Controls.Add(tabControlMedicine);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMedicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
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
        private ToolStripMenuItem updateUnitToolStripMenuItem;
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