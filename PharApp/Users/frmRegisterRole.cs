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
    public partial class frmRegisterRole : Form
    {
        private frmManageUsers _frmManageUsers;
        private List<AspNetRole> _userRolesList;

        public IReadOnlyList<AspNetRole> UserRolesList => _userRolesList.AsReadOnly();

        public frmRegisterRole()
        {
            InitializeComponent();
            _frmManageUsers = new frmManageUsers();
            _userRolesList = new List<AspNetRole>();
        }

        private void btnRegisterRole_Click(object sender, EventArgs e)
        {
            RegisterUserRole();
        }

        private void frmRegisterRole_Load(object sender, EventArgs e)
        {

        }

        // Method to register a new user
        private async void RegisterUserRole()
        {
            // Get values from text boxes
            string roleName = txtUserRole.Text;

            if (string.IsNullOrWhiteSpace(roleName))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userBal = new UserRoles(Helper.GetConnectionStringFromSettings());
            int success = await userBal.CreateRoleAsync(roleName);
            if (success == 1)
            {
                // Inform the user that registration was successful
                MessageBox.Show("User Role registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadUsersRolesAsync();
                this.Close();
            }
            else
            {
                MessageBox.Show("User Role registration failed. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadUsersRolesAsync()
        {
            try
            {
                _frmManageUsers.userRolesGrid.DataSource = null;
                var userBAL = new BAL.UserRoles(Helper.GetConnectionStringFromSettings());
                _userRolesList = await userBAL.ReadUserRolesAsync();
                //userRolesGrid.Columns["NormalizedName"].Visible = false;
                //userRolesGrid.Columns["ConcurrencyStamp"].Visible = false;
                _frmManageUsers.userRolesGrid.DataSource = _userRolesList;

                _frmManageUsers.userRolesGrid.Refresh();
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
