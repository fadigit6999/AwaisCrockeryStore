using BML;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DAL
{
    public class PurchaseDetail
    {
        private readonly string _connectionString;

        public PurchaseDetail(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreatePurchaseDetailAsync(string purchaseDetailId, string purchaseOrderId, string medicineId, string batchId, DateTime? expiryDate, int? quantity, decimal? total, decimal? gstTax, int? bonus, decimal? price, decimal? distDisc, DateTime? entiryDate)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManagePurchaseDetails", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@PurchaseDetailId", purchaseDetailId);
                command.Parameters.AddWithValue("@PurchaseOrderId", purchaseOrderId);
                command.Parameters.AddWithValue("@MedicineId", medicineId);
                command.Parameters.AddWithValue("@BatchId", batchId);
                command.Parameters.AddWithValue("@ExpiryDate", expiryDate ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Quantity", quantity ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Total", total ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Gst_tax", gstTax ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Bonus", bonus ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Dist_disc", distDisc ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Price", price ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Entiry_date", entiryDate ?? (object)DBNull.Value);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<List<BML.PurchaseViewReturn>> GetPurchaseDetailReturnAsync(string id)
        {
            List<PurchaseViewReturn> purchaseDetails = new List<PurchaseViewReturn>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManagePurchaseDetails", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "ViewDetailReturn"); // Assuming this parameter is required for your stored procedure
                command.Parameters.AddWithValue("@InvoiceNo", id);
                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        PurchaseViewReturn purchaseDetail = new PurchaseViewReturn
                        {
                            PurchaseDetailId = reader["PurchaseDetailId"].ToString(),
                            BatchId = reader["BatchId"].ToString(),
                            ExpiryDate = reader["ExpiryDate"].ToString(),
                            Quantity = reader["Quantity"].ToString(),
                            Total = reader["Total"].ToString(),
                            Gst_tax = reader["Gst_tax"].ToString(),
                            Bonus = reader["Bonus"].ToString(),
                            Dist_disc = reader["Dist_disc"].ToString(),
                            PurchaseDate = reader["PurchaseDate"].ToString(),
                            InvoiceNo = reader["InvoiceNo"].ToString(),
                            MedName = reader["MedName"].ToString(),
                            ManufacturerPrice = reader["ManufacturerPrice"].ToString(),
                            PurchaseOrderId = reader["PurchaseOrderId"].ToString(),
                            MedicineId = reader["MedicineId"].ToString()
                        };
                        purchaseDetails.Add(purchaseDetail);
                    }
                }
            }

            return purchaseDetails;
        }
        public async Task<List<PurchaseReturnAuditView>> GetPurchaseReturnAuditAsync()
        {
            List<PurchaseReturnAuditView> purchaseReturnAudits = new List<PurchaseReturnAuditView>();

            try
            {
                
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("ManagePurchaseDetails", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operation", "ViewReturnItems");
                    await connection.OpenAsync();
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var purchaseReturnAudit = new PurchaseReturnAuditView
                            {
                                MedName = reader["MedName"].ToString(),
                                Name_Urdu = reader["Name_Urdu"].ToString(),
                                BatchID = reader["BatchID"].ToString(),
                                OriginalQuantity = Convert.ToInt32(reader["OriginalQuantity"]),
                                ReturnQuantity = Convert.ToInt32(reader["ReturnQuantity"]),
                                PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"]),
                                ReturnAmount = Convert.ToDecimal(reader["ReturnAmount"]),
                                ReturnDate = Convert.ToDateTime(reader["ReturnDate"]),
                                InvoiceNo = reader["InvoiceNo"].ToString(),
                                SerialId = Convert.ToInt32(reader["serialid"]),
                                TotalPriceAfterReturn = Convert.ToDecimal(reader["TotalPriceAfterReturn"]),
                                QuantityAfterReturn = Convert.ToInt32(reader["QuantityAfterReturn"])
                            };
                            purchaseReturnAudits.Add(purchaseReturnAudit);
                        }
                    }
                }

                return purchaseReturnAudits;
            }
            catch (Exception ex)
            {
                return purchaseReturnAudits;
                Debug.WriteLine(ex);
            }
      
        }


        public async Task<bool> HandlePurchaseReturnAsync(string purchaseOrderId, string purchaseDetialId,string medid,string batchid, int quantity)
        {
            bool result = false;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageStock", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters for the stored procedure
                command.Parameters.AddWithValue("@Operation", "Purchase_Return_New");
                command.Parameters.AddWithValue("@PurchaseOrderId", purchaseOrderId);
                command.Parameters.AddWithValue("@PurchaseDetailId", purchaseDetialId);
                command.Parameters.AddWithValue("@MedicineID", medid);
                command.Parameters.AddWithValue("@BatchID", batchid);
                command.Parameters.AddWithValue("@Quantity", quantity);

                await connection.OpenAsync();

                try
                {
                    // Execute the command and check if any rows were affected
                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    result = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Handle any potential errors here
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            return result;
        }

        public async Task<bool> UpdatePurchaseReturnAsync(string purchaseDetailId, string medicineId, string batchId, string invoiceNo)
        {
            bool result = false;
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManagePurchaseDetails", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "UpdatePurchseReturn");
                command.Parameters.AddWithValue("@PurchaseDetailId", purchaseDetailId);
                command.Parameters.AddWithValue("@MedicineId", medicineId);
                command.Parameters.AddWithValue("@BatchId", batchId.ToLower().ToString());
                command.Parameters.AddWithValue("@InvoiceNo", invoiceNo);

                await connection.OpenAsync();

                try
                {
                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    result = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            return result;
        }

    }

}
