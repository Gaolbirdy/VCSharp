using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch05Test05
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("请输入字符串：");
            string str = ReadLine();
            string newStr = "yes";
            string oldStr = "no";
            str = str.Replace(oldStr, newStr);
            WriteLine(str);
            ReadKey();
        }
    }
}
