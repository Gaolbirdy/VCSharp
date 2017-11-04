using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

//2，f(n)=f(n-1)+f(n-2) f(0)=2 f(1)=3 ,用程序求得f(40)

namespace 练习题6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("输入一个数字：");
            int num = ToInt32(ReadLine());
            WriteLine($"F({num})的结果为： " + Fibonacci(num));
            ReadKey();
        }

        static int Fibonacci(int n)
        {
            int result = 0;
            if (n < 0)
                result = 0;
            else if (n == 0)
                result = 2;
            else if (n == 1)
                result = 3;
            else
                result = Fibonacci(n - 1) + Fibonacci(n - 2);
            return result;
        }
    }
}
