using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Omadiko.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeAddress { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public Country Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //Navigation Properties
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
