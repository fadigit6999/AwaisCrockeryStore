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
        public string SerialId { get; set; }
        public string AccountID { get; set; }
        public string TransactionID { get; set; }
        public string TransactionType { get; set; }
        public string TransactionDate { get; set; }
        public string TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string BankName { get; set; }
        public string CheckNo { get; set; }
        public string PaidAmount { get; set; }
        public string Balance { get; set; }
        public string Remarks { get; set; }
        public string CreatedDate { get; set; }
        public string isPaid { get; set; }
    }
}
