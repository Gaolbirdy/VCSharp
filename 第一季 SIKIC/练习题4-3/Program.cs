using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//3,求出1 ~1000之间的所有能被7整除的数，并计算和输出每5个的和。

namespace 练习题4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                    count++;
                    Write(i + " ");
                    if(count % 5 == 0)
                    {
                        WriteLine("和为：" + sum);
                        sum = 0;
                    }
                }
            }
            ReadKey();
        }
    }
}
