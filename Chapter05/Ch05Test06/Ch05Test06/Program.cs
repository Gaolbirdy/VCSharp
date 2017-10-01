using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch05Test06
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("输入字符串：");
            string str = ReadLine();
            str = str.Trim(' ');
            //str = str.Replace(" ", "\"\"");
            //WriteLine("\"" + str + "\"");
            string[] strArray = str.Split(' ');
            str = "";
            foreach (var s in strArray)
            {
                str += "\"" + s + "\"";
            }
            WriteLine(str);
            ReadKey();
        }
    }
}
