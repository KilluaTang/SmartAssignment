using System.Collections.Generic;
using System.Web;
using FruitShop.Models;

namespace FruitShop.DataAccess
{
    public class CartData
    {
        public const string CartSessionKey = "CartSession";
        private ShopContext db = new ShopContext();

        public CartData()
        {
        }

        //public static List<Product> GetItemsInCart()
        //{
        //    List<Product> productItemsInCart = new List<Product>();

        //    foreach(var product in Instance.ItemsInCart)
        //    {
        //    productItemsInCart.Add(ProductData.GetProduct(product.ProductId));
        //    }

        //    return productItemsInCart;
        //}

        ////  AddItem() - Adds an item to the Cart
        //public static void AddItem(int productId)
        //{
        //    CartItem newItem = new CartItem(productId);

        //    if (Instance.ItemsInCart.Exists(cartItem => cartItem.ProductId == productId))
        //    {
        //    foreach (CartItem item in Instance.ItemsInCart)
        //    {
        //        if (item.Equals(newItem))
        //        {
        //        item.Quantity += newItem.Quantity;
        //        return;
        //        }
        //    }
        //    }
        //    else
        //    {
        //    Instance.ItemsInCart.Add(newItem);
        //    }
        //}

        //// RemoveItem() - Removes an item from the shopping cart
        //public static void RemoveItem(int productId)
        //{
        //    CartItem removedItem = new CartItem(productId);
        //    Instance.ItemsInCart.Remove(removedItem);
        //}

        //// GetSubTotal() - returns the total price of all of the items in cart.
        //public static decimal GetSubTotal()
        //{
        //    decimal subTotal = 0;
        //    foreach (CartItem item in Instance.ItemsInCart)
        //    {
        //    subTotal += ProductData.GetProductDealPrice(item.ProductId, item.Quantity);
        //    }

        //    return subTotal;
        //}
    }
}