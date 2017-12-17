using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp中的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 18;
            //int b = 6;
            //int c = a + b;
            //Console.WriteLine(c);
            //c = a - b;
            //Console.WriteLine(c);
            //c = a * b;
            //Console.WriteLine(c);
            //c = a / b;
            //Console.WriteLine(c);

            //a = 5;
            //b = 4;
            //c = 2;
            //int d = a + b * c;
            //Console.WriteLine(d);
            //d = (a + b) * c;
            //Console.WriteLine(d);
            //d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            //Console.WriteLine(d);

            //a = 7;
            //b = 4;
            //c = 3;
            //d = (a + b) / c;
            //int e = (a + b) % c;
            //Console.WriteLine($"quotient: {d}");
            //Console.WriteLine($"remainder: {e}");

            //int max = int.MaxValue;
            //int min = int.MinValue;
            //Console.WriteLine($"The range of integers is {min} to {max}");
            //int what = max + 3;
            //Console.WriteLine($"An Example of overflow: {what}");

            //double a = 19;
            //double b = 23;
            //double c = 8;
            //double d = (a + b) / c;
            //Console.WriteLine(d);

            //double max = double.MaxValue;
            //double min = double.MinValue;
            //Console.WriteLine($"The range of double is {min} to {max}");

            //double third = 1.0 / 3.0;
            //Console.WriteLine(third);

            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"The area is {area}");
        }
    }
}
