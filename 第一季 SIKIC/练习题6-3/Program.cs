using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

//3，将一个正整数分解质因数。例如：输入90,打印出90=2*3*3*5。测试数据有多组

namespace 练习题6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("输入一个正整数：");
            int num = ToInt32(ReadLine());
            int result;
            for (int i = 0; i < num; i++)
            {
                if (IsPrime(i))
                {
                    if (num % i == 0)
                    {
                        num = num / i;
                    }
                }
                else
                    break;
            }
        }

        static bool IsPrime(int x)
        {
            bool isPrime = true;
            for (int i = 2; i < x; i++)
            {
                if ((x % i) != 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
