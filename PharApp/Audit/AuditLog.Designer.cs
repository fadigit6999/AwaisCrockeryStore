namespace PharApp.Audit
{
    partial class AuditLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditLog));
            richTextBoxAditLogs = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxAditLogs
            // 
            richTextBoxAditLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxAditLogs.Location = new Point(2, 1);
            richTextBoxAditLogs.Name = "richTextBoxAditLogs";
            richTextBoxAditLogs.Size = new Size(801, 451);
            richTextBoxAditLogs.TabIndex = 0;
            richTextBoxAditLogs.Text = "";
            // 
            // AuditLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBoxAditLogs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AuditLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audit Logs";
            Load += AuditLog_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxAditLogs;
    }
}