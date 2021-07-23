using Omadiko.Database;
using Omadiko.Entities;
using Omadiko.Entities.ViewModels;
using PagedList;
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
        public ActionResult Index(int? pSize, int? page)
        {

            List<Product> products = db.Products.ToList();

            int pageSize, pageNumber;
            Pagination(pSize, page, out pageSize, out pageNumber);
            return View(products.ToPagedList(pageNumber, pageSize));
        }
        private static void Pagination(int? pSize, int? page, out int pageSize, out int pageNumber)
        {
            pageSize = pSize ?? 5;
            pageNumber = page ?? 1;
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