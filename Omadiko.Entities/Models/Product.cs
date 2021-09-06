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

        [Required(ErrorMessage = "Required Field")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Only Letters")]
        [MaxLength(60, ErrorMessage = "Title must be less than 60 characters")]
        [MinLength(2, ErrorMessage = "Title must be greater than 2 characters")]
        public string ProductName { get; set; }


        [Required(ErrorMessage = "Required Field")]
        [RegularExpression(@"^[+-]?([0-9]+\.?[0-9]*|\.[0-9]+)$", ErrorMessage = "Only Numbers")]
        [Range(1.0, 100.0, ErrorMessage = "Price value must be between 1-100")]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "Required Field")]
        [RegularExpression(@"^[+-]?([0-9]+\.?[0-9]*|\.[0-9]+)$", ErrorMessage = "Only Numbers")]
        [Range(0.0, 1.0, ErrorMessage = "ABV Value must me between 0-1")]
        public double ABV { get; set; }  //Alcohol By Volume

        [Required(ErrorMessage = "Required Field")]
        [RegularExpression(@"^[+-]?([0-9]+\.?[0-9]*|\.[0-9]+)$", ErrorMessage = "Only Numbers")]
        [Range(0.0, 2.0, ErrorMessage = "Volume must be between 0.250-2")]
        public double Volume { get; set; }//Product ML


        [MaxLength(1000, ErrorMessage = "Description must be less than 1000 characters")]
        public string Description { get; set; }


        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Only Letters")]
        [MaxLength(20, ErrorMessage = "Type must be less than 20 characters")]
        [MinLength(2, ErrorMessage = "Type must be greater than 2 characters")]
        public string Type { get; set; }


        [RegularExpression(@"^[+-]?([0-9]+\.?[0-9]*|\.[0-9]+)$", ErrorMessage = "Only Numbers")]
        //[Range(1.0, 100.0, ErrorMessage = "Discount value must be between 1%-100%")]
        public decimal Discount { get; set; }

        public string DiscountCode { get; set; }

        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only Integers are allowed")]
        [Range(0, 5, ErrorMessage = "Popularity Value Must be Between 0-5")]
        public byte Popularity { get; set; }

        [Required(ErrorMessage = "Required Field")]
        //[RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.bmp)$", ErrorMessage ="Only jpg,png,bmp")]
        public string SmallPhoto { get; set; }
        [Required(ErrorMessage = "Required Field")]
        //[RegularExpression(@"([^\s]+(\.(?i)(jpg|png|bmp))$)", ErrorMessage = "Only jpg,png,bmp")]
        public string LargePhoto { get; set; }
        public Country Country { get; set; }
        
        public double ConvertABV(double abv)
        {
            return abv * 100;
        }
        public double ConvertVolume(double volume)
        {
            return volume * 1000;
        }
        //Navigation Properties

        public static TimeSpan GetDays()
        {
            var currentDate = DateTime.Now;
            var endDate = new DateTime(2021, 12, 24);
            TimeSpan remainingDays = endDate - currentDate;
            return remainingDays;
        }
        public int? CategoryId { get; set; }
        public int? BreweryId { get; set; }

        public virtual Category Category { get; set; }

       public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Item> Carts { get; set; }

        public virtual Brewery Brewery { get; set; }
       
        public virtual ICollection<Blog> Blogs { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
        
        public virtual ICollection<Customer> Customers { get; set; }
       
    }
}