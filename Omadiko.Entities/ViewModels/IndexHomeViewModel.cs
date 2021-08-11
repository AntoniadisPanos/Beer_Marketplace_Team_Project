using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Mvc;



namespace Omadiko.Entities.ViewModels
{
    public class IndexHomeViewModel
    {
        

        public Product Product { get; set; }
        public List<Product> BestProductsByPopularity { get; set; }

        
        
    }
}
