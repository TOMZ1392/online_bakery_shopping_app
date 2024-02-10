using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBakeryShopper.Models
{
    public class UserDetails
    {
        public string UserName { get; set; }
        public int UserRole { get; set; }
        public string UserPassword { get; set; }
        public long UserSessionId { get; set; }
        public int ActivityStat { get; set; }

       
    }
}
