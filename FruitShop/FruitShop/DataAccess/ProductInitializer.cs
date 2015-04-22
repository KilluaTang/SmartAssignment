using FruitShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FruitShop.DataAccess
{
    public class ProductInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    Price = 2.0m,
                    ProductName = "Apple",
                    ImageName = "Apple.jpg",
                    Description = "Yummy Apple! Nice and Sweet!",
                    //DealId = "Apples are R2 each, but you get 3 apples for R5!",
                    QuantityLimit = -1
                },
                
                new Product
                {
                    ProductId = 2,
                    Price = 3.0m,
                    ProductName = "Banana",
                    ImageName = "Banana.jpg",
                    Description = "Banana?! Baaaaaa naaaaaa naaaaaaa!",
                    //DealId = "Banana are R3 each, but you can only buy a maximum of 10",
                    QuantityLimit = 10
                },
                
                new Product
                {
                    ProductId = 3,
                    Price = 4.0m,
                    ProductName = "Coconut",
                    ImageName = "Coconut.jpg",
                    Description = "Ee Man we sell it cheap cheap!",
                    //DealId = "Coconuts are R4 each, but if you buy 2 you get 1 free.",
                    QuantityLimit = -1
                }
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}