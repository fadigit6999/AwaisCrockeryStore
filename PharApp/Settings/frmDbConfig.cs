using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharApp.Main;
using PharApp.Settings;
using PharApp.WinHelper;

namespace PharApp.Settings
{
    public partial class frmDbConfig : Form
    {
        public frmDbConfig()
        {
            InitializeComponent();
            CheckValues();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtServer.Text) || string.IsNullOrWhiteSpace(txtDatabase.Text))
            {
                MessageBox.Show("Please fill in server and database fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // If not using Windows authentication, validate username and password
            if (!chkWindowsAuth.Checked && (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)))
            {
                MessageBox.Show("Please fill in username and password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveDatabaseSettings()
        {
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            Properties.Settings.Default.UseWindowsAuth = chkWindowsAuth.Checked ? "true" : "false";
            Properties.Settings.Default.Username = txtUsername.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void CheckValues()
        {
            // Check if the Server property is already set
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.Server))
            {
                txtServer.Text = Properties.Settings.Default.Server;
            }

            // Check if the Database property is already set
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.Database))
            {
                txtDatabase.Text = Properties.Settings.Default.Database;
            }

            // Check if the UseWindowsAuth property is already set
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.UseWindowsAuth))
            {
                chkWindowsAuth.Checked = Properties.Settings.Default.UseWindowsAuth == "true";
            }

            // Check if the Username property is already set
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.Username))
            {
                txtUsername.Text = Properties.Settings.Default.Username;
            }

            // Check if the Password property is already set
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.Password))
            {
                txtPassword.Text = Properties.Settings.Default.Password;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            bool windowsAuthChecked = chkWindowsAuth.Checked;

            txtUsername.Enabled = !windowsAuthChecked;
            txtPassword.Enabled = !windowsAuthChecked;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (ValidateInput() && TestConnection())
            {
                Helper.Log("Database Connection Created: " + " ," + txtServer.Text + " ," + txtDatabase.Text);
                SaveDatabaseSettings();
                MessageBox.Show("Database settings saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private string GetConnectionString()
        {
            string server = txtServer.Text;
            string database = txtDatabase.Text;
            string windowsAuth = chkWindowsAuth.Checked ? "True" : "False";
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Build the connection string based on user input
            if (chkWindowsAuth.Checked)
            {
                return $"Server={server};Database={database};Integrated Security=True;";
            }
            else
            {
                return $"Server={server};Database={database};User ID={username};Password={password};";
            }
        }
        private bool TestConnection()
        {
            try
            {
                string connectionString = GetConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = null;
            Properties.Settings.Default.Database = null;
            Properties.Settings.Default.UseWindowsAuth = chkWindowsAuth.Checked ? "true" : "false";
            Properties.Settings.Default.Username = null;
            Properties.Settings.Default.Password = null;
            Properties.Settings.Default.Save();

            MessageBox.Show("Configuartion Clear successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Close();

            var frm = new frmDbConfig();
            frm.ShowDialog();
        }
    }
}
