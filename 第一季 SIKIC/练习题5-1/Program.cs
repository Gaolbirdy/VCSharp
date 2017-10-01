using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//1，找出100到999之间的水仙花数；"153 = 1 * 1 * 1 + 5 * 5 * 5 + 3 * 3 * 3"

namespace 练习题5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                int gewei = i % 10;
                int shiwei = (i / 10) % 10; // int shiwei2 = (i % 100) / 10;
                int baiwei = i / 100;
                double sum = Math.Pow(gewei, 3) + Math.Pow(shiwei, 3) + Math.Pow(baiwei, 3);
                if (i == sum)
                    WriteLine(i);
            }
            ReadKey();
        }
    }
}
