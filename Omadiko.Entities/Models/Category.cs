using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Omadiko.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Only Letters")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Min 2, Max 20 Characters")]
        public string CategoryName { get; set; }

        //Navigation Properties

        public virtual ICollection<Product> Products { get; set; }
    }
}