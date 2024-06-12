using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Stock
    {
        private readonly DAL.Stock _stockDAL;

        public Stock(string connectionString)
        {
            _stockDAL = new DAL.Stock(connectionString);
        }

        public async Task<int> ManageStockAsync(string operation, string medicineId, string batchId, DateTime? expiryDate, int? quantity, decimal? purchasePrice, decimal? salesPrice)
        {
            try
            {
                return await _stockDAL.ManageStockAsync(operation, medicineId, batchId, expiryDate, quantity, purchasePrice, salesPrice);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in StockBAL: {ex.Message}");
                return 0; // Return 0 indicating failure
            }
        }

        public async Task<int> SaleStockAsync(string operation, string medicineId, string batchId, DateTime? expiryDate, int? quantity, decimal? purchasePrice, decimal? salesPrice)
        {
            try
            {
                return await _stockDAL.SaleStockAsync(operation, medicineId, batchId, expiryDate, quantity, purchasePrice, salesPrice);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in StockBAL: {ex.Message}");
                return 0; // Return 0 indicating failure
            }
        }

        public async Task<List<BML.Stock>> GetMedicineStockAsync()
        {
            try
            {
                return await _stockDAL.GetMedicineStockAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in StockBAL - GetMedicineStockAsync: {ex.Message}");
                return new List<BML.Stock>(); // Return an empty list in case of error
            }
        }

        public async Task<List<BML.ViewStock>> GetViewStockAsync() 
        {
            try
            {
                return await _stockDAL.GetViewStockAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in StockBAL - GetMedicineStockAsync: {ex.Message}");
                return new List<BML.ViewStock>(); // Return an empty list in case of error
            }

        }

    }
}
