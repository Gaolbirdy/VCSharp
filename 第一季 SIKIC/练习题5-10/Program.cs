using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//10，输入一个字符串，判断其是否是C#的合法标识符。
// 字母和下划线可以在任何位置，数字不能在开头，@只能在开头

namespace 练习题5_10
{
    class Program
    {
        static string[] keywords = { "int", "string", "void" };

        static void Main(string[] args)
        {
            bool isOk = false;

            while (!isOk)
            {
                Write("输入字符串：");
                string str = ReadLine();

                if(IsKeywords(str))
                {
                    WriteLine("不能是系统关键字");
                    continue;
                }

                if (!CheckFirstChar(str))
                {
                    WriteLine("第一个字符不合法");
                    continue;
                }

                if (!CheckOtherChar(str))
                {
                    WriteLine("后续字符不合法");
                    continue;
                }
                isOk = true;
                WriteLine("字符串合法");
            }
            ReadKey();
        }

        static bool CheckFirstChar(string str) => IsUnderline(str[0]) || IsLetter(str[0]) || IsAtChar(str[0]);

        static bool CheckOtherChar(string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (IsNumber(str[i]) || IsUnderline(str[i]) || IsLetter(str[i]))
                    continue;
                else
                    return false;
            }
            return true;
        }

        //static bool IsKeywords(string str)
        //{
        //    foreach (string item in keywords)
        //    {
        //        if (str == item)
        //            return true;
        //    }
        //    return false;
        //}

        static bool IsKeywords(string str) => (Array.IndexOf(keywords, str) != -1) ? true : false;

        static bool IsLetter(char c) => ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) ? true : false;

        static bool IsNumber(char c) => (c >= '0' && c <= '9') ? true : false;

        static bool IsUnderline(char c) => (c == '_') ? true : false;

        static bool IsAtChar(char c) => (c == '@') ? true : false;
    }
}
