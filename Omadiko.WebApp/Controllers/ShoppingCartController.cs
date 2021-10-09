using Microsoft.AspNet.Identity;
using Omadiko.Database;
using Omadiko.Entities;

using Omadiko.WebApp.Models;
using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
                List<Omadiko.Entities.Item> cart = new List<Omadiko.Entities.Item> ();
                cart.Add(new Omadiko.Entities.Item()
                {
                    Product = db.Products.Find(id),
                    Quantity = 1
                });
                
                Session["Cart"] = cart;
            }
            else
            {
                List<Omadiko.Entities.Item> cart = (List<Omadiko.Entities.Item >)Session["Cart"];
                int index = IsExistingCheck(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Omadiko.Entities.Item()
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
            List<Omadiko.Entities.Item> cart = (List<Omadiko.Entities.Item>)Session["Cart"];
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
            
            List<Omadiko.Entities.Item> cart = (List<Omadiko.Entities.Item>)Session["Cart"];
            int index = IsExistingCheck(id);
            cart.RemoveAt(index);
            Session["Cart"] = cart;
            return View("Index");
        }
        public ActionResult Increase(int id)
        {
            List<Omadiko.Entities.Item> cart = (List<Omadiko.Entities.Item>)Session["Cart"];
            int index = IsExistingCheck(id);
            cart[index].Quantity++;
            Session["Cart"] = cart;
            return RedirectToAction("Index");

        }
        
        public ActionResult Decrease(int id)
        {
            List<Omadiko.Entities.Item> cart = (List<Omadiko.Entities.Item>)Session["Cart"];
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
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CheckOut()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckOut([Bind(Include = "CustomerId,CustomerFirstName,CustomerLastName,CustomerEmail,CustomerPhone,Country,CustomerAddress,CustomerAddress2,PostalCode")] Customer customer)
        {
            
            if (User.Identity.IsAuthenticated)
            {
                if (ModelState.IsValid)
                {
                    customer.UserId = db.Users.Max(x => x.Id);
                    db.Customers.Attach(customer);                   
                    db.Entry(customer).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }                                                   
            }
            else
            {
                if (ModelState.IsValid)
                {
                    db.Customers.Attach(customer);                   
                    db.Entry(customer).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }                                                                 
            }
           
                Omadiko.Entities.Order order = new Omadiko.Entities.Order()
                {
                    CustomerId = customer.CustomerId,
                    OrderDate = DateTime.Now.Date,
                    OrderTime = DateTime.Now.TimeOfDay,
                    OrderStatus = "Pending"
                };
                db.Orders.Attach(order);                
                db.Entry(order).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();    
            
            List<Omadiko.Entities.Item> cart = (List<Omadiko.Entities.Item>)Session["Cart"];
            if(cart is null)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                for (int i = 0; i < cart.Count; i++)
                {

                    OrderDetails orderDetails = new OrderDetails()
                    {
                        OrderId = db.Orders.Max(x => x.OrderId),
                        ProductName = cart[i].Product.ProductName,
                        Quantity = cart[i].Quantity,
                        Price = cart[i].Product.Price,
                        TotalAmount = cart[i].Quantity * cart[i].Product.Price,
                    };
                    db.OrderDetails.Add(orderDetails);
                    db.SaveChanges();
                }                                                                        
            }
            
            return RedirectToAction("OrderDetails");            
        }
        [HttpGet]
        public ActionResult OrderDetails()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OrderDetails(FormCollection frc)
        {
            Omadiko.Entities.Order order =new Omadiko.Entities.Order()
            {
                 CustomerId=db.Orders.Max(x=>x.CustomerId),
                 OrderDate = DateTime.Now.Date,
                 OrderTime = DateTime.Now.TimeOfDay,
                 OrderStatus = "Pending",
                OrderId =db.Orders.Max(x=>x.OrderId),
                OrderInstructions = frc["ordernotes"]
            };
            db.Entry(order).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("OrderInfo");
        }
        public ActionResult OrderInfo()
        {

            return View();
        }              
        public ActionResult PaymentInfo(FormCollection frc)
        {
            Omadiko.Entities.Order order = new Omadiko.Entities.Order()
            {
                CustomerId = db.Orders.Max(x => x.CustomerId),
                Fullfilled=true,
                OrderDate = DateTime.Now.Date,
                OrderTime = DateTime.Now.TimeOfDay,                
                OrderStatus = "Fullfilled",
                OrderId = db.Orders.Max(x => x.OrderId),
                PaymentDate=DateTime.Now.Date,
                OrderInstructions = frc["ordernotes"]
            };
            db.Entry(order).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
           
            return View();
        }
        public ActionResult PaymentWithPaypal()
        {
            //getting the apiContext as earlier
            APIContext apiContext = PaypalConfiguration.GetAPIContext();

            try
            {
                string payerId = Request.Params["PayerID"];

                if (string.IsNullOrEmpty(payerId))
                {
                    //this section will be executed first because PayerID doesn't exist

                    //it is returned by the create function call of the payment class

                    // Creating a payment

                    // baseURL is the url on which paypal sendsback the data.

                    // So we have provided URL of this controller only

                    string baseURI = Request.Url.Scheme + "://" + Request.Url.Authority + "/ShoppingCart/PaymentWithPayPal?";

                    //guid we are generating for storing the paymentID received in session

                    //after calling the create function and it is used in the payment execution

                    var guid = Convert.ToString((new Random()).Next(100000));

                    //CreatePayment function gives us the payment approval url

                    //on which payer is redirected for paypal acccount payment

                    var createdPayment = this.CreatePayment(apiContext, baseURI + "guid=" + guid);

                    //get links returned from paypal in response to Create function call

                    var links = createdPayment.links.GetEnumerator();

                    string paypalRedirectUrl = string.Empty;

                    while (links.MoveNext())
                    {
                        Links lnk = links.Current;

                        if (lnk.rel.ToLower().Trim().Equals("approval_url"))
                        {
                            //saving the payapalredirect URL to which user will be redirected for payment
                            paypalRedirectUrl = lnk.href;
                        }
                    }

                    // saving the paymentID in the key guid
                    Session.Add(guid, createdPayment.id);

                    return Redirect(paypalRedirectUrl);
                }
                else
                {
                    // This section is executed when we have received all the payments parameters

                    // from the previous call to the function Create

                    // Executing a payment

                    var guid = Request.Params["guid"];

                    var executedPayment = ExecutePayment(apiContext, payerId, Session[guid] as string);

                    if (executedPayment.state.ToLower() != "approved")
                    {
                        
                        return View("FailureView");
                    }

                }
            }
            catch (Exception ex)
            {
               
                return View("FailureView");
            }
            
            return View("SuccessView");
        }

        private PayPal.Api.Payment payment;

        private Payment ExecutePayment(APIContext apiContext, string payerId, string paymentId)
        {
            var paymentExecution = new PaymentExecution() { payer_id = payerId };
            this.payment = new Payment() { id = paymentId };
            return this.payment.Execute(apiContext, paymentExecution);
        }

        private Payment CreatePayment(APIContext apiContext, string redirectUrl)
        {

            //similar to credit card create itemlist and add item objects to it
            var itemList = new ItemList() { items = new List<PayPal.Api.Item>() };

            List<Omadiko.Entities.Item> listCarts = (List<Omadiko.Entities.Item>)Session["Cart"];
            foreach(var cart in listCarts)
            {
                itemList.items.Add(new PayPal.Api.Item()
                {
                    name =cart.Product.ProductName.ToString(),
                    currency = "USD",
                    price =cart.Product.Price.ToString(),
                    quantity = cart.Quantity.ToString(),
                    sku = "sku"
                });
            }
            

            var payer = new Payer() {payment_method = "paypal" };

            // Configure Redirect Urls here with RedirectUrls object
            var redirUrls = new RedirectUrls()
            {
                cancel_url = redirectUrl,
                return_url = redirectUrl
            };

            // similar as we did for credit card, do here and create details object
            var details = new Details()
            {
                tax = "1",
                shipping = "1",
                subtotal =listCarts.Sum(x=>x.Quantity*x.Product.Price).ToString()
            };

            // similar as we did for credit card, do here and create amount object
            var amount = new Amount()
            {
                currency = "USD",
                total = (Convert.ToDouble(details.tax)+ Convert.ToDouble(details.shipping)+Convert.ToDouble(details.subtotal)).ToString(), // Total must be equal to sum of shipping, tax and subtotal.
                details = details
            };

            var transactionList = new List<Transaction>();

            transactionList.Add(new Transaction()
            {
                description = "Transaction description.",
                invoice_number =Convert.ToString((new Random()).Next(10000)),
                amount = amount,
                item_list = itemList
            });

            this.payment = new Payment()
            {
                
                intent = "sale",
                payer = payer,
                transactions = transactionList,
                redirect_urls = redirUrls
            };

            // Create a payment using a APIContext
            return this.payment.Create(apiContext);

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

    
                  
