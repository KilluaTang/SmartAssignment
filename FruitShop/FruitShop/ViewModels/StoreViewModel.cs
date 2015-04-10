using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FruitShop.Models;

namespace FruitShop.ViewModels
{
    public class StoreViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public Product Product { get; set; }
    }
}