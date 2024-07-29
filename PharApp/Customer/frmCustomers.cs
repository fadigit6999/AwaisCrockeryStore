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

namespace PharApp.Customer
{
    public partial class frmCustomers : Form
    {
        private List<BML.Customer> _customerList;
        public IReadOnlyList<BML.Customer> CustomerList => _customerList.AsReadOnly();
        
        public frmCustomers()
        {
            InitializeComponent();
        }

        private async void frmCustomers_Load(object sender, EventArgs e)
        {
            LoadGridDataCustomer();
           
        }

        private async void LoadGridDataCustomer()
        {
            try
            {
                var customerBal = new BAL.Customer(Helper.GetConnectionStringFromSettings());
                _customerList = await customerBal.GetCustomersAsync();
                // Bind the data to the grid
                dataGridViewCustomer.DataSource = _customerList;
                dataGridViewCustomer.Columns["CustomerID"].HeaderText = "Id";
                dataGridViewCustomer.Columns["FullName"].HeaderText = "Name";
                dataGridViewCustomer.Columns["Email"].HeaderText = "Email";
                dataGridViewCustomer.Columns["Phone"].HeaderText = "Phone No";
                dataGridViewCustomer.Columns["CustomerType"].HeaderText = "Type";
                dataGridViewCustomer.Columns["AddressLine1"].HeaderText = "Address";

                dataGridViewCustomer.Columns["CustomerID"].DisplayIndex = 1;
                dataGridViewCustomer.Columns["FullName"].DisplayIndex = 2;
                dataGridViewCustomer.Columns["Email"].DisplayIndex = 3;
                dataGridViewCustomer.Columns["Phone"].DisplayIndex = 4;
                dataGridViewCustomer.Columns["CustomerType"].DisplayIndex = 5;
                dataGridViewCustomer.Columns["AddressLine1"].DisplayIndex = 6;

                dataGridViewCustomer.Columns["FirstName"].Visible = false;

                dataGridViewCustomer.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var frm = new frmRegisterCustomer(this);
            frm.ShowDialog();
        }

        private async void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BML.UserSession.User.UserRole.ToUpper() == "OPERATOR")
            {
                MessageBox.Show("You are not authorized to perform this action. Only Admins can delete resources.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if a row is selected
            if (dataGridViewCustomer.SelectedRows.Count > 0)
            {
                string name = dataGridViewCustomer.SelectedRows[0].Cells["FullName"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string Id = dataGridViewCustomer.SelectedRows[0].Cells["CustomerId"].Value.ToString();

                    var customerBal = new BAL.Customer(Helper.GetConnectionStringFromSettings());
                    var success = await customerBal.DeleteCustomerAsync(Id);
                    if (success == 1)
                    {
                        LoadGridDataCustomer();
                        // Show success message
                        MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the row index at the mouse position
            int rowIndex = dataGridViewCustomer.HitTest(e.X, e.Y).RowIndex;

            // If a row is clicked
            if (rowIndex >= 0)
            {
                // Select the clicked row
                dataGridViewCustomer.ClearSelection();
                dataGridViewCustomer.Rows[rowIndex].Selected = true;

                // Show the context menu strip at the mouse position
                contextMenuStripCustomer.Show(dataGridViewCustomer, e.Location);
            }
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewCustomer.SelectedRows.Count > 0)
            {
                string name = dataGridViewCustomer.SelectedRows[0].Cells["FullName"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string Id = dataGridViewCustomer.SelectedRows[0].Cells["CustomerId"].Value.ToString();

                    var frm = new frmRegisterCustomer(this,Id);
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a Customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
