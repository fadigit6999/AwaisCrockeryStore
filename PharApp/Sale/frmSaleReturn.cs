using BML;
using PharApp.RdlcReports.Purchase;
using PharApp.RdlcReports.Sale;
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

namespace PharApp.Sale
{
    public partial class frmSaleReturn : Form
    {
        private BindingList<SaleReturnAuditView> originalBindingList;
        private BindingList<SaleReturnAuditView> filteredBindingList;
        private readonly string _invoiceid;
        private readonly string _orderId;
        private string _orderDetailId;
        public frmSaleReturn(string invoiceid = null, string orderid = null)
        {
            InitializeComponent();
            _invoiceid = invoiceid;
            _orderId = orderid;
        }
        private void frmSale_Load(object sender, EventArgs e)
        {
            LoadGridDataViewSale();
            ClearDetailsGrid();
            LoadGridViewDetails(_invoiceid);
        }

        private async void LoadGridViewDetails(string invoiceid)
        {
            var saleDetailBal = new BAL.SaleDetail(Helper.GetConnectionStringFromSettings());
            var saleDetailList = await saleDetailBal.GetSaleDetailReturnAsync(invoiceid);
            string invoice = string.Empty;
            string invoicedate = string.Empty;
            foreach (var details in saleDetailList)
            {
                if (string.IsNullOrEmpty(invoice) && string.IsNullOrEmpty(invoicedate))
                {
                    invoice = details.InvoiceNo;
                    invoicedate = Convert.ToDateTime(details.SaleDate).ToString("MM/dd/yyyy");
                }
                _orderDetailId = details.SalesDetailId;
                string medid = details.MedicineId;

                string medInformation = details.MedName;

                // Extract other information from the text boxes
                string batchid = details.BatchId;
                string expiryDate = details.ExpiryDate;
                string quantity = details.Quantity;
                string manufacturePrice = details.ManufacturerPrice;
                string gstTax = details.GstTax;
                string discountPercentage = details.DistDisc;
                string bonus = details.Bonus;
                string total = details.Total;

                // Add a new row to the DataGridView
                dataGridViewSaleDetails.Rows.Add(_orderDetailId, medid, medInformation, batchid, gstTax, discountPercentage, expiryDate, quantity, manufacturePrice, total, "X");

                //txtAdvTax.Text = "";
            }
            lblDefineInvoice.Text = invoice;
            lblInvoiceDateDefine.Text = invoicedate;
        }

        private async void PopulateComboBoxCustomer()
        {
            try
            {
                try
                {
                    var cmbCustomerBal = new BAL.Customer(Helper.GetConnectionStringFromSettings());
                    List<BML.Customer> cmbManufacturerList = await cmbCustomerBal.GetCustomersAsync();

                    // Create a dictionary to hold the category names and IDs
                    Dictionary<string, string> ManufacturerDictionary = new Dictionary<string, string>();
                    ManufacturerDictionary.Add("Choose Customer", Guid.NewGuid().ToString());
                    // Populate the dictionary with category names and IDs
                    foreach (var type in cmbManufacturerList)
                    {
                        ManufacturerDictionary.Add(type.FullName, type.CustomerID);
                    }

                    // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                    cmbCustomer.DataSource = new BindingSource(ManufacturerDictionary, null);
                    cmbCustomer.DisplayMember = "Key"; // Display category names
                    cmbCustomer.ValueMember = "Value"; // Use category IDs as values

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
        private async void PopulateComboBoxMedicine()
        {
            try
            {
                try
                {
                    var cmbMedicineBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
                    List<BML.Medicine> cmbMedicineList = await cmbMedicineBal.GetMedicinesDropdownStockBasedGroupAsync();


                    Dictionary<string, string> MedicineDictionary = new Dictionary<string, string>();
                    MedicineDictionary.Add("Choose Medicine", Guid.NewGuid().ToString());

                    foreach (var medicine in cmbMedicineList)
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
            var saleOrderBal = new BAL.SaleOrder(Helper.GetConnectionStringFromSettings());
            string futureInvoiceNumber = await saleOrderBal.GetNextInvoiceNumberAsync();


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

            foreach (DataGridViewRow row in dataGridViewSaleDetails.Rows)
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
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSaleDetails.Columns["RemoveColumn"].Index)
            {
                // Remove the corresponding row
                dataGridViewSaleDetails.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void dataGridViewPurchaseDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Update the grand total when there is a change in the "Total" column
            if (e.ColumnIndex == dataGridViewSaleDetails.Columns["TotalColumn"].Index)
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

            foreach (DataGridViewRow row in dataGridViewSaleDetails.Rows)
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
            var selectedStock = stockList.Where(s => s.MedicineID == selectedMedicineId);
            if (selectedMedicine != null)
            {
                Dictionary<string, string> StockDictionary = new Dictionary<string, string>();
                StockDictionary.Add("Choose BatchId", Guid.NewGuid().ToString());

                var addedBatchIds = new HashSet<string>();

                foreach (var stock in selectedStock)
                {
                    if (!addedBatchIds.Contains(stock.BatchID.ToString()))
                    {
                        StockDictionary.Add(stock.BatchID, stock.MedicineID);
                        addedBatchIds.Add(stock.MedicineID.ToString());
                    }

                }

                cmbBatchId.DataSource = new BindingSource(StockDictionary, null);
                cmbBatchId.DisplayMember = "Key";
                cmbBatchId.ValueMember = "Value";
            }
        }
        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            if (ValidateDetails())
            {
                if (!CalculateStockQuantity())
                {
                    MessageBox.Show($"Medicine quantity is exceeding from stock quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Get values from text boxes
                    // Extract the selected value and text from the ComboBox
                    string medInformationId = cmbMedInformation.SelectedValue?.ToString();
                    string medInformation = cmbMedInformation.Text;
                    // Extract other information from the text boxes
                    string batchid = cmbBatchId.Text;
                    string expiryDate = txtExpiryDate.Text;
                    int quantity = Convert.ToInt32(txtSaleQnt.Text);
                    decimal manufacturePrice = Convert.ToDecimal(txtManfPrice.Text);
                    decimal gstTax = Convert.ToDecimal(txtGSTtx.Text);
                    int discountPercentage = Convert.ToInt32(txtDisc.Text);
                    string bonus = txtBonus.Text;

                    // Calculate the total before any discounts or taxes
                    decimal totalBeforeDiscount = quantity * manufacturePrice;

                    // Calculate the total after applying the discount
                    decimal totalAfterDiscount = totalBeforeDiscount * (1 - (decimal)discountPercentage / 100);

                    // Calculate the total with GST included
                    decimal totalWithTax = totalAfterDiscount * (1 + gstTax / 100);

                    // Calculate the total by summing up all the values
                    decimal total = totalWithTax;

                    // Add a new row to the DataGridView
                    dataGridViewSaleDetails.Rows.Add(medInformationId, medInformation, batchid, gstTax, discountPercentage, bonus, expiryDate, quantity, manufacturePrice, Math.Round(total, 2), "X");

                    txtAdvTax.Text = "";
                }

            }
        }
        private void dataGridViewPurchaseDetails_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                // Get the cell at the clicked point
                DataGridView.HitTestInfo hitTestInfo = dataGridViewSaleDetails.HitTest(e.X, e.Y);

                // Check if a cell is clicked
                if (hitTestInfo.RowIndex >= 0 && hitTestInfo.ColumnIndex >= 0)
                {
                    // Check if the clicked column is "RemoveColumn"
                    if (dataGridViewSaleDetails.Columns[hitTestInfo.ColumnIndex].Name == "RemoveColumn")
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
                            dataGridViewSaleDetails.Rows.RemoveAt(hitTestInfo.RowIndex);
                            MessageBox.Show("This item has been removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (dataGridViewSaleDetails.Columns[hitTestInfo.ColumnIndex].Name == "QuantityColumn")
                    {
                        var selectedRow = dataGridViewSaleDetails.Rows[hitTestInfo.RowIndex];
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
            if (string.IsNullOrEmpty(cmbBatchId.Text) || cmbBatchId.Text == "Choose BatchId")
            {
                MessageBox.Show("Please enter Batch ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            // Quantity validation
            if (!int.TryParse(txtSaleQnt.Text, out int quantity) || quantity <= 0)
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

            if (txtStockQuantity.Text == "0")
            {
                MessageBox.Show("Medicine is out of stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cmbBatchId.DataSource = null;
            txtExpiryDate.Text = "MM/DD/YYYY";
            txtStockQuantity.Text = "";
            txtSaleQnt.Text = "1";
            txtManfPrice.Text = "0.00";
            txtGSTtx.Text = "0";
            txtDisc.Text = "0";
            txtBonus.Text = "0";
        }
        public void ClearDetailsGrid()
        {
            // Clear the DataGridView
            dataGridViewSaleDetails.DataSource = null;
            dataGridViewSaleDetails.Columns.Clear();

            // Add columns
            dataGridViewSaleDetails.Columns.Add("OrderDetailIdColumn", "DetailId");
            dataGridViewSaleDetails.Columns.Add("MedIdColumn", "Id");
            dataGridViewSaleDetails.Columns.Add("MedInformationColumn", "Item");
            dataGridViewSaleDetails.Columns.Add("BatchedColumn", "Item Code");
            dataGridViewSaleDetails.Columns.Add("GstTaxColumn", "GSTTx.");
            dataGridViewSaleDetails.Columns.Add("DsicColumn", "Disc");
            dataGridViewSaleDetails.Columns.Add("ExpiryDateColumn", "Ex. Date");
            dataGridViewSaleDetails.Columns.Add("QuantityColumn", "Qnt.");
            dataGridViewSaleDetails.Columns.Add("ManfPriceColumn", "Sale Price");
            dataGridViewSaleDetails.Columns.Add("TotalColumn", "Total");
            dataGridViewSaleDetails.Columns.Add("RemoveColumn", "Remove");
        }
        private async void btnPurchase_Click(object sender, EventArgs e)
        {
            if (dataGridViewSaleDetails.Rows.Count == 0)
            {
                MessageBox.Show("Please ensure there is at least one Item in the Sale details grid before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                bool result = false;
                var SaleOrderDetailsBAL = new BAL.SaleDetail(Helper.GetConnectionStringFromSettings());
                foreach (DataGridViewRow row in dataGridViewSaleDetails.Rows)
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

                        result = await SaleOrderDetailsBAL.HandleSaleStockReturnAsync(formatOrderId, _orderDetailId, medicineId, batchId, quantity);
                        Helper.Log("Sale Stock Return Changes: " + " ," + medicineId + " ," + batchId.ToString() + " ," + quantity);
                        if (result)
                        {
                            //result = await SaleOrderDetailsBAL.UpdateSaleReturnAsync(_orderDetailId, medicineId, batchId, invoice);
                            Helper.Log("Sale (Order-Details) Return Changes: " + " ," + _orderDetailId + " ," + medicineId + " ," + batchId.ToString() + " ," + invoice);
                        }
                        else
                        {
                            MessageBox.Show($"Failed to register the Sale return. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (result)
                {
                    LoadGridDataViewSale();
                    ClearDetailsGrid();
                    MessageBox.Show($"Sale is returned for invoice ## {_invoiceid} ## successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to register the Sale return. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidateOrder()
        {
            if (string.IsNullOrEmpty(cmbCustomer.Text) || cmbCustomer.Text == "Choose Customer" || cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the ## Customer ## .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cmbCustomer.Text = "Choose Customer";

            if (checkBoxWarranty.Checked == true)
            {
                checkBoxWarranty.Checked = false;
            }

            // Clear DateTimePicker
            saleDate.Value = DateTime.Now;
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
        private async void LoadGridDataViewSale()
        {
            try
            {
                var saleBal = new BAL.SaleDetail(Helper.GetConnectionStringFromSettings());
                var saleList = await saleBal.GetSaleDetailReturnAuditAsync();

                originalBindingList = new BindingList<SaleReturnAuditView>(saleList);
                filteredBindingList = new BindingList<SaleReturnAuditView>(saleList);
                dataGridViewSale.DataSource = filteredBindingList;

                dataGridViewSale.Columns["SerialId"].HeaderText = "Serial ID";
                dataGridViewSale.Columns["InvoiceNo"].HeaderText = "Invoice No.";
                dataGridViewSale.Columns["MedName"].HeaderText = "Item (En)";
                dataGridViewSale.Columns["Name_Urdu"].HeaderText = "Item (Urdu)";
                dataGridViewSale.Columns["BatchID"].HeaderText = "Item Code";
                dataGridViewSale.Columns["OriginalQuantity"].HeaderText = "Original Quantity";
                dataGridViewSale.Columns["ReturnQuantity"].HeaderText = "Returned Quantity";
                dataGridViewSale.Columns["SalePrice"].HeaderText = "Sale Price";
                dataGridViewSale.Columns["ReturnAmount"].HeaderText = "Return Amount";
                dataGridViewSale.Columns["ReturnDate"].HeaderText = "Return Date";
                dataGridViewSale.Columns["TotalPriceAfterReturn"].HeaderText = "Total After Return";
                dataGridViewSale.Columns["QuantityAfterReturn"].HeaderText = "Qnty After Return";


                dataGridViewSale.Columns["SerialId"].DisplayIndex = 0;
                dataGridViewSale.Columns["InvoiceNo"].DisplayIndex = 1;
                dataGridViewSale.Columns["MedName"].DisplayIndex = 2;
                dataGridViewSale.Columns["Name_Urdu"].DisplayIndex = 3;
                dataGridViewSale.Columns["BatchID"].DisplayIndex = 4;
                dataGridViewSale.Columns["OriginalQuantity"].DisplayIndex = 5;
                dataGridViewSale.Columns["ReturnQuantity"].DisplayIndex = 6;
                dataGridViewSale.Columns["SalePrice"].DisplayIndex = 7;
                dataGridViewSale.Columns["ReturnAmount"].DisplayIndex = 8;
                dataGridViewSale.Columns["ReturnDate"].DisplayIndex = 9;
                dataGridViewSale.Columns["TotalPriceAfterReturn"].DisplayIndex = 10;
                dataGridViewSale.Columns["QuantityAfterReturn"].DisplayIndex = 11;

                dataGridViewSale.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async void cmbBatchId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Initialize BAL instances
                var medicineBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
                var stockBal = new BAL.Stock(Helper.GetConnectionStringFromSettings());

                // Retrieve list of medicines and stock asynchronously
                List<BML.Medicine> medicineList = await medicineBal.GetMedicinesGroupAsync();
                List<BML.Stock> stockList = await stockBal.GetMedicineStockAsync();

                // Get the selected Medicine ID from the combo box
                string selectedStockId = cmbBatchId.Text.ToString().ToLower();
                string selectedMedicineId = cmbMedInformation.SelectedValue.ToString();

                // Find the corresponding medicine and stock in the lists
                var selectedMedicine = medicineList.FirstOrDefault(m => m.MedicineId == selectedMedicineId);
                var selectedStock = stockList.FirstOrDefault(s => s.BatchID == selectedStockId && s.MedicineID == selectedMedicineId);

                if (selectedStock != null)
                {
                    // Update UI with medicine information
                    txtManfPrice.Text = selectedMedicine.SellPrice.ToString();
                    txtExpiryDate.Text = Convert.ToDateTime(selectedStock.ExpiryDate).ToString("MM/dd/yyyy");
                    if (selectedStock.Quantity == 0)
                    {
                        txtStockQuantity.Text = selectedStock != null ? selectedStock.Quantity.ToString() : "0";
                        MessageBox.Show($"Medicine ## {selectedMedicine.Name} ## with BatchId ## {selectedStockId} ## is out of stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        txtStockQuantity.Text = selectedStock.Quantity.ToString();
                    }

                }
                else
                {
                    txtExpiryDate.Text = "MM/DD/YYYY";
                    txtManfPrice.Text = "0.00";
                    txtStockQuantity.Text = "0";
                }
            }
            catch (Exception)
            {

            }

        }
        private void txtPurchaseQnt_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStockQuantity.Text) && !string.IsNullOrEmpty(txtSaleQnt.Text))
            {
                if (!CalculateStockQuantity())
                {
                    MessageBox.Show($"Medicine quantity is exceeding from stock quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private int CalculateTotalQuantityInGrid(string medicineId, string batchId)
        {
            int totalQuantity = 0;

            foreach (DataGridViewRow row in dataGridViewSaleDetails.Rows)
            {
                if (row.Cells["MedIdColumn"].Value != null && row.Cells["BatchedColumn"].Value != null)
                {
                    string rowMedicineId = row.Cells["MedIdColumn"].Value.ToString();
                    string rowBatchId = row.Cells["BatchedColumn"].Value.ToString();

                    if (rowMedicineId == medicineId && rowBatchId == batchId)
                    {
                        int quantity;
                        if (int.TryParse(row.Cells["QuantityColumn"].Value.ToString(), out quantity))
                        {
                            totalQuantity += quantity;
                        }
                    }
                }
            }

            return totalQuantity;
        }
        private bool CalculateStockQuantity()
        {
            int totalStockQuantity = Convert.ToInt32(txtStockQuantity.Text);
            int quantity = Convert.ToInt32(txtSaleQnt.Text);
            int totalGridQuantity = CalculateTotalQuantityInGrid(cmbMedInformation.SelectedValue.ToString(), cmbBatchId.Text);
            int totalRequiredQuantity = quantity + totalGridQuantity;
            if (totalStockQuantity > totalRequiredQuantity || totalStockQuantity == totalRequiredQuantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(filterText))
            {
                filteredBindingList = new BindingList<SaleReturnAuditView>(originalBindingList);
            }
            else
            {

                var filteredList = originalBindingList.Where(Sale =>
   Sale.SerialId.ToString().ToLower().Contains(filterText) ||
   Sale.InvoiceNo.ToLower().Contains(filterText) ||
   Sale.MedName.ToLower().Contains(filterText) ||
   Sale.Name_Urdu.ToLower().Contains(filterText) ||
   Sale.OriginalQuantity.ToString().ToLower().Contains(filterText) ||
   Sale.ReturnQuantity.ToString().ToLower().Contains(filterText) ||
   Sale.SalePrice.ToString().ToLower().Contains(filterText) ||
   Sale.ReturnAmount.ToString().ToLower().Contains(filterText) ||
   Sale.ReturnDate.ToString("dd-MM-yyyy").ToLower().Contains(filterText) || // Assuming you want to filter based on the date format
   Sale.BatchID.ToString().ToLower().Contains(filterText)
).ToList();

                filteredBindingList = new BindingList<SaleReturnAuditView>(filteredList);
            }

            dataGridViewSale.DataSource = filteredBindingList;
        }
        private void txtSaleQnt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAdvTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, numeric digits, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtSaleQnt_Click(object sender, EventArgs e)
        {
            txtSaleQnt.Text = string.Empty;
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

        private void txtAdvTax_Click(object sender, EventArgs e)
        {
            txtAdvTax.Text = string.Empty;
        }

        private void dataGridViewSale_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the row index at the mouse position
            int rowIndex = dataGridViewSale.HitTest(e.X, e.Y).RowIndex;

            // If a row is clicked
            if (rowIndex >= 0)
            {
                // Select the clicked row
                dataGridViewSale.ClearSelection();
                dataGridViewSale.Rows[rowIndex].Selected = true;

                // Show the context menu strip at the mouse position
                contextMenuStripSale.Show(dataGridViewSale, e.Location);
            }
        }

        private void printReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewSale.SelectedRows.Count > 0)
            {
                string name = dataGridViewSale.SelectedRows[0].Cells["InvoiceNo"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to Print Report this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string OrderId = dataGridViewSale.SelectedRows[0].Cells["OrderID"].Value.ToString();
                    // Code to print the purchase
                    var frm = new rptSaleReturn(Helper.FormatGuid(OrderId));
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a medicine to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateQnty_Click(object sender, EventArgs e)
        {
            // Retrieve the OrderDetailID from the input field
            string orderDetailId = txtOrderid.Text;
            // Loop through the DataGridView rows to find the matching OrderDetailID
            foreach (DataGridViewRow row in dataGridViewSaleDetails.Rows)
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
                txtReturnQnty.Text = new string(inputText.Where(char.IsDigit).ToArray());
                txtReturnQnty.SelectionStart = txtReturnQnty.Text.Length; // Move cursor to end
                return;
            }

            // Check if the new quantity is greater than the old quantity
            if (int.TryParse(txtReturnQnty.Text, out int newQuantity) && int.TryParse(txtOldQnty.Text, out int oldQuantity))
            {
                if (newQuantity > oldQuantity)
                {
                    MessageBox.Show("The new quantity cannot be greater than the old quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReturnQnty.Text = oldQuantity.ToString(); // Reset to old quantity
                    txtReturnQnty.SelectionStart = txtReturnQnty.Text.Length; // Move cursor to end
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
    }
}
