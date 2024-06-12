using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class SaleDetail
    {
        private readonly DAL.SaleDetail _saleOrderDetailDAL;

        public SaleDetail(string connectionString)
        {
            _saleOrderDetailDAL = new DAL.SaleDetail(connectionString);
        }

        public async Task<int> CreateSaleOrderDetailAsync(string salesOrderId, string medicineId, string batchId, DateTime expiryDate, int quantity, decimal total, decimal gstTax, int bonus, decimal price, decimal distDisc, DateTime entryDate, bool warrantyApplicable)
        {
            try
            {
                return await _saleOrderDetailDAL.CreateSaleOrderDetailAsync(salesOrderId, medicineId, batchId, expiryDate, quantity, total, gstTax, bonus,price, distDisc, entryDate, warrantyApplicable);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating sale order detail: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> UpdateSaleOrderDetailAsync(string salesDetailId, string salesOrderId, string medicineId, string batchId, DateTime expiryDate, int quantity, decimal total, decimal gstTax, int bonus, decimal distDisc, DateTime entryDate, int serialId, bool warrantyApplicable)
        {
            try
            {
                return await _saleOrderDetailDAL.UpdateSaleOrderDetailAsync(salesDetailId, salesOrderId, medicineId, batchId, expiryDate, quantity, total, gstTax, bonus, distDisc, entryDate, serialId, warrantyApplicable);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating sale order detail: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> DeleteSaleOrderDetailAsync(string salesDetailId)
        {
            try
            {
                return await _saleOrderDetailDAL.DeleteSaleOrderDetailAsync(salesDetailId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting sale order detail: {ex.Message}");
                return 0;
            }
        }

        public async Task<bool> HandleSaleStockReturnAsync(string medId, string batchid, int quantity)
        {
            try
            {
                return await _saleOrderDetailDAL.HandleSaleStockReturnAsync(medId, batchid, quantity);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting purchase orders: {ex.Message}");
                return false;
            }
        }
        public async Task<List<BML.SaleViewReturn>> GetSaleDetailReturnAsync(string invoiceid)
        {
            try
            {
                return await _saleOrderDetailDAL.GetPurchaseDetailReturnAsync(invoiceid);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting purchase orders: {ex.Message}");
                return new List<BML.SaleViewReturn>();
            }
        }

        public async Task<bool> UpdateSaleReturnAsync(string saleDetailId, string medicineId, string batchId, string invoiceid)
        {
            try
            {
                return await _saleOrderDetailDAL.UpdateSaleReturnAsync(saleDetailId, medicineId, batchId, invoiceid);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting purchase orders: {ex.Message}");
                return false;
            }
        }
    }
}
