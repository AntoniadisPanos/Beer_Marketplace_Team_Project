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
       
        public DateTime OrderDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool Fullfilled { get; set; }
        public bool Paid { get; set; }
        public bool Deleted { get; set; }


        //Navigation properties

       public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
      public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}