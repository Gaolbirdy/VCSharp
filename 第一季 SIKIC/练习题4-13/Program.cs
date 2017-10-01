using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//13,一个控制台应用程序，求1000之内的所有“完数”。所谓“完数”是指一个数恰好等于它的所有因子之和。例如6是完数，因为6=1+2+3。

namespace 练习题4_13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                string str = "1 ";
                int sum = 1;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                        str += j + " ";
                    }
                }
                if (sum == i)
                {
                    Write(i + "：" + str);
                    WriteLine();
                }
            }
            ReadKey();
        }
    }
}
