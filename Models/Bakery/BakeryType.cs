using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBakeryShopper.Models
{
    public class BakeryType
    {
        public int BakeryTypeId { get; set; }
        public string  BakeryTypeName { get; set; }
        public bool TypeAvailability { get; set; }
        public int TypeDiscount { get; set; }
        public IFormFile TypeImage { get; set; }
        public int CountItems { get; set; }
        public int CountPurchase { get; set; }
        public BakeryType()
        {
            this.CountItems = 0;
            this.CountPurchase = 0;
            this.TypeAvailability = false;
        }
       
    }
}
