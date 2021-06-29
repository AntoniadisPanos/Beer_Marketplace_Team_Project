using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
    class Supplier
    {
        public int SupplierId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Name must be less than 20 characters")]
        [MinLength(2, ErrorMessage = "Name must be greater than 2 characters")]
        public string Name { get; set; }
        public string Region { get; set; }
    }
}
