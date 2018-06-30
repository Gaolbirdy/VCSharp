#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace 特性
{
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Constructor |
        AttributeTargets.Field |
        AttributeTargets.Method |
        AttributeTargets.Property,
        AllowMultiple = true,
        Inherited = false)]
    public class MyAttribute : Attribute
    { }

    [MyAttribute]
    public class MyClass
    {
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            WriteLine(msg);
        }
    }

    class Test
    {
        static void Function1()
        {
            MyClass.Message("In Function 1.");
            Function2();
        }

        static void Function2()
        {
            MyClass.Message("In Function 2.");
        }

        public static void Main()
        {
            MyClass.Message("In Main Function.");
            Function1();
            ReadKey();
        }
    }
}
