namespace PharApp.Inventory
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            dataGridViewStock = new DataGridView();
            txtSearch = new TextBox();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStock
            // 
            dataGridViewStock.AllowUserToAddRows = false;
            dataGridViewStock.AllowUserToDeleteRows = false;
            dataGridViewStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewStock.BackgroundColor = Color.White;
            dataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStock.Location = new Point(0, 45);
            dataGridViewStock.Name = "dataGridViewStock";
            dataGridViewStock.ReadOnly = true;
            dataGridViewStock.RowHeadersWidth = 51;
            dataGridViewStock.Size = new Size(1124, 594);
            dataGridViewStock.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(67, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(252, 27);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(8, 15);
            label18.Name = "label18";
            label18.Size = new Size(53, 20);
            label18.TabIndex = 7;
            label18.Text = "Search";
            // 
            // frmStock
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1126, 639);
            Controls.Add(txtSearch);
            Controls.Add(label18);
            Controls.Add(dataGridViewStock);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock";
            Load += frmStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewStock;
        private TextBox txtSearch;
        private Label label18;
    }
}