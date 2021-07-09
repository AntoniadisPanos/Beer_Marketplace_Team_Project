using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Omadiko.Entities
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int OrderNumber { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        public bool FullFilled { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}

