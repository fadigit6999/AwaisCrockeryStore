using PharApp.WinHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.CodeDom.Compiler;
using BML;
using PharApp.RdlcReports.Purchase;
using PharApp.RdlcReports.Sale;

namespace PharApp.Purchase
{
    public partial class frmPurchaseReturn : Form
    {
        private BindingList<PurchaseReturnAuditView> originalPurchaseList;
        private BindingList<PurchaseReturnAuditView> filteredPurchaseList;
        private readonly string _invoiceid;
        private readonly string _orderId;
        private string _orderDetailId;
        public frmPurchaseReturn(string invoiceid = null, string orderid = null)
        {
            InitializeComponent();
            _invoiceid = invoiceid;
            _orderId = orderid;

        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            LoadGridDataViewPurchase();
            ClearDetailsGrid();
            LoadGridViewDetails(_invoiceid);

        }

        private async void PopulateComboBoxManufacturer()
        {
            try
            {
                try
                {
                    var cmbManufacturerBal = new BAL.Manufacturer(Helper.GetConnectionStringFromSettings());
                    List<BML.Manufacturer> cmbManufacturerList = await cmbManufacturerBal.GetManufacturersAsync();

                    // Create a dictionary to hold the category names and IDs
                    Dictionary<string, string> ManufacturerDictionary = new Dictionary<string, string>();
                    ManufacturerDictionary.Add("Choose Manufacturer", Guid.NewGuid().ToString());
                    // Populate the dictionary with category names and IDs
                    foreach (var type in cmbManufacturerList)
                    {
                        ManufacturerDictionary.Add(type.ManufacturerName, type.ManufacturerId);
                    }

                    // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                    cmbManufacturer.DataSource = new BindingSource(ManufacturerDictionary, null);
                    cmbManufacturer.DisplayMember = "Key"; // Display category names
                    cmbManufacturer.ValueMember = "Value"; // Use category IDs as values

                }
                catch (Exception ex)
                {
                    // Handle exceptions, log, or show error message
                    MessageBox.Show($"Error while populating units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or show error message
                MessageBox.Show($"Error while populating units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PopulateComboBoxMedicine(string manufacturerid)
        {
            try
            {
                try
                {
                    var cmbMedicineBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
                    List<BML.Medicine> cmbMedicineList = await cmbMedicineBal.GetMedicinesDropdownGroupAsync();
                    var popMedicineList = cmbMedicineList.Where(x => x.ManufacturerId == manufacturerid).ToList();

                    Dictionary<string, string> MedicineDictionary = new Dictionary<string, string>();
                    MedicineDictionary.Add("Choose Medicine", Guid.NewGuid().ToString());

                    foreach (var medicine in popMedicineList)
                    {
                        MedicineDictionary.Add($"{medicine.Name}({medicine.Strength}{medicine.Unit})", medicine.MedicineId);
                    }

                    cmbMedInformation.DataSource = new BindingSource(MedicineDictionary, null);
                    cmbMedInformation.DisplayMember = "Key";
                    cmbMedInformation.ValueMember = "Value";

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error while populating units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error while populating units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void PopulateComboBoxPaymentType()
        {
            try
            {
                try
                {
                    var cmbPaymentTypeBal = new BAL.PaymentType(Helper.GetConnectionStringFromSettings());
                    List<BML.PaymentType> cmbPaymentTypeList = await cmbPaymentTypeBal.GetPaymentTypesAsync();


                    Dictionary<string, string> pTypeDictionary = new Dictionary<string, string>();
                    pTypeDictionary.Add("Choose Payment Type", Guid.NewGuid().ToString());

                    foreach (var pt in cmbPaymentTypeList)
                    {
                        pTypeDictionary.Add(pt.TypeName, pt.PaymentTypeId);
                    }

                    cmbPaymentType.DataSource = new BindingSource(pTypeDictionary, null);
                    cmbPaymentType.DisplayMember = "Key";
                    cmbPaymentType.ValueMember = "Value";

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error while populating Payment Type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error while populating Payment Type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadFutureInvoice()
        {
            var purchaseOrderBal = new BAL.PurchaseOrder(Helper.GetConnectionStringFromSettings());
            string futureInvoiceNumber = await purchaseOrderBal.GetFutureInvoiceNumberAsync();


            if (futureInvoiceNumber != null)
            {
                txtInvoice.Text = futureInvoiceNumber;
            }
            else
            {
                txtInvoice.Text = futureInvoiceNumber;
            }
        }

        private void UpdateGrandTotal()
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dataGridViewPurchaseDetails.Rows)
            {
                // Skip the row if it is a new row or if the cell value is null or empty
                if (!row.IsNewRow && row.Cells["TotalColumn"].Value != null)
                {
                    // Convert the cell value to a decimal and add it to the grand total
                    grandTotal += Convert.ToDecimal(row.Cells["TotalColumn"].Value);
                }
            }

            // Display the grand total in the txtGrandTotal TextBox
            txtTotal.Text = grandTotal.ToString();
            txtGrandTotal.Text = grandTotal.ToString();
        }

        private void dataGridViewPurchaseDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewPurchaseDetails.Columns["RemoveColumn"].Index)
            {
                // Remove the corresponding row
                dataGridViewPurchaseDetails.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataGridViewPurchaseDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Update the grand total when there is a change in the "Total" column
            if (e.ColumnIndex == dataGridViewPurchaseDetails.Columns["TotalColumn"].Index)
            {
                UpdateGrandTotal();
            }
        }

        private void dataGridViewPurchaseDetails_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateGrandTotal();
        }

        private void dataGridViewPurchaseDetails_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateGrandTotal();
        }

        private List<BML.PurchaseDetail> GetPurchaseDetailsFromGrid()
        {
            List<BML.PurchaseDetail> purchaseDetails = new List<BML.PurchaseDetail>();

            foreach (DataGridViewRow row in dataGridViewPurchaseDetails.Rows)
            {
                if (!row.IsNewRow)
                {
                    BML.PurchaseDetail purchaseDetail = new BML.PurchaseDetail();

                    // Assuming the order of columns in the DataGridView matches the order of properties in the PurchaseDetail class
                    //purchaseDetail.MedInformation = row.Cells["MedInformationColumn"].Value.ToString();
                    //purchaseDetail.Batched = row.Cells["BatchedColumn"].Value.ToString();
                    purchaseDetail.ExpiryDate = Convert.ToDateTime(row.Cells["ExpiryDateColumn"].Value);
                    purchaseDetail.Quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                    //purchaseDetail.ManufacturePrice = Convert.ToDecimal(row.Cells["ManufacturePriceColumn"].Value);
                    purchaseDetail.Total = Convert.ToDecimal(row.Cells["TotalColumn"].Value);

                    purchaseDetails.Add(purchaseDetail);
                }
            }

            return purchaseDetails;
        }

        private async void cmbMedInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Initialize BAL instances
            var medicineBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
            var stockBal = new BAL.Stock(Helper.GetConnectionStringFromSettings());

            // Retrieve list of medicines and stock asynchronously
            List<BML.Medicine> medicineList = await medicineBal.GetMedicinesGroupAsync();
            List<BML.Stock> stockList = await stockBal.GetMedicineStockAsync();

            // Get the selected Medicine ID from the combo box
            string selectedMedicineId = cmbMedInformation.SelectedValue.ToString();

            // Find the corresponding medicine and stock in the lists
            var selectedMedicine = medicineList.FirstOrDefault(m => m.MedicineId == selectedMedicineId);
            var selectedStock = stockList.Where(s => s.MedicineID == selectedMedicineId).ToList();
            var totalQuantity = selectedStock.Sum(s => s.Quantity);
            if (selectedMedicine != null)
            {
                // Update UI with medicine information
                txtManfPrice.Text = selectedMedicine.ManufacturerPrice.ToString();
                txtStockQuantity.Text = selectedStock != null ? totalQuantity.ToString() : "0"; // Show stock quantity if available, otherwise default to 0
            }
            else
            {
                // Handle case where the selected medicine is not found
                txtManfPrice.Text = "0.00"; // Set default manufacture price
                txtStockQuantity.Text = "0"; // Set default stock quantity
            }
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {

        }

        private async void LoadGridViewDetails(string invoiceid)
        {
            var purchaseDetailBal = new BAL.PurchaseDetail(Helper.GetConnectionStringFromSettings());
            var saleDetailList = await purchaseDetailBal.GetPurchaseDetailReturnAsync(invoiceid);
            string invoice = string.Empty;
            string invoicedate = string.Empty;
            foreach (var details in saleDetailList)
            {
                if (string.IsNullOrEmpty(invoice) && string.IsNullOrEmpty(invoicedate))
                {
                    invoice = details.InvoiceNo;
                    invoicedate = Convert.ToDateTime(details.PurchaseDate).ToString("MM/dd/yyyy");
                }
                _orderDetailId = details.PurchaseDetailId;
                string medid = details.MedicineId;

                string medInformation = details.MedName;

                // Extract other information from the text boxes
                string batchid = details.BatchId;
                string expiryDate = details.ExpiryDate;
                string quantity = details.Quantity;
                string manufacturePrice = details.ManufacturerPrice;
                string gstTax = details.Gst_tax;
                string discountPercentage = details.Gst_tax;
                string bonus = details.Bonus;
                string total = details.Total;

                // Add a new row to the DataGridView
                dataGridViewPurchaseDetails.Rows.Add(_orderDetailId, medid, medInformation, batchid, gstTax, discountPercentage, bonus, expiryDate, quantity, manufacturePrice, total, "X");

                //txtAdvTax.Text = "";
            }
            lblDefineInvoice.Text = invoice;
            lblInvoiceDateDefine.Text = invoicedate;
        }

        private void dataGridViewPurchaseDetails_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                // Get the cell at the clicked point
                DataGridView.HitTestInfo hitTestInfo = dataGridViewPurchaseDetails.HitTest(e.X, e.Y);

                // Check if a cell is clicked
                if (hitTestInfo.RowIndex >= 0 && hitTestInfo.ColumnIndex >= 0)
                {
                    // Check if the clicked column is "RemoveColumn"
                    if (dataGridViewPurchaseDetails.Columns[hitTestInfo.ColumnIndex].Name == "RemoveColumn")
                    {
                        // Prompt the user for confirmation
                        DialogResult result = MessageBox.Show(
                            "Are you sure you want to remove this item? This action cannot be undone!",
                            "Confirmation",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        // If the user confirms deletion
                        if (result == DialogResult.Yes)
                        {
                            // Remove the corresponding row
                            dataGridViewPurchaseDetails.Rows.RemoveAt(hitTestInfo.RowIndex);
                            MessageBox.Show("This item has been removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (dataGridViewPurchaseDetails.Columns[hitTestInfo.ColumnIndex].Name == "QuantityColumn")
                    {
                        var selectedRow = dataGridViewPurchaseDetails.Rows[hitTestInfo.RowIndex];
                        var itemName = selectedRow.Cells["MedInformationColumn"].Value?.ToString() ?? string.Empty;

                        var confirmationResult = MessageBox.Show(
                            $"Are you sure you want to edit the quantity for the item ## {itemName} ##?",
                            "Confirmation",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );
                        // Extract relevant data from the selected row
                        var orderId = selectedRow.Cells["OrderDetailIdColumn"].Value?.ToString() ?? string.Empty;
                        var batchId = selectedRow.Cells["BatchedColumn"].Value?.ToString() ?? string.Empty;
                        var oldQuantity = selectedRow.Cells["QuantityColumn"].Value?.ToString() ?? string.Empty;

                        // Populate fields with the extracted data
                        txtOrderid.Text = orderId;
                        txtItem.Text = itemName;
                        txtItemCode.Text = batchId;
                        txtOldQnty.Text = oldQuantity;

                        // Enable controls for updating the quantity
                        txtReturnQnty.Enabled = true;
                        btnUpdateQnty.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Please click on the Remove button to delete an item.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void txtAdvDisc_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAdvTax.Text, out decimal advTaxPercentage))
            {
                if (decimal.TryParse(txtTotal.Text, out decimal total))
                {
                    decimal advTaxAmount = total * (advTaxPercentage / 100);

                    decimal grandTotal = total + advTaxAmount;

                    txtGrandTotal.Text = grandTotal.ToString("0.00");
                }
            }
        }

        private bool ValidateDetails()
        {
            if (string.IsNullOrEmpty(cmbMedInformation.Text) || cmbMedInformation.Text == "Choose Medicine" || cmbMedInformation.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Batch ID validation
            if (string.IsNullOrWhiteSpace(txtBatchId.Text))
            {
                MessageBox.Show("Please enter Batch ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Expiry Date validation
            if (!DateTime.TryParse(dateTimeMedExpiry.Text, out DateTime expiryDate) || expiryDate < DateTime.Today)
            {
                MessageBox.Show("Please enter a valid future Expiry Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Quantity validation
            if (!int.TryParse(txtPurchaseQnt.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid Quantity (greater than 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Manufacture Price validation
            if (!decimal.TryParse(txtManfPrice.Text, out decimal manufacturePrice) || manufacturePrice <= 0)
            {
                MessageBox.Show("Please enter a valid Manufacture Price (greater than 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // GST Tax validation
            if (!decimal.TryParse(txtGSTtx.Text, out decimal gstTax) || gstTax < 0)
            {
                MessageBox.Show("Please enter a valid GST Tax (greater than or equal to 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Discount Percentage validation
            if (!int.TryParse(txtDisc.Text, out int discountPercentage) || discountPercentage < 0 || discountPercentage > 100)
            {
                MessageBox.Show("Please enter a valid Discount Percentage (between 0 and 100).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtBonus.Text, out int bonus) || bonus < 0)
            {
                MessageBox.Show("Please enter a valid Bonus (a non-negative integer).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Bonus validation (optional)
            // You can add additional validations here as needed

            // All validations passed
            return true;
        }

        public void DefaultDetails()
        {
            // Set default values for the text boxes
            cmbMedInformation.Text = "Choose Medicine";
            txtBatchId.Text = "BatchId";
            dateTimeMedExpiry.Value = DateTime.Today.AddDays(1);
            txtPurchaseQnt.Text = "1";
            txtManfPrice.Text = "0.00";
            txtGSTtx.Text = "0";
            txtDisc.Text = "0";
            txtBonus.Text = "0";
        }

        public void ClearDetailsGrid()
        {
            dataGridViewPurchaseDetails.DataSource = null;
            dataGridViewPurchaseDetails.Columns.Clear();
            dataGridViewPurchaseDetails.Columns.Add("OrderDetailIdColumn", "DetailId");
            dataGridViewPurchaseDetails.Columns.Add("MedIdColumn", "Id");
            dataGridViewPurchaseDetails.Columns.Add("MedInformationColumn", "Item");
            dataGridViewPurchaseDetails.Columns.Add("BatchedColumn", "Item Code");
            dataGridViewPurchaseDetails.Columns.Add("GstTaxColumn", "GSTTx.");
            dataGridViewPurchaseDetails.Columns.Add("DsicColumn", "Disc");
            dataGridViewPurchaseDetails.Columns.Add("BonusColumn", "Bonus");
            dataGridViewPurchaseDetails.Columns.Add("ExpiryDateColumn", "Ex. Date");
            dataGridViewPurchaseDetails.Columns.Add("QuantityColumn", "Qnt.");
            dataGridViewPurchaseDetails.Columns.Add("ManfPriceColumn", "Manuf. Price");
            dataGridViewPurchaseDetails.Columns.Add("TotalColumn", "Total");
            dataGridViewPurchaseDetails.Columns.Add("RemoveColumn", "Remove");
        }

        private async void btnPurchase_Click(object sender, EventArgs e)
        {
            if (dataGridViewPurchaseDetails.Rows.Count == 0)
            {
                MessageBox.Show("Please ensure there is at least one Item in the purchase details grid before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                bool result = false;
                var purchaseOrderDetailsBAL = new BAL.PurchaseDetail(Helper.GetConnectionStringFromSettings());
                foreach (DataGridViewRow row in dataGridViewPurchaseDetails.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string medicineId = row.Cells["MedIdColumn"].Value?.ToString();
                        string batchId = row.Cells["BatchedColumn"].Value?.ToString();
                        _orderDetailId = row.Cells["OrderDetailIdColumn"].Value?.ToString();
                        string id = row.Cells["MedIdColumn"].Value?.ToString();
                        int quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                        string invoice = lblDefineInvoice.Text;
                        string formatOrderId = Helper.FormatGuid(_orderId);
                        result = await purchaseOrderDetailsBAL.HandlePurchaseReturnAsync(formatOrderId, _orderDetailId, medicineId, batchId, quantity);
                        Helper.Log("Purchase Stock Return Changes: " + " ," + medicineId + " ," + batchId.ToString() + " ," + quantity);
                        if (result)
                        {
                            //result = await purchaseOrderDetailsBAL.UpdatePurchaseReturnAsync(_orderDetailId, medicineId, batchId, invoice);
                            Helper.Log("Purchase (Order-Details) Return Changes: " + " ," + _orderDetailId + " ," + medicineId + " ," + batchId.ToString() + " ," + invoice);
                        }
                        else
                        {
                            MessageBox.Show($"Failed to register the Purchase return. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (result)
                {
                    LoadGridDataViewPurchase();
                    ClearDetailsGrid();
                    MessageBox.Show($"Purchase is returned for invoice ## {_invoiceid} ## successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to register the Purchase return. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateOrder()
        {
            if (string.IsNullOrEmpty(cmbManufacturer.Text) || cmbManufacturer.Text == "Choose Manufacturer" || cmbManufacturer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Manufacturer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cmbPaymentType.Text) || cmbPaymentType.Text == "Choose Payment Type" || cmbPaymentType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Payment Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnClearDetails_Click(object sender, EventArgs e)
        {
            DefaultDetails();
        }
        private void ClearOrderValues()
        {
            // Clear TextBoxes
            txtDetail.Text = string.Empty;
            LoadFutureInvoice();
            txtTotal.Text = string.Empty;
            txtGrandTotal.Text = string.Empty;
            txtAdvTax.Text = string.Empty;

            // Clear ComboBoxes
            cmbPaymentType.Text = "Choose Payment Type";
            cmbManufacturer.Text = "Choose Manufacturer";

            // Clear DateTimePicker
            purchaseDate.Value = DateTime.Now;
        }

        private void ClearAll()
        {
            DefaultDetails();
            ClearOrderValues();
            ClearDetailsGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private async void LoadGridDataViewPurchase()
        {
            try
            {
                var purchaseBal = new BAL.PurchaseDetail(Helper.GetConnectionStringFromSettings());
                var purchaseList = await purchaseBal.GetPurchaseReturnAuditAsync();

                originalPurchaseList = new BindingList<PurchaseReturnAuditView>(purchaseList);
                filteredPurchaseList = new BindingList<PurchaseReturnAuditView>(purchaseList);
                dataGridViewPurchase.DataSource = filteredPurchaseList;

                dataGridViewPurchase.Columns["SerialId"].HeaderText = "Serial ID";
                dataGridViewPurchase.Columns["InvoiceNo"].HeaderText = "Invoice No.";
                dataGridViewPurchase.Columns["MedName"].HeaderText = "Item (EN)";
                dataGridViewPurchase.Columns["Name_Urdu"].HeaderText = "Item (Urdu)";
                dataGridViewPurchase.Columns["BatchID"].HeaderText = "Item Code";
                dataGridViewPurchase.Columns["OriginalQuantity"].HeaderText = "Original Quantity";
                dataGridViewPurchase.Columns["ReturnQuantity"].HeaderText = "Returned Quantity";
                dataGridViewPurchase.Columns["PurchasePrice"].HeaderText = "Purchase Price";
                dataGridViewPurchase.Columns["ReturnAmount"].HeaderText = "Return Amount";
                dataGridViewPurchase.Columns["ReturnDate"].HeaderText = "Return Date";
                dataGridViewPurchase.Columns["TotalPriceAfterReturn"].HeaderText = "Total After Return";
                dataGridViewPurchase.Columns["QuantityAfterReturn"].HeaderText = "Qnty After Return";


                dataGridViewPurchase.Columns["SerialId"].DisplayIndex = 0;
                dataGridViewPurchase.Columns["InvoiceNo"].DisplayIndex = 1;
                dataGridViewPurchase.Columns["MedName"].DisplayIndex = 2;
                dataGridViewPurchase.Columns["Name_Urdu"].DisplayIndex = 3;
                dataGridViewPurchase.Columns["BatchID"].DisplayIndex = 4;
                dataGridViewPurchase.Columns["OriginalQuantity"].DisplayIndex = 5;
                dataGridViewPurchase.Columns["ReturnQuantity"].DisplayIndex = 6;
                dataGridViewPurchase.Columns["PurchasePrice"].DisplayIndex = 7;
                dataGridViewPurchase.Columns["ReturnAmount"].DisplayIndex = 8;
                dataGridViewPurchase.Columns["ReturnDate"].DisplayIndex = 9;
                dataGridViewPurchase.Columns["TotalPriceAfterReturn"].DisplayIndex =10;
                dataGridViewPurchase.Columns["QuantityAfterReturn"].DisplayIndex =11;

                dataGridViewPurchase.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(filterText))
            {
                filteredPurchaseList = new BindingList<PurchaseReturnAuditView>(originalPurchaseList);
            }
            else
            {
                var filteredList = originalPurchaseList.Where(purchase =>
    purchase.SerialId.ToString().ToLower().Contains(filterText) ||
    purchase.InvoiceNo.ToLower().Contains(filterText) ||
    purchase.MedName.ToLower().Contains(filterText) ||
    purchase.Name_Urdu.ToLower().Contains(filterText) ||
    purchase.OriginalQuantity.ToString().ToLower().Contains(filterText) ||
    purchase.ReturnQuantity.ToString().ToLower().Contains(filterText) ||
    purchase.PurchasePrice.ToString().ToLower().Contains(filterText) ||
    purchase.ReturnAmount.ToString().ToLower().Contains(filterText) ||
    purchase.ReturnDate.ToString("dd-MM-yyyy").ToLower().Contains(filterText) || // Assuming you want to filter based on the date format
    purchase.BatchID.ToString().ToLower().Contains(filterText)
).ToList();


                filteredPurchaseList = new BindingList<PurchaseReturnAuditView>(filteredList);
            }

            dataGridViewPurchase.DataSource = filteredPurchaseList;
            dataGridViewPurchase.Columns["SerialId"].HeaderText = "Serial ID";
            dataGridViewPurchase.Columns["InvoiceNo"].HeaderText = "Invoice No.";
            dataGridViewPurchase.Columns["MedName"].HeaderText = "Item (EN)";
            dataGridViewPurchase.Columns["Name_Urdu"].HeaderText = "Item (Urdu)";
            dataGridViewPurchase.Columns["BatchID"].HeaderText = "Item Code";
            dataGridViewPurchase.Columns["OriginalQuantity"].HeaderText = "Original Quantity";
            dataGridViewPurchase.Columns["ReturnQuantity"].HeaderText = "Returned Quantity";
            dataGridViewPurchase.Columns["PurchasePrice"].HeaderText = "Purchase Price";
            dataGridViewPurchase.Columns["ReturnAmount"].HeaderText = "Return Amount";
            dataGridViewPurchase.Columns["ReturnDate"].HeaderText = "Return Date";
            dataGridViewPurchase.Columns["TotalPriceAfterReturn"].HeaderText = "Total After Return";
            dataGridViewPurchase.Columns["QuantityAfterReturn"].HeaderText = "Qnty After Return";


            dataGridViewPurchase.Columns["SerialId"].DisplayIndex = 0;
            dataGridViewPurchase.Columns["InvoiceNo"].DisplayIndex = 1;
            dataGridViewPurchase.Columns["MedName"].DisplayIndex = 2;
            dataGridViewPurchase.Columns["Name_Urdu"].DisplayIndex = 3;
            dataGridViewPurchase.Columns["BatchID"].DisplayIndex = 4;
            dataGridViewPurchase.Columns["OriginalQuantity"].DisplayIndex = 5;
            dataGridViewPurchase.Columns["ReturnQuantity"].DisplayIndex = 6;
            dataGridViewPurchase.Columns["PurchasePrice"].DisplayIndex = 7;
            dataGridViewPurchase.Columns["ReturnAmount"].DisplayIndex = 8;
            dataGridViewPurchase.Columns["ReturnDate"].DisplayIndex = 9;
            dataGridViewPurchase.Columns["TotalPriceAfterReturn"].DisplayIndex = 10;
            dataGridViewPurchase.Columns["QuantityAfterReturn"].DisplayIndex = 11;

            dataGridViewPurchase.Refresh();
        }

        private void txtPurchaseQnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, numeric digits, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, numeric digits, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtGSTtx_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, numeric digits, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, numeric digits, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtAdvTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, numeric digits, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtPurchaseQnt_Click(object sender, EventArgs e)
        {
            txtPurchaseQnt.Text = string.Empty;
        }

        private void txtBonus_Click(object sender, EventArgs e)
        {
            txtBonus.Text = string.Empty;
        }

        private void txtDisc_Click(object sender, EventArgs e)
        {
            txtDisc.Text = string.Empty;
        }

        private void txtGSTtx_Click(object sender, EventArgs e)
        {
            txtGSTtx.Text = string.Empty;
        }

        private void txtBatchId_Click(object sender, EventArgs e)
        {
            txtBatchId.Text = string.Empty;
        }

        private void txtAdvTax_Click(object sender, EventArgs e)
        {
            txtAdvTax.Text = string.Empty;
        }

        private void cmbManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbManufacturer.Text) || cmbManufacturer.Text != "Choose Manufacturer" || cmbManufacturer.SelectedIndex != -1)
            {
                PopulateComboBoxMedicine(cmbManufacturer.SelectedValue.ToString());
            }
        }

        private void dataGridViewPurchase_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the row index at the mouse position
            int rowIndex = dataGridViewPurchase.HitTest(e.X, e.Y).RowIndex;

            // If a row is clicked
            if (rowIndex >= 0)
            {
                // Select the clicked row
                dataGridViewPurchase.ClearSelection();
                dataGridViewPurchase.Rows[rowIndex].Selected = true;

                // Show the context menu strip at the mouse position
                contextMenuStripPurchase.Show(dataGridViewPurchase, e.Location);
            }
        }

        private void printReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewPurchase.SelectedRows.Count > 0)
            {
                string name = dataGridViewPurchase.SelectedRows[0].Cells["InvoiceNo"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to Print Report for this invoice ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string OrderId = dataGridViewPurchase.SelectedRows[0].Cells["OrderID"].Value.ToString();
                    // Code to print the purchase
                    var frm = new rptPurchaseReturn(Helper.FormatGuid(OrderId));
                    frm.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Please select a medicine to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editItemQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewPurchase.SelectedRows.Count > 0)
            {
                string name = dataGridViewPurchase.SelectedRows[0].Cells["MedName"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to edit Quantity for this Item ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string OrderId = dataGridViewPurchase.SelectedRows[0].Cells["OrderID"].Value.ToString();
                    string item = dataGridViewPurchase.SelectedRows[0].Cells["OrderID"].Value.ToString();
                    string itemcode = dataGridViewPurchase.SelectedRows[0].Cells["BatchId"].Value.ToString();
                    string oldQnty = dataGridViewPurchase.SelectedRows[0].Cells["Quantity"].Value.ToString();
                    // Code to print the purchase

                    txtOrderid.Text = OrderId;
                    txtItem.Text = name;
                    txtItemCode.Text = itemcode;
                    txtOldQnty.Text = oldQnty;
                    txtNewQnty.Enabled = true;
                    btnUpdateQnty.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Please select a medicine to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPagePurchase_Click(object sender, EventArgs e)
        {

        }

        #region Quantity Update Procedure
        private void btnUpdateQnty_Click(object sender, EventArgs e)
        {
            // Retrieve the OrderDetailID from the input field
            string orderDetailId = txtOrderid.Text;
            // Loop through the DataGridView rows to find the matching OrderDetailID
            foreach (DataGridViewRow row in dataGridViewPurchaseDetails.Rows)
            {
                // Compare the current row's OrderDetailID with the input
                if (row.Cells["OrderDetailIdColumn"].Value != null &&
                    row.Cells["OrderDetailIdColumn"].Value.ToString() == orderDetailId)
                {

                    row.Cells["QuantityColumn"].Value = txtReturnQnty.Text;

                    ClearUpdateText();
                    // Display success message
                    MessageBox.Show("The item has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // If the OrderDetailID was not found in the grid
            MessageBox.Show("OrderDetailID not found in the grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtNewQnty_KeyUp(object sender, KeyEventArgs e)
        {
            // Get the text from the TextBox
            string inputText = txtReturnQnty.Text;

            // Validate if the input is numeric
            if (!System.Text.RegularExpressions.Regex.IsMatch(inputText, "^[0-9]*$"))
            {
                // If the input is not numeric, remove the invalid characters
                MessageBox.Show("Please enter only numeric digits (0-9).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewQnty.Text = new string(inputText.Where(char.IsDigit).ToArray());
                txtNewQnty.SelectionStart = txtNewQnty.Text.Length; // Move cursor to end
                return;
            }

            // Check if the new quantity is greater than the old quantity
            if (int.TryParse(txtReturnQnty.Text, out int newQuantity) && int.TryParse(txtOldQnty.Text, out int oldQuantity))
            {
                if (newQuantity > oldQuantity)
                {
                    MessageBox.Show("The new quantity cannot be greater than the old quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNewQnty.Text = oldQuantity.ToString(); // Reset to old quantity
                    txtNewQnty.SelectionStart = txtNewQnty.Text.Length; // Move cursor to end
                }
            }
        }

        void ClearUpdateText()
        {
            txtOrderid.Text = "";
            txtItem.Text = "";
            txtItemCode.Text = "";
            txtOldQnty.Text = "";
            txtReturnQnty.Text = "";
        }
        #endregion

    }
}
