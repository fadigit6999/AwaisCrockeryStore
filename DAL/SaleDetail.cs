using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BML;

namespace DAL
{
    public class SaleDetail
    {
        private readonly string _connectionString;

        public SaleDetail(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreateSaleOrderDetailAsync(string salesOrderId, string medicineId, string batchId, DateTime expiryDate, int quantity, decimal total, decimal gstTax, int bonus, decimal price, decimal distDisc, DateTime entryDate, bool warrantyApplicable)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSalesDetails", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@SalesOrderId", salesOrderId);
                command.Parameters.AddWithValue("@MedicineId", medicineId);
                command.Parameters.AddWithValue("@BatchId", batchId);
                command.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Total", total);
                command.Parameters.AddWithValue("@GstTax", gstTax);
                command.Parameters.AddWithValue("@Bonus", bonus);
                command.Parameters.AddWithValue("@DistDisc", distDisc);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@EntryDate", entryDate);
                command.Parameters.AddWithValue("@WarrantyApplicable", warrantyApplicable);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> UpdateSaleOrderDetailAsync(string salesDetailId, string salesOrderId, string medicineId, string batchId, DateTime expiryDate, int quantity, decimal total, decimal gstTax, int bonus, decimal distDisc, DateTime entryDate, int serialId, bool warrantyApplicable)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSalesDetails", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Update");
                command.Parameters.AddWithValue("@SalesDetailId", salesDetailId);
                command.Parameters.AddWithValue("@SalesOrderId", salesOrderId);
                command.Parameters.AddWithValue("@MedicineId", medicineId);
                command.Parameters.AddWithValue("@BatchId", batchId);
                command.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Total", total);
                command.Parameters.AddWithValue("@GstTax", gstTax);
                command.Parameters.AddWithValue("@Bonus", bonus);
                command.Parameters.AddWithValue("@DistDisc", distDisc);
                command.Parameters.AddWithValue("@EntryDate", entryDate);
                command.Parameters.AddWithValue("@SerialId", serialId);
                command.Parameters.AddWithValue("@WarrantyApplicable", warrantyApplicable);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> DeleteSaleOrderDetailAsync(string salesDetailId)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSaleOrderDetail", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Delete");
                command.Parameters.AddWithValue("@SalesDetailId", salesDetailId);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }
        public async Task<bool> HandleSaleStockReturnAsync(string medicineId, string batchId, int quantity)
        {
            bool result = false;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageStock", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters for the stored procedure
                command.Parameters.AddWithValue("@Operation", "Sale_Return");
                command.Parameters.AddWithValue("@MedicineID", medicineId);
                command.Parameters.AddWithValue("@BatchID", batchId);
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

        public async Task<bool> UpdateSaleReturnAsync(string saleDetailId, string medicineId, string batchId, string invoiceNo)
        {
            bool result = false;
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSalesDetails", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "UpdateSaleReturn");
                command.Parameters.AddWithValue("@SalesDetailId", saleDetailId);
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
        public async Task<List<BML.SaleViewReturn>> GetPurchaseDetailReturnAsync(string id)
        {
            List<BML.SaleViewReturn> saleDetails = new List<BML.SaleViewReturn>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSalesDetails", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "ViewDetailReturn"); // Assuming this parameter is required for your stored procedure
                command.Parameters.AddWithValue("@InvoiceNo", id);
                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.SaleViewReturn saleDetail = new BML.SaleViewReturn
                        {
                            SalesDetailId = reader["SalesDetailId"] != DBNull.Value ? reader["SalesDetailId"].ToString() : null,
                            BatchId = reader["BatchId"] != DBNull.Value ? reader["BatchId"].ToString() : null,
                            ExpiryDate = reader["ExpiryDate"] != DBNull.Value ? reader["ExpiryDate"].ToString() : null,
                            Quantity = reader["Quantity"] != DBNull.Value ? reader["Quantity"].ToString() : null,
                            Total = reader["Total"] != DBNull.Value ? reader["Total"].ToString() : null,
                            GstTax= reader["GstTax"] != DBNull.Value ? reader["GstTax"].ToString() : null,
                            Bonus = reader["Bonus"] != DBNull.Value ? reader["Bonus"].ToString() : null,
                            DistDisc= reader["DistDisc"] != DBNull.Value ? reader["DistDisc"].ToString() : null,
                            SaleDate = reader["SalesDate"] != DBNull.Value ? reader["SalesDate"].ToString() : null,
                            InvoiceNo = reader["InvoiceNo"] != DBNull.Value ? reader["InvoiceNo"].ToString() : null,
                            MedName = reader["MedName"] != DBNull.Value ? reader["MedName"].ToString() : null,
                            ManufacturerPrice = reader["ManufacturerPrice"] != DBNull.Value ? reader["ManufacturerPrice"].ToString() : null,
                            SalesOrderId = reader["SalesOrderId"] != DBNull.Value ? reader["SalesOrderId"].ToString() : null,
                            MedicineId = reader["MedicineId"] != DBNull.Value ? reader["MedicineId"].ToString() : null
                        };
                        saleDetails.Add(saleDetail);
                    }
                }
            }

            return saleDetails;
        }

    }
}
