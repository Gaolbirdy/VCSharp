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
    //[AttributeUsage(AttributeTargets.Class |
    //    AttributeTargets.Constructor |
    //    AttributeTargets.Field |
    //    AttributeTargets.Method |
    //    AttributeTargets.Property,
    //    AllowMultiple = true,
    //    Inherited = false)]
    //public class MyAttribute : Attribute
    //{ }

    //[MyAttribute]
    //public class MyClass
    //{
    //    [Conditional("DEBUG")]
    //    public static void Message(string msg)
    //    {
    //        WriteLine(msg);
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
    //        ReadKey();
    //    }
    //}

    //public class MyClass
    //{
    //    [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
    //    static void OldMethod()
    //    {
    //        WriteLine("It is the old method");
    //    }

    //    static void NewMethod()
    //    {
    //        WriteLine("It is the new method");
    //    }

    //    public static void Main()
    //    {
    //        OldMethod();
    //    }
    //}


    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Constructor|
        AttributeTargets.Field |
        AttributeTargets.Method |
        AttributeTargets.Property,
        AllowMultiple = true)]
    public class DebugInfo : Attribute
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

        public string LastReivew
        {
            get
            {
                return lastReview ;
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

    [DebugInfo(45, "Maxsu","12/8/2018", Message = "Return type mismatch")]
    [DebugInfo(49, "Sukyda","10/10/2018", Message = "Unused varialbe")]
    class Rectangle
    {
        protected double length;
        protected double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        [DebugInfo(55, "Maxsu", "19/10/2018", Message = "Return type mismatch")]
        public double GetArea()
        {
            return length * width;
        }

        [DebugInfo(565, "Maxsu", "12/8/2018")]
        public void Display()
        {
            WriteLine("Length: {0}", length);
            WriteLine("Width: {0}", width);
            WriteLine("Area: {0}", GetArea());
        }
    }

}
