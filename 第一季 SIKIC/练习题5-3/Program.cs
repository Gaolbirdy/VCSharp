using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

//3，猜数字游戏，我有一个数，请您猜猜是多少？
////请您输入一个0-50之间的数：20（用户输入数字）
////您猜小了，这个数字比20大：30
////您猜大了，这个数字比30小：25
////恭喜您猜对了，这个数字为：25
//用户猜错了就继续猜，猜对了就停止游戏。

namespace 练习题5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = new Random().Next(0, 51);
            Write("我有一个数，请您猜猜是多少？ 请您输入一个0-50之间的数: ");
            while (true)
            {
                int num = ToInt32(ReadLine());
                if (answer > num)
                {
                    WriteLine($"您猜小了，这个数字比{num}大");
                    continue;
                }
                else if (answer < num)
                {
                    WriteLine($"您猜大了，这个数字比{num}小");
                    continue;
                }
                else
                {
                    WriteLine($"您猜对了，这个数字为{num}");
                    break;
                }
            }
            ReadKey();
        }
    }
}
