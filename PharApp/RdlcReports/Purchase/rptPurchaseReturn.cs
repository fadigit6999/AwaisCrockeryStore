using Microsoft.Reporting.WinForms;
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

namespace PharApp.RdlcReports.Purchase
{
    public partial class rptPurchaseReturn : Form
    {
        private readonly string _id;
        public rptPurchaseReturn(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void rptPurchase_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = Helper.GetConnectionStringFromSettings();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("ManagePurchaseOrder", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", "Purchase_Return_rpt");
                        cmd.Parameters.AddWithValue("@PurchaseOrderId", _id);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DSPurchaseReturn ds = new DSPurchaseReturn();
                        da.Fill(ds, "DT_Purchase_Return"); // Ensure the DataTable  RDLC

                        ReportDataSource dataSource = new ReportDataSource("DSPurchaseReturn", ds.Tables[0]);
                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dataSource);

                        // Set the path to the RDLC file relative to the executable
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "PharApp.RdlcReports.Purchase.rptPurchaseReturn.rdlc";

                        this.reportViewer1.RefreshReport();
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
