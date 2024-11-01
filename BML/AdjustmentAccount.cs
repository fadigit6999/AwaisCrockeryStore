using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class AdjustmentAccount
    {
        public int SerialId { get; set; }
        public string AccountID { get; set; }
        public string TransactionID { get; set; }
        public string TransactionType { get; set; }
        public DateTime DepositDate { get; set; }
        public decimal TotalDepositAmount { get; set; }
        public string Remarks { get; set; }
    }
}
