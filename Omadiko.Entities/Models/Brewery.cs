using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Omadiko.Entities
{
    public class Brewery
    {
        public int BreweryId { get; set; }
       
        public string BreweryName { get; set; }
        public string Location { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }

        //Navigation Properties
        public virtual ICollection<Product> Products { get; set; }
    }
}