using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

//12,一个控制台应用程序，要求完成写列功能。
//	1）接收一个整数n。
//	2）如果接收的值n为正数，输出1 ~n间的全部整数。
//	3）如果接收的值n为负值，用break或者return退出程序。
//	4）如何n为0的话 转到1继续接收下一个整数。

namespace 练习题4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            while (true)
            {
                Write("输入一个整数: ");
                num = ToInt32(ReadLine());
                if (num == 0)
                    continue;
                else if (num >= 0)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        Write(i + " ");
                    }
                    break;
                }
                else
                {
                    return;
                }
            }
            ReadKey();
        }
    }
}
