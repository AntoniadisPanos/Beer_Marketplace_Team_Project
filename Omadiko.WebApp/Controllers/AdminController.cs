﻿using Omadiko.Database;
using Omadiko.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.Controllers
{
    public class AdminController : Controller
    {
        
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }
       
    }
}