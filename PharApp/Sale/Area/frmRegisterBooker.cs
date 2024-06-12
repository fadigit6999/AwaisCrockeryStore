using PharApp.Inventory;
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
using System.Xml.Linq;

namespace PharApp.Sale.Area
{
    public partial class frmRegisterBooker : Form
    {
        public frmArea _frmArea = null;
        private List<BML.Booker> _bookerList;
        public IReadOnlyList<BML.Booker> BookerList => _bookerList.AsReadOnly();
        public readonly BAL.Booker _booker;
        public frmRegisterBooker(Form frm = null)
        {
            InitializeComponent();
            _frmArea = frm as frmArea;
            _booker = new BAL.Booker(Helper.GetConnectionStringFromSettings());
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string notes = richTxtNotes.Text;

                int result = await _booker.CreateBookerAsync(name, email, phone, notes);
                if (result == 1)
                {
                    Helper.Log($"Booker Created:Name {name}");
                    LoadGridDataBooker();
                    MessageBox.Show("Booker registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register Booker. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnRegisterAddOther_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                string phone= txtPhone.Text;
                string notes= richTxtNotes.Text;

                int result = await _booker.CreateBookerAsync(name,email,phone,notes);
                if (result == 1)
                {
                    Helper.Log($"Booker Created:Name {name}");
                    LoadGridDataBooker();
                    MessageBox.Show("Booker registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    var frm = new frmRegisterBooker(_frmArea);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to register Booker. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool ValidateInput()
        {
            // Check if the Name, Strength, and Generic Name fields are empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the Area", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validation passed
            return true;
        }


        private async void LoadGridDataBooker()
        {
            try
            {
                _bookerList = await _booker.GetBookersAsync();
                // Bind the data to the grid
                _frmArea.dataGridViewBooker.DataSource = _bookerList;
                _frmArea.dataGridViewBooker.Columns["BookerID"].HeaderText = "Id";
                _frmArea.dataGridViewBooker.Columns["Name"].HeaderText = "Area";
                _frmArea.dataGridViewBooker.Columns["Email"].HeaderText = "Description";
                _frmArea.dataGridViewBooker.Columns["Phone"].HeaderText = "Description";
                _frmArea.dataGridViewBooker.Columns["Notes"].HeaderText = "Description";

                _frmArea.dataGridViewBooker.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
