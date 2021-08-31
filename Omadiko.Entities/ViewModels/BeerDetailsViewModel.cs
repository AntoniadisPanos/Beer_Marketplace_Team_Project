using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.ViewModels
{
  public  class BeerDetailsViewModel
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set; }

        public List<Item> Carts { get; set; }
        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}
