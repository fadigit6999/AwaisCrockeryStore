using BML;
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
    public partial class frmManageUsers : Form
    {
        private List<AspNetUser> _userList;
        private List<AspNetRole> _userRolesList;

        public IReadOnlyList<AspNetUser> UserList => _userList.AsReadOnly();

        public IReadOnlyList<AspNetRole> UserRolesList => _userRolesList.AsReadOnly();

        public frmManageUsers()
        {
            InitializeComponent();
            _userList = new List<AspNetUser>();
            _userRolesList = new List<AspNetRole>();

        }

        private void btnUserRegistration_Click(object sender, EventArgs e)
        {
            var frmUserRegistration = new frmRegisterUser();
            frmUserRegistration.ShowDialog();

        }

        private async Task LoadUsersAsync()
        {
            try
            {
                var userBAL = new BAL.User(Helper.GetConnectionStringFromSettings());
                _userList = await userBAL.ReadUserAsync();
                registeredUserGrid.DataSource = _userList;
                registeredUserGrid.Columns["AccessFailedCount"].Visible = false;
                registeredUserGrid.Columns["NormalizedUserName"].Visible = false;
                registeredUserGrid.Columns["NormalizedEmail"].Visible = false;
                registeredUserGrid.Columns["PasswordHash"].Visible = false;
                registeredUserGrid.Columns["SecurityStamp"].Visible = false;
                registeredUserGrid.Columns["ConcurrencyStamp"].Visible = false;
                registeredUserGrid.Columns["PhoneNumberConfirmed"].Visible = false;
                registeredUserGrid.Columns["TwoFactorEnabled"].Visible = false;
                registeredUserGrid.Columns["LockoutEnd"].Visible = false;
                registeredUserGrid.Columns["LockoutEnabled"].Visible = false;
                registeredUserGrid.Columns["EmailConfirmed"].Visible = false;

                registeredUserGrid.Columns["Id"].HeaderText = "User Id";
                registeredUserGrid.Columns["FirstName"].HeaderText = "First Name";
                registeredUserGrid.Columns["LastName"].HeaderText = "Last Name";
                registeredUserGrid.Columns["DateCreated"].HeaderText = "Reg. Date";
                registeredUserGrid.Columns["UserName"].HeaderText = "Username";
                registeredUserGrid.Columns["Email"].HeaderText = "Email";
                registeredUserGrid.Columns["PhoneNumber"].HeaderText = "Phone No";

                registeredUserGrid.Columns["Id"].DisplayIndex = 0;
                registeredUserGrid.Columns["FirstName"].DisplayIndex = 1;
                registeredUserGrid.Columns["LastName"].DisplayIndex = 2;
                registeredUserGrid.Columns["DateCreated"].DisplayIndex = 6;
                registeredUserGrid.Columns["UserName"].DisplayIndex = 3;
                registeredUserGrid.Columns["Email"].DisplayIndex = 4;
                registeredUserGrid.Columns["Status"].DisplayIndex = 7;
                registeredUserGrid.Columns["PhoneNumber"].DisplayIndex = 5;
                registeredUserGrid.Columns["DateCreated"].DefaultCellStyle.Format = "dd/MM/yyyy";

                registeredUserGrid.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading users: {ex.Message}");
            }
        }

        private async void frmManageUsers_Load(object sender, EventArgs e)
        {
            await LoadUsersAsync();
            await LoadUsersRolesAsync();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var filterList = _userList.Where(item =>
            item.Id.ToLower().Contains(txtSearch.Text.ToLower()) ||
            item.FirstName.ToLower().Contains(txtSearch.Text.ToLower()) ||
            item.LastName.ToLower().Contains(txtSearch.Text.ToLower()) ||
            item.Status.ToLower().Contains(txtSearch.Text.ToLower()) ||
            item.Email.ToLower().Contains(txtSearch.Text.ToLower()) ||
            item.UserName.ToLower().Contains(txtSearch.Text.ToLower())
            // Add conditions for other fields as needed
            ).ToList();


            registeredUserGrid.DataSource = null;
            registeredUserGrid.DataSource = filterList;
            registeredUserGrid.Columns["AccessFailedCount"].Visible = false;
            registeredUserGrid.Columns["NormalizedUserName"].Visible = false;
            registeredUserGrid.Columns["NormalizedEmail"].Visible = false;
            registeredUserGrid.Columns["PasswordHash"].Visible = false;
            registeredUserGrid.Columns["SecurityStamp"].Visible = false;
            registeredUserGrid.Columns["ConcurrencyStamp"].Visible = false;
            registeredUserGrid.Columns["PhoneNumberConfirmed"].Visible = false;
            registeredUserGrid.Columns["TwoFactorEnabled"].Visible = false;
            registeredUserGrid.Columns["LockoutEnd"].Visible = false;
            registeredUserGrid.Columns["LockoutEnabled"].Visible = false;
            registeredUserGrid.Columns["EmailConfirmed"].Visible = false;

            registeredUserGrid.Columns["Id"].HeaderText = "User Id";
            registeredUserGrid.Columns["FirstName"].HeaderText = "First Name";
            registeredUserGrid.Columns["LastName"].HeaderText = "Last Name";
            registeredUserGrid.Columns["DateCreated"].HeaderText = "Reg. Date";
            registeredUserGrid.Columns["UserName"].HeaderText = "Username";
            registeredUserGrid.Columns["Email"].HeaderText = "Email";
            registeredUserGrid.Columns["PhoneNumber"].HeaderText = "Phone No";

            registeredUserGrid.Columns["Id"].DisplayIndex = 0;
            registeredUserGrid.Columns["FirstName"].DisplayIndex = 1;
            registeredUserGrid.Columns["LastName"].DisplayIndex = 2;
            registeredUserGrid.Columns["DateCreated"].DisplayIndex = 6;
            registeredUserGrid.Columns["UserName"].DisplayIndex = 3;
            registeredUserGrid.Columns["Email"].DisplayIndex = 4;
            registeredUserGrid.Columns["Status"].DisplayIndex = 7;
            registeredUserGrid.Columns["PhoneNumber"].DisplayIndex = 5;
            registeredUserGrid.Columns["DateCreated"].DefaultCellStyle.Format = "dd/MM/yyyy";

            registeredUserGrid.Refresh();

        }

        private void btnRegisterRoles_Click(object sender, EventArgs e)
        {
            var frmUserRole = new frmRegisterRole();
            frmUserRole.ShowDialog();
        }

        public async Task LoadUsersRolesAsync()
        {
            try
            {
                var userBAL = new BAL.UserRoles(Helper.GetConnectionStringFromSettings());
                _userRolesList = await userBAL.ReadUserRolesAsync();
               
                userRolesGrid.DataSource = _userRolesList;
                userRolesGrid.Columns["NormalizedName"].Visible = false;
                userRolesGrid.Columns["ConcurrencyStamp"].Visible = false;
                userRolesGrid.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading users: {ex.Message}");
            }
        }

    }
}
