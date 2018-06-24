using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DataTypeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Size of double: {0}", sizeof(double));

            object obj;
            obj = 100;
            int a = (int)obj;
            WriteLine("a = {0}",a);

            dynamic d = 20;
            WriteLine("d = {0}", d);

            string str = "Yiibai point";
            string str2 = @"Yiibai point";
            WriteLine("str = {0}", str);
            WriteLine("str2 = {0}", str2);

            int* i;
            char* c;

            ReadLine();
        }
    }
}
