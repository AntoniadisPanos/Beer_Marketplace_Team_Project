using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.ViewModels
{
    
   public class AdminIndexViewModel
    {
       
        public List<ApplicationUser> ApplicationUsers { get; set; }

        public List<Message> Messages { get; set; }
        public List<Category> Categories { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }

     
        
    }
    
}
