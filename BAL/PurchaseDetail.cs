using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class PurchaseDetail
    {
        private readonly DAL.PurchaseDetail _purchaseDetailDAL;

        public PurchaseDetail(string connectionString)
        {
            _purchaseDetailDAL = new DAL.PurchaseDetail(connectionString);
        }

        public async Task<int> CreatePurchaseDetailAsync(string purchaseDetailId, string purchaseOrderId, string medicineId, string batchId, DateTime? expiryDate, int? quantity, decimal? total, decimal? gstTax, int? bonus,decimal? price, decimal? distDisc, DateTime? entiryDate)
        {
            try
            {
                return await _purchaseDetailDAL.CreatePurchaseDetailAsync(purchaseDetailId, purchaseOrderId, medicineId, batchId, expiryDate, quantity, total, gstTax, bonus,price, distDisc, entiryDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating purchase detail: {ex.Message}");
                return 0;
            }
        }
        public async Task<List<BML.PurchaseViewReturn>> GetPurchaseDetailReturnAsync(string invoiceid)
        {
            try
            {
                return await _purchaseDetailDAL.GetPurchaseDetailReturnAsync(invoiceid);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting purchase orders: {ex.Message}");
                return new List<BML.PurchaseViewReturn>();
            }
        }

        public async Task<List<BML.PurchaseReturnAuditView>> GetPurchaseReturnAuditAsync()
        {
            try
            {
                return await _purchaseDetailDAL.GetPurchaseReturnAuditAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting purchase orders: {ex.Message}");
                return new List<BML.PurchaseReturnAuditView>();
            }
        }


        public async Task<bool> HandlePurchaseReturnAsync(string orderId,string orderDetailId,string medid,string batchid,int quantity)
        {
            try
            {
                return await _purchaseDetailDAL.HandlePurchaseReturnAsync(orderId,orderDetailId,medid,batchid,quantity);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting purchase orders: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdatePurchaseReturnAsync(string purchaesDetailId, string medicineId, string batchId,string invoiceid)
        {
            try
            {
                return await _purchaseDetailDAL.UpdatePurchaseReturnAsync(purchaesDetailId,medicineId,batchId,invoiceid);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting purchase orders: {ex.Message}");
                return false;
            }
        }


    }
}
