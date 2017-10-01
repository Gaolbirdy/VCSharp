using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch04Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 5;
            int var2 = 13;
            int var3 = 20;
            WriteLine(var1 > 10 && var2 > 10);
            WriteLine(var1 > 10 || var2 > 10);
            WriteLine(var1 > 10 ^ var2 > 10);
            WriteLine(var2 > 10 ^ var3 > 10);
            //多个异或，则两两比较，依次计算
            ReadKey();
        }
    }
}
