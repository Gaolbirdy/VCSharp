using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace StringApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //字符串，字符串连接
//            string fname, lname;
//            fname = "Rowan";
//            lname = "Atkinson";

//            string fullname = fname + lname;
//            Console.WriteLine("Full Name: {0}", fullname);

//            //通过使用 string 构造函数
//            char[] letters = { 'H', 'e', 'l', 'l', 'o'};
//            string greetings = new string(letters);
//            Console.WriteLine("Greetings: {0}", greetings);

//            //方法返回字符串
//            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
//            string message = String.Join(" ", sarray);
//            Console.WriteLine("Message: {0}", message);

//            //用于转化值的格式化方法
//            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
//            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
//            Console.WriteLine("Message: {0}", chat);

//            Console.ReadKey();
//        }
//    }
//}

//namespace StringApplication
//{
//    class StringProg
//    {
//        static void Main()
//        {
//            string str1 = "This is test";
//            string str2 = "This is text";

//            if (String.Compare(str1, str2) == 0)
//            {
//                Console.WriteLine(str1 + " and " + str2 + " are equal.");
//            }
//            else
//            {
//                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
//                Console.WriteLine(String.Compare(str1, str2));
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace StringApplication
//{
//    class StringProg
//    {
//        static void Main()
//        {
//            string str = "This is test";
//            if (str.Contains("test"))
//            {
//                Console.WriteLine("The sequence 'test' was found.");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace StringApplication
//{
//    class StringProg
//    {
//        static void Main()
//        {
//            string str = "Last night I dreamt of San Pedro";
//            Console.WriteLine(str);
//            string substr = str.Substring(23);
//            Console.WriteLine(substr);
//            Console.ReadKey();
//        }
//    }
//}

namespace StringApplication
{
    class StringProg
    {
        static void Main()
        {
            string[] starray = new string[]
            {
                "Down the way nights are dark",
                "And the sun shines daily on the mountain top",
                "I took a trip on a sailing ship",
                "And when I reached Jamaica",
                "I made a stop"
            };
            string str = String.Join("\n", starray);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}