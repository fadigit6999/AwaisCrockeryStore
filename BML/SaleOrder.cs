using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class SaleOrder
    {
        public string? SalesOrderId { get; set; }
        public string? CustomerId { get; set; }
        public DateTime SalesDate { get; set; }
        public string? PaymentTypeId { get; set; }
        public string? InvoiceNo { get; set; }
        public decimal Total { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal AdvTax { get; set; }
        public DateTime EntryDate { get; set; }
        public int Serial { get; set; }
        public string? InvoiceType { get; set; }
    }
}
