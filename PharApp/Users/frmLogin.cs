using PharApp.Main;
using PharApp.Settings;
using PharApp.WinHelper;
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

namespace PharApp.Users
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private int failedLoginAttempts = 0;

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Check if username and password fields are not empty
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password to log in.");
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                // Instantiate the User BAL
                var userBAL = new BAL.User(Helper.GetConnectionStringFromSettings());

                // Retrieve user credentials from the database
                var (retrievedUsername, encryptedPassword) = await userBAL.GetUserCredentialsByUsernameAsync(username);

                try
                {
                    // Decrypt the retrieved encrypted password
                    string decryptedPassword = await PasswordHashEncryption.DecryptPasswordHash(encryptedPassword);

                    // Check if retrieved username and decrypted password match the entered credentials
                    if (retrievedUsername != null && decryptedPassword == password)
                    {
                        if (Convert.ToDateTime(Properties.Settings.Default.Lisence) > DateTime.Today)
                        {
                            if (string.IsNullOrEmpty(Properties.Settings.Default.UserUsername) && string.IsNullOrEmpty(Properties.Settings.Default.UserPassword.ToString()))
                            {

                                // If credentials are valid, open the main form and reset failed login attempts
                                if (checkBoxSavePassword.Checked == true)
                                {

                                    Properties.Settings.Default.UserUsername = txtUsername.Text.ToString();
                                    Properties.Settings.Default.UserPassword = encryptedPassword.ToString();
                                    Properties.Settings.Default.UserPassExpiry = DateTime.Today.AddDays(30).ToString();
                                    Properties.Settings.Default.Save();
                                }
                            }
                            BML.UserSession.User = await Helper.GetUserRole(txtUsername.Text.ToLower().ToString());
                            frmMain mainForm = new frmMain();
                            mainForm.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Licnese has been out dated please contact with Developer Team!");
                        }
                        failedLoginAttempts = 0;
                    }
                    else
                    {
                        // If credentials are invalid, increment failed login attempts
                        failedLoginAttempts++;

                        // If failed attempts reach a threshold, prompt the user to contact the admin
                        if (failedLoginAttempts >= 3)
                        {
                            MessageBox.Show("You have made multiple unsuccessful login attempts. Please contact the administrator for assistance.");
                        }
                        else
                        {
                            // If failed attempts are below the threshold, display a generic error message
                            MessageBox.Show("Invalid username or password. Please verify your credentials and try again.");
                        }
                    }
                }
                catch (ArgumentNullException)
                {
                    // Handle decryption failure due to null value (invalid encrypted password)
                    MessageBox.Show("An error occurred during login. Please try again or contact the administrator for assistance.");
                }
            }
            catch (Exception ex)
            {
                // Handle any other exceptions that occur during the login process
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private async void frmLogin_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.Lisence))
            {
                Properties.Settings.Default.Lisence = DateTime.Now.AddDays(40).ToString();
            }
            CheckAndOpenFormBasedOnDatabaseConnection();
            var userBal = new BAL.User(Helper.GetConnectionStringFromSettings());

            var users = await userBal.ReadUserAsync();

            if (users == null || users.Count < 1)
            {
                this.Hide();
                var frm = new frmRegisterUser(null,"login");
                frm.ShowDialog();
            }
            else
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.UserUsername) && !string.IsNullOrEmpty(Properties.Settings.Default.UserPassword.ToString()))
                {
                    if (Convert.ToDateTime(Properties.Settings.Default.UserPassExpiry.ToString()) > DateTime.Today  )
                    {
                        txtUsername.Text = Properties.Settings.Default.UserUsername.ToString();
                        string decryptedPassword = await PasswordHashEncryption.DecryptPasswordHash(Properties.Settings.Default.UserPassword.ToString());
                        txtPassword.Text = decryptedPassword;
                        checkBoxSavePassword.Checked = true;
                    }
                    else
                    {
                        Properties.Settings.Default.UserUsername = null;
                        Properties.Settings.Default.UserPassword = null;
                        Properties.Settings.Default.UserPassExpiry = null;
                        Properties.Settings.Default.Save();
                    }
                }
            }

        }

        private void CheckAndOpenFormBasedOnDatabaseConnection()
        {
            string connectionString = Helper.GetConnectionStringFromSettings();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Database connection failed, open the form to enter connection settings
                OpenDesiredForm();
            }
        }

        private void OpenDesiredForm()
        {
            OpenDatabaseConfigForm();
        }

        private void OpenDatabaseConfigForm()
        {
            // Open the form to enter database connection information
            frmDbConfig config = new frmDbConfig();
            config.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDatabaseCheck_Click(object sender, EventArgs e)
        {
            frmDbConfig config = new frmDbConfig();
            config.ShowDialog();
        }
    }
}
