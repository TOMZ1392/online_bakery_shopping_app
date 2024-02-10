using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBakeryShopper.Models.Users
{
    public class CustomerDetails
    {
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddr1 { get; set; }
        public string CustomerAddr2 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public long PinCode { get; set; }
        public long PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserPasswordMatch { get; set; }
    }
}
