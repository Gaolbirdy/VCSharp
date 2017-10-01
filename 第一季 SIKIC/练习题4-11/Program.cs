using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

//11,一个控制台应用程序,要求用户输入5个大写字母，如果用户输入的信息不满足要求，提示帮助信息并要求重新输入。

namespace 练习题4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                while (true)
                {
                    WriteLine($"输入第{i}个大写字母：");
                    char c = ToChar(ReadLine());
                    if (c >= 'A' && c <= 'Z')
                        break;
                    else
                        WriteLine("不符合，重新输入");
                }
            }
            ReadKey();
        }
    }
}
