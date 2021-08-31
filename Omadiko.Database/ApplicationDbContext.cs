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
        public DbSet<Item> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        //public DbSet<Payment> Payments { get; set; }
        public DbSet<ShippingDetails> ShippingDetails { get; set; }
        
        public DbSet<UserDetails>UserDetails { get; set; }
        public DbSet<UserLocation>UserLocations { get; set; }

        public DbSet<Message> Messages { get; set; }
        
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
       
        public DbSet<Customer> Customers { get; set; }
       
        public DbSet<PhotoForSite> PhotoForSites { get; set; }

       
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        

        //fluent api Customer-ApplicationUser Model

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<ApplicationUser>()
        //        .HasOptional(m => m.Customer)
        //        .WithRequired(m => m.ApplicationUser)
        //        .Map(p => p.MapKey("UserId"));
        //}
    }
}
