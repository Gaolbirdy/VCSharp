using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//namespace EscapeChar
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            WriteLine("Hello\tWorld\n\n");
//            ReadLine();
//        }
//    }
//}

namespace DeclaringConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;

            double r;
            WriteLine("Enter Radius: ");
            r = Convert.ToInt32(ReadLine());
            double areaCircle = pi * r * r;
            WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            ReadLine();
        }
    }
}
