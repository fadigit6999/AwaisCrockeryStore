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
            groupBox1.Location = new Point(108, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(318, 77);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Backup";
            // 
            // btnFolder
            // 
            btnFolder.Location = new Point(137, 44);
            btnFolder.Margin = new Padding(3, 2, 3, 2);
            btnFolder.Name = "btnFolder";
            btnFolder.Size = new Size(175, 22);
            btnFolder.TabIndex = 1;
            btnFolder.Text = "See Backup Files";
            btnFolder.UseVisualStyleBackColor = true;
            btnFolder.Click += btnFolder_Click;
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(5, 44);
            btnBackup.Margin = new Padding(3, 2, 3, 2);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(127, 22);
            btnBackup.TabIndex = 1;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnDialogueBox
            // 
            btnDialogueBox.Location = new Point(281, 19);
            btnDialogueBox.Margin = new Padding(3, 2, 3, 2);
            btnDialogueBox.Name = "btnDialogueBox";
            btnDialogueBox.Size = new Size(32, 22);
            btnDialogueBox.TabIndex = 1;
            btnDialogueBox.Text = "..";
            btnDialogueBox.UseVisualStyleBackColor = true;
            btnDialogueBox.Click += btnDialogueBox_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(5, 20);
            txtFolderPath.Margin = new Padding(3, 2, 3, 2);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.ReadOnly = true;
            txtFolderPath.Size = new Size(274, 23);
            txtFolderPath.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmManualBackup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 99);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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