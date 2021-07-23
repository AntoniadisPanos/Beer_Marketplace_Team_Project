using Omadiko.Database;
using Omadiko.Entities;
using Omadiko.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Product
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
        public ActionResult ProductInfo(int? id)
        {
           if(id is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if(product is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            var mostpopular = db.Products.Where(x => x.Popularity >= 3).OrderByDescending(x => x.Popularity).Take(5).ToList();

            IndexHomeViewModel vm = new IndexHomeViewModel()
            {
                Product = product,
                BestProductsByPopularity = mostpopular
            };
            return View(vm);
        }
    }
}