using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//12，网上流传一句话:"常在网上飘啊，哪能不挨刀啊～"。其实要想能安安心心地上网其实也不难，学点安全知识就可以。
//首先，我们就要设置一个安全的密码。那什么样的密码才叫安全的呢？一般来说一个比较安全的密码至少应该满足下面两个条件：

//(1).密码长度大于等于8，且不要超过16。
//(2).密码中的字符应该来自下面“字符类别”中四组中的至少三组。

//这四个字符类别分别为：
//1.大写字母：A,B,C...Z;
//2.小写字母：a,b,c...z;
//3.数字：0,1,2...9;
//4.特殊符号：~,!,@,#,$,%,^;

//给你一个密码，你的任务就是判断它是不是一个安全的密码。

namespace 练习题5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("输入密码：");

            string password = ReadLine();
            const int minLength = 8;
            const int maxLength = 16;
            char[] specialChars = { '~', '!' , '@', '#', '$', '%', '^'};
            byte safeLevel = 0;
            bool isSafe = false;

            if (!IsLengthOk(password, minLength, maxLength))
            {
                WriteLine("密码长度不合法：必须为8~16位");
                return;
            }

            for (int i = 0; i < password.Length; i++)
            {
                IsUpperCase(password[i]);
                IsLowerCase(password[i]);
                IsNumber(password[i]);
            }

            isSafe = safeLevel >= 3 ? true : false;

            string safe = isSafe ? "是安全的密码" : "不是安全的密码";
            WriteLine(safe);
            ReadKey();
        }

        static bool IsUpperCase(char c) => (c >= 'A' && c <= 'Z') ? true : false;

        static bool IsLowerCase(char c) => (c >= 'a' && c <= 'z') ? true : false;

        static bool IsNumber(char c) => (c >= '0' && c <= '9') ? true : false;

        static bool HasSpecialChar(string str, char[] chars) => (str.IndexOfAny(chars) != -1) ? true : false;

        static bool IsLengthOk(string str, int min, int max) => (str.Length >= min && str.Length <= max) ? true : false;
    }
}
