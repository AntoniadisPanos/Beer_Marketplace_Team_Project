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
    class BeerRepository
    {

        ApplicationDbContext db = new ApplicationDbContext();


        public IEnumerable<Beer> GetAll()
        {
            return db.Beers.ToList();
        }

        public IEnumerable<Beer> GetAllOrderedByName()
        {
            return db.Beers.OrderBy(x => x.Name).ToList();
        }

        public IEnumerable<Beer> FilterByName(string name)
        {
            return db.Beers.Where(x => x.Name.Contains(name)).ToList();
        }



        public Beer GetById(int? id)
        {
            return db.Beers.Find(id);
        }

        public void Insert(Beer beer)
        {
            db.Entry(beer).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Update(Beer beer)
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

