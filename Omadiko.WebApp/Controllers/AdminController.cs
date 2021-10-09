using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Omadiko.Database;
using Omadiko.Entities;
using Omadiko.Entities.ViewModels;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Omadiko.WebApp.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin
        [Authorize(Roles="Admin")]
        public ActionResult Index()
        {
            AdminIndexViewModel vm = new AdminIndexViewModel()
            {
                Categories = db.Categories.ToList(),
                Customers = db.Customers.ToList(),
                Messages = db.Messages.ToList(),
                Products = db.Products.ToList(),
                ApplicationUsers = db.Users.ToList(),
                
            };
            
            return View(vm);
        }                
    }
}