using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
    class ShippingDetails
    {
        public int ShippingDetailsId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public Country Country { get; set; }
    }
}
