using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

//4，输入两个正整数m和n，求其最大公约数和最小公倍数。

namespace 练习题6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("输入第一个正整数：");
            int num1 = ToInt32(ReadLine());
            WriteLine("输入第二个正整数：");
            int num2 = ToInt32(ReadLine());

        }
    }
}
