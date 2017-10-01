using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//10,一个控制台应用程序，输出1 ~5的平方值，要求：用for语句实现。用while语句实现。用do-while语句实现。

namespace 练习题4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                WriteLine(i * i);
            }

            int j = 1;
            do
            {
                WriteLine(j * j);
                j++;
            } while (j <= 5);

            int k = 1;
            while (k < 6)
            {
                WriteLine(k * k);
                k++;
            }
            ReadKey();
        }
    }
}
