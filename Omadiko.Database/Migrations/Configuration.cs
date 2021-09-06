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
            Product beer1 = new Product() { ProductName = "Corona", Price = 3.0m, SmallPhoto = "/Content/Images/169X299/Corona_extra_355ml.png", LargePhoto = "/Content/Images/475X550/corona_beer_330ml.png", ABV = 0.05, Volume = 0.335, Description = "Corona Beer", Type = "Lager", Popularity = 5 };
            Product beer2 = new Product() { ProductName = "Chios_Alos", Price = 2.0m, SmallPhoto = "/Content/Images/169X299/Chiou_alos_pale_ale_330ml.png", LargePhoto = "/Content/Images/475X550/Chios_alos_pale_330ml_adobespark.png", ABV = 0.07, Volume = 0.330, Description = "Test", Type = "Pale Ale", Popularity = 4 };
            Product beer3 = new Product() { ProductName = "ΦΡΕΣΚΙΑ ΜΠΥΡΑ ΧΙΟΥ", Price = 2.2m, SmallPhoto = "/Content/Images/169X299/Chiou_Freskia.png", LargePhoto = "/Content/Images/169X299/Chiou_Freskia_Ale_330ml.png", ABV = 0.049, Volume = 0.330, Description = "qqq", Type = "Pale Ale", Popularity = 3 };
            Product beer4 = new Product() { ProductName = "Aecht_Schlenkerla_Rauchbie", Price = 4.0m, SmallPhoto = "/Content/Images/169X299/Aecht-Schlenkerla-Rauchbier-Marzen.png", LargePhoto = "/Content/Images/475X550/Aecht_Schlenkerla_Rauchbier_Maerzen.png", ABV = 0.051, Volume = 0.500, Description = "qqq", Type = "Smoked", Popularity = 3 }; 
            Product beer5 = new Product() { ProductName = "Fix Hellas", Price = 2.0m, SmallPhoto = "/Content/Images/169X299/Fix_Hellas_500ml.png", LargePhoto = "/Content/Images/475X550/Fix_Hellas_500ml.png", ABV = 0.005, Volume = 0.500, Description = "qqq", Type = "Lager", Popularity = 3 };
            Product beer6 = new Product() { ProductName = "ASAHI", Price = 2.36m, SmallPhoto = "/Content/Images/169X299/Asahi_Super_Dry-Black_330ml.png", LargePhoto = "/Content/Images/475X550/ASAHI_SUPER_DRY_BEER_330ml.png", ABV = 0.005, Volume = 0.330, Description = "qqq", Type = "Dry", Popularity = 3 };
            Product beer7 = new Product() { ProductName = "CHIOS BBQ", Price = 2.2m, SmallPhoto = "/Content/Images/169X299/Chios_BBQ.png", LargePhoto = "/Content/Images/475X550/CHIOS_BBQ.png", ABV = 0.05, Volume = 0.330, Description = "qqq", Type = "Smoked", Popularity = 3 };
            Product beer8 = new Product() { ProductName = "Corfu", Price = 2.6m, SmallPhoto = "/Content/Images/169X299/Corfu_Dark_Ale_Bitter_500ml.png", LargePhoto = "/Content/Images/475X550/Corfu_Dark_Ale_Bitter_500ml.png", ABV = 0.05, Volume = 0.330, Description = "qqq", Type = "Bitter", Popularity = 3 }; 
            Product beer9 = new Product() { ProductName = "Erdinger Weiss", Price = 2.3m, SmallPhoto = "/Content/Images/169X299/Erdinger_Weiss_500ml.png", LargePhoto = "/Content/Images/475X550/Erdinger_Weiss_500ml.png", ABV = 0.053, Volume = 0.500, Description = "qqq", Type = "Weiss", Popularity = 3 }; 
            Product beer10 = new Product() { ProductName = "Gouden Carolus Ambrio", Price = 2.3m, SmallPhoto = "/Content/Images/169X299/Gouden_Carolus_330ml.png", LargePhoto = "/Content/Images/475X550/Gouden_Carolus_Ambrio_330ml.png", ABV = 0.08, Volume = 0.330, Description = "qqq", Type = "Strong Ale", Popularity = 3 };
            Product beer11 = new Product() { ProductName = "GRIMBERGEN Double", Price = 3.0m, SmallPhoto = "/Content/Images/169X299/Grimbergen-double-330ml.png", LargePhoto = "/Content/Images/475X550/Grimbergen_Double_330ml.png", ABV = 0.065, Volume = 0.330, Description = "qqq", Type = "Trappist", Popularity = 3 }; 
            Product beer12 = new Product() { ProductName = "Guinness Draught", Price = 2.0m, SmallPhoto = "/Content/Images/169X299/Guiness-draught-stout-330ml.png", LargePhoto = "/Content/Images/475X550/Guinness_Draught_Stout_330ml.png", ABV = 0.042, Volume = 0.330, Description = "qqq", Type = "Draught", Popularity = 3 }; 
            Product beer13 = new Product() { ProductName = "Guinness Special", Price = 3.3m, SmallPhoto = "/Content/Images/169X299/Guiness_Special_export_330ml.png", LargePhoto = "/Content/Images/475X550/Guinness_Special_STOUT.png", ABV = 0.08, Volume = 0.330, Description = "qqq", Type = "Stout", Popularity = 3 };
            Product beer14 = new Product() { ProductName = "McFarland", Price = 1.4m, SmallPhoto = "/Content/Images/169X299/McFarland_Red_Irish_330ml.png", LargePhoto = "/Content/Images/475X550/McFarland_Beer_330ml.png", ABV = 0.056, Volume = 0.330, Description = "qqq", Type = "Red Ale", Popularity = 3 };
            Product beer15 = new Product() { ProductName = "Kaiser Pils", Price = 1.4m, SmallPhoto = "/Content/Images/169X299/Kaiser_Pilsner_500ml.png", LargePhoto = "/Content/Images/475X550/Kaizer_Pilsner_500ml.png", ABV = 0.05, Volume = 0.330, Description = "qqq", Type = "Pilsner", Popularity = 3 };
            Product beer16 = new Product() { ProductName = "Kirki Pale Ale", Price = 2.7m, SmallPhoto = "/Content/Images/169X299/Kirki-Pale-Ale-330ml.png", LargePhoto = "/Content/Images/475X550/Kirki_Pale_Ale_330ml.png", ABV = 0.056, Volume = 0.330, Description = "qqq", Type = "Pale Ale", Popularity = 3 }; 
            Product beer17 = new Product() { ProductName = "Newcastle Brown Ale", Price = 1.6m, SmallPhoto = "/Content/Images/169X299/Newcastle_Brown_Ale_330ml.png", LargePhoto = "/Content/Images/475X550/Newcastle_Brown_Ale_330ml.png", ABV = 0.047, Volume = 0.330, Description = "qqq", Type = "Brown Ale", Popularity = 3 }; 
            Product beer18 = new Product() { ProductName = "Paguru Cream Ale", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Paguru_Cream_Ale_330ml.png", LargePhoto = "/Content/Images/475X550/Paguru_Cream_Ale_330ml.png", ABV = 0.05, Volume = 0.330, Description = "qqq", Type = "Cream Ale", Popularity = 3 };
            Product beer19 = new Product() { ProductName = "Paulaner Salvator", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Paulaner_Salvator.500ml.png", LargePhoto = "/Content/Images/475X550/Paulaner_Salvator_330ml.png", ABV = 0.079, Volume = 0.330, Description = "qqq", Type = "Bock", Popularity = 3 }; 
            Product beer20 = new Product() { ProductName = "Rodenbach Caractere", Price = 4.0m, SmallPhoto = "/Content/Images/169X299/Rodenbach_Caractere_Rouge_Red_Ale_750ml.png", LargePhoto = "/Content/Images/475X550/Rodenback_Caractere_Rouge_750ml.png", ABV = 0.07, Volume = 0.750, Description = "qqq", Type = "Bock", Popularity = 3 }; 
            Product beer21 = new Product() { ProductName = "Samichlaus Bier", Price = 4.0m, SmallPhoto = "/Content/Images/169X299/Samichlaus_Bier_330ml.png", LargePhoto = "/Content/Images/475X550/Samichlaus_Bier_330ml.png", ABV = 0.14, Volume = 0.330, Description = "qqq", Type = "Bock", Popularity = 3 }; 
            Product beer22 = new Product() { ProductName = "Timmermans kriek", Price = 3.5m, SmallPhoto = "/Content/Images/169X299/Timmermans_Kriek_330ml.png", LargePhoto = "/Content/Images/475X550/Timmermans_kriek_330ml.png", ABV = 0.04, Volume = 0.330, Description = "qqq", Type = "Lambic fruit", Popularity = 3 };
            Product beer23 = new Product() { ProductName = "Βεργινα Weiss", Price = 1.4m, SmallPhoto = "/Content/Images/169X299/Vergina-Weiss-500ml.png", LargePhoto = "/Content/Images/475X550/Vergina_Weiss_500ml.png", ABV = 0.054, Volume = 0.500, Description = "qqq", Type = "Weiss", Popularity = 3 };
            Product beer24 = new Product() { ProductName = "Νησος 7 Μποφορ", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Nisos-7-bofor-330ml.png", LargePhoto = "/Content/Images/475X550/Nisos_7_bofor_330ml.png", ABV = 0.07, Volume = 0.330, Description = "qqq", Type = "Porter", Popularity = 3 }; 
            Product beer25 = new Product() { ProductName = "Amstel", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/AMSTEL_500ml_adobespark.png", LargePhoto = "/Content/Images/475X550/Amstel 500ml.png", ABV = 0.05, Volume = 0.500, Description = "qqq", Type = "Lager", Popularity = 3 };
            Product beer26 = new Product() { ProductName = "Becks Blue", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Becks_Alc_Free_Pilsener_330ml_adobespark.png", LargePhoto = "/Content/Images/475X550/Becks-Blue-330ml-scaled.png", ABV = 0, Volume = 0.330, Description = "qqq", Type = "Pilsner", Popularity = 3 };
            Product beer27 = new Product() { ProductName = "Bevog Rudeen", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Bevog-Rudeen-Black-Ipa-330ml.png", LargePhoto = "/Content/Images/475X550/Bevog-Rudeen-Black-Ipa-330ml.png", ABV = 0.074, Volume = 0.330, Description = "qqq", Type = "Ipa", Popularity = 3 };
            Product beer28 = new Product() { ProductName = "Brinks", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Brinks_Blonde_330ml.png", LargePhoto = "/Content/Images/475X550/Brinks_Blonde_330ml.png", ABV = 0.048, Volume = 0.330, Description = "qqq", Type = "Lager", Popularity = 3 };
            Product beer29 = new Product() { ProductName = "Clausthaler", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Clausthaler_alc_free_330ml.png", LargePhoto = "/Content/Images/475X550/Clausthaler_alc_free_330ml.png", ABV = 0.05, Volume = 0.330, Description = "qqq", Type = "Lager", Popularity = 3 };
            Product beer30 = new Product() { ProductName = "Royal Ionian", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Corfu_Beer_Ionian_Radler_330.png", LargePhoto = "/Content/Images/475X550/Corfu_Beer_Ionian_Radler_330.png", ABV = 0.02, Volume = 0.330, Description = "qqq", Type = "Radler", Popularity = 3 };
            Product beer31 = new Product() { ProductName = "Fanziskaner", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Fanziskaner_Weiss_500ml.png", LargePhoto = "/Content/Images/475X550/Fanziskaner_Weiss_500ml.png", ABV = 0.05, Volume = 0.500, Description = "qqq", Type = "German Hefeweizen", Popularity = 3 };
            Product beer32 = new Product() { ProductName = "Ikariotissa", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Ikariotissa_330ml.png", LargePhoto = "/Content/Images/475X550/Ikariotissa_330ml.png", ABV = 0.05, Volume = 0.330, Description = "qqq", Type = "Golden Ale", Popularity = 3 }; 
            Product beer33 = new Product() { ProductName = "Kozel Dark", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Kozel_Dark_500ml.png", LargePhoto = "/Content/Images/475X550/Kozel-Dark-500ml.png", ABV = 0.038, Volume = 0.500, Description = "qqq", Type = "Dark Lager", Popularity = 3 }; 
            Product beer34 = new Product() { ProductName = "Krusovice", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Krusovice_330ml.png", LargePhoto = "/Content/Images/475X550/Krusovice_330ml.png", ABV = 0.05, Volume = 0.500, Description = "qqq", Type = "Lager", Popularity = 3 }; 
            Product beer35 = new Product() { ProductName = "Mamos", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Mamos_500ml.png", LargePhoto = "/Content/Images/475X550/Mamos_500ml.png", ABV = 0.05, Volume = 0.500, Description = "qqq", Type = "Lager", Popularity = 3 };
            Product beer36 = new Product() { ProductName = "Peroni", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Peroni_330.png", LargePhoto = "/Content/Images/475X550/Peroni_330.png", ABV = 0.51, Volume = 0.330, Description = "qqq", Type = "Lager", Popularity = 3 }; 
            Product beer37 = new Product() { ProductName = "Pinta Imperator", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Pinta_Imperator_Baltycki_330ml.png", LargePhoto = "/Content/Images/475X550/Pinta_Imperator_Baltycki_330ml.png", ABV = 0.91, Volume = 0.330, Description = "qqq", Type = "Baltic Porter", Popularity = 3 }; 
            Product beer38 = new Product() { ProductName = "Semedorato Golden Seed", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Semedorato_Golden_Seed_330ml.png", LargePhoto = "/Content/Images/475X550/Semedorato_Golden_Seed_330ml.png", ABV = 0.07, Volume = 0.330, Description = "qqq", Type = "Lager", Popularity = 3 }; 
            Product beer39 = new Product() { ProductName = "Stella Artois Premium", Price = 2.4m, SmallPhoto = "/Content/Images/169X299/Stella_Artois Premium_Lager_660ml.png", LargePhoto = "/Content/Images/475X550/Stella_Artois Premium_Lager_660ml.png", ABV = 0.48, Volume = 0.660, Description = "qqq", Type = "Lager", Popularity = 3 };


            Category BrownAle = new Category() { CategoryName = "Brown Ale" };
            BrownAle.Products = new List<Product>() { beer17 }; 
            Category PaleAle = new Category() { CategoryName = "Pale Ale" };
            PaleAle.Products = new List<Product>() { beer2, beer3, beer16 }; 
            Category CreamAle = new Category() { CategoryName = "Cream Ale" };
            CreamAle.Products = new List<Product>() { beer18 };
            Category GoldenAle = new Category() { CategoryName = "Golden Ale" };
            GoldenAle.Products = new List<Product>() { beer32 };
            Category RedAle = new Category() { CategoryName = "Red Ale" };
            RedAle.Products = new List<Product>() { beer14 }; 
            Category StrongAle = new Category() { CategoryName = "Red Ale" }; 
            StrongAle.Products = new List<Product>() { beer10 }; 
            Category Porter = new Category() { CategoryName = "Porter" };
            Porter.Products = new List<Product>() { beer24 }; 
            Category Stout = new Category() { CategoryName = "Stout" };
            Stout.Products = new List<Product>() { beer13 };
            Category Lager = new Category() { CategoryName = "Lager" };
            Lager.Products = new List<Product>() { beer1, beer5, beer25, beer28, beer29, beer34, beer35, beer36, beer38, beer39 };
            Category DarkLager = new Category() { CategoryName = "Dark Lager" }; 
            DarkLager.Products = new List<Product>() { beer33 };
            Category Smoked = new Category() { CategoryName = "Smoked" };
            Smoked.Products = new List<Product>() { beer4, beer7 };
            Category Dry = new Category() { CategoryName = "Dry" };
            Dry.Products = new List<Product>() { beer6 };
            Category Bitter = new Category() { CategoryName = "Bitter" };
            Bitter.Products = new List<Product>() { beer8 }; 
            Category Weiss = new Category() { CategoryName = "Weiss" };
            Weiss.Products = new List<Product>() { beer9, beer23 }; 
            Category Trappist = new Category() { CategoryName = "Trappist" }; 
            Trappist.Products = new List<Product>() { beer11 };
            Category Draught = new Category() { CategoryName = "Draught" };
            Draught.Products = new List<Product>() { beer12 };
            Category Pilsner = new Category() { CategoryName = "Pilsner" };
            Pilsner.Products = new List<Product>() { beer15, beer26 };
            Category Bock = new Category() { CategoryName = "Bock" };
            Bock.Products = new List<Product>() { beer19, beer20, beer21 }; 
            Category LambicFruit = new Category() { CategoryName = "Lambic Fruit" };
            LambicFruit.Products = new List<Product>() { beer22 };
            Category Ipa = new Category() { CategoryName = "Ipa" };
            Ipa.Products = new List<Product>() { beer27 };
            Category Radler = new Category() { CategoryName = "Radler" };
            Radler.Products = new List<Product>() { beer30 };
            Category BalticPorter = new Category() { CategoryName = "Baltic Porter" };
            BalticPorter.Products = new List<Product>() { beer37 };
            Category GermanHefeweizen = new Category() { CategoryName = "German Hefeweizen" };
            GermanHefeweizen.Products = new List<Product>() { beer31 };

            //Blogs
            Blog blog1 = new Blog() { Comments = "The best bear i have ever taste", CustomerName = "Giannis", CustomerEmail = "giannhskabouris@hotmail.com",ProductId=1 };
            beer1.Blogs = new List<Blog> { blog1 };
            Blog blog2 = new Blog() { Comments = "The best bear i have ever taste", CustomerName = "Panos", CustomerEmail = "panosantoniadis@hotmail.com",ProductId = 2 };
            beer2.Blogs = new List<Blog> { blog2 };
            Blog blog3 = new Blog() { Comments = "The best bear i have ever taste", CustomerName = "Giwrgos", CustomerEmail = "giwrgoskara@hotmail.com", ProductId = 3 };
            beer3.Blogs = new List<Blog> { blog3 };
            Blog blog4 = new Blog() { Comments = "The best bear i have ever taste", CustomerName = "Marios", CustomerEmail = "marioskolokotronis@hotmail.com", ProductId = 4 };
            beer4.Blogs = new List<Blog> { blog4 };

            ////Articles

            Article art1 = new Article() { Blog = "Brewed with licorice a proprietary, hand-smoked malt and almost a pound of East Kent Goldings hops per barrel.Opaque brown in color, with muddy brown edges and a cola-colored head that drops quickly to a ringed lace. Strong and dominating licorice aroma with an underlying robust molasses-ness and highly roasted malts. Thick-ish, deep blackstrap molasses character (sweet, tangy nectar), quite robust.", FullBlog = "A rich-looking, deep-copper-hued beer, leaning toward the dark side, with an off-white foam head that drops to a fine ringed lace. Aroma is unique. Uniquely British, with a suggestion of dryness, metallic hints, prominent nutty malt character, interesting orchard-esque notes, deep caramel beneath, toasty and soft powdery spices. Lively in the mouth, with a slightly crisp carbonation that peaks and provides some creaminess. Medium, even-bodied, with a round fullness about it. Quite dry up front, with slightly abrasive raw, leafy and pithy characters mixed with some tamed hop bitterness. Wood and earth? Yeah, a bit. Some fruity and berry-like tartness, reminiscent of holiday pie fillings and plump, juicy, almost over-ripe black cherries. Definite apple flavors follow fruit, as well as juicy pear. Robust and hearty as far as beers go. Toasty malts, bready, crust-like. Watery toffee, with hints of vanilla beneath. Dusting of cinnamon. Orange zest flavors become more pronounced as the beer warms, pulling through toward the finish. Man, this beer is all over the place. Quite dry in the finish, with a lingering yeasty character, touch of toasty sweetness and a bitey feel on the palate.The short, stubby, 11.2-ounce Duvel-style bottle releases a dark, leathery-brown brew, with a tan-colored, super-tight, creamy, fluffy lacing. Amazing head retention. Malted milk balls, spicy yeast and a soft herbal Saaz aroma. As soon as the beer hits the palate, it creams up with a light and fluffy feel and lively carbonation. Slight up-front sharpness, a meld of light hop bitterness and slight medicinal phenols, with a warming alcohol bite riding its wake. Notes of pith and leaf. Herbal tea and a tease of pepper tucked beneath a moderate residual sweetness, with flavors of toffee, brown bread, dried fruits and fermented honey. Some spice emerges from the alcohol as it warms. Finish goes dry, with some residual malt sweetness and bready yeast in the back.", DateTime = new DateTime(2020, 12, 21), Title = "OKTOBERFEST" };
            Article art2 = new Article() { Blog = "Brewed with licorice a proprietary, hand-smoked malt and almost a pound of East Kent Goldings hops per barrel.Opaque brown in color, with muddy brown edges and a cola-colored head that drops quickly to a ringed lace. Strong and dominating licorice aroma with an underlying robust molasses-ness and highly roasted malts. Thick-ish, deep blackstrap molasses character (sweet, tangy nectar), quite robust.", FullBlog = "A rich-looking, deep-copper-hued beer, leaning toward the dark side, with an off-white foam head that drops to a fine ringed lace. Aroma is unique. Uniquely British, with a suggestion of dryness, metallic hints, prominent nutty malt character, interesting orchard-esque notes, deep caramel beneath, toasty and soft powdery spices. Lively in the mouth, with a slightly crisp carbonation that peaks and provides some creaminess. Medium, even-bodied, with a round fullness about it. Quite dry up front, with slightly abrasive raw, leafy and pithy characters mixed with some tamed hop bitterness. Wood and earth? Yeah, a bit. Some fruity and berry-like tartness, reminiscent of holiday pie fillings and plump, juicy, almost over-ripe black cherries. Definite apple flavors follow fruit, as well as juicy pear. Robust and hearty as far as beers go. Toasty malts, bready, crust-like. Watery toffee, with hints of vanilla beneath. Dusting of cinnamon. Orange zest flavors become more pronounced as the beer warms, pulling through toward the finish. Man, this beer is all over the place. Quite dry in the finish, with a lingering yeasty character, touch of toasty sweetness and a bitey feel on the palate.The short, stubby, 11.2-ounce Duvel-style bottle releases a dark, leathery-brown brew, with a tan-colored, super-tight, creamy, fluffy lacing. Amazing head retention. Malted milk balls, spicy yeast and a soft herbal Saaz aroma. As soon as the beer hits the palate, it creams up with a light and fluffy feel and lively carbonation. Slight up-front sharpness, a meld of light hop bitterness and slight medicinal phenols, with a warming alcohol bite riding its wake. Notes of pith and leaf. Herbal tea and a tease of pepper tucked beneath a moderate residual sweetness, with flavors of toffee, brown bread, dried fruits and fermented honey. Some spice emerges from the alcohol as it warms. Finish goes dry, with some residual malt sweetness and bready yeast in the back.", DateTime = new DateTime(2020, 12, 14), Title = "NOW STOCKED IN NYC" };
            Article art3 = new Article() { Blog = "Brewed with licorice a proprietary, hand-smoked malt and almost a pound of East Kent Goldings hops per barrel.Opaque brown in color, with muddy brown edges and a cola-colored head that drops quickly to a ringed lace. Strong and dominating licorice aroma with an underlying robust molasses-ness and highly roasted malts. Thick-ish, deep blackstrap molasses character (sweet, tangy nectar), quite robust.", FullBlog = "A rich-looking, deep-copper-hued beer, leaning toward the dark side, with an off-white foam head that drops to a fine ringed lace. Aroma is unique. Uniquely British, with a suggestion of dryness, metallic hints, prominent nutty malt character, interesting orchard-esque notes, deep caramel beneath, toasty and soft powdery spices. Lively in the mouth, with a slightly crisp carbonation that peaks and provides some creaminess. Medium, even-bodied, with a round fullness about it. Quite dry up front, with slightly abrasive raw, leafy and pithy characters mixed with some tamed hop bitterness. Wood and earth? Yeah, a bit. Some fruity and berry-like tartness, reminiscent of holiday pie fillings and plump, juicy, almost over-ripe black cherries. Definite apple flavors follow fruit, as well as juicy pear. Robust and hearty as far as beers go. Toasty malts, bready, crust-like. Watery toffee, with hints of vanilla beneath. Dusting of cinnamon. Orange zest flavors become more pronounced as the beer warms, pulling through toward the finish. Man, this beer is all over the place. Quite dry in the finish, with a lingering yeasty character, touch of toasty sweetness and a bitey feel on the palate.The short, stubby, 11.2-ounce Duvel-style bottle releases a dark, leathery-brown brew, with a tan-colored, super-tight, creamy, fluffy lacing. Amazing head retention. Malted milk balls, spicy yeast and a soft herbal Saaz aroma. As soon as the beer hits the palate, it creams up with a light and fluffy feel and lively carbonation. Slight up-front sharpness, a meld of light hop bitterness and slight medicinal phenols, with a warming alcohol bite riding its wake. Notes of pith and leaf. Herbal tea and a tease of pepper tucked beneath a moderate residual sweetness, with flavors of toffee, brown bread, dried fruits and fermented honey. Some spice emerges from the alcohol as it warms. Finish goes dry, with some residual malt sweetness and bready yeast in the back.", DateTime = new DateTime(2020, 12, 09), Title = "NEW STOCK NOW AVAILABLE" };
            Article art4 = new Article() { Blog = "Brewed with licorice a proprietary, hand-smoked malt and almost a pound of East Kent Goldings hops per barrel.Opaque brown in color, with muddy brown edges and a cola-colored head that drops quickly to a ringed lace. Strong and dominating licorice aroma with an underlying robust molasses-ness and highly roasted malts. Thick-ish, deep blackstrap molasses character (sweet, tangy nectar), quite robust.", FullBlog = "A rich-looking, deep-copper-hued beer, leaning toward the dark side, with an off-white foam head that drops to a fine ringed lace. Aroma is unique. Uniquely British, with a suggestion of dryness, metallic hints, prominent nutty malt character, interesting orchard-esque notes, deep caramel beneath, toasty and soft powdery spices. Lively in the mouth, with a slightly crisp carbonation that peaks and provides some creaminess. Medium, even-bodied, with a round fullness about it. Quite dry up front, with slightly abrasive raw, leafy and pithy characters mixed with some tamed hop bitterness. Wood and earth? Yeah, a bit. Some fruity and berry-like tartness, reminiscent of holiday pie fillings and plump, juicy, almost over-ripe black cherries. Definite apple flavors follow fruit, as well as juicy pear. Robust and hearty as far as beers go. Toasty malts, bready, crust-like. Watery toffee, with hints of vanilla beneath. Dusting of cinnamon. Orange zest flavors become more pronounced as the beer warms, pulling through toward the finish. Man, this beer is all over the place. Quite dry in the finish, with a lingering yeasty character, touch of toasty sweetness and a bitey feel on the palate.The short, stubby, 11.2-ounce Duvel-style bottle releases a dark, leathery-brown brew, with a tan-colored, super-tight, creamy, fluffy lacing. Amazing head retention. Malted milk balls, spicy yeast and a soft herbal Saaz aroma. As soon as the beer hits the palate, it creams up with a light and fluffy feel and lively carbonation. Slight up-front sharpness, a meld of light hop bitterness and slight medicinal phenols, with a warming alcohol bite riding its wake. Notes of pith and leaf. Herbal tea and a tease of pepper tucked beneath a moderate residual sweetness, with flavors of toffee, brown bread, dried fruits and fermented honey. Some spice emerges from the alcohol as it warms. Finish goes dry, with some residual malt sweetness and bready yeast in the back.", DateTime = new DateTime(2020, 12, 27), Title = "TRY OUR NEW FlAVOURS " };
            Article art5 = new Article() { Blog = "Brewed with licorice a proprietary, hand-smoked malt and almost a pound of East Kent Goldings hops per barrel.Opaque brown in color, with muddy brown edges and a cola-colored head that drops quickly to a ringed lace. Strong and dominating licorice aroma with an underlying robust molasses-ness and highly roasted malts. Thick-ish, deep blackstrap molasses character (sweet, tangy nectar), quite robust.", FullBlog = "A rich-looking, deep-copper-hued beer, leaning toward the dark side, with an off-white foam head that drops to a fine ringed lace. Aroma is unique. Uniquely British, with a suggestion of dryness, metallic hints, prominent nutty malt character, interesting orchard-esque notes, deep caramel beneath, toasty and soft powdery spices. Lively in the mouth, with a slightly crisp carbonation that peaks and provides some creaminess. Medium, even-bodied, with a round fullness about it. Quite dry up front, with slightly abrasive raw, leafy and pithy characters mixed with some tamed hop bitterness. Wood and earth? Yeah, a bit. Some fruity and berry-like tartness, reminiscent of holiday pie fillings and plump, juicy, almost over-ripe black cherries. Definite apple flavors follow fruit, as well as juicy pear. Robust and hearty as far as beers go. Toasty malts, bready, crust-like. Watery toffee, with hints of vanilla beneath. Dusting of cinnamon. Orange zest flavors become more pronounced as the beer warms, pulling through toward the finish. Man, this beer is all over the place. Quite dry in the finish, with a lingering yeasty character, touch of toasty sweetness and a bitey feel on the palate.The short, stubby, 11.2-ounce Duvel-style bottle releases a dark, leathery-brown brew, with a tan-colored, super-tight, creamy, fluffy lacing. Amazing head retention. Malted milk balls, spicy yeast and a soft herbal Saaz aroma. As soon as the beer hits the palate, it creams up with a light and fluffy feel and lively carbonation. Slight up-front sharpness, a meld of light hop bitterness and slight medicinal phenols, with a warming alcohol bite riding its wake. Notes of pith and leaf. Herbal tea and a tease of pepper tucked beneath a moderate residual sweetness, with flavors of toffee, brown bread, dried fruits and fermented honey. Some spice emerges from the alcohol as it warms. Finish goes dry, with some residual malt sweetness and bready yeast in the back.", DateTime = new DateTime(2021, 12, 05), Title = "BREWING TIPS" };
            Article art6 = new Article() { Blog = "Brewed with licorice a proprietary, hand-smoked malt and almost a pound of East Kent Goldings hops per barrel.Opaque brown in color, with muddy brown edges and a cola-colored head that drops quickly to a ringed lace. Strong and dominating licorice aroma with an underlying robust molasses-ness and highly roasted malts. Thick-ish, deep blackstrap molasses character (sweet, tangy nectar), quite robust.", FullBlog = "A rich-looking, deep-copper-hued beer, leaning toward the dark side, with an off-white foam head that drops to a fine ringed lace. Aroma is unique. Uniquely British, with a suggestion of dryness, metallic hints, prominent nutty malt character, interesting orchard-esque notes, deep caramel beneath, toasty and soft powdery spices. Lively in the mouth, with a slightly crisp carbonation that peaks and provides some creaminess. Medium, even-bodied, with a round fullness about it. Quite dry up front, with slightly abrasive raw, leafy and pithy characters mixed with some tamed hop bitterness. Wood and earth? Yeah, a bit. Some fruity and berry-like tartness, reminiscent of holiday pie fillings and plump, juicy, almost over-ripe black cherries. Definite apple flavors follow fruit, as well as juicy pear. Robust and hearty as far as beers go. Toasty malts, bready, crust-like. Watery toffee, with hints of vanilla beneath. Dusting of cinnamon. Orange zest flavors become more pronounced as the beer warms, pulling through toward the finish. Man, this beer is all over the place. Quite dry in the finish, with a lingering yeasty character, touch of toasty sweetness and a bitey feel on the palate.The short, stubby, 11.2-ounce Duvel-style bottle releases a dark, leathery-brown brew, with a tan-colored, super-tight, creamy, fluffy lacing. Amazing head retention. Malted milk balls, spicy yeast and a soft herbal Saaz aroma. As soon as the beer hits the palate, it creams up with a light and fluffy feel and lively carbonation. Slight up-front sharpness, a meld of light hop bitterness and slight medicinal phenols, with a warming alcohol bite riding its wake. Notes of pith and leaf. Herbal tea and a tease of pepper tucked beneath a moderate residual sweetness, with flavors of toffee, brown bread, dried fruits and fermented honey. Some spice emerges from the alcohol as it warms. Finish goes dry, with some residual malt sweetness and bready yeast in the back.", DateTime = new DateTime(2020, 12, 30), Title = "NEW BREWING KITS AVAILABLE" };



            //Photos
            PhotoForSite photo1 = new PhotoForSite() { Url = "https://c4.wallpaperflare.com/wallpaper/760/269/149/food-beer-wallpaper-preview.jpg" };
            PhotoForSite photo2 = new PhotoForSite() { Url = "https://c4.wallpaperflare.com/wallpaper/246/1015/597/alcohol-food-beer-drinking-glass-hd-wallpaper-preview.jpg" };
            PhotoForSite photo3 = new PhotoForSite() { Url = "https://c0.wallpaperflare.com/preview/197/815/783/bottle.jpg" };
            PhotoForSite photo4 = new PhotoForSite() { Url = "~/Template/images/114642september-555x355.jpg" };
            PhotoForSite photo5 = new PhotoForSite() { Url = "~/Template/images/Brazil-ranked-number-2-most-innovative-craft-beer-market-Mintel.jpg" };
            PhotoForSite photo6 = new PhotoForSite() { Url = "~/Template/images/dt-freevb-1500x500.jpg" };
            PhotoForSite photo7 = new PhotoForSite() { Url = "~/Template/images/Hooghoudt-30_RON5843-555x355.jpg" };
            PhotoForSite photo8 = new PhotoForSite() { Url = "~/Template/images/Japanese-Beer-2017.jpg" };
            PhotoForSite photo9 = new PhotoForSite() { Url = "~/Template/images/nordic-beer-markets.jpg" };
            PhotoForSite photo10 = new PhotoForSite() { Url = "~/Template/images/US-craft-beer-slows-while-spirits-take-off_wrbm_large" };




            context.Products.AddOrUpdate(x => x.ProductName, beer1, beer2, beer3, beer4, beer5, beer6, beer7, beer8, beer9, beer10, beer11, beer12, beer13, beer14, beer15, beer16, beer17, beer18, beer19, beer20, beer21, beer22, beer23, beer24, beer25, beer26, beer27, beer28, beer29, beer30, beer31, beer32, beer33, beer34, beer35, beer36, beer37, beer38, beer39);
            context.Categories.AddOrUpdate(x => x.CategoryName, BrownAle, PaleAle, CreamAle, GoldenAle, RedAle, StrongAle, Porter, Stout, Lager, DarkLager, Smoked, Dry, Bitter, Weiss, Trappist, Draught, Pilsner, Bock, LambicFruit, Ipa, Radler, BalticPorter, GermanHefeweizen);
            context.Articles.AddOrUpdate(x => x.DateTime, art1, art2, art3, art4, art5, art6);
            context.Blogs.AddOrUpdate(x => x.CustomerEmail, blog1, blog2, blog3, blog4);
            context.PhotoForSites.AddOrUpdate(x => x.Url, photo1, photo2, photo3, photo4, photo5, photo6, photo7, photo8, photo9, photo10);
            context.SaveChanges(); 

            if (!context.Roles.Any(x => x.Name == "Admin"))
            { var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };
                manager.Create(role);
            }
            if (!context.Roles.Any(x => x.Name == "Customer"))
            { var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Customer" };
                manager.Create(role);
            }
            var PasswordHash = new PasswordHasher();
            if (!context.Users.Any(x => x.UserName == "admin@admin.net"))
            { var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser 
                { UserName = "admin@admin.net",
                    Email = "admin@admin.net",
                    PasswordHash = PasswordHash.HashPassword("Admin1!")
                }; manager.Create(user);
                manager.AddToRole(user.Id, "Admin"); 
            }
            var PassWordHash1 = new PasswordHasher(); 
            if (!context.Users.Any(x => x.UserName == "customer@customer.net"))
            { var store = new UserStore<ApplicationUser>(context); 
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() 
                { UserName = "customer@customer.net",
                    Email = "customer@customer.net", 
                    PasswordHash = PassWordHash1.HashPassword("Customer")
                }; 
                manager.Create(user); manager.AddToRole(user.Id, "Customer");
            }

            
        }


    }
}
    

