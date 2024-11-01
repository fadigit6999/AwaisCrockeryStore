using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class ViewAdjustmentDeposit
    {
        public string TrxId { get; set; }
        public int SerialId { get; set; }
        public string AccountID { get; set; }
        public string TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string BankName { get; set; }
        public string CheckNo { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal Balance { get; set; }
        public string Remarks { get; set; }
        public DateTime CreatedDate { get; set; }
        public int isPaid { get; set; }
    }
}
