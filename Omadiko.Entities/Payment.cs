using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
   public class Payment
    {
        public int PaymentId { get; set; }
        public string Type { get; set; }

        //Navigation Properties
        public int ApplicationUserId { get; set; }

       public virtual ApplicationUser ApplicationUser { get; set; }
       
       
    }
}
