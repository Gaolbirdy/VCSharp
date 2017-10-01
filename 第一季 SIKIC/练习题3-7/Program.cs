using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//7，计算半径为n的圆的周长和面积

namespace 练习题3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 10;
            WriteLine("半径：" + r);
            WriteLine("周长：" + (2 * Math.PI * r));
            WriteLine("面积：" + (Math.PI * r * r));
            ReadKey();
        }
    }
}
