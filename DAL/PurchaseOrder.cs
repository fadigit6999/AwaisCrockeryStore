using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PurchaseOrder
    {
        private readonly string _connectionString;

        public PurchaseOrder(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreatePurchaseOrderAsync(string purchaseOrderId, string manufacturerId, DateTime? purchaseDate,string invoiceNo, string paymentTypeId, decimal? total, decimal? grandTotal, decimal? advTax)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManagePurchaseOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@PurchaseOrderId", purchaseOrderId);
                command.Parameters.AddWithValue("@ManufacturerId", manufacturerId);
                command.Parameters.AddWithValue("@PurchaseDate", purchaseDate ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@InvoiceNo", invoiceNo);
                command.Parameters.AddWithValue("@PaymentTypeId", paymentTypeId);
                command.Parameters.AddWithValue("@Total", total ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Grand_Total", grandTotal ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Adv_Tax", advTax ?? (object)DBNull.Value);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }
        public async Task<int> UpdatePurchaseOrderAsync(string purchaseOrderId, string manufacturerId, DateTime? purchaseDate, int? invoiceNo, string paymentTypeId)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManagePurchaseOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Update");
                command.Parameters.AddWithValue("@PurchaseOrderId", purchaseOrderId);
                command.Parameters.AddWithValue("@ManufacturerId", manufacturerId);
                command.Parameters.AddWithValue("@PurchaseDate", purchaseDate ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@InvoiceNo", invoiceNo ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PaymentTypeId", paymentTypeId);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> DeletePurchaseOrderAsync(string purchaseOrderId)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManagePurchaseOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Delete");
                command.Parameters.AddWithValue("@PurchaseOrderId", purchaseOrderId);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<List<BML.PurchaseOrder>> GetPurchaseOrdersAsync()
        {
            List<BML.PurchaseOrder> purchaseOrders = new List<BML.PurchaseOrder>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManagePurchaseOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Read");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.PurchaseOrder purchaseOrder = new BML.PurchaseOrder
                        {
                            PurchaseOrderId = reader["PurchaseOrderId"].ToString(),
                            ManufacturerId = reader["ManufacturerId"].ToString(),
                            PurchaseDate = reader["PurchaseDate"] != DBNull.Value ? (DateTime)reader["PurchaseDate"] : (DateTime?)null,
                            InvoiceNo = reader["InvoiceNo"] != DBNull.Value ? (int)reader["InvoiceNo"] : (int?)null,
                            PaymentTypeId = reader["PaymentTypeId"].ToString()
                        };
                        purchaseOrders.Add(purchaseOrder);
                    }
                }
            }

            return purchaseOrders;
        }

        public async Task<string> GetFutureInvoiceNumberAsync()
        {
            try
            {
                string nextInvoiceNumber = null;

                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("ManagePurchaseOrder", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Operation", "GetFutureInvoice");

                        await connection.OpenAsync();

                        // Execute the scalar query to retrieve the result directly
                        object result = await command.ExecuteScalarAsync();

                        // Check if the result is not null and convert it to string
                        if (result != null)
                        {
                            nextInvoiceNumber = result.ToString();
                        }
                    }
                }

                return nextInvoiceNumber;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting future invoice number: {ex.Message}");
                return null;
            }
        }

        public async Task<List<BML.ViewPurchase>> ViewPurchaseAsync()
        {
            List<BML.ViewPurchase> purchaseOrders = new List<BML.ViewPurchase>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManagePurchaseOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Purchase");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.ViewPurchase purchaseOrder = new BML.ViewPurchase
                        {
                            OrderID = reader["OrderID"].ToString(),
                            MedName = reader["MedName"].ToString(),
                            Total = reader["Total"].ToString(),
                            ManufacturerName = reader["ManufacturerName"].ToString(),
                            InvoiceNo = reader["InvoiceNo"].ToString(),
                            Quantity = reader["Quantity"].ToString(),
                            TypeName = reader["TypeName"].ToString(),
                            BatchId = reader["BatchId"].ToString().ToUpper(),
                            ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"].ToString()).ToString("dd/MM/yyyy") 
                        };
                        purchaseOrders.Add(purchaseOrder);
                    }
                }
            }

            return purchaseOrders;
        }

        public async Task<List<BML.ViewPurchase>> ViewPurchaseReturnAsync()
        {
            List<BML.ViewPurchase> purchaseOrders = new List<BML.ViewPurchase>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManagePurchaseOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "PurchaseReturn");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.ViewPurchase purchaseOrder = new BML.ViewPurchase
                        {
                            OrderID = reader["OrderID"].ToString(),
                            MedName = reader["MedName"].ToString(),
                            Total = reader["Total"].ToString(),
                            ManufacturerName = reader["ManufacturerName"].ToString(),
                            InvoiceNo = reader["InvoiceNo"].ToString(),
                            Quantity = reader["Quantity"].ToString(),
                            TypeName = reader["TypeName"].ToString(),
                            BatchId = reader["BatchId"].ToString(),
                            ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"].ToString()).ToString("dd/MM/yyyy")
                        };
                        purchaseOrders.Add(purchaseOrder);
                    }
                }
            }

            return purchaseOrders;
        }
    }
}
