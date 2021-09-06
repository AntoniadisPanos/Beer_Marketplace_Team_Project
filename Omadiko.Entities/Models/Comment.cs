using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
  public  class Comment
    {
        public int CommentId { get; set; }
        
        public string Comments { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Only Letters")]
        public string CustomerName { get; set; }


        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Please enter a valid Email")]
        public string CustomerEmail { get; set; }

        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }

        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
