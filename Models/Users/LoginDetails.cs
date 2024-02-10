using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheBakeryShopper.Models.Users
{
    public class LoginDetails
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int UserRole { get; set; }
        public string UserPassword { get; set; }
        public long UserSessionId { get; set; }
        public int ActivityStat { get; set; }

    }
}
