using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TheBakeryShopper.Models.Product

{
    public class ProductType
    {
       

        public int BakeryTypeId { get; set; }
        
        public string BakeryTypeName { get; set; }
        public bool TypeAvailability { get; set; }
        public int TypeDiscount { get; set; }
        public IFormFile TypeImage { get; set; }
        public string ServerImgPath { get; set; }
        public int CountItems { get; set; }
        public int CountPurchase { get; set; }
        public ProductType()
        {
            this.CountItems = 0;
            this.CountPurchase = 0;
            this.TypeAvailability = false;
        }
    }
}
