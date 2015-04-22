using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FruitShop.DataAccess;

namespace FruitShop.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Count { get; set; }

        public CartItem(int productId)
        {
            this.ProductId = productId;
        }
    }
}