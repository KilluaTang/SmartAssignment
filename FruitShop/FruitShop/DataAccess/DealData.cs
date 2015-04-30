using FruitShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FruitShop.DataAccess
{
    public class DealData
    {
        private ShopContext db = new ShopContext();

        public Deal GetDeal(int dealId)
        {
            return db.Deals.Find(dealId);
        }
    }
}