using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
   public class UserLocation
    {
        public int UserLocationId { get; set; }
        public string HomeAddress { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public Country Country { get; set; }
    }
}
