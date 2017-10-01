using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch03Test05
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine("输入第1个整数:");
            //int var1 = ToInt32(ReadLine());
            //WriteLine("输入第2个整数:");
            //int var2 = ToInt32(ReadLine());
            //WriteLine("输入第3个整数:");
            //int var3 = ToInt32(ReadLine());
            //WriteLine("输入第4个整数:");
            //int var4 = ToInt32(ReadLine());
            //WriteLine("它们的乘积是：" + (var1 * var2 * var3 * var4));
            //ReadKey();

            //WriteLine("要计算几个数的乘积:");
            //int numCount = ToInt32(ReadLine());
            //int result = 1;
            //string numbers = "";
            //for (int i = 1; i <= numCount; i++)
            //{
            //    Write($"\n输入第{i}个整数:");
            //    int var = ToInt32(ReadLine());
            //    result *= var;
            //    numbers = numbers + ( (i > 1 && i <= numCount) ? " * " : "") + var;
            //    WriteLine(numbers + " == " + result);
            //}
            
            long result = 1;
            string numbers = "";
            int count = 1;
            WriteLine("计算整数乘积（输入非数字则会结束计算）\n");
            while (true)
            {
                Write($"输入第{count}个整数: ");
                string input = ReadLine();
                int var;
                bool isInt = int.TryParse(input, out var);
                if (!isInt)
                {
                    WriteLine("输入值无效，计算结束");
                    break;
                }
                result *= var;
                numbers = numbers + (count > 1 ? " * " : "") + var;
                WriteLine(numbers + " == " + result + "\n");
                count++;
            }
            ReadKey();
        }
    }
}
