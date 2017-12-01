using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 100, j, k;
            //char c, ch;
            //float f, salary;
            //double d;

            //int d = 3, f = 5;
            //byte z = 22;
            //double pi = 3.14159;
            //char x = 'x';

            short a;
            int b;
            double c;

            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"num: {num}");
            Console.ReadKey();
        }
    }
}
