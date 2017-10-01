using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//7,编程输出1000以内的所有素数

namespace 练习题4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1000; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Write(i + " ");
                }
            }
            ReadKey();
        }
    }
}
