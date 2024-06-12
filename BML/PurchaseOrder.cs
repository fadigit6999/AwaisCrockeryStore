using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class PurchaseOrder
    {
        public string? PurchaseOrderId { get; set; }
        public string? ManufacturerId { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public int? InvoiceNo { get; set; }
        public string? PaymentTypeId { get; set; }
        public decimal? Total { get; set; }
        public decimal? Grand_Total { get; set; }
        public decimal? Adv_Tax { get; set; }
    }

}
