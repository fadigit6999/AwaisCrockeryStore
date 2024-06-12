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
    public class Stock
    {
        private readonly string _connectionString;

        public Stock(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> ManageStockAsync(string operation, string medicineId, string batchId, DateTime? expiryDate, int? quantity, decimal? purchasePrice, decimal? salesPrice)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageStock", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", operation);
                command.Parameters.AddWithValue("@MedicineID", medicineId);
                command.Parameters.AddWithValue("@BatchID", batchId);
                command.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@PurchasePrice", purchasePrice);
                command.Parameters.AddWithValue("@SalesPrice", salesPrice);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> SaleStockAsync(string operation, string medicineId, string batchId, DateTime? expiryDate, int? quantity, decimal? purchasePrice, decimal? salesPrice)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageStock", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", operation);
                command.Parameters.AddWithValue("@MedicineID", medicineId);
                command.Parameters.AddWithValue("@BatchID", batchId);
                command.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@PurchasePrice", purchasePrice);
                command.Parameters.AddWithValue("@SalesPrice", salesPrice);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<List<BML.Stock>> GetMedicineStockAsync()
        {
            List<BML.Stock> stockList = new List<BML.Stock>();

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    using (var command = new SqlCommand("SELECT * FROM MedicineStock", connection))
                    {
                        await connection.OpenAsync();

                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                // Create a new StockModel object and populate it with data from the reader
                                BML.Stock stock = new BML.Stock
                                {
                                    MedicineID = reader["MedicineID"].ToString(),
                                    BatchID = reader["BatchID"].ToString(),
                                    ExpiryDate = reader["ExpiryDate"] != DBNull.Value ? (DateTime)reader["ExpiryDate"] : (DateTime?)null,
                                    Quantity = reader["Quantity"] != DBNull.Value ? (int)reader["Quantity"] : (int?)null,
                                    PurchasePrice = reader["PurchasePrice"] != DBNull.Value ? (decimal)reader["PurchasePrice"] : (decimal?)null,
                                    SalesPrice = reader["SalesPrice"] != DBNull.Value ? (decimal)reader["SalesPrice"] : (decimal?)null,
                                    StockValue = reader["StockValue"] != DBNull.Value ? (decimal)reader["StockValue"] : (decimal?)null
                                };

                                // Add the stock object to the list
                                stockList.Add(stock);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetMedicineStockAsync: {ex.Message}");
            }

            return stockList;
        }

        public async Task<List<BML.ViewStock>> GetViewStockAsync()
        {
            List<BML.ViewStock> stockList = new List<BML.ViewStock>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageStock", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "ViewStock");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.ViewStock stock = new BML.ViewStock
                        {
                            SL = reader["SL"].ToString(),
                            MedName = reader["MedName"].ToString(),
                            ManufacturerName = reader["ManufacturerName"].ToString(),
                            SalePrice = reader["SalePrice"].ToString(),
                            PurchasePrice = reader["PurchasePrice"].ToString(),
                            InQuantity = reader["InQuantity"].ToString(),
                            SoldQuantity = reader["SoldQuantity"].ToString(),
                            Stock = reader["Stock"].ToString(),
                            StockSellPrice = reader["StockSellPrice"].ToString(),
                            StockPurchasePrice = reader["StockPurchasePrice"].ToString(),
                            BatchId = reader["BatchId"].ToString(),
                            ExpiryDate = reader["ExpiryDate"].ToString()
                        };
                        stockList.Add(stock);
                    }
                }
            }

            return stockList;
        }


    }
}
