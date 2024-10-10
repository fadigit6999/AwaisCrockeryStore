using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Account
    {
        public string? AccountID { get; set; } 
        public int? SerialId { get; set; } 
        public string? AccountName { get; set; } 
        public string? AccountType { get; set; } 
        public decimal? CurrentBalance { get; set; } 
        public string? CreatedDate { get; set; }
    }
}
