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
            string result = num + " = ";

            for (int i = 1; i <= num; i++)    // i为寻找的因子
            {
                if (num == 1 || IsPrime(num))
                {
                    result += num;  // 是1，或是质数，则质因子即为该数本身；将质因子拼接进等式字符串
                    break;  // 即找到了最后一个质因子，结束循环
                }
                if (IsPrime(i))
                {
                    if (num % i == 0)
                    {
                        result += i + " * ";  // 将质因子拼接进等式字符串
                        num = num / i;  // 找到一个质因子后，得到商作为正整数，继续循环找下一个质因子
                        i = 1 - 1;    // 找到一个质因子后，把i重置为0，在循环后的i++后，i被重置为起始的因子数1；对商从头开始找质因子
                        continue;
                    }
                }
            }
            WriteLine(result);
            ReadKey();
        }

        static bool IsPrime(int x)
        {
            bool isPrime = true;
            if (x == 1)
                isPrime = false;
            else
            {
                for (int i = 2; i < x; i++)
                {
                    if ((x % i) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            return isPrime;
        }
    }
}
