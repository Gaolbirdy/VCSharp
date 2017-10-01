using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch03Test04
{
    class Program
    {
        static void Main(string[] args)
        {
            var var1 = 1;
            var var2 = 2;
            var var3 = 3;
            var var4 = 4;
            var var5 = 5;
            var resultVar1 = 0;
            resultVar1 += var1 * var2 + var3 % var4 / var5; // 1 * 2 + 3 % 4 / 5 == 2 + 0 == 2
            var resultVar2 = 0;
            resultVar2 += ((var1 * var2) + ((var3 % var4) / var5));
            WriteLine(resultVar1);
            WriteLine(resultVar2);
            WriteLine(resultVar2.CompareTo(resultVar1));
            ReadKey();
        }
    }
}
