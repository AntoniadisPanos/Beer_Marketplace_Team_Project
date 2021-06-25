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
    class AuthorRepository
    {

        ApplicationDbContext db = new ApplicationDbContext();


        public IEnumerable<Author> GetAll()
        {
            return db.Authors.ToList();
        }

        public IEnumerable<Author> GetAllOrderedByName()
        {
            return db.Authors.OrderBy(x => x.FirstName).ToList();
        }

        public IEnumerable<Author> FilterByName(string firstName)
        {
            return db.Authors.Where(x => x.FirstName.Contains(firstName)).ToList();
        }



        public Author GetById(int? id)
        {
            return db.Authors.Find(id);
        }

        public void Insert(Author author)
        {
            db.Entry(author).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Update(Author author)
        {
            db.Entry(author).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var author = db.Books.Find(id);

            db.Entry(author).State = EntityState.Deleted;
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

