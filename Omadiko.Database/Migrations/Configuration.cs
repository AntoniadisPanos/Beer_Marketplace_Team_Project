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
            Product beer1 = new Product() {ProductName="Corona",Price=3,PhotoUrl= "/Content/Images/xlarge_corona_20sgl.jpg", Description="qqq",Type="Lager",Popularity=5 };
            Product beer2 = new Product() { ProductName = "Chios_Alos",Price=2,PhotoUrl= "/Content/Images/_aecht_schlenkerla_rauchbier_marzen_500ml.jpg", Description="qqq", Type = "pale Ale", Popularity=4 };
            Product beer3 = new Product() { ProductName = "÷Ò›ÛÍÈ· Ã˝Ò· ◊ﬂÔı", Price = 2.2M, PhotoUrl = "/Content/Images/169X299/◊ﬂÔı ÷Ò›ÛÍÈ· Ale ÷È‹ÎÁ 330ml (PALE ALE) (169X299).jpg", Description = "qqq", Type = "Pale Ale", Popularity = 3 };
            Product beer4 = new Product() { ProductName = "Aecht_Schlenkerla_Rauchbie",Price=4,PhotoUrl= "/Content/Images/freskia_mpyra_chiou_330ml.jpg", Description="qqq", Type = "Smoked beer", Popularity=3 };
            Product beer5 = new Product() { ProductName = "Fix_Hellas",Price=2,PhotoUrl= "/Content/Images/169X299/Fix Hellas 500ml (LAGER) (169◊299).jpg", Description="qqq", Type = "Lager", Popularity=3 };
            Product beer6 = new Product() { ProductName = "ASAHI", Price= 2.36M, PhotoUrl= "/Content/Images/169X299/ASAHI SUPER DRY BEER 0,33LT (DRY BEER) (169X299).jpg", Description="qqq", Type = "Dry beer", Popularity=3 };
            Product beer7 = new Product() { ProductName = "CHIOS BBQ", Price= 2.2M, PhotoUrl= "/Content/Images/169X299/CHIOS BBQ - ÷—≈” …¡  ¡–Õ…”‘« Ã–’—¡ ◊…œ’ 0.33lt (SMOKED PORTER) (169X299).jpg", Description="qqq", Type = "Smoked beer", Popularity=3 };
            Product beer8 = new Product() { ProductName = "Corfu", Price= 2.6M, PhotoUrl= "/Content/Images/169X299/Corfu Dark Ale Bitter 500ml (BITTER DARK)(169X299).jpg", Description="qqq", Type = "Bitter", Popularity=3 };
            Product beer9 = new Product() { ProductName = "Erdinger Weiss", Price= 2.3M, PhotoUrl= "/Content/Images/169X299/Erdinger Weiss 500ml (WEISS)(169X299).jpg", Description="qqq", Type = "Weiss", Popularity=3 };
            Product beer10 = new Product() { ProductName = "Gouden Carolus Ambrio", Price= 2.3M, PhotoUrl= "/Content/Images/169X299/Gouden Carolus Ambrio 0.33lt(STRONG)(169◊299).jpg", Description="qqq", Type = "Strong Ale", Popularity=3 };
            Product beer11 = new Product() { ProductName = "GRIMBERGEN Double", Price= 3, PhotoUrl= "/Content/Images/169X299/Grimbergen Double 0.33lt (TRAPPIST) (169◊299).jpg", Description="qqq", Type = "Trappist", Popularity=3 };
            Product beer12 = new Product() { ProductName = "Guinness Draught", Price= 2, PhotoUrl= "/Content/Images/169X299/Guinness Draught-Stout 330ml (DRAUGHT-STOUT) (169X299).jpg", Description="qqq", Type = "Draught", Popularity=3 };
            Product beer13 = new Product() { ProductName = "Guinness Special", Price= 3.3M, PhotoUrl= "/Content/Images/169X299/Guinness Special 0.33lt (STOUT) (169X299).jpg", Description="qqq", Type = "Stout", Popularity=3 };
            Product beer14 = new Product() { ProductName = "McFarland", Price= 1.4M, PhotoUrl= "/Content/Images/169X299/McFarland ÷È‹ÎÁ Irish Ale 330ml(IRISH ALE,RED ALE) (169x299).jpg", Description="qqq", Type = "Irish Ale", Popularity=3 };
            Product beer15 = new Product() { ProductName = "Kaiser Pils", Price= 1.4M, PhotoUrl= "/Content/Images/169X299/Kaiser Pilsner Lager ÷È‹ÎÁ 500ml(PILSNER) (169x299).jpg", Description="qqq", Type = "Pilsner", Popularity=3 };
            Product beer16 = new Product() { ProductName = "Kirki Pale Ale", Price= 2.7M, PhotoUrl= "/Content/Images/169X299/Kirki Pale Ale 0.33lt (PALE ALE) (169X299).jpg", Description="qqq", Type = "Pale Ale", Popularity=3 };
            Product beer17 = new Product() { ProductName = "Newcastle Brown Ale", Price= 1.6M, PhotoUrl= "/Content/Images/169X299/Newcastle Brown Ale 330ml (BROWN ALE) (169◊299).jpg", Description="qqq", Type = "Brown Ale", Popularity=3 };
            Product beer18 = new Product() { ProductName = "Paguru Cream Ale", Price= 2.4M, PhotoUrl= "/Content/Images/169X299/Paguru Cream Ale 330ml (CREAM ALE) (169X299).jpg", Description="qqq", Type = "Cream Ale", Popularity=3 };
            Product beer19 = new Product() { ProductName = "Paulaner Salvator", Price= 2.4M, PhotoUrl= "/Content/Images/169X299/Paulaner Salvator 0.33lt (BOCK) (169X299).jpg", Description="qqq", Type = "Bock", Popularity=3 };
            Product beer20 = new Product() { ProductName = "Rodenbach Caractere", Price= 4, PhotoUrl= "/Content/Images/169X299/Rodenbach Caractere Rouge Red Ale 750ml (RED ALE) (169X299).jpg", Description="qqq", Type = "Bock", Popularity=3 };
            Product beer21 = new Product() { ProductName = "Samichlaus Bier", Price= 4, PhotoUrl= "/Content/Images/169X299/Samichlaus Bier 0.33lt (BOCK) (169X299).jpg", Description="qqq", Type = "Bock", Popularity=3 };
            Product beer22 = new Product() { ProductName = "Timmermans kriek", Price= 3.5M, PhotoUrl= "/Content/Images/169X299/Timmermans kriek 330ml (LAMBIC) (169X299).jpg", Description="qqq", Type = "Lambic fruit", Popularity=3 };
            Product beer23 = new Product() { ProductName = "¬ÂÒ„ﬂÌ· Weiss", Price= 1.4M, PhotoUrl= "/Content/Images/169X299/¬≈—√…Õ¡ WEISS ÷…¡À« 0.5L (WEISS) (169x299).jpg", Description="qqq", Type = "Weiss", Popularity=3 };
            Product beer24 = new Product() { ProductName = "Õ«”œ” 7 ÃÔˆ¸Ò", Price= 2.4M, PhotoUrl= "/Content/Images/169X299/Õ«”œ” 7 ÃÔˆ¸Ò 0.33lt (PORTER) (169X299).jpg", Description="qqq", Type = "Porter", Popularity=3 };
           

            Category Brown_Ale = new Category() { CategoryName = "Brown Ale" };
            Category Pale_Ale = new Category() { CategoryName = "Pale Ale" };
            Category India_Pale_Ale = new Category() { CategoryName = "India Pale Ale" };
            Category Porter = new Category() { CategoryName = "Porter" };
            Category Stout = new Category() { CategoryName = "Stout" };
            Category Belgian_Style_Beer = new Category() { CategoryName = "Belgian Style Beer" };
            Category Wheat_Beer = new Category() { CategoryName = "Wheat Beer" };
            Category Golden_Ale = new Category() { CategoryName = "Golden Ale" };
            Category Red_Ale = new Category() { CategoryName = "Red Ale" };
            Category Dark_Ale = new Category() { CategoryName = "Dark Ale" };




            Brown_Ale.Products = new List<Product>() { beer1, beer2, beer3, beer4,beer5};
          

           
         
            context.Products.AddOrUpdate(x => x.ProductName, beer1, beer2, beer3, beer4,beer5,beer6,beer7,beer8,beer9,beer10,beer11,beer12,beer13,beer14,beer15,beer16,beer17,beer18,beer19,beer20,beer21,beer22,beer23,beer24);
            context.Categories.AddOrUpdate(x => x.CategoryName, Brown_Ale, Pale_Ale, India_Pale_Ale, Porter, Stout, Belgian_Style_Beer, Wheat_Beer, Golden_Ale, Red_Ale, Dark_Ale);
          

            context.SaveChanges();
            



            if (!context.Roles.Any(x => x.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };



                manager.Create(role);
            }
            if (!context.Roles.Any(x => x.Name == "customer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);

                var role = new IdentityRole { Name = "customer" };
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

            var PassWordHash1 = new PasswordHasher();
            if (!context.Users.Any(x => x.UserName == "customer@customer.net"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser()
                {
                    UserName = "customer@customer.net",
                    Email = "customer@customer.net",
                    PasswordHash = PassWordHash1.HashPassword("customer")
                };
                manager.Create(user);
                manager.AddToRole(user.Id, "customer");

            }







        }
    }
}
