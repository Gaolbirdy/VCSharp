using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

//6，喜欢西游记的同学肯定都知道悟空偷吃蟠桃的故事，你们一定都觉得这猴子太闹腾了，其实你们是有所不知：悟空是在研究一个数学问题！
//什么问题？他研究的问题是蟠桃一共有多少个！
//不过，到最后，他还是没能解决这个难题，呵呵^-^
//当时的情况是这样的：
//第一天悟空吃掉桃子总数一半多一个，第二天又将剩下的桃子吃掉一半多一个，以后每天吃掉前一天剩下的一半多一个，
//到第n天准备吃的时候只剩下一个桃子。聪明的你，请帮悟空算一下，他第一天开始吃的时候桃子一共有多少个呢？
//用户输入n的值，计算出来他第一天吃的时候桃子是多少个

namespace 练习题5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("悟空第几天准备吃的时候只剩下一个桃子了？ ");
            int day = ToInt32(ReadLine());
            for (int i = 0; i < day; i++)
            {

            }
            ReadKey();
        }
    }
}
