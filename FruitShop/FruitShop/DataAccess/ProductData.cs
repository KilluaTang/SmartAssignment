using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FruitShop.Models;

namespace FruitShop.DataAccess
{
    public static class ProductData
    {
        static List<Product> products = new List<Product>();
        static string defaultProductImagePath = "~/Content/ProductImage/";

        static ProductData()
        {
            products.Add(new Product
            {
                ProductId = 1,
                Price = 2.0m,
                ProductName = "Apple",
                ImageName = "Apple.jpg",
                ImagePath = defaultProductImagePath,
                Description = "Yummy Apple! Nice and Sweet!",
                Deal = "Apples are R2 each, but you get 3 apples for R5!",
                QuantityLimit = -1
            });

            products.Add(new Product
            {
                ProductId = 2,
                Price = 3.0m,
                ProductName = "Banana",
                ImageName = "Banana.jpg",
                Description = "Banana?! Baaaaaa naaaaaa naaaaaaa!",
                Deal = "Banana are R3 each, but you can only buy a maximum of 10",
                QuantityLimit = 10
            });

            products.Add(new Product
            {
                ProductId = 3,
                Price = 4.0m,
                ProductName = "Coconut",
                ImageName = "Coconut.jpg",
                Description = "Ee Man we sell it cheap cheap!",
                Deal = "Coconuts are R4 each, but if you buy 2 you get 1 free.",
                QuantityLimit = -1
            });
        }

        public static List<Product> GetProducts()
        {
            return products;
        }

        public static Product GetProduct( int productId )
        {
            return products.Single(product => product.ProductId == productId);
        }

        public static decimal GetProductDealPrice( int productId, int quantity )
        {
            decimal sumDealPrice = 0.0m;
            decimal productPrice = GetProduct(productId).Price;
            switch (productId)
            {
                case 1:
                    sumDealPrice = (quantity / 3) * 5 + (quantity % 3) * productPrice;
                    break;
                case 2:
                    sumDealPrice = productPrice * quantity;
                    break;
                case 3:
                    if( quantity > 3 )
                    {
                        if (quantity % 2 != 0)
                        {
                            // TODO
                            //quantity is odd
                            sumDealPrice = productPrice * (quantity / 2);
                        }
                        else
                        {
                            // TODO
                            //quantity is even
                            sumDealPrice = quantity * productPrice;
                        }
                    }
                    else
                    {
                        // If quantity its 1 or 2 the price remain but increase the quantity by 1 if its 2.
                        sumDealPrice = quantity * productPrice;
                    }
                    break;
            }

            return sumDealPrice;
        }
    }
}