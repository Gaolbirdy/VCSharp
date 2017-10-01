using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

//2,让用户输入两个整数，然后再输入0-3之间的一个数，0代表加法，1代表减法，2代表乘法，3代表除法,计算这两个数字的结果

namespace 练习题4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            float res;
            WriteLine("输入第一个整数：");
            x = ToInt32(ReadLine());
            WriteLine("输入第二个整数：");
            y = ToInt32(ReadLine());
            WriteLine("输入0-3之间的一个数，0代表加法，1代表减法，2代表乘法，3代表除法：");
            z = ToInt32(ReadLine());
            switch (z)
            {
                case 0:
                default:
                    res = x + y;
                    WriteLine(x + " + " + y + " == " + res);
                    break;
                case 1:
                    res = x - y;
                    WriteLine(x + " - " + y + " == " + res);
                    break;
                case 2:
                    res = x * y;
                    WriteLine(x + " * " + y + " == " + res);
                    break;
                case 3:
                    try
                    {
                        res = (float)x / y;
                        WriteLine(x + " / " + y + " == " + res);
                    }
                    catch (Exception e)
                    {
                        WriteLine(e.Message);
                    }
                    break;
            }
            ReadKey();
        }
    }
}
