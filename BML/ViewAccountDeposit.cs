using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class ViewAccountDeposit
    {
        public string SerialId { get; set; }
        public string TransactionDate { get; set; }
        public string AccountID { get; set; }
        public string TrxAccountId { get; set; }
        public string TransactionType { get; set; }
        public string PaymentMethod { get; set; }
        public string CreditAmount { get; set; }
        public string DebitAmount { get; set; }
        public string BankName { get; set; }
        public string CheckNo { get; set; }
        public string Remarks { get; set; }
    }
}
