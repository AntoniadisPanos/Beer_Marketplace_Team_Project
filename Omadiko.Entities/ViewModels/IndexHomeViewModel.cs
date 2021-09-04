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

        public List<Product> TwoProductsForPage { get; set; }

        public List<Blog> IndividualBlogForProduct { get; set; }

        public Blog Blog { get; set; }

        public List<Article> Articles { get; set; }

        public List<Blog> Blogs { get; set; }

        public PhotoForSite photoForSite { get; set; }


        //test
        public Message Message { get; set; }

        public ApplicationUser applicationUser { get; set; }

    }
}
