using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class ViewAdjustmentAccount
    {
        public string AccountID { get; set; }
        public string TransactionID { get; set; }
        public string TransactionType { get; set; }
        public DateTime DepositDate { get; set; }
        public decimal TotalDepositAmount { get; set; }
        public string Remarks { get; set; }
    }
}
