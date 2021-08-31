using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
  public  class Comment
    {
        public int CommentId { get; set; }

        public string Comments { get; set; }

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }

        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }

        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
