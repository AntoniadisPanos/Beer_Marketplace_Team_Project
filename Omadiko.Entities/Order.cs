using Omadiko.Entities.Custom_Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
    class Order
    {
        public int OrderId { get; set; }

        [CustomValidation(typeof(ValidationMethods), Methods.ValidateGreaterThanZero)]
        public int Quantity { get; set; }
    }
}
