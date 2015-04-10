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
      StoreViewModel model = new StoreViewModel();
      model.Products = ProductData.GetProducts();

      return View(model);
    }

    public ActionResult ProductView(int id)
    {
      StoreViewModel model = new StoreViewModel();
      model.Product = ProductData.GetProduct(id);

      return View(model);
    }
  }
}