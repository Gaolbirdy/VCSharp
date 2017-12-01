using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeChar
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello\tWorld\n\n");

        //    string a = "hello, world";
        //    string b = @"hello, world";
        //    string c = "hello \t world";
        //    string d = @"hello \t world";
        //    string e = "Joe said \"Hello\" to me";
        //    string f = @"Joe said ""Hello"" to me";
        //    string g="\\\\server\\share\\file.txt";
        //    string h = @"\\server\share\file.txt";
        //    string i = "one\r\ntwo\r\nthree";
        //    string j = @"one
        //    two
        //    three";
        //    string k = "one\rtwo\rthree";

        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //    Console.WriteLine(c);
        //    Console.WriteLine(d);
        //    Console.WriteLine(e);
        //    Console.WriteLine(f);
        //    Console.WriteLine(g);
        //    Console.WriteLine(h);
        //    Console.WriteLine(i);
        //    Console.WriteLine(j);
        //    Console.WriteLine(k);

        //    Console.ReadLine();
        ////}
    }
}

namespace DeclaringConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadKey();
        }
    }
}
