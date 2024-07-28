using BAL;
using BML;
using DAL;
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

namespace PharApp.Users
{
    public partial class FrmAssignUserRole : Form
    {
        private frmManageUsers _frmManageUsers;
        private readonly string _userId = null;
        public FrmAssignUserRole(Form frm = null, string userId = null)
        {
            InitializeComponent();
            _frmManageUsers = frm as frmManageUsers;
            _userId = userId;
        }

        private void btnRegisterRole_Click(object sender, EventArgs e)
        {
            RegisterUserRole();
        }

        private void frmRegisterRole_Load(object sender, EventArgs e)
        {
            PopulateComboBoxRole();
        }

        private async void PopulateComboBoxRole()
        {
            try
            {
                var cmbRoleBal = new BAL.UserRoles(Helper.GetConnectionStringFromSettings());
                var cmbRoleList = await cmbRoleBal.ReadUserRolesAsync();

                // Create a dictionary to hold the category names and IDs
                Dictionary<string, string> unitDictionary = new Dictionary<string, string>();
                unitDictionary.Add("Choose Role", Guid.NewGuid().ToString());
                // Populate the dictionary with category names and IDs
                foreach (var role in cmbRoleList)
                {
                    unitDictionary.Add(role.Name, role.Id);
                }

                // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                cmbRole.DataSource = new BindingSource(unitDictionary, null);
                cmbRole.DisplayMember = "Key"; // Display category names
                cmbRole.ValueMember = "Value"; // Use category IDs as values
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or show error message
                MessageBox.Show($"Error while populating Unit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to register a new user
        private async void RegisterUserRole()
        {
            if (ValidateInput())
            {
                var userBal = new UserRoles(Helper.GetConnectionStringFromSettings());
                int success = await userBal.AssignUserRoleAsync(_userId, cmbRole.SelectedValue.ToString());
                if (success == 1)
                {
                    // Inform the user that registration was successful
                    await LoadUsersAsync();
                    MessageBox.Show("User Role Assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User Role Assignment failed. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(cmbRole.Text) || cmbRole.Text == "Choose Role" || cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select role for the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validation passed
            return true;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
