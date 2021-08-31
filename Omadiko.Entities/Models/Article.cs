using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
   public class Article
    {
        public int ArticleId { get; set; }

        public string Blog { get; set; }

        public string FullBlog { get; set; }
        public DateTime DateTime { get; set; }

        public string Title { get; set; }
        

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }


        public virtual ICollection<Comment> Comments { get; set; }


        
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
