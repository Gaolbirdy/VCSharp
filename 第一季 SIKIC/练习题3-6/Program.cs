using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

//6，编写一个程序，输入梯形的上底 下底 和高 ，计算出来梯形的面积并显示出来。

namespace 练习题3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("输入梯形的上底：");
            float x = ToSingle(ReadLine());
            Write("输入梯形的下底：");
            float y = ToSingle(ReadLine());
            Write("输入梯形的高底：");
            float h = ToSingle(ReadLine());
            Write("梯形的面积：" + (x + y) * h / 2);
            ReadKey();
        }
    }
}
