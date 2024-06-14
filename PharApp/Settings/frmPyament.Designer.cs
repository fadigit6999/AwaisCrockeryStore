namespace PharApp.Settings
{
    partial class frmPyament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPyament));
            label1 = new Label();
            label2 = new Label();
            txtPaymentType = new TextBox();
            dataGridViewPaymentType = new DataGridView();
            contextMenuStripPaymentType = new ContextMenuStrip(components);
            updatePayTypeToolStripMenuItem = new ToolStripMenuItem();
            deletePayTypeToolStripMenuItem = new ToolStripMenuItem();
            btnRegisterPaymentType = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaymentType).BeginInit();
            contextMenuStripPaymentType.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(4, 5);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "Payment Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 33);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // txtPaymentType
            // 
            txtPaymentType.Location = new Point(10, 50);
            txtPaymentType.Margin = new Padding(3, 2, 3, 2);
            txtPaymentType.Name = "txtPaymentType";
            txtPaymentType.Size = new Size(225, 23);
            txtPaymentType.TabIndex = 1;
            // 
            // dataGridViewPaymentType
            // 
            dataGridViewPaymentType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPaymentType.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPaymentType.BackgroundColor = Color.White;
            dataGridViewPaymentType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPaymentType.ContextMenuStrip = contextMenuStripPaymentType;
            dataGridViewPaymentType.Location = new Point(10, 79);
            dataGridViewPaymentType.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPaymentType.Name = "dataGridViewPaymentType";
            dataGridViewPaymentType.RowHeadersWidth = 51;
            dataGridViewPaymentType.Size = new Size(728, 282);
            dataGridViewPaymentType.TabIndex = 3;
            dataGridViewPaymentType.MouseClick += dataGridViewPaymentType_MouseClick;
            // 
            // contextMenuStripPaymentType
            // 
            contextMenuStripPaymentType.ImageScalingSize = new Size(20, 20);
            contextMenuStripPaymentType.Items.AddRange(new ToolStripItem[] { updatePayTypeToolStripMenuItem, deletePayTypeToolStripMenuItem });
            contextMenuStripPaymentType.Name = "contextMenuStripPaymentType";
            contextMenuStripPaymentType.Size = new Size(159, 48);
            // 
            // updatePayTypeToolStripMenuItem
            // 
            updatePayTypeToolStripMenuItem.Name = "updatePayTypeToolStripMenuItem";
            updatePayTypeToolStripMenuItem.Size = new Size(158, 22);
            updatePayTypeToolStripMenuItem.Text = "Update PayType";
            // 
            // deletePayTypeToolStripMenuItem
            // 
            deletePayTypeToolStripMenuItem.Name = "deletePayTypeToolStripMenuItem";
            deletePayTypeToolStripMenuItem.Size = new Size(158, 22);
            deletePayTypeToolStripMenuItem.Text = "Delete PayType";
            deletePayTypeToolStripMenuItem.Click += deletePayTypeToolStripMenuItem_Click;
            // 
            // btnRegisterPaymentType
            // 
            btnRegisterPaymentType.Location = new Point(248, 49);
            btnRegisterPaymentType.Margin = new Padding(3, 2, 3, 2);
            btnRegisterPaymentType.Name = "btnRegisterPaymentType";
            btnRegisterPaymentType.Size = new Size(120, 25);
            btnRegisterPaymentType.TabIndex = 2;
            btnRegisterPaymentType.Text = "Register";
            btnRegisterPaymentType.UseVisualStyleBackColor = true;
            btnRegisterPaymentType.Click += btnRegisterPaymentType_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(710, 7);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 22);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmPyament
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 370);
            Controls.Add(btnClose);
            Controls.Add(btnRegisterPaymentType);
            Controls.Add(dataGridViewPaymentType);
            Controls.Add(txtPaymentType);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPyament";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment Type";
            Load += frmPyament_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaymentType).EndInit();
            contextMenuStripPaymentType.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPaymentType;
        private DataGridView dataGridViewPaymentType;
        private Button btnRegisterPaymentType;
        private ContextMenuStrip contextMenuStripPaymentType;
        private ToolStripMenuItem updatePayTypeToolStripMenuItem;
        private ToolStripMenuItem deletePayTypeToolStripMenuItem;
        private Button btnClose;
    }
}