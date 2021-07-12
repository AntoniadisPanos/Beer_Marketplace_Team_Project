using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Omadiko.Entities
{
    public class Brewery
    {
        public int BreweryId { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [MaxLength(30, ErrorMessage = "Name must be less than 30 characters")]
        [MinLength(2, ErrorMessage = "Name must be greater than 2 characters")]
        public string BreweryName { get; set; }
        public string Location { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
    }
}