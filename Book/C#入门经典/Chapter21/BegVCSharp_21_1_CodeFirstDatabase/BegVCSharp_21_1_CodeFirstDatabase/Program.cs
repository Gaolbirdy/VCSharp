using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using static System.Console;

namespace BegVCSharp_21_1_CodeFirstDatabase
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        [Key]
        public int Code { get; set; }
    }

    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BookContext())
            {
                Book book = new Book { Title = "Beginning Visual C# 2015", Author = "Perkins, Reid, and Hammer" };

                AddBook(db, book);

                book = new Book { Title = "Beginning XML", Author = "Fawcett, Quin, and Ayers"};

                AddBook(db, book);
                var query = from b in db.Books
                            orderby b.Title
                            select b;

                WriteLine("All books in the database:");
                foreach (var b in query)
                {
                    WriteLine($"{b.Title} by {b.Author}, code={b.Code}");
                }


                WriteLine("Press a key to exit...");
                ReadKey();
            }
        }

        private static void AddBook(BookContext db, Book book)
        {
            var testQuery = from b in db.Books
                            where b.Title == book.Title && b.Author == book.Author
                            select b;

            if (testQuery.Count() < 1)
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
        }
    }
}