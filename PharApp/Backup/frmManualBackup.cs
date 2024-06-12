using PharApp.WinHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharApp.Backup
{
    public partial class frmManualBackup : Form
    {
        public frmManualBackup()
        {
            InitializeComponent();
        }

        private void btnDialogueBox_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select the folder where you want to save the backup.";
                folderBrowserDialog.ShowNewFolderButton = true;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolderPath.Text = folderBrowserDialog.SelectedPath;
                    Properties.Settings.Default.BackupPath = txtFolderPath.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void PerformBackup(string folderPath, string databaseName, string connectionString)
        {
            try
            {
                string backupFilePath = Path.Combine(folderPath, $"{databaseName}_{DateTime.Now:yyyyMMdd_HHmmss}.bak");
                string sqlCmdScript = $"BACKUP DATABASE [{databaseName}] TO DISK = '{backupFilePath}' WITH FORMAT, INIT, SKIP, NOREWIND, NOUNLOAD, STATS = 10";

                // Write the backup command to a temporary SQL script file
                string tempSqlFilePath = Path.Combine(Path.GetTempPath(), "BackupScript.sql");
                File.WriteAllText(tempSqlFilePath, sqlCmdScript);

                string sqlCmdText = $"/C sqlcmd -S {Properties.Settings.Default.Server.ToString()} -E -i \"{tempSqlFilePath}\"";

                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", sqlCmdText)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process proc = new Process())
                {
                    proc.StartInfo = procStartInfo;
                    proc.Start();

                    string output = proc.StandardOutput.ReadToEnd();
                    string error = proc.StandardError.ReadToEnd();
                    proc.WaitForExit();

                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show($"Error during backup: {error}");
                    }
                    else
                    {
                        MessageBox.Show("Backup completed successfully.\n" + output);
                    }
                }

                // Clean up the temporary SQL script file
                if (File.Exists(tempSqlFilePath))
                {
                    File.Delete(tempSqlFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception during backup: {ex.Message}");
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string folderPath = txtFolderPath.Text;
            string databaseName = Properties.Settings.Default.Database.ToString();
            if (string.IsNullOrEmpty(databaseName))
            {
                MessageBox.Show("Database name not present!");
                return;
            }
            string connectionString = Helper.GetConnectionStringFromSettings(); // Update with actual connection string

            if (Directory.Exists(folderPath))
            {
                PerformBackup(folderPath, databaseName, connectionString);
            }
            else
            {
                MessageBox.Show("Invalid folder path.");
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            string folderPath = txtFolderPath.Text.Trim(); // Trim to remove leading/trailing spaces

            if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("Folder path is empty or does not exist.");
            }
        }

        private void frmManualBackup_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.BackupPath))
            {
                txtFolderPath.Text = Properties.Settings.Default.BackupPath.ToString();
            }
        }
    }
}
