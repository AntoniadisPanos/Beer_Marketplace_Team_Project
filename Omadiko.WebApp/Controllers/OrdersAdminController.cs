using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Omadiko.Database;
using Omadiko.Entities;

namespace Omadiko.WebApp.Controllers
{
    public class OrdersAdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OrdersAdmin
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            var orders = db.Orders.Include(o => o.Customer).Include(o=>o.ApplicationUsers);
            return View(orders.ToList());
        }

        // GET: OrdersAdmin/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: OrdersAdmin/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "CustomerFirstName");
            return View();
        }

        // POST: OrdersAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "OrderId,OrderDate,ShippingDate,PaymentDate,Fullfilled,Paid,Deleted,OrderTime,OrderStatus,OrderInstructions,Country,UserId,CustomerId")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            CreateOrderViewBag();
             return View(order);
        }
            public void CreateOrderViewBag()
            {
            var customer = db.Customers.ToList().Select(x => new
            {
                CustomerId = x.CustomerId,
                CustomerFullName = string.Format($"{x.CustomerFirstName} {x.CustomerLastName}")

            });
            var users = db.Users.ToList().Select(x => new
            {
                UserId = x.Id,
                UserName = x.UserName
            });
            ViewBag.CustomerId = new SelectList(customer, "CustomerId", "CustomerFullName");
            ViewBag.UserId = new SelectList(users, "UserId", "UserName");
        }




        // GET: OrdersAdmin/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "CustomerFirstName", order.CustomerId);
            return View(order);
        }

        // POST: OrdersAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "OrderId,OrderDate,ShippingDate,PaymentDate,Fullfilled,Paid,Deleted,OrderTime,OrderStatus,OrderInstructions,Country,UserId,CustomerId")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "CustomerFirstName", order.CustomerId);
            return View(order);
        }

        // GET: OrdersAdmin/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: OrdersAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
