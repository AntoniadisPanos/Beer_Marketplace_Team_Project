using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Omadiko.Database;
using Omadiko.Entities;
using Omadiko.Entities.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.Controllers
{
    public class AdminController : Controller
    {
       
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetDate()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var data = db.OrderDetails.Include("Product").ToList();

            var query = db.OrderDetails.Include("Product")
                .GroupBy(x => x.ProductName)
                .Select(y => new { name = y.Key, count =y.SingleOrDefault().Quantity });
            return Json(query, JsonRequestBehavior.AllowGet);
        }
        
        
        

    }
}