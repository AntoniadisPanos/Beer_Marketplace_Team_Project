using Omadiko.Database;
using Omadiko.Entities;
using Omadiko.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;



namespace Omadiko.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        
        public ActionResult Index()
        {
            IndexHomeViewModel vm = new IndexHomeViewModel()
            {
                Articles = db.Articles.OrderBy(x => x.DateTime).Take(5).ToList(),
                BestProductsByPopularity = db.Products.Where(x => x.Popularity >= 3).OrderByDescending(x => x.Popularity).Take(5).ToList()
            };
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact(FormCollection frc)
        {
            
            return View();
        }
      
        public ActionResult OurStory()
        {
            ViewBag.Message = "You story page.";
            return View();
        }
        public ActionResult Blog()
        {
            var article = db.Articles.ToList();
            return View(article);
        }



        //[HttpGet]
        //public ActionResult SingleBlog(int? id)
        //{
        //    db.Articles.Find(id);
        //  var comment = db.Comments.ToList();
        //    return View(comment);
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult SingleBlog(FormCollection frc,int?id )
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
                 Comment comment=new Comment()
                {
                    
                    ArticleId= article.ArticleId,
                    CustomerName = User.Identity.Name,
                    CustomerEmail = User.Identity.Name,
                    Comments = frc["comment"],
                };
                db.Comments.Add(comment);

                var articlepercomment= db.Comments.Where(x => x.Article.ArticleId==id).ToList();                
                ArticleCommentsUserViewModel vm = new ArticleCommentsUserViewModel()
                {
                    Article=article,
                    Comment = comment,                                        
                    Comments= articlepercomment,

                };                       
            //var model = db.Comments.ToList(); 
            //if(model != null)
            //{
            //   db.Comments.ToList();
            //}
            db.SaveChanges();
            return View(vm);
        }
        public ActionResult OurBeer()
        {

            
            IndexHomeViewModel vm = new IndexHomeViewModel()
            {
                BestProductsByPopularity = db.Products.Where(x => x.Popularity >= 3).OrderByDescending(x => x.Popularity).Take(10).ToList(),
                Articles = db.Articles.Take(2).ToList(),
                TwoProductsForPage = db.Products.Take(2).ToList(),               
            }; 
            return View(vm);
        }
       
    }
}