using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//1,编写一个程序，对输入的4个整数，求出其中的最大值和最小值，并显示出来。

namespace 练习题4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("输入4个整数：");
            int num1 = CheckNum(1);
            int num2 = CheckNum(2);
            int num3 = CheckNum(3);
            int num4 = CheckNum(4);
            int maxNum = Max(num1, num2, num3, num4);
            int minNum = Min(num1, num2, num3, num4);

            WriteLine("最大值是: " + maxNum + "最小值是:" + minNum);
            ReadKey();
        }

        static int Max(int num1, int num2, int num3, int num4)
        {
            int max;
            if (num1 > num2)
            {
                max = num1;
            }
            else
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }
            if (num4 > max)
            {
                max = num4;
            }
            return max;
        }

        static int Min(int num1, int num2, int num3, int num4)
        {
            int min;
            if (num1 < num2)
            {
                min = num1;
            }
            else
            {
                min = num2;
            }
            if (num3 < min)
            {
                min = num3;
            }
            if (num4 < min)
            {
                min = num4;
            }
            return min;
        }

        static int CheckNum(int index)
        {
            bool isNumberOk = false;
            int returnNum = 0;
            while (!isNumberOk)
            {
                WriteLine($"输入第{index}个整数：");
                string input = ReadLine();
                isNumberOk = int.TryParse(input, out returnNum);
                if (!isNumberOk)
                    WriteLine("输入值无效，需重新输入：\n");
            }
            return returnNum;
        }
    }
}
