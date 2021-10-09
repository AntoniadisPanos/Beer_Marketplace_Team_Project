using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Omadiko.Entities
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int OrderNumber { get; set; }
        //[RegularExpression(@"^[+-]?([0-9]+\.?[0-9]*|\.[0-9]+)$", ErrorMessage = "Only Numbers")]
        public decimal Price { get; set; }
        //[RegularExpression(@"^[0-9]*$", ErrorMessage = "Only Integers are allowed")]
        public int Quantity { get; set; }


        //[RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Only Letters")]
        //[StringLength(20, MinimumLength = 2, ErrorMessage = "Min 2, Max 20 Characters")]
        public string ProductName { get; set; }

        //[RegularExpression(@"^[+-]?([0-9]+\.?[0-9]*|\.[0-9]+)$", ErrorMessage = "Only Numbers")]
        public decimal TotalAmount { get; set; }

        public bool FullFilled { get; set; }
        public DateTime? ShippingDate { get; set; }
        public DateTime? PaymentDate { get; set; }

        //test properties
        //public int ProductId { get; set; }
        public virtual ICollection<Product> Products { get; set; }

       

        //Navigation Properties

       public int OrderId { get; set; }
       public virtual Order Order { get; set; }
    }
}

