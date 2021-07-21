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
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(60, ErrorMessage = "Title must be less than 60 characters")]
        [MinLength(2, ErrorMessage = "Title must be greater than 2 characters")]
        public string ProductName { get; set; }

       //[CustomValidation(typeof(ValidationMethods), Methods.ValidateGreaterThanZero)]
        public decimal Price { get; set; }

       // [CustomValidation(typeof(ValidationMethods), Methods.ABVPercent)]
        public double ABV { get; set; }  //Alcohol By Volume

      // [CustomValidation(typeof(ValidationMethods), Methods.ValidateVolume)]
        public double Volume { get; set; }

        [MaxLength(500, ErrorMessage = "Description must be less than 500 characters")]
        
        public string Description { get; set; }

        [MaxLength(20, ErrorMessage = "Type must be less than 60 characters")]
        [MinLength(2, ErrorMessage = "Type must be greater than 2 characters")]
        public string Type { get; set; }

        [Range(0, 5)]
        public byte Popularity { get; set; }

        public string PhotoUrl { get; set; }
        public Country Country { get; set; }
        

        //Navigation Properties

      
        public int? CategoryId { get; set; }
        public int? BreweryId { get; set; }

        public virtual Category Category { get; set; }

       public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }

        public virtual Brewery Brewery { get; set; }
       
       
       
    }
}