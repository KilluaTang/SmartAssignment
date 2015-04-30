using FruitShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FruitShop.DataAccess
{
    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var products = new List<Product>
            {
                new Product
                {
                    Price = 2.0m,
                    ProductName = "Apple",
                    ImageName = "Apple.jpg",
                    Description = "Yummy Apple! Nice and Sweet!",
                    DealId = 1
                },
                
                new Product
                {
                    Price = 3.0m,
                    ProductName = "Banana",
                    ImageName = "Banana.jpg",
                    Description = "Banana?! Baaaaaa naaaaaa naaaaaaa!",
                    DealId = 2,
                    QuantityLimit = 10
                },
                
                new Product
                {
                    Price = 4.0m,
                    ProductName = "Coconut",
                    ImageName = "Coconut.jpg",
                    Description = "Ee Man we sell it cheap cheap!",
                    DealId = 3
                }
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var deals = new List<Deal>
            {
                new Deal
                {
                    DealName = "Buy 3 in discount price",
                    DealDescription = "Buy 3 for R5"
                },

                new Deal
                {
                    DealName = "Pachurse Quantity Limit",
                    DealDescription = "Can only buy maximum of 10"
                },

                new Deal
                {
                    DealName = "Buy 2 get 1 free",
                    DealDescription = "Buy 2 get 1 free"
                }
            };

            deals.ForEach(s => context.Deals.Add(s));
            context.SaveChanges();
        }
    }
}