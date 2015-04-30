using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FruitShop.Models
{
    public class Deal
    {
        public int DealId { get; set; }
        public string DealName { get; set; }
        public string DealDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}