using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omadiko.Entities.Custom_Validations;


namespace Omadiko.Entities
{
    class Ingredients
    {
        public int IngredientsId { get; set; }

        [MaxLength(60, ErrorMessage = "Title must be less than 60 characters")]
        [MinLength(2, ErrorMessage = "Title must be greater than 2 characters")]
        public string Grains { get; set; }

        [MaxLength(60, ErrorMessage = "Title must be less than 60 characters")]
        [MinLength(2, ErrorMessage = "Title must be greater than 2 characters")]
        public string Hops { get; set; }

        [MaxLength(60, ErrorMessage = "Title must be less than 60 characters")]
        [MinLength(2, ErrorMessage = "Title must be greater than 2 characters")]
        public string Yeast { get; set; }

        [CustomValidation(typeof(ValidationMethods),Methods.ValidateZeroToHundred)]
        public string WaterPercentange { get; set; }
    }
}
