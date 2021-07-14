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
            Product beer1 = new Product() {ProductName="Corona",Price=3,PhotoUrl= "/Content/Images/xlarge_corona_20sgl.jpg", Description="qqq",Popularity=5 };
            Product beer2 = new Product() { ProductName = "Chios_Alospale",Price=2,PhotoUrl= "/Content/Images/_aecht_schlenkerla_rauchbier_marzen_500ml.jpg", Description="qqq",Popularity=4 };
            Product beer3 = new Product() { ProductName = "Chios_Freskia",Price=5,PhotoUrl= "/Content/Images/chiou_alos_pale_ale_fiali_12x330ml.jpg", Description="qqq",Popularity=4 };
            Product beer4 = new Product() { ProductName = "Aecht_Schlenkerla_Rauchbie",Price=4,PhotoUrl= "/Content/Images/freskia_mpyra_chiou_330ml.jpg", Description="qqq",Popularity=3 };

            Category cat1 = new Category() { CategoryName = "Blonde" };
            Category cat2 = new Category() { CategoryName = "Dark" };

           // Order order1 = new Order() { OrderDate = new DateTime(2021, 02, 03), PaymentDate = new DateTime(2021, 02, 05), ShippingDate = new DateTime(2021, 02, 06), Paid = true, Fullfilled = true, Deleted = false };
            //Order order2 = new Order() { OrderDate = new DateTime(2021, 03, 04), PaymentDate = new DateTime(2021, 03, 06), ShippingDate = new DateTime(2021, 03, 07), Paid = true, Fullfilled = true, Deleted = false };
            //Order order3 = new Order() { OrderDate = new DateTime(2021, 03, 05), PaymentDate = new DateTime(2021, 04, 07), ShippingDate = new DateTime(2021, 03, 09), Paid = true, Fullfilled = true, Deleted = false };

           

            cat1.Products = new List<Product>() { beer1, beer2, beer3, beer4 };
           // order1.Products = new List<Product> { beer1, beer2 };

           
         
            context.Products.AddOrUpdate(x => x.ProductName, beer1, beer2, beer3, beer4);
            context.Categories.AddOrUpdate(x => x.CategoryName, cat1, cat2);
           // context.Orders.AddOrUpdate(x => x.OrderDate, order1, order2, order3);

            context.SaveChanges();
            



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
