using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch05Test04
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("请输入字符串：");
            string str = ReadLine();
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
