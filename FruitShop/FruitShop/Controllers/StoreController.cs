using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

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
        model.ImagePath = products.GetImagePath();

        if (model.Product.DealId != null)
        {
            model.Deal = products.GetDeal(model.Product.DealId);
        }

        if (model.Product == null)
        {
            return HttpNotFound();
        }

        return View(model);
    }

    //// GET: Product/Edit/5
    //public ActionResult Edit(int? id)
    //{
    //    if (id == null)
    //    {
    //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //    }
    //    Product product = db.Products.Find(id);
    //    if (product == null)
    //    {
    //        return HttpNotFound();
    //    }
    //    ViewBag.DealId = new SelectList(db.Deals, "DealId", "DealName", product.DealId);
    //    return View(product);
    //}

    //// POST: Product/Edit/5
    //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult Edit([Bind(Include = "ProductId,ProductName,Price,ImageName,Description,DealId,QuantityLimit")] Product product)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        db.Entry(product).State = EntityState.Modified;
    //        db.SaveChanges();
    //        return RedirectToAction("Index");
    //    }
    //    ViewBag.DealId = new SelectList(db.Deals, "DealId", "DealName", product.DealId);
    //    return View(product);
    //}
  }
}