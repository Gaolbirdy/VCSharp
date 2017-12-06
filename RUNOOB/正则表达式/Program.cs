using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//public class Example
//{
//    public static void Main()
//    {
//        string input = "1851 1999 1950 1905 2003";
//        string pattern = @"(?<=19)\d{2}\b";

//        foreach (Match match in Regex.Matches(input, pattern))
//            Console.WriteLine(match.Value);
//        Console.ReadKey();
//    }
//}

//namespace RegExApplication
//{
//    class Program
//    {
//        private static void ShowMatch(string text, string expr)
//        {
//            Console.WriteLine("The Expression: {0}", expr);
//            MatchCollection mc = Regex.Matches(text, expr);
//            foreach (Match m in mc)
//            {
//                Console.WriteLine(m);
//            }
//        }

//        static void Main()
//        {
//            string str = "A Thousand Splendid Suns";

//            Console.WriteLine("Matching words that start with 'S': ");
//            ShowMatch(str, @"\bS\S*");
//            Console.ReadKey();
//        }
//    }
//}

//namespace RegExApplication
//{
//    class Program
//    {
//        private static void ShowMatch(string text, string expr)
//        {
//            Console.WriteLine("The Expression: " + expr);
//            MatchCollection mc = Regex.Matches(text, expr);
//            foreach (Match m in mc)
//            {
//                Console.WriteLine(m);
//            }
//        }

//        static void Main()
//        {
//            string str = "make maze and manage to measure it";

//            Console.WriteLine("Matching words start with 'm' and ends with 'e':");
//            ShowMatch(str, @"\bm\S*e\b");
//            Console.ReadKey();
//        }
//    }
//}

namespace RegExApplication
{
    class Program
    {
        static void Main()
        {
            string input = "Hello   World   ";
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);
            Console.ReadKey();
        }
    }
}