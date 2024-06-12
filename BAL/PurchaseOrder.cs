using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class PurchaseOrder
    {
        private readonly DAL.PurchaseOrder _purchaseOrderDAL;

        public PurchaseOrder(string connectionString)
        {
            _purchaseOrderDAL = new DAL.PurchaseOrder(connectionString);
        }

        public async Task<int> CreatePurchaseOrderAsync(string purchaseOrderId, string manufacturerId, DateTime purchaseDate, string invoiceNo, string paymentTypeId, decimal total, decimal grandTotal, decimal advTax)
        {
            try
            {
                return await _purchaseOrderDAL.CreatePurchaseOrderAsync(purchaseOrderId, manufacturerId, purchaseDate, invoiceNo, paymentTypeId, total, grandTotal, advTax);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating purchase order: {ex.Message}");
                return 0;
            }
        }


        public async Task<int> UpdatePurchaseOrderAsync(string purchaseOrderId, string manufacturerId, DateTime purchaseDate, int invoiceNo, string paymentTypeId)
        {
            try
            {
                return await _purchaseOrderDAL.UpdatePurchaseOrderAsync(purchaseOrderId, manufacturerId, purchaseDate, invoiceNo, paymentTypeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating purchase order: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> DeletePurchaseOrderAsync(string purchaseOrderId)
        {
            try
            {
                return await _purchaseOrderDAL.DeletePurchaseOrderAsync(purchaseOrderId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting purchase order: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<BML.PurchaseOrder>> GetPurchaseOrdersAsync()
        {
            try
            {
                return await _purchaseOrderDAL.GetPurchaseOrdersAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting purchase orders: {ex.Message}");
                return new List<BML.PurchaseOrder>();
            }
        }

        public async Task<string> GetFutureInvoiceNumberAsync()
        {
            try
            {
                return await _purchaseOrderDAL.GetFutureInvoiceNumberAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting future invoice number: {ex.Message}");
                return null;
            }
        }

        public async Task<List<BML.ViewPurchase>> ViewPurchaseAsync()
        {
            try
            {
                return await _purchaseOrderDAL.ViewPurchaseAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting purchase orders: {ex.Message}");
                return new List<BML.ViewPurchase>();
            }
        }

        public async Task<List<BML.ViewPurchase>> ViewPurchaseReturnAsync()
        {
            try
            {
                return await _purchaseOrderDAL.ViewPurchaseReturnAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting purchase orders: {ex.Message}");
                return new List<BML.ViewPurchase>();
            }
        }
    }
}
