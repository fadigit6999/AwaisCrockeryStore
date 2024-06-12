using PharApp.WinHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace PharApp.Users
{
    public partial class frmRegisterUser : Form
    {
        private readonly string _login = null;
        public frmRegisterUser(string login = null)
        {
            InitializeComponent();
            _login = login;
        }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {
            txtFristName.Focus();
        }

        // Method to register a new user
        private async void RegisterUser()
        {
            // Get values from text boxes
            string firstName = txtFristName.Text;
            string lastName = txtLastName.Text;
            string userName = txtUsername.Text;
            string email = txtEmail.Text;
            string phoneNo = txtPhoneno.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phoneNo) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Check if passwords match
            if (!Helper.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Helper.ValidatePassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character (e.g., !@#$%^&*()). Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Optionally, clear the text boxes after registration
            ClearTextBoxes();
            var userBal = new User(Helper.GetConnectionStringFromSettings());
            int success = await userBal.CreateUserAsync(firstName, lastName, userName, email, await PasswordHashEncryption.EncryptPasswordHash(password), phoneNo, true, true, false, false, 0, DateTime.UtcNow);
            if (success == 1)
            {
                if (_login is not null)
                {
                    // Inform the user that registration was successful
                    MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var frm = new frmLogin();
                    frm.ShowDialog();
                }
                else
                {
                    // Inform the user that registration was successful
                    MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("User registration failed. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to clear all text boxes
        private void ClearTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        // Event handler for the register button click
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                // If password is currently in plain text mode, switch to asterisks mode
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
            else
            {
                // If password is currently in asterisks mode, switch to plain text mode
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = Helper.GeneratePassword(8);
            txtConfirmPassword.Text = txtPassword.Text.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
