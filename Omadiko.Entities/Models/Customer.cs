using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
  public  class Customer
    {
       
        public int CustomerId { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Only Letters")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Min 2, Max 20 Characters")]
        public string CustomerFirstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Only Letters")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Min 2, Max 20 Characters")]
        public string CustomerLastName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "Please use Letters and Numbers only")]
        public string PostalCode { get; set; }
        [RegularExpression(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$", ErrorMessage = "Not a valid phone number")]
        public string CustomerPhone { get; set; }



        [Required]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Please enter a valid Email")]
        public string CustomerEmail { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "Please use Letters and Numbers only")]
        public string CustomerAddress { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "Please use Letters and Numbers only")]
        public string CustomerAddress2 { get; set; }


        public Country Country { get; set; }

        //Navigation Properties 

        public ICollection<Message> Messages { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

       public virtual ICollection<Blog> Blogs { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public Customer()
        {
            this.Blogs = new HashSet<Blog>();
        }

      
       public virtual ICollection<Product> Products { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }


        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
