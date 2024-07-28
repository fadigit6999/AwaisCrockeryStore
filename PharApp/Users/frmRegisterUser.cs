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
using PharApp.Customer;

namespace PharApp.Users
{
    public partial class frmRegisterUser : Form
    {
        public frmManageUsers _frmManageUsers = null;
        private readonly string _login = null;
        public frmRegisterUser(Form frm = null, string login = null)
        {
            InitializeComponent();
            if (frm is not null)
            {
                _frmManageUsers = frm as frmManageUsers;
            }
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
                    LoadUsersAsync();
                    MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var frm = new frmLogin();
                    frm.ShowDialog();
                }
                else
                {
                    // Inform the user that registration was successful
                    MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsersAsync();
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

        private async Task LoadUsersAsync()
        {
            try
            {
                var userBAL = new BAL.User(Helper.GetConnectionStringFromSettings());
                var _userList = await userBAL.ReadUserAsync();
                _frmManageUsers.registeredUserGrid.DataSource = _userList;
                _frmManageUsers.registeredUserGrid.Columns["AccessFailedCount"].Visible = false;
                _frmManageUsers.registeredUserGrid.Columns["NormalizedUserName"].Visible = false;
                _frmManageUsers.registeredUserGrid.Columns["NormalizedEmail"].Visible = false;
                _frmManageUsers.registeredUserGrid.Columns["PasswordHash"].Visible = false;
                _frmManageUsers.registeredUserGrid.Columns["SecurityStamp"].Visible = false;
                _frmManageUsers.registeredUserGrid.Columns["ConcurrencyStamp"].Visible = false;
                _frmManageUsers.registeredUserGrid.Columns["PhoneNumberConfirmed"].Visible = false;
                _frmManageUsers.registeredUserGrid.Columns["TwoFactorEnabled"].Visible = false;
                _frmManageUsers.registeredUserGrid.Columns["LockoutEnd"].Visible = false;
                _frmManageUsers.registeredUserGrid.Columns["LockoutEnabled"].Visible = false;
                _frmManageUsers.registeredUserGrid.Columns["EmailConfirmed"].Visible = false;

                _frmManageUsers.registeredUserGrid.Columns["Id"].HeaderText = "User Id";
                _frmManageUsers.registeredUserGrid.Columns["FirstName"].HeaderText = "First Name";
                _frmManageUsers.registeredUserGrid.Columns["LastName"].HeaderText = "Last Name";
                _frmManageUsers.registeredUserGrid.Columns["DateCreated"].HeaderText = "Reg. Date";
                _frmManageUsers.registeredUserGrid.Columns["UserName"].HeaderText = "Username";
                _frmManageUsers.registeredUserGrid.Columns["Email"].HeaderText = "Email";
                _frmManageUsers.registeredUserGrid.Columns["PhoneNumber"].HeaderText = "Phone No";
                _frmManageUsers.registeredUserGrid.Columns["UserRole"].HeaderText = "Role";

                _frmManageUsers.registeredUserGrid.Columns["Id"].DisplayIndex = 0;
                _frmManageUsers.registeredUserGrid.Columns["FirstName"].DisplayIndex = 1;
                _frmManageUsers.registeredUserGrid.Columns["LastName"].DisplayIndex = 2;
                _frmManageUsers.registeredUserGrid.Columns["DateCreated"].DisplayIndex = 6;
                _frmManageUsers.registeredUserGrid.Columns["UserName"].DisplayIndex = 3;
                _frmManageUsers.registeredUserGrid.Columns["Email"].DisplayIndex = 4;
                _frmManageUsers.registeredUserGrid.Columns["Status"].DisplayIndex = 7;
                _frmManageUsers.registeredUserGrid.Columns["PhoneNumber"].DisplayIndex = 5;
                _frmManageUsers.registeredUserGrid.Columns["UserRole"].DisplayIndex = 8;

                _frmManageUsers.registeredUserGrid.Columns["DateCreated"].DefaultCellStyle.Format = "dd/MM/yyyy";

                _frmManageUsers.registeredUserGrid.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading users: {ex.Message}");
            }
        }
    }
}
