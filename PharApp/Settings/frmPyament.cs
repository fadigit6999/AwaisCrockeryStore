using DocumentFormat.OpenXml.Wordprocessing;
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

namespace PharApp.Settings
{
    public partial class frmPyament : Form
    {
        private List<BML.PaymentType> _paymentTypeList;

        public IReadOnlyList<BML.PaymentType> paymentTypeList => _paymentTypeList.AsReadOnly();

        private readonly BAL.PaymentType _paymentType;
        private string _typeId = null;

        public frmPyament()
        {
            InitializeComponent();
            _paymentTypeList = new List<BML.PaymentType>();
            _paymentType = new BAL.PaymentType(Helper.GetConnectionStringFromSettings());
        }

        private void frmPyament_Load(object sender, EventArgs e)
        {
            LoadGridDataPaymentType();
            txtPaymentType.Text = "";
            btnRegisterPaymentType.Visible = true;
            btnClear.Visible = false;
            btnUpdate.Visible = false;
        }

        private async void btnRegisterPaymentType_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string pt = txtPaymentType.Text;
                var ptBAL = new BAL.PaymentType(Helper.GetConnectionStringFromSettings());
                int result = await ptBAL.CreatePaymentTypeAsync(pt);
                Helper.Log("Payment Type Created: " + " ," + pt);
                if (result == 1)
                {
                    LoadGridDataPaymentType();
                    MessageBox.Show("Payment Type registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPaymentType.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to register Payment type. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            // Check if the Name, Strength, and Generic Name fields are empty
            if (string.IsNullOrEmpty(txtPaymentType.Text))
            {
                MessageBox.Show("Please enter the Payment Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validation passed
            return true;
        }


        private async void LoadGridDataPaymentType()
        {
            try
            {
                var paymentTypeBal = new BAL.PaymentType(Helper.GetConnectionStringFromSettings());
                _paymentTypeList = await paymentTypeBal.GetPaymentTypesAsync();

                // Bind the data to the grid
                dataGridViewPaymentType.DataSource = _paymentTypeList;
                dataGridViewPaymentType.Columns["PaymentTypeId"].HeaderText = "Id";
                dataGridViewPaymentType.Columns["TypeName"].HeaderText = "Type";

                dataGridViewPaymentType.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPaymentType_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the row index at the mouse position
            int rowIndex = dataGridViewPaymentType.HitTest(e.X, e.Y).RowIndex;

            // If a row is clicked
            if (rowIndex >= 0)
            {
                // Select the clicked row
                dataGridViewPaymentType.ClearSelection();
                dataGridViewPaymentType.Rows[rowIndex].Selected = true;

                // Show the context menu strip at the mouse position
                contextMenuStripPaymentType.Show(dataGridViewPaymentType, e.Location);
            }
        }

        private async void deletePayTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewPaymentType.SelectedRows.Count > 0)
            {
                string name = dataGridViewPaymentType.SelectedRows[0].Cells["TypeName"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string Id = dataGridViewPaymentType.SelectedRows[0].Cells["PaymentTypeId"].Value.ToString();

                    var pTypeBal = new BAL.PaymentType(Helper.GetConnectionStringFromSettings());
                    var success = await pTypeBal.DeletePaymentTypeAsync(Id);
                    if (success == 1)
                    {
                        Helper.Log("Payment Type deleted: " + " ," + Id);
                        LoadGridDataPaymentType();
                        // Show success message
                        MessageBox.Show("Payment Type deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Payment Type to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void updatePayTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewPaymentType.SelectedRows.Count > 0)
            {
                string name = dataGridViewPaymentType.SelectedRows[0].Cells["TypeName"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to update this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    _typeId = dataGridViewPaymentType.SelectedRows[0].Cells["PaymentTypeId"].Value.ToString();
                    var paymentType = await _paymentType.GetPaymentTypesAsync();
                    var paymentTypeSingle = paymentType.Where(x => x.PaymentTypeId == _typeId).FirstOrDefault();
                    if (paymentTypeSingle != null)
                    {
                        txtPaymentType.Text = paymentTypeSingle.TypeName;
                        btnRegisterPaymentType.Visible = false;
                        btnClear.Visible = true;
                        btnUpdate.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Payment Type to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string pt = txtPaymentType.Text;
                int result = await _paymentType.UpdatePaymentTypeAsync(_typeId,pt);
                Helper.Log("Payment Type updateed: " + " ," + pt);
                if (result == 1)
                {
                    LoadGridDataPaymentType();
                    MessageBox.Show("Payment Type updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to update Payment type. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear() 
        {
            txtPaymentType.Text = "";
            btnRegisterPaymentType.Visible = true;
            btnClear.Visible = false;
            btnUpdate.Visible = false;
        }
    }
}
