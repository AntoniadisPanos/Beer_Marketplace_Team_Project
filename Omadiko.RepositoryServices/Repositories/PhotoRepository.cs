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
    public class PhotoRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public List<PhotoForSite> GetAll()
        {
            return db.PhotoForSites.ToList();
        }
        public PhotoForSite GetById(int id)
        {
            return db.PhotoForSites.Find(id);
        }
        public void Create(PhotoForSite photo)
        {
            db.Entry(photo).State = EntityState.Added;
            db.SaveChanges();
        }
        public void Edit(PhotoForSite photo)
        {
            db.Entry(photo).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            PhotoForSite photo = db.PhotoForSites.Find(id);
            if (!(photo is null))
            {
                db.Entry(photo).State = EntityState.Deleted;
                db.SaveChanges();
            }
            else
            {
                throw new Exception("Unable to delete this Photo");
            }
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
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
