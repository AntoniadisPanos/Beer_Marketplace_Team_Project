using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult OurStory()
        {
            ViewBag.Message = "You story page.";
            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.Message = "Your Blog is here.";
            return View();
        }
        public ActionResult SingleBlog()
        {
            ViewBag.Message = "Your Blog is here.";
            return View();
        }
    }
}