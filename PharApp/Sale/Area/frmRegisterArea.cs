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
    public partial class frmRegisterArea : Form
    {
        public frmArea _frmArea = null;
        private List<BML.Area> _manuAreaList;
        public IReadOnlyList<BML.Area> AreaList => _manuAreaList.AsReadOnly();

        public frmRegisterArea(Form frm = null)
        {
            InitializeComponent();
            _frmArea = frm as frmArea;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string areName = txtAreaNmae.Text;
                string areDescription = richTxtDescription.Text;

                var areaBAL = new BAL.Area(Helper.GetConnectionStringFromSettings());
                int result = await areaBAL.CreateAreaAsync(areName, areDescription);
                Helper.Log("Sale Area Created: " + " ," + areName + " ," + areDescription.ToString());
                if (result == 1)
                {
                    Helper.Log($"Area Created:Name {areName}");
                    LoadGridDataArea();
                    MessageBox.Show("Area registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register Unit. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnRegisterAddOther_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string areName = txtAreaNmae.Text;
                string areDescription = richTxtDescription.Text;

                var areaBAL = new BAL.Area(Helper.GetConnectionStringFromSettings());
                int result = await areaBAL.CreateAreaAsync(areName, areDescription);
                Helper.Log("Sale Area Created: " + " ," + areName + " ," + areDescription.ToString());
                if (result == 1)
                {
                    Helper.Log($"Area Created:Name {areName}");
                    LoadGridDataArea();
                    MessageBox.Show("Area registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    var frm = new frmRegisterArea(_frmArea);
                    frm.ShowDialog();
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


        private bool ValidateInput()
        {
            // Check if the Name, Strength, and Generic Name fields are empty
            if (string.IsNullOrWhiteSpace(txtAreaNmae.Text))
            {
                MessageBox.Show("Please enter the Area", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validation passed
            return true;
        }


        private async void LoadGridDataArea()
        {
            try
            {
                var cmbAreaBal = new BAL.Area(Helper.GetConnectionStringFromSettings());
                _manuAreaList = await cmbAreaBal.GetAreasAsync();
                // Bind the data to the grid
                _frmArea.dataGridViewArea.DataSource = _manuAreaList;
                _frmArea.dataGridViewArea.Columns["AreaId"].HeaderText = "Id";
                _frmArea.dataGridViewArea.Columns["AreaName"].HeaderText = "Area";
                _frmArea.dataGridViewArea.Columns["AreaDescription"].HeaderText = "Description";

                _frmArea.dataGridViewArea.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRegisterArea_Load(object sender, EventArgs e)
        {

        }
    }
}
