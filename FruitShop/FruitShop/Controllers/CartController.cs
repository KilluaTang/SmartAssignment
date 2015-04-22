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
  public class CartController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Add(int id)
    {
      return RedirectToAction("Index");
    }

    public ActionResult RemoveItem(int id)
    {
      return RedirectToAction("Index");
    }
  }
}