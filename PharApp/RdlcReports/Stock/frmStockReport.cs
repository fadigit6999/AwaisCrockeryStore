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

        private void frmStockReport_Load(object sender, EventArgs e)
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

    }
}
