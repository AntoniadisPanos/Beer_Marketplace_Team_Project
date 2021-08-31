using Omadiko.Database;
using Omadiko.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.Models
{
    public class CustomerProductViewModel
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public IEnumerable<SelectListItem> SelectProductsForCustomers
        {
            get
            {
                if (Customer is null)
                {
                    return db.Products.ToList().Select(x => new SelectListItem()
                    {
                        Value = x.ProductId.ToString(),
                        Text = x.ProductName
                    });
                }
                else
                {
                    var productsid = Customer.Products.Select(x => x.ProductId);
                    return db.Products.ToList().Select(x => new SelectListItem()
                    {
                        Value = x.ProductId.ToString(),
                        Text = x.ProductName,
                        Selected = productsid.Any(y => y == x.ProductId)
                    });
                }
            }

        }




        public Customer Customer { get; set; }

        public Country Country { get; set; }

    }
}