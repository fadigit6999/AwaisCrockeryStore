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

namespace PharApp.Sale.Area
{
    public partial class frmArea : Form
    {
        private List<BML.Area> _manuAreaList;
        public IReadOnlyList<BML.Area> AreaList => _manuAreaList.AsReadOnly();
        private List<BML.Booker> _bookerList;
        public IReadOnlyList<BML.Booker> bookerList => _bookerList.AsReadOnly();
        private List<BML.Supplier> _supplierList;
        public IReadOnlyList<BML.Supplier> SupplierList => _supplierList.AsReadOnly();
        //As Services
        private readonly BAL.Booker _booker;
        private readonly BAL.Supplier _supplier;
        public frmArea()
        {
            InitializeComponent();
            _booker = new BAL.Booker(Helper.GetConnectionStringFromSettings());
            _supplier = new BAL.Supplier(Helper.GetConnectionStringFromSettings());
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var frm = new frmRegisterArea(this);
            frm.ShowDialog();
        }
        private async void LoadGridDataArea()
        {
            try
            {
                var cmbAreaBal = new BAL.Area(Helper.GetConnectionStringFromSettings());
                _manuAreaList = await cmbAreaBal.GetAreasAsync();
                // Bind the data to the grid
                dataGridViewArea.DataSource = _manuAreaList;
                dataGridViewArea.Columns["AreaId"].HeaderText = "Id";
                dataGridViewArea.Columns["AreaName"].HeaderText = "Area";
                dataGridViewArea.Columns["AreaDescription"].HeaderText = "Description";
                dataGridViewArea.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadGridDataBooker()
        {
            try
            {
                _bookerList = await _booker.GetBookersAsync();
                // Bind the data to the grid
                dataGridViewBooker.DataSource = _bookerList;
                dataGridViewBooker.Columns["BookerID"].HeaderText = "Id";
                dataGridViewBooker.Columns["Name"].HeaderText = "Area";
                dataGridViewBooker.Columns["Email"].HeaderText = "Description";
                dataGridViewBooker.Columns["Phone"].HeaderText = "Description";
                dataGridViewBooker.Columns["Notes"].HeaderText = "Description";

                dataGridViewBooker.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadGridDataSupplier()
        {
            try
            {
                _supplierList = await _supplier.GetSuppliersAsync();
                // Bind the data to the grid
                dataGridViewSupplier.DataSource = _supplierList;
                dataGridViewSupplier.Columns["SupplierID"].HeaderText = "Id";
                dataGridViewSupplier.Columns["Name"].HeaderText = "Name";
                dataGridViewSupplier.Columns["CompanyName"].HeaderText = "Company";
                dataGridViewSupplier.Columns["Email"].HeaderText = "Email";
                dataGridViewSupplier.Columns["Phone"].HeaderText = "Phone";
                dataGridViewSupplier.Columns["Address"].HeaderText = "Address";
                dataGridViewSupplier.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewArea_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the row index at the mouse position
            int rowIndex = dataGridViewArea.HitTest(e.X, e.Y).RowIndex;

            // If a row is clicked
            if (rowIndex >= 0)
            {
                // Select the clicked row
                dataGridViewArea.ClearSelection();
                dataGridViewArea.Rows[rowIndex].Selected = true;

                // Show the context menu strip at the mouse position
                contextMenuStripArea.Show(dataGridViewArea, e.Location);
            }

        }
        private async void deleteAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewArea.SelectedRows.Count > 0)
            {
                string name = dataGridViewArea.SelectedRows[0].Cells["AreaName"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string Id = dataGridViewArea.SelectedRows[0].Cells["AreaId"].Value.ToString();

                    var areaBal = new BAL.Area(Helper.GetConnectionStringFromSettings());
                    var success = await areaBal.DeleteAreaAsync(Id);
                    Helper.Log("Sale Area Deleted: " + " ," + Id);
                    if (success == 1)
                    {
                        LoadGridDataArea();
                        // Show success message
                        MessageBox.Show("Area deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Area to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmArea_Load(object sender, EventArgs e)
        {
            LoadGridDataArea();
            LoadGridDataBooker();
            LoadGridDataSupplier();
        }
        private void btnRegisterBooker_Click(object sender, EventArgs e)
        {
            var frm = new frmRegisterBooker(this);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frmRegisterSupplier(this);
            frm.ShowDialog();
        }
    }
}
