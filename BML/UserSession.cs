using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    internal class UserSession
    {
        public static AspNetUser? User { get; set; }
        public static AspNetRole? Role { get; set; }
    }
}
