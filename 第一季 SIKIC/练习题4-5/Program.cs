using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//5,兔子繁殖问题。设有一对新生的兔子，从第三个月开始他们每个月都生一对兔子，新生的兔子从第三个月开始又每个月生一对兔子。
//按此规律，并假定兔子没有死亡，20个月后共有多少个兔子？要求编写为控制台程序。

namespace 练习题4_5
{ 
    // 解法1：模拟兔子生育过程，效率低，抽象程度不高；容易递归太深而异常
    class Program_1
    {
        static int startCount = 2;
        static int totalCount = startCount;

        static void Main(string[] args)
        {
            int totalMonths = 20;
            Born(totalMonths);
            WriteLine("最后兔子对数： " + totalCount / 2);
            ReadKey();
        }

        // 仅算单独一对兔子，从他们新生时至给定月数生育的数量
        static void Born(int lastMonths)
        {
            int childCount = 0;
            int totalChildCount = 0;
            for (int passMonth = 1; passMonth <= lastMonths; passMonth++)
            {
                // 该对兔子每月生下的那对兔子
                if (passMonth >= 3)
                {
                    childCount = 2;
                    int birthMonth = passMonth; // 新生那对兔子所在的那个月份
                    // 新生那对兔子根据还剩下的月数去处理自己的生育问题
                    Born(lastMonths - passMonth + 1); // 20 - 3 + 1, 18 - 2
                }
                totalChildCount += childCount;
            }
            WriteLine($"{lastMonths} 个月 这对总共生了 {totalChildCount} 只兔子\n");
            totalCount += totalChildCount;
        }
    }
}
