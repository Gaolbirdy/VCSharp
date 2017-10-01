using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

//3，接受用户输入的两个整数，存储到两个变量里面，交换变量存储的值。

namespace 练习题3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Write("输出第1个整数：");
            num1 = ToInt32(ReadLine());
            Write("输出第2个整数：");
            num2 = ToInt32(ReadLine());
            int temp = num1;
            num1 = num2;
            num2 = temp;
            WriteLine("交换后：" + num1 + "  " + num2);
            ReadKey();
        }
    }
}
