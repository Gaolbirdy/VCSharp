using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//6,编程输出1 ~100中能被3整除但不能被5整除的数,并统计有多少个这样的数。

namespace 练习题4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0 && i % 5 != 0)
                {
                    Write(i + " ");
                    sum++;
                }
            }
            WriteLine("能被3整除但不能被5整除的数的数量： " + sum);
            ReadKey();
        }
    }
}
