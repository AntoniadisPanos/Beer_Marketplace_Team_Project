using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Omadiko.Entities.Custom_Validations;

namespace Omadiko.Entities
{
    public class Beer
    {
        public int BeerId { get; set; }

        [Required(ErrorMessage ="Title is required")]
        [MaxLength(60,ErrorMessage ="Title must be less than 60 characters")]
        [MinLength(2,ErrorMessage ="Title must be greater than 2 characters")]
        public string Name { get; set; }

        [CustomValidation(typeof(ValidationMethods), Methods.ValidateGreaterThanZero)]
        public double Price { get; set; }

        [CustomValidation(typeof(ValidationMethods),Methods.ValidateZeroToHundred)]
        public float ABV { get; set; }  //Alcohol By Volume

        [MaxLength(20, ErrorMessage = "Color must be less than 20 characters")]
        [MinLength(2, ErrorMessage = "Color must be greater than 2 characters")]
        public string Color { get; set; }

        [MaxLength(20, ErrorMessage = "Type must be less than 60 characters")]
        [MinLength(2, ErrorMessage = "Type must be greater than 2 characters")]
        public string Type { get; set; }

        [Range(0, 5)]
        public int Popularity { get; set; }

        [MaxLength(60, ErrorMessage = "Title must be less than 60 characters")]
        [MinLength(2, ErrorMessage = "Title must be greater than 2 characters")]
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
       
    }
}
