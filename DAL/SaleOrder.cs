using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SaleOrder
    {
        private readonly string _connectionString;

        public SaleOrder(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreateSaleOrderAsync(string salesOrderId, string customerId, DateTime? salesDate, string paymentTypeId, string invoiceNo, decimal total, decimal grandTotal, decimal advTax, string invoiceType, string Area = "",string bookerid = "",string supplierid = "")
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSalesOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@SalesOrderId", salesOrderId);
                command.Parameters.AddWithValue("@CustomerId", customerId);
                command.Parameters.AddWithValue("@SalesDate", salesDate ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PaymentTypeId", paymentTypeId);
                command.Parameters.AddWithValue("@InvoiceNo", invoiceNo);
                command.Parameters.AddWithValue("@Total", total);
                command.Parameters.AddWithValue("@GrandTotal", grandTotal);
                command.Parameters.AddWithValue("@AdvTax", advTax);
                command.Parameters.AddWithValue("@InvoiceType", invoiceType);
                command.Parameters.AddWithValue("@Sale_Area", Area);
                command.Parameters.AddWithValue("@BookerId", bookerid);
                command.Parameters.AddWithValue("@SupplierId", supplierid);


                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> UpdateSaleOrderAsync(string salesOrderId, string customerId, DateTime? salesDate, string paymentTypeId, string invoiceNo, decimal total, decimal grandTotal, decimal advTax, int serial, string invoiceType)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSalesOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Update");
                command.Parameters.AddWithValue("@SalesOrderId", salesOrderId);
                command.Parameters.AddWithValue("@CustomerId", customerId);
                command.Parameters.AddWithValue("@SalesDate", salesDate ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PaymentTypeId", paymentTypeId);
                command.Parameters.AddWithValue("@InvoiceNo", invoiceNo);
                command.Parameters.AddWithValue("@Total", total);
                command.Parameters.AddWithValue("@GrandTotal", grandTotal);
                command.Parameters.AddWithValue("@AdvTax", advTax);
                command.Parameters.AddWithValue("@Serial", serial);
                command.Parameters.AddWithValue("@InvoiceType", invoiceType);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> DeleteSaleOrderAsync(string salesOrderId)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSalesOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Delete");
                command.Parameters.AddWithValue("@SalesOrderId", salesOrderId);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<List<BML.ViewSale>> GetSaleOrdersAsync()
        {
            List<BML.ViewSale> saleOrders = new List<BML.ViewSale>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSalesOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Sales");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.ViewSale saleOrder = new BML.ViewSale
                        {
                            OrderID = reader["OrderID"].ToString(),
                            MedName = reader["MedName"].ToString(),
                            BatchId= reader["BatchId"].ToString(),
                            InvType= reader["EstimateStatus"].ToString(),
                            ExpiryDate =Convert.ToDateTime(reader["ExpiryDate"]).ToString("dd/MM/yyyy"),
                            Quantity = reader["Quantity"].ToString(),
                            Total= reader["Total"].ToString(),
                            InvoiceNo = reader["InvoiceNo"].ToString(),
                            Customer= reader["CustomerName"].ToString(),
                            TypeName= reader["TypeName"].ToString(),
                            AreaName = reader["AreaName"].ToString(),
                            BookerName = reader["BookerName"].ToString(),
                            SupplierName= reader["SupplierName"].ToString()
                        };
                        saleOrders.Add(saleOrder);
                    }
                }
            }

            return saleOrders;
        }
        public async Task<List<BML.ViewSale>> GetSaleReturnOrdersAsync()
        {
            List<BML.ViewSale> saleOrders = new List<BML.ViewSale>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSalesOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "SalesReturn");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.ViewSale saleOrder = new BML.ViewSale
                        {
                            OrderID = reader["OrderID"].ToString(),
                            MedName = reader["MedName"].ToString(),
                            BatchId = reader["BatchId"].ToString(),
                            InvType = reader["EstimateStatus"].ToString(),
                            ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"]).ToString("dd/MM/yyyy"),
                            Quantity = reader["Quantity"].ToString(),
                            Total = reader["Total"].ToString(),
                            InvoiceNo = reader["InvoiceNo"].ToString(),
                            Customer = reader["CustomerName"].ToString(),
                            TypeName = reader["TypeName"].ToString(),   
                            AreaName = reader["AreaName"].ToString(),
                            BookerName = reader["BookerName"].ToString(),
                            SupplierName = reader["SupplierName"].ToString()
                        };
                        saleOrders.Add(saleOrder);
                    }
                }
            }

            return saleOrders;
        }

        public async Task<string> GetNextInvoiceNumberAsync()
        {
            try
            {
                string nextInvoiceNumber = null;

                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("ManageSalesOrder", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Operation", "GetNextInvoiceNumber");

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
                Console.WriteLine($"Error getting next invoice number: {ex.Message}");
                return null;
            }
        }
    }
}
