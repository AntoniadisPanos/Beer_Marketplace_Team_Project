using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "Author must have first name ")]
        [MinLength(5),MaxLength(10)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Author must have Last name ")]
        [MinLength(5), MaxLength(10)]
        public string LastName { get; set; }
        public  virtual ICollection<Book> Books { get; set; }
    }
}
