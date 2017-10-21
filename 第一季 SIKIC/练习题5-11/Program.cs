using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//11，“回文串”是一个正读和反读都一样的字符串，比如“level”或者“noon”等等就是回文串。请写一个程序判断读入的字符串是否是“回文”。

namespace 练习题5_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("请输入字符串：");
            string str = ReadLine();
            bool palindrome = true;

            for (int i = 0; i < str.Length / 2; i++) // 奇数长度的数组的中间元素，就不用比了
            //for (int i = 0; i <= (str.Length - 1) / 2; i++) // 奇数和偶数数组的比较次数一样
            {
                if (str[i] != str[str.Length - 1 -i])
                {
                    palindrome = false;
                    break;
                }
            }

            string isPalindrome = palindrome ? "是回文串" : "不是回文串";
            WriteLine(isPalindrome);
            ReadKey();
        }
    }
}
