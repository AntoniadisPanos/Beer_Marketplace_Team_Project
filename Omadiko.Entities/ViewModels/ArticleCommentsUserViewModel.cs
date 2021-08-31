using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.ViewModels
{
   public class ArticleCommentsUserViewModel
    {
        public Article Article { get; set; }

        public List<Article> Articles { get; set; }

        public List<Comment> Comments { get; set; }

        public Comment Comment { get; set; }

        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}
