using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//9,编写一个掷筛子100次的程序，并打印出各种点数的出现次数。

namespace 练习题4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int countOf1 = 0, countOf2 = 0, countOf3 = 0, countOf4 = 0, countOf5 = 0, countOf6 = 0;
            for (int i = 0; i < 100; i++)
            {
                int random = gen.Next(1, 7);
                Write(random + " ");
                switch (random)
                {
                    case 1:
                        countOf1++;
                        break;
                    case 2:
                        countOf2++;
                        break;
                    case 3:
                        countOf3++;
                        break;
                    case 4:
                        countOf4++;
                        break;
                    case 5:
                        countOf5++;
                        break;
                    case 6:
                        countOf6++;
                        break;
                }
            }
            WriteLine();
            WriteLine("1的次数： " + countOf1);
            WriteLine("2的次数： " + countOf2);
            WriteLine("3的次数： " + countOf3);
            WriteLine("4的次数： " + countOf4);
            WriteLine("5的次数： " + countOf5);
            WriteLine("6的次数： " + countOf6);
            ReadKey();
        }
    }
}
