using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//2，3个可乐瓶可以换一瓶可乐，现在有364瓶可乐。
//问一共可以喝多少瓶可乐，剩下几个空瓶！

namespace 练习题5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int remains = 364    ; // 剩余可乐
            int empty = 0; // 剩余空瓶
            int total = 0; // 总共喝的瓶数

            while(remains > 0)
            {
                empty += remains; // 喝光剩余所有瓶 364 ，得到空瓶数
                total += remains; // 喝光剩余所有瓶 总共喝的
                remains = empty / 3; // 3个空瓶再兑换1瓶 121
                empty = empty % 3; // 兑换后剩余空瓶 1
            }
            WriteLine("一共喝了：" + total);
            WriteLine("剩余空瓶：" + empty);
            WriteLine("还剩几瓶可乐：" + remains);
            ReadKey();
        }
    }
}
