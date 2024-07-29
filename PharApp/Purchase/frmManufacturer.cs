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

namespace PharApp.Purchase
{
    public partial class frmManufacturer : Form
    {
        private List<BML.Manufacturer> _manufacturerList;

        public IReadOnlyList<BML.Manufacturer> MedicineList => _manufacturerList.AsReadOnly();

        public frmManufacturer()
        {
            InitializeComponent();
            _manufacturerList = new List<BML.Manufacturer>();
            LoadGridDataManufacturer();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var frmRegisterManufacturer = new frmRegisterManufacturer(this);
            frmRegisterManufacturer.ShowDialog();
        }

        private async void LoadGridDataManufacturer()
        {
            try
            {
                var cmbManufacturerBal = new BAL.Manufacturer(Helper.GetConnectionStringFromSettings());
                _manufacturerList = await cmbManufacturerBal.GetManufacturersAsync();

                // Bind the data to the grid
                dataGridViewManufacturer.DataSource = _manufacturerList;
                dataGridViewManufacturer.Columns["ManufacturerId"].HeaderText = "Id";
                dataGridViewManufacturer.Columns["ManufacturerName"].HeaderText = "Name";
                dataGridViewManufacturer.Columns["ManufacturerAddress"].HeaderText = "Address";
                dataGridViewManufacturer.Columns["ManufacturerMobile"].HeaderText = "Mobile";
                dataGridViewManufacturer.Columns["ManufacturerDetails"].HeaderText = "Details";

                dataGridViewManufacturer.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewManufacturer_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the row index at the mouse position
            int rowIndex = dataGridViewManufacturer.HitTest(e.X, e.Y).RowIndex;

            // If a row is clicked
            if (rowIndex >= 0)
            {
                // Select the clicked row
                dataGridViewManufacturer.ClearSelection();
                dataGridViewManufacturer.Rows[rowIndex].Selected = true;

                // Show the context menu strip at the mouse position
                contextMenuStripManufac.Show(dataGridViewManufacturer, e.Location);
            }

        }

        private async void deleteManufToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BML.UserSession.User.UserRole.ToUpper() == "OPERATOR")
            {
                MessageBox.Show("You are not authorized to perform this action. Only Admins can delete resources.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridViewManufacturer.SelectedRows.Count > 0)
            {
                string name = dataGridViewManufacturer.SelectedRows[0].Cells["ManufacturerName"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string Id = dataGridViewManufacturer.SelectedRows[0].Cells["ManufacturerId"].Value.ToString();

                    var manufBal = new BAL.Manufacturer(Helper.GetConnectionStringFromSettings());
                    var success = await manufBal.DeleteManufacturerAsync(Id);
                    if (success == 1)
                    {
                        LoadGridDataManufacturer();
                        // Show success message
                        MessageBox.Show("Manufacturer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Manufacturer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateManufToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewManufacturer.SelectedRows.Count > 0)
            {
                string name = dataGridViewManufacturer.SelectedRows[0].Cells["ManufacturerName"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to update this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string Id = dataGridViewManufacturer.SelectedRows[0].Cells["ManufacturerId"].Value.ToString();
                    var frm = new frmRegisterManufacturer(this, Id);
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a Manufacturer to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
