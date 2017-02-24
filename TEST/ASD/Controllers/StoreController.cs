using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASD.Models;

namespace ASD.Controllers
{
    public class StoreController : Controller
    {
        private store db = new store();

        //
        // GET: /Store/

        public ActionResult Index()
        {
            var products = db.Product.ToList();

            return View(products);
        }

        // GET: /Store/Browse?genre=Disco

          public ActionResult Browse(string product)
          {
          //   Retrieve Genre and its Associated Albums from database
          /*     var productModel = db.Products.Include("Products")
                  .Single(p => p.Product_name == product); */

              return View(product);
          } 

        //
        // GET: /Store/Details/5

        public ActionResult Details(int id)
        {
            var products = db.Product.Find(id);

            return View(products);
        }

        //
        // GET: /Store/GenreMenu

        [ChildActionOnly]
        public ActionResult ProductMenu()
        {
            var products = db.Product.ToList();

            return PartialView(products);
        }

    }
}