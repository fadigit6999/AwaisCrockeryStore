using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class PurchaseDetail
    {
        public string? PurchaseDetailId { get; set; }
        public string? PurchaseOrderId { get; set; }
        public string? MedicineId { get; set; }
        public string? BatchId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? Quantity { get; set; }
        public decimal? Total { get; set; }
        public decimal? GstTax { get; set; }
        public int? Bonus { get; set; }
        public decimal? DistDisc { get; set; }
        public DateTime? EntiryDate { get; set; }
    }



}
