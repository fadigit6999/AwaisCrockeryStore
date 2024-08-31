using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class PurchaseReturnAuditView
    {
        public string MedName { get; set; }
        public string Name_Urdu { get; set; }
        public string BatchID { get; set; }
        public int OriginalQuantity { get; set; }
        public int ReturnQuantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal ReturnAmount { get; set; }
        public DateTime ReturnDate { get; set; }
        public string InvoiceNo { get; set; }
        public int SerialId { get; set; }
        public int QuantityAfterReturn { get; set; }
        public decimal TotalPriceAfterReturn { get; set; }

    }
}
