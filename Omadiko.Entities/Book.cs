using Omadiko.Entities.Custom_Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
    class Book
    {
        public int BookId { get; set; }
        [Required(ErrorMessage = "Book must have a price ")]
        [CustomValidation(typeof(ValidationMethods), Methods.ValidateGreaterThanZero)]
        public int Price { get; set; }
        [Required(ErrorMessage = "Book Must Have A Price ")]
        [MaxLength(25),MinLength(5)]
        public string Title { get; set; }
        [Required(ErrorMessage = "We must know if book is available or not ")]
        public bool IsAvailable { get; set; }

        public virtual Author Author { get; set; }

        public int AuthorId { get; set; }
    }
}
    