using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class SaleOrder
    {
        private readonly DAL.SaleOrder _saleOrderDAL;
        public SaleOrder(string connectionString)
        {
            _saleOrderDAL = new DAL.SaleOrder(connectionString);
        }
        public async Task<int> CreateSaleOrderAsync(string salesOrderId, string customerId, DateTime salesDate, string paymentTypeId, string invoiceNo, decimal total, decimal grandTotal, decimal advTax, string invoiceType,string Area,string bookerid = "", string supplierid = "")
        {
            try
            {
                return await _saleOrderDAL.CreateSaleOrderAsync(salesOrderId, customerId, salesDate, paymentTypeId, invoiceNo, total, grandTotal, advTax, invoiceType, Area,bookerid,supplierid);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating sale order: {ex.Message}");
                return 0;
            }
        }
        public async Task<int> UpdateSaleOrderAsync(string salesOrderId, string customerId, DateTime salesDate, string paymentTypeId, string invoiceNo, decimal total, decimal grandTotal, decimal advTax, int serial, string invoiceType)
        {
            try
            {
                return await _saleOrderDAL.UpdateSaleOrderAsync(salesOrderId, customerId, salesDate, paymentTypeId, invoiceNo, total, grandTotal, advTax, serial, invoiceType);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating sale order: {ex.Message}");
                return 0;
            }
        }
        public async Task<int> DeleteSaleOrderAsync(string salesOrderId)
        {
            try
            {
                return await _saleOrderDAL.DeleteSaleOrderAsync(salesOrderId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting sale order: {ex.Message}");
                return 0;
            }
        }
        public async Task<List<BML.ViewSale>> GetSaleOrdersAsync()
        {
            try
            {
                return await _saleOrderDAL.GetSaleOrdersAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting sale orders: {ex.Message}");
                return new List<BML.ViewSale>();
            }
        }
        public async Task<List<BML.ViewSale>> GetSaleReturnOrdersAsync()
        {
            try
            {
                return await _saleOrderDAL.GetSaleReturnOrdersAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting sale orders: {ex.Message}");
                return new List<BML.ViewSale>();
            }
        }
        public async Task<string> GetNextInvoiceNumberAsync()
        {
            try
            {
                return await _saleOrderDAL.GetNextInvoiceNumberAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting next invoice number: {ex.Message}");
                return null;
            }
        }

    }
}
