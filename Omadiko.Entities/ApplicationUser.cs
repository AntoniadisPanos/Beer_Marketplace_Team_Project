using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
    public class ApplicationUser : IdentityUser
    {

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation Properties

        public virtual ICollection<Order> Orders { get; set; }
        public virtual UserDetails UserDetails { get; set; }
       
        public virtual Blog Blog { get; set; }
        public virtual ICollection<UserLocation> UserLocations { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
