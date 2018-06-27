using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 结构体
{
    //struct Books
    //{
    //    public string title;
    //    public string author;
    //    public string subject;
    //    public int book_id;
    //}

    //public class TestStructure
    //{
    //    public static void Main(string[] args)
    //    {
    //        Books book1;
    //        Books book2;

    //        book1.title = "C Programming";
    //        book1.author = "Maxsu";
    //        book1.subject = "C Programming Tutorial";
    //        book1.book_id = 5493427;

    //        book2.title = "Telecom Billing";
    //        book2.author = "Sukida";
    //        book2.subject = "Telecom Billing Tutorial";
    //        book2.book_id = 8493480;

    //        WriteLine("Book 1 title : {0}", book1.title);
    //        WriteLine("Book 1 author : {0}", book1.author);
    //        WriteLine("Book 1 subject : {0}", book1.subject);
    //        WriteLine("Book 1 book_id : {0}", book1.book_id);

    //        WriteLine("Book 2 title : {0}", book2.title);
    //        WriteLine("Book 2 author : {0}", book2.author);
    //        WriteLine("Book 2 subject : {0}", book2.subject);
    //        WriteLine("Book 2 book_id : {0}", book2.book_id);
    //    }
    //}

    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void GetValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }

        public void Display()
        {
            WriteLine("Title: {0}", title);
            WriteLine("Author: {0}", author);
            WriteLine("Subject: {0}", subject);
            WriteLine("Book_id: {0}", book_id);
        }
    }

    class TestStructure
    {
        public static void Main(string[] args)
        {
            Books book1 = new Books();
            Books book2 = new Books();

            book1.GetValues("C Programming",
        "Maxsu", "C Programming Tutorial", 749540712);

            book2.GetValues("Telecom Billing",
        "Sukida", "Telecom Billing Tutorial", 59570011);

            book1.Display();

            book2.Display();

        }
    }
}
