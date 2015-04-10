﻿using System;
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
      var productsInCart = CartData.GetItems();
      return View(productsInCart);
    }

    public ActionResult Add(int id)
    {
      CartData.AddItem(id);
      return RedirectToAction("Index");
    }

    public ActionResult RemoveItem(int id)
    {
      CartData.RemoveItem(id);
      return RedirectToAction("Index");
    }
  }
}