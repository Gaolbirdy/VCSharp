#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace 特性
{
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Constructor |
        AttributeTargets.Field |
        AttributeTargets.Method |
        AttributeTargets.Property,
        AllowMultiple = true)]

    public class DebugInfo : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        public DebugInfo(int bg, string dev, string d)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = d;
        }

        public int BugNo
        {
            get
            {
                return bugNo;
            }
        }

        public string Developer
        {
            get
            {
                return developer;
            }
        }

        public string LastReview
        {
            get
            {
                return LastReview;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }

    [DebugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
    [DebugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
    class Rectangele
    {
        // 成员变量
        protected double length;
        protected double width;

        public Rectangele(double l, double w)
        {
            length = l;
            width = w;
        }

        [DebugInfo(55, "Zara Ali", "19/20/2012",
        Message = "Return type mismatch")]
        public double GetArea()
        {
            return length * width;
        }

        [DebugInfo(56, "Zara Ali", "19/20/2012")]
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}

//public class MyClass
//{
//    [Conditional("DEBUG")]
//    public static void Message(string msg)
//    {
//        Console.WriteLine(msg);
//    }
//}
//class Test
//{
//    static void Function1()
//    {
//        MyClass.Message("In Function 1.");
//        Function2();
//    }


//    static void Function2()
//    {
//        MyClass.Message("In Function 2.");
//    }

//    public static void Main()
//    {
//        MyClass.Message("In Main Function.");
//        Function1();
//        Console.ReadKey();
//    }
//}

//public class MyClass
//{
//    [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
//    static void OldMethod()
//    {
//        Console.WriteLine("It is the old method");
//    }
//    static void NewMethod()
//    {
//        Console.WriteLine("It is the new method");
//    }
//    public static void Main()
//    {
//        OldMethod();
//    }
//}
