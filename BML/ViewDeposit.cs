using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class ViewDeposit
    {
        public string? TransactionID { get; set; } // Unique identifier for each transaction
        public string? TransactionDate { get; set; } // Date of the transaction
        public string? AccountID { get; set; }     // Foreign key from AccountTable
        public string? InvoiceNo { get; set; }     // Invoice number related to the transaction
        public string? PaymentMethod { get; set; } // 'Cash', 'Debit', 'Credit', 'Online Banking', or 'Check'
        public string? BankName { get; set; } = string.Empty; // Optional bank name for online or check payments
        public string? CheckNo { get; set; } = string.Empty;  // Optional check number for check payments
        public string? TransactionType { get; set; } // 'Sale' or 'Purchase'
        public decimal? TotalAmount { get; set; }  // Total transaction amount
        public decimal? PaidAmount { get; set; }  // Amount paid in the transaction
        public decimal? Balance { get; set; }     // Remaining balance
        public string Remarks { get; set; } = string.Empty; // Any additional remarks for the transaction
        
    }
}
