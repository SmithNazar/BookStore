using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Inferno", Author = "Dan Brown", Price = 220 });
            db.Books.Add(new Book { Name = "A Brief History of Time", Author = "Stephen Hawking", Price = 180 });
            db.Books.Add(new Book { Name = "Тигролови", Author = "Іван Багряний", Price = 150 });

            base.Seed(db);
        }
    }
}