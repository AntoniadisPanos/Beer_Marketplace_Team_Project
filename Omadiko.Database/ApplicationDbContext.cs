using Microsoft.AspNet.Identity.EntityFramework;
using Omadiko.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() :base("Sindesmos")
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        //public DbSet<Payment> Payments { get; set; }
        public DbSet<ShippingDetails> ShippingDetails { get; set; }
        
        public DbSet<UserDetails>UserDetails { get; set; }
        public DbSet<UserLocation>UserLocations { get; set; }

       


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}
