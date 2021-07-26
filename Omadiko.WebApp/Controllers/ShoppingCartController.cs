using Omadiko.Database;
using Omadiko.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
       
        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult OrderNow(int id)
        {
            if (Session["Cart"] == null)
            {
                List<Cart> cart = new List<Cart>();
                cart.Add(new Cart()
                {
                    Product = db.Products.Find(id),
                    Quantity = 1
                });
                Session["Cart"] = cart;
            }
            else
            {
                List<Cart> cart = (List<Cart>)Session["Cart"];
                int index = IsExistingCheck(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Cart()
                    {
                        Product = db.Products.Find(id),
                        Quantity = 1
                    });
                }
                Session["Cart"] = cart;
            }
            return RedirectToAction("Index");
        }
        private int IsExistingCheck(int id)
        {
            List<Cart> cart = (List<Cart>)Session["Cart"];
            for(int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductId.Equals(id))
                {
                    return i;
                }
                    
            }
            return -1;
        }
        public ActionResult Delete(int id)
        {
            
            List<Cart> cart = (List<Cart>)Session["Cart"];
            int index = IsExistingCheck(id);
            cart.RemoveAt(index);
            Session["Cart"] = cart;
            return View("Index");
        }
        public ActionResult Increase(int id)
        {
            List<Cart> cart = (List<Cart>)Session["Cart"];
            int index = IsExistingCheck(id);
            cart[index].Quantity++;
            Session["Cart"] = cart;
            return RedirectToAction("Index");

        }
        public ActionResult Decrease(int id)
        {
            List<Cart> cart = (List<Cart>)Session["Cart"];
            int index = IsExistingCheck(id);
            cart[index].Quantity--;
            if (cart[index].Quantity == 0)
            {
                cart.RemoveAt(index);
            }
            Session["Cart"] = cart;
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            return View("Index");
        }
       public ActionResult CheckOut(FormCollection fc)
        {
            List<Cart> cart = (List<Cart>)Session["Cart"];
                     
            return View("CheckOut");

        }
    }
                  
}