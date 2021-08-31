using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
  public  class Customer
    {
       
        public int CustomerId { get; set; }
         public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }
        public string PostalCode { get; set; }
        public string CustomerPhone { get; set; }

        
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerAddress2 { get; set; }

        public Country Country { get; set; }

        //Navigation Properties 

        public virtual ICollection<Order> Orders { get; set; }

       public virtual ICollection<Blog> Blogs { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public Customer()
        {
            this.Blogs = new HashSet<Blog>();
        }

      
       public virtual ICollection<Product> Products { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }


        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
