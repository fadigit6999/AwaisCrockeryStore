using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class PurchaseViewReturn
    {
        public string? PurchaseDetailId { get; set; }
        public string? BatchId { get; set; }
        public string? ExpiryDate { get; set; }
        public string? Quantity { get; set; }
        public string? Total { get; set; }
        public string? Gst_tax { get; set; }
        public string? Bonus { get; set; }
        public string? Dist_disc { get; set; }
        public string? PurchaseDate { get; set; }
        public string? InvoiceNo { get; set; }
        public string? MedName { get; set; }
        public string? ManufacturerPrice { get; set; }
        public string? PurchaseOrderId { get; set; }
        public string? MedicineId { get; set; }

    }
}
