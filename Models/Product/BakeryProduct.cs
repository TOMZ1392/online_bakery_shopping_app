using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBakeryShopper.Models.Product
{
    public class BakeryProduct
    {

        public int ProductId { get; set; }
        public KeyValuePair<int,string> ProductType { get; set; }
        public List<KeyValuePair<int, string>> ProductTypeDetails;
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int ProductQty { get; set; }
        public bool Availability { get; set; }
        public int PreparationTime { get; set; }
        public IFormFile ImgPath { get; set; }
        public string ServerImgPath { get; set; }
        public int Discount { get; set; }
        public float DiscountedPrice { get; set; }
        public bool IsBestSeller { get; set; }
        public int PurchaseCount { get; set; }
        public BakeryProduct()
        {
            this.IsBestSeller = false;
            this.Availability = false;
            /*ProductTypeNames = new List<string>() {
                "Pasty","PlumCakes","BirthdayCakes","Ice Creams"
            };*/

        }
        public void SetDiscountedPrice()
        {

            this.DiscountedPrice = Price - (Price * Discount) / 100;
        }
        public void ToggleBestSeller()
        {
            if (IsBestSeller)
            {
                IsBestSeller = false;
            }
            else
            {
                IsBestSeller = true;
            }
        }


    }
}
