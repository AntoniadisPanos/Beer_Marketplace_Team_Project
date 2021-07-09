using Omadiko.Database;
using Omadiko.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.RepositoryServices
{
    class ProductRepository
    {

        ApplicationDbContext db = new ApplicationDbContext();


        public IEnumerable<Product> GetAll()
        {
            return db.Beers.ToList();
        }

        public IEnumerable<Product> GetAllOrderedByName()
        {
            return db.Beers.OrderBy(x => x.ProductName).ToList();
        }

        public IEnumerable<Product> FilterByName(string name)
        {
            return db.Beers.Where(x => x.ProductName.Contains(name)).ToList();
        }



        public Product GetById(int? id)
        {
            return db.Beers.Find(id);
        }

        public void Insert(Product beer)
        {
            db.Entry(beer).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Update(Product beer)
        {
            db.Entry(beer).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var beer = db.Beers.Find(id);

            db.Entry(beer).State = EntityState.Deleted;
            db.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}

