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
            tabManufactured.SuspendLayout();
            tabManageManufacturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManufacturer).BeginInit();
            contextMenuStripManufac.SuspendLayout();
            SuspendLayout();
            // 
            // tabManufactured
            // 
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
            contextMenuStripManufac.Size = new Size(181, 70);
            // 
            // updateManufToolStripMenuItem
            // 
            updateManufToolStripMenuItem.Name = "updateManufToolStripMenuItem";
            updateManufToolStripMenuItem.Size = new Size(180, 22);
            updateManufToolStripMenuItem.Text = "Update Mfg";
            updateManufToolStripMenuItem.Click += updateManufToolStripMenuItem_Click;
            // 
            // deleteManufToolStripMenuItem
            // 
            deleteManufToolStripMenuItem.Name = "deleteManufToolStripMenuItem";
            deleteManufToolStripMenuItem.Size = new Size(180, 22);
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
            // frmManufacturer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabManufactured);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmManufacturer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manufacturer";
            tabManufactured.ResumeLayout(false);
            tabManageManufacturer.ResumeLayout(false);
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
    }
}