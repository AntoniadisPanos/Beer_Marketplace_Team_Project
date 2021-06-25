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
    public class BookRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();


        public IEnumerable<Book> GetAll()
        {
            return db.Books.ToList();
        }

        public IEnumerable<Book> GetAllOrderedByName()
        {
            return db.Books.OrderBy(x=>x.Title).ToList();
        }

        public IEnumerable<Book> FilterByName(string title)
        {
            return db.Books.Where(x => x.Title.Contains(title)).ToList();
        }



        public Book GetById(int? id)
        {
            return db.Books.Find(id);
        }

        public void Insert(Book book)
        {
            db.Entry(book).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Update(Book book)
        {
            db.Entry(book).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = db.Books.Find(id);

            db.Entry(book).State = EntityState.Deleted;
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
