using Omadiko.Entities.Custom_Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Omadiko.Entities
{
    public class Order
    {
        public int OrderId { get; set; }



        //  [CustomValidation(typeof(ValidationMethods), Methods.ValidateGreaterThanZero)]
       
        public DateTime? OrderDate { get; set; }
        public DateTime? ShippingDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool Fullfilled { get; set; }
        public bool Paid { get; set; }
        public bool Deleted { get; set; }

        //testing properties to see if this works

        
        public TimeSpan? OrderTime { get; set; }
        public string OrderStatus { get; set; }
        //public string CustomerName { get; set; }

        //public string PostalCode { get; set; }
        //public string CustomerPhone { get; set; }
        //public string CustomerEmail { get; set; }
        //public string CustomerAddress { get; set; }
        //public string CustomerAddress2 { get; set; }
        public string OrderInstructions { get; set; }
        

        

       
        public  Country Country { get; set; }

        public Order()
        {
            OrderDetails = new HashSet<OrderDetails>();
            ApplicationUsers = new HashSet<ApplicationUser>();
        }
        


        //Navigation properties
      
        public int? ShippingDetailsId { get; set; }
        public virtual ShippingDetails ShippingDetails { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public int UserId { get; set; }
         public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
         public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<Item> Carts { get; set; }

        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}