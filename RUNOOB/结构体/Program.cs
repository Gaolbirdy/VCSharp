using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace 结构体
//{
//    struct Books
//    {
//        public string title;
//        public string author;
//        public string subject;
//        public int book_id;
//    }

//    public class testStructure
//    {
//        //struct Books
//        //{
//        //    public string title;
//        //    public string author;
//        //    public string subject;
//        //    public int book_id;
//        //}

//        static void Main(string[] args)
//        {
//            Books book1;
//            Books book2 = new Books();

//            book1.title = "C Programming";
//            book1.author = "Nuha Ali";
//            book1.subject = "C Programming Tutorial";
//            book1.book_id = 6495407;

//            book2.title = "Telecom Billing";
//            book2.author = "Zara Ali";
//            book2.subject = "Telecom Billing Tutorial";
//            book2.book_id = 6495700;

//            Console.WriteLine("book 1 title : {0}", book1.title);
//            Console.WriteLine("book 1 author : {0}", book1.author);
//            Console.WriteLine("book 1 subject : {0}", book1.subject);
//            Console.WriteLine("book 1 book_id : {0}", book1.book_id);

//            Console.WriteLine("book 2 title : {0}", book2.title);
//            Console.WriteLine("book 2 author : {0}", book2.author);
//            Console.WriteLine("book 2 subject : {0}", book2.subject);
//            Console.WriteLine("book 2 book_id : {0}", book2.book_id);

//            Console.ReadKey();
//        }
//    }
//}

namespace 结构体
{
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
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }
    }

    public class testStructure
    {
        //struct Books
        //{
        //    public string title;
        //    public string author;
        //    public string subject;
        //    public int book_id;
        //}

        static void Main(string[] args)
        {
            Books book1 = new Books();
            Books book2 = new Books();

            book1.GetValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);

            book2.GetValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", 6495700);

            book1.Display();

            book2.Display();

            Console.ReadKey();
        }
    }
}
