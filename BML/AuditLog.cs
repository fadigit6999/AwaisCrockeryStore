using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class AuditLog
    {
        public DateTime ChangeDate { get; set; }
        public string? ChangeDescription { get; set; }
    }

}
