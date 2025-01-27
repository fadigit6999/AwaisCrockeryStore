using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class ViewDeposit
    {
        public string? TrxAccountId { get; set; } 
        public string? AccountID { get; set; }
        public string? TransactionType { get; set; }
        public string? Total { get; set; }  // Total transaction amount
        public string? Paid { get; set; }  // Amount paid in the transaction
        public string? Balanace { get; set; }     // Remaining balance
        
    }
}
