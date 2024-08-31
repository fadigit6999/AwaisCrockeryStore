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
    public partial class frmPurchase : Form
    {
        private BindingList<ViewPurchase> originalPurchaseList;
        private BindingList<ViewPurchase> filteredPurchaseList;
        public frmPurchase()
        {
            InitializeComponent();
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            PopulateComboBoxManufacturer();
            PopulateComboBoxPaymentType();
            LoadFutureInvoice();
            DefaultDetails();
            ClearDetailsGrid();
            LoadGridDataViewPurchase();
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
                    MedicineDictionary.Add("Choose Item", Guid.NewGuid().ToString());

                    foreach (var medicine in popMedicineList)
                    {
                        MedicineDictionary.Add($"{medicine.Name}({medicine.Strength}{medicine.Unit}-{medicine.BoxSize})", medicine.MedicineId);
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
                    if (cmbPaymentTypeList != null && cmbPaymentTypeList.Count>0)
                    {
                        foreach (var pt in cmbPaymentTypeList)
                        {
                            pTypeDictionary.Add(pt.TypeName, pt.PaymentTypeId);
                        }
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
            if (ValidateDetails())
            {
                // Get values from text boxes
                // Extract the selected value and text from the ComboBox
                string medInformationId = cmbMedInformation.SelectedValue?.ToString();
                string medInformation = cmbMedInformation.Text;

                // Extract other information from the text boxes
                string batchid = txtBatchId.Text;
                string expiryDate = dateTimeMedExpiry.Text;
                int quantity = Convert.ToInt32(txtPurchaseQnt.Text);
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
                dataGridViewPurchaseDetails.Rows.Add(medInformationId, medInformation, batchid, gstTax, discountPercentage, expiryDate, quantity, manufacturePrice, Math.Round(total, 2), "X");

                txtAdvTax.Text = "";
            }


        }

        private void dataGridViewPurchaseDetails_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the right mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                // Get the cell at the clicked point
                DataGridView.HitTestInfo hitTestInfo = dataGridViewPurchaseDetails.HitTest(e.X, e.Y);

                // Check if a cell is clicked and it's in the RemoveColumn
                try
                {
                    if (hitTestInfo.RowIndex >= 0 &&
                    dataGridViewPurchaseDetails.Columns[hitTestInfo.ColumnIndex].Name == "RemoveColumn")
                    {
                        // Remove the corresponding row
                        dataGridViewPurchaseDetails.Rows.RemoveAt(hitTestInfo.RowIndex);
                    }
                }
                catch (Exception)
                {

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
            else
            {
                txtGrandTotal.Text = txtTotal.Text;
            }
        }

        private bool ValidateDetails()
        {
            if (string.IsNullOrEmpty(cmbMedInformation.Text) || cmbMedInformation.Text == "Choose Item" || cmbMedInformation.SelectedIndex == -1)
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
            cmbMedInformation.Text = "Choose Item";
            txtBatchId.Text = "ItemCode";
            dateTimeMedExpiry.Value = DateTime.Today.AddDays(1);
            txtPurchaseQnt.Text = "1";
            txtManfPrice.Text = "0.00";
            txtGSTtx.Text = "0";
            txtDisc.Text = "0";
            txtBonus.Text = "0";
        }

        public void ClearDetailsGrid()
        {
            // Clear the DataGridView
            dataGridViewPurchaseDetails.DataSource = null;
            dataGridViewPurchaseDetails.Columns.Clear();

            // Add columns
            dataGridViewPurchaseDetails.Columns.Add("MedIdColumn", "Id");
            dataGridViewPurchaseDetails.Columns.Add("MedInformationColumn", "Item Info");
            dataGridViewPurchaseDetails.Columns.Add("BatchedColumn", "Item Code");
            dataGridViewPurchaseDetails.Columns.Add("GstTaxColumn", "GST%");
            dataGridViewPurchaseDetails.Columns.Add("DsicColumn", "Disc%");
            //dataGridViewPurchaseDetails.Columns.Add("BonusColumn", "Bonus");
            dataGridViewPurchaseDetails.Columns.Add("ExpiryDateColumn", "Ex. Date");
            dataGridViewPurchaseDetails.Columns.Add("QuantityColumn", "Qty.");
            dataGridViewPurchaseDetails.Columns.Add("ManfPriceColumn", "Mfg. Price");
            dataGridViewPurchaseDetails.Columns.Add("TotalColumn", "Total");
            dataGridViewPurchaseDetails.Columns.Add("RemoveColumn", "Remove");
        }

        private async void btnPurchase_Click(object sender, EventArgs e)
        {
            if (ValidateOrder())
            {
                if (dataGridViewPurchaseDetails.Rows.Count == 0)
                {
                    MessageBox.Show("Please ensure there is at least one Medicine in the purchase details grid before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string orderId = Guid.NewGuid().ToString();
                    string detail = txtDetail.Text;
                    string invoice = txtInvoice.Text;
                    decimal totalDecimal = decimal.Parse(txtTotal.Text);
                    decimal grandTotalDecimal = decimal.Parse(txtGrandTotal.Text);
                    decimal advTaxDecimal;
                    if (string.IsNullOrEmpty(txtAdvTax.Text))
                    {
                        advTaxDecimal = 0;
                    }
                    else
                    {
                        decimal.TryParse(txtAdvTax.Text, out advTaxDecimal);
                    }
                    string purchaseDateStr = purchaseDate.Value.ToString("yyyy-MM-dd"); // Format date as string
                    string paymentType = cmbPaymentType.SelectedValue?.ToString(); // Get selected item from combo box
                    string manufacturer = cmbManufacturer.SelectedValue?.ToString(); // Get selected item from combo box

                    //Order Process
                    var purchaseIrderBAL = new BAL.PurchaseOrder(Helper.GetConnectionStringFromSettings());
                    int result = await purchaseIrderBAL.CreatePurchaseOrderAsync(orderId, manufacturer, Convert.ToDateTime(purchaseDate.Value), invoice, paymentType, totalDecimal, grandTotalDecimal, advTaxDecimal);
                    Helper.Log("Purchase Order Created: " + " ," + orderId + " ," + manufacturer + " ," + Convert.ToDateTime(purchaseDate.Value) + " ," + invoice + " ," + paymentType + " ," + totalDecimal + " ," + grandTotalDecimal + " ," + advTaxDecimal);
                    if (result == 1)
                    {
                        // Assuming dataGridViewPurchaseDetails is the DataGridView control
                        foreach (DataGridViewRow row in dataGridViewPurchaseDetails.Rows)
                        {
                            // Check if the row is not the new row
                            if (!row.IsNewRow)
                            {
                                // Retrieve values from cells
                                string purchaseDetailId = Guid.NewGuid().ToString();
                                string purchaseOrderId = orderId.ToString();
                                string medicineId = row.Cells["MedIdColumn"].Value?.ToString();
                                string batchId = row.Cells["BatchedColumn"].Value?.ToString();
                                DateTime? expiryDate = Convert.ToDateTime(row.Cells["ExpiryDateColumn"].Value);
                                int? quantity = row.Cells["QuantityColumn"].Value as int?;
                                decimal? total = row.Cells["TotalColumn"].Value as decimal?;
                                decimal? gstTax = row.Cells["GstTaxColumn"].Value as decimal?;
                                decimal? purchaseprice = row.Cells["ManfPriceColumn"].Value as decimal?;
                                //decimal? salePrice = row.Cells["GstTaxColumn"].Value as decimal?;
                                int? bonus = 0;
                                decimal? distDisc = Convert.ToDecimal(row.Cells["DsicColumn"].Value) as decimal?;

                                var purchaseOrderDetailsBAL = new BAL.PurchaseDetail(Helper.GetConnectionStringFromSettings());
                                result = await purchaseOrderDetailsBAL.CreatePurchaseDetailAsync(purchaseDetailId, purchaseOrderId, medicineId, Helper.ProcessString(batchId), expiryDate, quantity, total, gstTax, bonus, purchaseprice, distDisc, DateTime.Now);
                                Helper.Log("Purchase details Created: " + purchaseOrderId + " ," + medicineId + " ," + Helper.ProcessString(batchId) + " ," + expiryDate + " ," + quantity + " ," + total + " ," + gstTax + " ," + bonus + " ," + purchaseprice + " ," + distDisc + " ," + DateTime.Now);
                                if (result >= 1)
                                {
                                    var stockBAL = new BAL.Stock(Helper.GetConnectionStringFromSettings());
                                    result = await stockBAL.ManageStockAsync("Create", medicineId, batchId.ToString().ToLower().Replace(" ", ""), expiryDate, quantity, 0, 0);
                                    Helper.Log("Pruchase Stock Changes:" + medicineId + " ," + batchId.ToString().ToLower().Replace(" ", "") + " ," + expiryDate + " ," + quantity + " ," + 0 + " ," + 0);

                                }
                            }
                        }

                        if (result >= 1)
                        {
                            DefaultDetails();
                            ClearOrderValues();
                            ClearDetailsGrid();
                            LoadGridDataViewPurchase();
                            // Display success message
                            DialogResult msg = MessageBox.Show("Purchase registered successfully. Do you want to print the purchase?",
                                      "Success",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                            if (msg == DialogResult.Yes)
                            {
                                // Code to print the purchase
                                var frm = new rptPurchase(orderId);
                                frm.ShowDialog();
                            }
                        }
                        else
                        {
                            // Display failure message
                            MessageBox.Show("Failed to register the Purchase. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
                var purchaseBal = new BAL.PurchaseOrder(Helper.GetConnectionStringFromSettings());
                var purchaseList = await purchaseBal.ViewPurchaseAsync();

                originalPurchaseList = new BindingList<ViewPurchase>(purchaseList);
                filteredPurchaseList = new BindingList<ViewPurchase>(purchaseList);

                dataGridViewPurchase.DataSource = originalPurchaseList;
                dataGridViewPurchase.Columns["OrderID"].DisplayIndex = 0;
                dataGridViewPurchase.Columns["InvoiceNo"].DisplayIndex = 1;
                dataGridViewPurchase.Columns["MedName"].DisplayIndex = 2;
                dataGridViewPurchase.Columns["ManufacturerName"].DisplayIndex = 3;
                dataGridViewPurchase.Columns["TypeName"].DisplayIndex = 4;
                dataGridViewPurchase.Columns["Quantity"].DisplayIndex = 7;
                dataGridViewPurchase.Columns["Total"].DisplayIndex = 8;
                dataGridViewPurchase.Columns["ExpiryDate"].DisplayIndex = 5;
                dataGridViewPurchase.Columns["BatchId"].DisplayIndex = 6;

                dataGridViewPurchase.Columns["OrderID"].HeaderText = "Id";
                dataGridViewPurchase.Columns["InvoiceNo"].HeaderText = "Invoice";
                dataGridViewPurchase.Columns["MedName"].HeaderText = "Item";
                dataGridViewPurchase.Columns["ManufacturerName"].HeaderText = "Mgf.";
                dataGridViewPurchase.Columns["Quantity"].HeaderText = "Quantity";
                dataGridViewPurchase.Columns["Total"].HeaderText = "Gr. Total";
                dataGridViewPurchase.Columns["TypeName"].HeaderText = "Payment";
                dataGridViewPurchase.Columns["ExpiryDate"].HeaderText = "Ex. Date";
                dataGridViewPurchase.Columns["BatchId"].HeaderText = "Item Code";

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
                filteredPurchaseList = new BindingList<ViewPurchase>(originalPurchaseList);
            }
            else
            {
                var filteredList = originalPurchaseList.Where(purchase =>
                    purchase.OrderID.ToString().ToLower().Contains(filterText) ||
                    purchase.InvoiceNo.ToLower().Contains(filterText) ||
                    purchase.MedName.ToLower().Contains(filterText) ||
                    purchase.ManufacturerName.ToLower().Contains(filterText) ||
                    purchase.Quantity.ToString().ToLower().Contains(filterText) ||
                    purchase.Total.ToString().ToLower().Contains(filterText) ||
                    purchase.TypeName.ToLower().Contains(filterText) ||
                    purchase.ExpiryDate.ToString().ToLower().Contains(filterText) ||
                    purchase.BatchId.ToLower().Contains(filterText)
                ).ToList();

                filteredPurchaseList = new BindingList<ViewPurchase>(filteredList);
            }

            dataGridViewPurchase.DataSource = filteredPurchaseList;

            dataGridViewPurchase.Columns["OrderID"].DisplayIndex = 0;
            dataGridViewPurchase.Columns["InvoiceNo"].DisplayIndex = 1;
            dataGridViewPurchase.Columns["MedName"].DisplayIndex = 2;
            dataGridViewPurchase.Columns["ManufacturerName"].DisplayIndex = 3;
            dataGridViewPurchase.Columns["TypeName"].DisplayIndex = 4;
            dataGridViewPurchase.Columns["Quantity"].DisplayIndex = 7;
            dataGridViewPurchase.Columns["Total"].DisplayIndex = 8;
            dataGridViewPurchase.Columns["ExpiryDate"].DisplayIndex = 5;
            dataGridViewPurchase.Columns["BatchId"].DisplayIndex = 6;

            dataGridViewPurchase.Columns["OrderID"].HeaderText = "Id";
            dataGridViewPurchase.Columns["InvoiceNo"].HeaderText = "Invoice";
            dataGridViewPurchase.Columns["MedName"].HeaderText = "Item";
            dataGridViewPurchase.Columns["ManufacturerName"].HeaderText = "Mgf.";
            dataGridViewPurchase.Columns["Quantity"].HeaderText = "Quantity";
            dataGridViewPurchase.Columns["Total"].HeaderText = "Gr. Total";
            dataGridViewPurchase.Columns["TypeName"].HeaderText = "Payment";
            dataGridViewPurchase.Columns["ExpiryDate"].HeaderText = "Ex. Date";
            dataGridViewPurchase.Columns["BatchId"].HeaderText = "Item Code";

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
                    var frm = new rptPurchase(Helper.FormatGuid(OrderId));
                    frm.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Please select a medicine to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewPurchase.SelectedRows.Count > 0)
            {
                string name = dataGridViewPurchase.SelectedRows[0].Cells["InvoiceNo"].Value.ToString();
                string OrderId = dataGridViewPurchase.SelectedRows[0].Cells["OrderID"].Value.ToString();
                // Prompt the user for confirmation
                var frm = new frmPurchaseReturn(name,OrderId);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a medicine to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGridDataViewPurchase();
        }
    }
}
