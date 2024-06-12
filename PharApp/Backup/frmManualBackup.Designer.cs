namespace PharApp.Backup
{
    partial class frmManualBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManualBackup));
            groupBox1 = new GroupBox();
            btnFolder = new Button();
            btnBackup = new Button();
            btnDialogueBox = new Button();
            txtFolderPath = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnFolder);
            groupBox1.Controls.Add(btnBackup);
            groupBox1.Controls.Add(btnDialogueBox);
            groupBox1.Controls.Add(txtFolderPath);
            groupBox1.Location = new Point(124, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 103);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Backup";
            // 
            // btnFolder
            // 
            btnFolder.Location = new Point(157, 59);
            btnFolder.Name = "btnFolder";
            btnFolder.Size = new Size(200, 29);
            btnFolder.TabIndex = 1;
            btnFolder.Text = "See Backup Files";
            btnFolder.UseVisualStyleBackColor = true;
            btnFolder.Click += btnFolder_Click;
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(6, 59);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(145, 29);
            btnBackup.TabIndex = 1;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnDialogueBox
            // 
            btnDialogueBox.Location = new Point(321, 25);
            btnDialogueBox.Name = "btnDialogueBox";
            btnDialogueBox.Size = new Size(36, 29);
            btnDialogueBox.TabIndex = 1;
            btnDialogueBox.Text = "..";
            btnDialogueBox.UseVisualStyleBackColor = true;
            btnDialogueBox.Click += btnDialogueBox_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(6, 26);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.ReadOnly = true;
            txtFolderPath.Size = new Size(313, 27);
            txtFolderPath.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmManualBackup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 132);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmManualBackup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manual Backup";
            Load += frmManualBackup_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button btnBackup;
        private Button btnDialogueBox;
        private TextBox txtFolderPath;
        private Button btnFolder;
    }
}