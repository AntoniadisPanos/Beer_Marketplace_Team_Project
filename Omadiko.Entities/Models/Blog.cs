using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
   public class Blog
    {
        public int BlogId { get; set; }
        
        
        public string Comments { get; set; }
        
        public string CustomerName { get; set; }
       
        public string CustomerEmail { get; set; }



        //Navigation Properties
       
        
        public int? ProductId { get; set; }
        public  Product Product { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }

        public Blog()
        {
            this.Customers = new HashSet<Customer>();
        }

    }



}
