using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch06Ex01
{
    class Program
    {
        static string myString;

        static void Write()
        {
            string myString = "String defined in Write()";
            WriteLine("Now in Write()");
            WriteLine($"Local myString = {myString}");
            WriteLine($"Global myString = {Program.myString}");
            Program.myString = "Global String New";
        }

        static double Multipply(double myVal1, double myVal2) => myVal1 * myVal2;

        static void Main(string[] args)
        {
            int i;
            string text = "";
            for(i = 0; i < 10; i++)
            {
                text = "Line " + i.ToString();
                WriteLine(text);
            }
            WriteLine($"Last text output in loop: {text}");

            string myString = "String defined in Main()";
            Program.myString = "Global String";
            Write();
            WriteLine("\nNow in Main()");
            WriteLine($"Local myString = {myString}");
            WriteLine($"Global myString = {Program.myString}");

            double x = 100, y = 2;
            WriteLine($"\n\n{x} * {y} = {Multipply(x, y)}");
            ReadKey();
        }
    }
}
