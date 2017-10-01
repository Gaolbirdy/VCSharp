using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//8,编程输出九九乘法表。

namespace 练习题4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = i; j <= 9; j++)
                {
                    Write(i + " * " + j + " == " + (i * j) + "; ");
                }
                WriteLine();
            }
            ReadKey();
        }
    }
}
