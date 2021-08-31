using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
   public class UserDetails
    {
        public int UserDetailsId { get; set; }

        //Navigation Properties

        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
