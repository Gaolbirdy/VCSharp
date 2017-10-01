using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

//5，从键盘输入一个三位的正整数，按数字的相反顺序输出。

namespace 练习题3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("从键盘输入一个三位的正整数：");
            string str = ReadLine();
            int x = ToInt32(str);
            int geWei, shiWei, baiWei;
            geWei = x % 10;
            shiWei = (x / 10) % 10;
            baiWei = x / 100;
            Write("算法1：" + geWei + shiWei + baiWei + "\n");

            string newStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Write(str[i] + " ");
                newStr += str[i];
            }
            WriteLine();
            WriteLine(newStr);
            ReadKey();
        }
    }
}
