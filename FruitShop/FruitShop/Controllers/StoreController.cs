using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using FruitShop.DataAccess;
using FruitShop.Models;
using FruitShop.ViewModels;

namespace FruitShop.Controllers
{
  public class StoreController : Controller
  {
    // GET: Products
    public ActionResult Index()
    {
      ProductData products = new ProductData();

      StoreViewModel model = new StoreViewModel();
      model.Products = products.GetProducts();

      return View(model);
    }

    public ActionResult ProductView(int id)
    {
      ProductData products = new ProductData();

      StoreViewModel model = new StoreViewModel();
      model.Product = products.GetProduct(id);

      return View(model);
    }
  }
}