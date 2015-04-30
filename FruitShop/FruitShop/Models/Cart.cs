using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FruitShop.DataAccess;

namespace FruitShop.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}