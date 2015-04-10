using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FruitShop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string Deal { get; set; }
        public int QuantityLimit { get; set; }
    }
}