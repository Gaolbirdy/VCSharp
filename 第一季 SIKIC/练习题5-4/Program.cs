using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//4，编写一个应用程序用来输入的字符串进行加密，对于字母字符串加密规则如下：
//‘a’→’d’ ‘b’→’e’ ‘w’→’z’ …… ‘x’→’a’ ‘y’→’b’ ‘z’→’c’‘A’→’D’ ‘B’→’E’ ‘W’→’Z’ …… ‘X’→’A’ ‘Y’→’B’ ‘Z’→’C’? 对于其他字符，不进行加密。
// github test

namespace 练习题5_4
{
    class Program
    {
        static void Main()
        {
            const int pwOffset = 3;
            int charCount = 'z' - 'a' + 1; // 字符集的总数量，用于偏移越界后从头开始
            string oldStr = ReadLine();
            string newStr = "";
            for (int i = 0; i < oldStr.Length; i++)
            {
                if ((oldStr[i] >= 'a' && oldStr[i] <= 'z') || (oldStr[i] >= 'A' && oldStr[i] <= 'Z'))
                {
                    //if(str[i] >= 'x' || str[i] >= 'X')
                    //    str[i] = (char)(str[i] + pwOffset - charCount);
                    //else
                    //    str[i] = (char)(str[i] + pwOffset);

                    char firstChar = char.IsLower(oldStr[i]) ? 'a' : 'A';
                    //str[i] = (char)((str[i] + pwOffset - firstChar) % charCount + firstChar); // 求余获取相对于第一个字符的最大偏移量
                    int posOffset = oldStr[i] + pwOffset - firstChar;
                    int maxOffset = posOffset % charCount;
                    char newChar = (char)(firstChar + maxOffset);
                    newStr += newChar;
                }
                else
                    newStr += oldStr[i];
            }
            WriteLine(newStr);
            ReadKey();
        }
    }
}
