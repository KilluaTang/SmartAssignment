using System.Collections.Generic;
using System.Web;
using FruitShop.Models;

namespace FruitShop.DataAccess
{
  public class CartData
  {
    public List<CartItem> ItemsInCart { get; set; }
    public const string CartSessionKey = "CartSession";
    public static readonly CartData Instance;

    static CartData()
    {
      if (HttpContext.Current.Session[CartSessionKey] == null)
      {
        Instance = new CartData();
        Instance.ItemsInCart = new List<CartItem>();
        HttpContext.Current.Session[CartSessionKey] = Instance;
      }
      else
      {
        Instance = (CartData)HttpContext.Current.Session[CartSessionKey];
      }
    }

    public static List<CartItem> GetItems()
    {
      return Instance.ItemsInCart;
    }

    //  AddItem() - Adds an item to the Cart
    public static void AddItem(int productId)
    {
      CartItem newItem = new CartItem(productId);

      if (Instance.ItemsInCart.Contains(newItem))
      {
        foreach (CartItem item in Instance.ItemsInCart)
        {
          if (item.Equals(newItem))
          {
            item.Quantity += newItem.Quantity;
            return;
          }
        }
      }
      else
      {
        Instance.ItemsInCart.Add(newItem);
      }
    }

    // RemoveItem() - Removes an item from the shopping cart
    public static void RemoveItem(int productId)
    {
      CartItem removedItem = new CartItem(productId);
      Instance.ItemsInCart.Remove(removedItem);
    }

    // GetSubTotal() - returns the total price of all of the items in cart.
    public static decimal GetSubTotal()
    {
      decimal subTotal = 0;
      foreach (CartItem item in Instance.ItemsInCart)
      {
        subTotal += ProductData.GetProductDealPrice(item.ProductId, item.Quantity);
      }

      return subTotal;
    }
  }
}