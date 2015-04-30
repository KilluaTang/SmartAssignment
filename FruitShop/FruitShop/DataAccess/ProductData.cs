using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FruitShop.Models;
using System.Web.Configuration;

namespace FruitShop.DataAccess
{
    public class ProductData
    {
        private ShopContext db = new ShopContext();

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public Product GetProduct(int productId)
        {
            return db.Products.Find(productId);
        }

        public Deal GetDeal(int? dealId)
        {
            return db.Deals.Find(dealId);
        }

        public string GetImagePath()
        {
            return WebConfigurationManager.AppSettings["ImagePath"];
        }

        //public decimal GetProductDealPrice( int productId, int quantity )
        //{
        //    decimal sumDealPrice = 0.0m;
        //    decimal productPrice = GetProduct(productId).Price;
        //    switch (productId)
        //    {
        //        case 1:
        //            sumDealPrice = (quantity / 3) * 5 + (quantity % 3) * productPrice;
        //            break;
        //        case 2:
        //            sumDealPrice = productPrice * quantity;
        //            break;
        //        case 3:
        //            if( quantity > 3 )
        //            {
        //                if (quantity % 2 != 0)
        //                {
        //                    // TODO
        //                    //quantity is odd
        //                    sumDealPrice = productPrice * (quantity / 2);
        //                }
        //                else
        //                {
        //                    // TODO
        //                    //quantity is even
        //                    sumDealPrice = quantity * productPrice;
        //                }
        //            }
        //            else
        //            {
        //                // If quantity its 1 or 2 the price remain but increase the quantity by 1 if its 2.
        //                sumDealPrice = quantity * productPrice;
        //            }
        //            break;
        //    }

        //    return sumDealPrice;
        //}
    }
}