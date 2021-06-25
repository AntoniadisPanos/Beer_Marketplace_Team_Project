namespace Omadiko.Database.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Omadiko.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Omadiko.Database.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Omadiko.Database.ApplicationDbContext context)
        {
            Product p1 = new Product() { Name = "TurboX", Price = 550 };
            Product p2 = new Product() { Name = "HP", Price = 200 };
            Product p3 = new Product() { Name = "Samsung", Price = 300 };

            context.Products.AddOrUpdate(x => new { x.Name }, p1, p2, p3);
            context.SaveChanges();
            #region Book Authors
            Book book1 = new Book() { Title = "Lord of The Rings", Price = 20, IsAvailable = true };
            Book book2 = new Book() { Title = "Avatar", Price = 15, IsAvailable = false };
            Book book3 = new Book() { Title = "Harry-Potter", Price = 20, IsAvailable = true };
            Book book4 = new Book() { Title = "The fifty shades", Price = 20, IsAvailable = true };

            Author author1 = new Author() { FirstName = "Stephen", LastName = " Kings" };
            Author author2 = new Author() { FirstName = "Mitsos", LastName = "Tolkien" };
            Author author3 = new Author() { FirstName = "J-King", LastName = " Rolling" };

            author1.Books = new List<Book>() { book1, book2, book3 };
            author2.Books = new List<Book>() { book1 };
            author3.Books = new List<Book>() { book1, book2 };

            context.Authors.AddOrUpdate(x => x.FirstName, author1, author2, author3);
            context.SaveChanges();
            #endregion



            if (!context.Roles.Any(x => x.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };



                manager.Create(role);
            }


            var PasswordHash = new PasswordHasher();
            if (!context.Users.Any(x => x.UserName == "admin@admin.net"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser
                {
                    UserName = "admin@admin.net",
                    Email = "admin@admin.net",
                    PasswordHash = PasswordHash.HashPassword("Admin1!")
                };



                manager.Create(user);
                manager.AddToRole(user.Id, "Admin");
            }








        }
    }
}
