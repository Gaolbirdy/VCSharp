using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//4,编写一个控制台程序，分别输出1 ~100之间的平方、平方根。 

namespace 练习题4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                WriteLine(i + "的平方：" + Math.Pow(i, 2));
                WriteLine(i + "的平方根：" + Math.Sqrt(i));
                WriteLine();
            }
            ReadKey();
        }
    }
}
