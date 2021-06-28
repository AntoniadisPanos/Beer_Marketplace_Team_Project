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

            Beer beer1 = new Beer() {Name="Corona",Price=3,PhotoUrl="/Images/corona.jpg",Description="",Popularity=5 };
            Beer beer2 = new Beer() {Name="Chios_Alospale",Price=2,PhotoUrl= "/Content/Images/_aecht_schlenkerla_rauchbier_marzen_500ml.jpg", Description="",Popularity=4 };
            Beer beer3 = new Beer() {Name="Chios_Freskia",Price=5,PhotoUrl= "/Content/Images/chiou_alos_pale_ale_fiali_12x330ml.jpg", Description="",Popularity=4 };
            Beer beer4 = new Beer() {Name="Aecht_Schlenkerla_Rauchbie",Price=4,PhotoUrl= "/Content/Images/freskia_mpyra_chiou_330ml.jpg", Description="",Popularity=3 };

            context.Beers.AddOrUpdate(x => x.Name, beer1, beer2, beer3, beer4);
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
