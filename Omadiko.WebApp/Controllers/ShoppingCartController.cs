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
        public ActionResult CheckOut([Bind(Include = "CustomerId,CustomerFirstName,CustomerLastName,CustomerEmail,CustomerPhone,Country,CustomerAddress,CustomerAddress2,PostalCode")] Customer customer,IEnumerable<int> SelectProductsForCustomers)
        {
            if (User.Identity.IsAuthenticated)
            {
                customer.UserId = db.Users.Max(x => x.Id);
                db.Customers.Attach(customer);
                db.Entry(customer).Collection("Products").Load();
                customer.Products.Clear();
                if(!(SelectProductsForCustomers is null))
                {
                    foreach(var id in SelectProductsForCustomers)
                    {
                        Product product = db.Products.Find(id);
                        if(customer != null)
                        {
                            customer.Products.Add(product);
                        }
                    }
                }
                db.Entry(customer).State = System.Data.Entity.EntityState.Added;
                
                db.SaveChanges();
            }
            else
            {
                db.Customers.Attach(customer);
                db.Entry(customer).Collection("Products").Load();
                customer.Products.Clear();
                if (!(SelectProductsForCustomers is null))
                {
                    foreach (var id in SelectProductsForCustomers)
                    {
                        Product product = db.Products.Find(id);
                        if (customer != null)
                        {
                            customer.Products.Add(product);
                        }
                    }
                }
                db.Entry(customer).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                
            }


            
           Omadiko.Entities.Order order = new Omadiko.Entities.Order()
                {
                    
                    CustomerId=customer.CustomerId,
                    OrderDate = DateTime.Now.Date,
                    OrderTime = DateTime.Now.TimeOfDay,
                    OrderStatus = "Pending"
                };
            //db.Orders.Add(order);
            db.Orders.Attach(order);
            db.Entry(order).Collection("Products").Load();
            
            
            db.Entry(order).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

           


            List<Omadiko.Entities.Item> cart = (List<Omadiko.Entities.Item>)Session["Cart"];
            for (int i = 0; i <cart.Count; i++)
            {
               
                OrderDetails orderDetails = new OrderDetails()
                {
                    OrderId = db.Orders.Max(x => x.OrderId),
                    //ProductId = cart[i].Product.ProductId,
                    ProductName=cart[i].Product.ProductName,
                    Quantity = cart[i].Quantity,
                    Price=cart[i].Product.Price,
                    TotalAmount=cart[i].Quantity*cart[i].Product.Price,                                                          
                };


                db.OrderDetails.Add(orderDetails);                
                db.SaveChanges();
            }
            
            return RedirectToAction("OrderDetails");
            

        }
        public ActionResult OrderDetails(FormCollection frc)
        {
         Omadiko.Entities.Order order =new Omadiko.Entities.Order()
            {
                OrderInstructions = frc["ordernotes"]
            };
            db.Orders.Add(order);
            db.SaveChanges();
            return RedirectToAction("OrderInfo");
        }
        public ActionResult OrderInfo()
        {
            List<Omadiko.Entities.Item> cart = (List<Omadiko.Entities.Item>)Session["Cart"];

            return View();
        }
        //Work with Paypal Payment
       
        public ActionResult PaymentInfo()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult PaymentWithPaypal(string Cancel = null)
        {
            //getting the apiContext  
            APIContext apiContext = PaypalConfiguration.GetAPIContext();
            try
            {
                //A resource representing a Payer that funds a payment Payment Method as paypal  
                //Payer Id will be returned when payment proceeds or click to pay  
                string payerId = Request.Params["PayerID"];
                if (string.IsNullOrEmpty(payerId))
                {
                    //this section will be executed first because PayerID doesn't exist  
                    //it is returned by the create function call of the payment class  
                    // Creating a payment  
                    // baseURL is the url on which paypal sendsback the data.  
                    string baseURI = Request.Url.Scheme + "://" + Request.Url.Authority + "/ShoppingCart/PaymentWithPayPal?";
                    //here we are generating guid for storing the paymentID received in session  
                    //which will be used in the payment execution  
                    var guid = Convert.ToString((new Random()).Next(100000));
                    //CreatePayment function gives us the payment approval url  
                    //on which payer is redirected for paypal account payment  
                    var createdPayment = this.CreatePayment(apiContext, baseURI + "guid=" + guid);
                    //get links returned from paypal in response to Create function call  
                    var links = createdPayment.links.GetEnumerator();
                    string paypalRedirectUrl = null;
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
                    // This function exectues after receving all parameters for the payment  
                    var guid = Request.Params["guid"];
                    var executedPayment = ExecutePayment(apiContext, payerId, Session[guid] as string);
                    //If executed payment failed then we will show payment failure message to user  
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
            //on successful payment, show success page to user.  
            return View("SuccessView");
        }
        private PayPal.Api.Payment payment;
        private Payment ExecutePayment(APIContext apiContext, string payerId, string paymentId)
        {
            var paymentExecution = new PaymentExecution()
            {
                payer_id = payerId
            };
            this.payment = new Payment()
            {
                id = paymentId
            };
            return this.payment.Execute(apiContext, paymentExecution);
        }
        private Payment CreatePayment(APIContext apiContext, string redirectUrl)
        {
            //create itemlist and add item objects to it  
            var itemList = new ItemList()
            {
                items = new List<PayPal.Api.Item>()
            };
            //Adding Item Details like name, currency, price etc

            List<Omadiko.Entities.Item> listCarts = (List<Omadiko.Entities.Item>)Session["Cart"];
            foreach (var cart in listCarts)
            {
                itemList.items.Add(new PayPal.Api.Item()
                {
                    name =cart.Product.ProductName,
                    currency = "USD",
                    price = cart.Product.Price.ToString(),
                    quantity = cart.Quantity.ToString(),
                    sku = "sku"
                });
            }
            
               
            
            var payer = new Payer()
            {
                payment_method = "paypal"
            };
            // Configure Redirect Urls here with RedirectUrls object  
            var redirUrls = new RedirectUrls()
            {
                cancel_url = redirectUrl + "&Cancel=true",
                return_url = redirectUrl
            };
            // Adding Tax, shipping and Subtotal details  
            var details = new Details()
            {
                tax = "1",
                shipping = "1",
                subtotal ="1" /*listCarts.Sum(x=>x.Quantity*x.Product.Price).ToString()*/
            };
            //Final amount with details  
            var amount = new Amount()
            {
                currency = "USD",
                total = (Convert.ToDouble(details.tax) + Convert.ToDouble(details.shipping) + Convert.ToDouble(details.subtotal)).ToString(), // Total must be equal to sum of tax, shipping and subtotal.  
                details = details
            };
            var transactionList = new List<Transaction>();
            // Adding description about the transaction  
            transactionList.Add(new Transaction()
            {
                description = "Transaction description",
                invoice_number = "#100000", //Generate an Invoice No  
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

    
                  
