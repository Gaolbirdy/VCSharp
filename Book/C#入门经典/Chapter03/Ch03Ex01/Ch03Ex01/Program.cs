using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "\"myInterger\" is ";
            //New C# 6 syntax -> String Interpolation
            Console.WriteLine($"{myString} {myInteger}");
            Console.ReadLine();

            //Pre C# 6 syntax
            //Console.WriteLine("{0} {1}", myString, myInteger);
        }
    }
}
