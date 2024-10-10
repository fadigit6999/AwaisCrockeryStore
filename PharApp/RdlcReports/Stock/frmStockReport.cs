using Microsoft.Reporting.WinForms;
using PharApp.RdlcReports.Purchase;
using PharApp.WinHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharApp.RdlcReports.Stock
{
    public partial class frmStockReport : Form
    {
        public frmStockReport()
        {
            InitializeComponent();
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
                    ManufacturerDictionary.Add("-- Choose Manufacturer --", Guid.NewGuid().ToString());
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

        private void frmStockReport_Load(object sender, EventArgs e)
        {
            //load Dropdown for the Manufacturer
            PopulateComboBoxManufacturer();
            //Load Report for All Stock
            LoadReportDefault();
        }

        private void btnMfg_Click(object sender, EventArgs e)
        {
            if (ValidateMfg())
            {
                string mfg = cmbManufacturer.SelectedValue.ToString();

                try
                {
                    string connectionString = Helper.GetConnectionStringFromSettings();
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("ManageStock", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Operation", "StockReport");
                            cmd.Parameters.AddWithValue("@Mfg", mfg);


                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DSPurchase ds = new DSPurchase();
                            da.Fill(ds, "DT_Stock"); // Ensure the DataTable  RDLC

                            ReportDataSource dataSource = new ReportDataSource("DTStock", ds.Tables[2]);
                            this.reportViewerStock.LocalReport.DataSources.Clear();
                            this.reportViewerStock.LocalReport.DataSources.Add(dataSource);

                            // Set the path to the RDLC file relative to the executable
                            this.reportViewerStock.LocalReport.ReportEmbeddedResource = "PharApp.RdlcReports.Stock.Stock.rdlc";

                            this.reportViewerStock.RefreshReport();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private bool ValidateMfg()
        {
            if (string.IsNullOrEmpty(cmbManufacturer.Text) || cmbManufacturer.Text == "-- Choose Manufacturer --" || cmbManufacturer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Mfg!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        void LoadReportDefault()
        {
            try
            {
                string connectionString = Helper.GetConnectionStringFromSettings();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("ManageStock", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", "StockReport");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DSPurchase ds = new DSPurchase();
                        da.Fill(ds, "DT_Stock"); // Ensure the DataTable  RDLC

                        ReportDataSource dataSource = new ReportDataSource("DTStock", ds.Tables[2]);
                        this.reportViewerStock.LocalReport.DataSources.Clear();
                        this.reportViewerStock.LocalReport.DataSources.Add(dataSource);

                        // Set the path to the RDLC file relative to the executable
                        this.reportViewerStock.LocalReport.ReportEmbeddedResource = "PharApp.RdlcReports.Stock.Stock.rdlc";

                        this.reportViewerStock.RefreshReport();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAllStock_Click(object sender, EventArgs e)
        {
            LoadReportDefault();
        }
    }
}
