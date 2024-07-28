using DocumentFormat.OpenXml.Office2010.PowerPoint;
using PharApp.WinHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharApp.Inventory
{
    public partial class frmWelcome : Form
    {
        public frmMedicine _frmMedicine = null;
        private List<BML.Unit> _unitList;

        public IReadOnlyList<BML.Unit> UnitList => _unitList.AsReadOnly();

        private readonly string _unitId = null;

        public frmWelcome(Form frm, string unitId = null)
        {
            InitializeComponent();
            _frmMedicine = frm as frmMedicine;
            _unitId = unitId;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;


            if (ValidateInput())
            {
                var unitBAL = new BAL.Unit(Helper.GetConnectionStringFromSettings());
                int result = await unitBAL.CreateUnitAsync(Name);
                if (result == 1)
                {
                    Helper.Log($"Unit Created:Name {Name}");
                    LoadGridDataUnit();
                    MessageBox.Show("Unit registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register Unit. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            // Check if the Name, Strength, and Generic Name fields are empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the Unit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validation passed
            return true;
        }

        private async void btnRegisterAddOther_Click(object sender, EventArgs e)
        {

            if (ValidateInput())
            {
                string Name = txtName.Text;
                var unitBAL = new BAL.Unit(Helper.GetConnectionStringFromSettings());
                int result = await unitBAL.CreateUnitAsync(Name);
                if (result == 1)
                {
                    Helper.Log($"Unit Created:Name {Name}");
                    LoadGridDataUnit();
                    MessageBox.Show("Unit registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    var frmUnit = new frmRegisterUnit(_frmMedicine);
                    frmUnit.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to register Unit. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void LoadGridDataUnit()
        {
            try
            {
                var cmbUnitBal = new BAL.Unit(Helper.GetConnectionStringFromSettings());
                _unitList = await cmbUnitBal.GetUnitsAsync();
                // Bind the data to the grid
                _frmMedicine.dataGridViewMedicineUnit.DataSource = _unitList;
                _frmMedicine.dataGridViewMedicineUnit.Columns["UnitId"].HeaderText = "Unit Id";
                _frmMedicine.dataGridViewMedicineUnit.Columns["UnitName"].HeaderText = "Item Unit";

                _frmMedicine.dataGridViewMedicineUnit.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmregisterunit_Load(object sender, EventArgs e)
        {
            if (_unitId is not null)
            {
                var unitBAL = new BAL.Unit(Helper.GetConnectionStringFromSettings());
                var unitlist = await unitBAL.GetUnitsAsync();
                var singleUnit = unitlist.Where(x => x.UnitId == _unitId).FirstOrDefault();
                txtName.Text = singleUnit.UnitName;
                btnRegister.Visible = false;
                btnRegisterAddOther.Visible = false;

            }
            else
            {
                btnUpdate.Visible = false;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string Name = txtName.Text;
                var unitBAL = new BAL.Unit(Helper.GetConnectionStringFromSettings());
                int result = await unitBAL.UpdateUnitAsync(_unitId,Name);
                if (result == 1)
                {
                    Helper.Log($"Unit updated:Name {Name}");
                    LoadGridDataUnit();
                    MessageBox.Show("Unit updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update Unit. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

        



