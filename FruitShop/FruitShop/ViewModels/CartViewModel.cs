using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FruitShop.Models;

namespace FruitShop.ViewModels
{
    public class CartViewModel
    {
        public IEnumerable<Product> ProductsInCart { get; set; }
    }
}