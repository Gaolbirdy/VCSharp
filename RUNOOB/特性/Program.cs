#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using static System.Console;

namespace 特性
{
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Constructor |
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

        public string LastReview
        {
            get
            {
                return lastReview;
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

        [DebugInfo(55, "Zara Ali", "19/20/2012", Message = "Return type mismatch")]
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
            WriteLine();
        }
    }

    class ExcuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangele r = new Rectangele(4.5, 7.5);
            r.Display();
            Type type = typeof(Rectangele);
            //MemberInfo type = typeof(Rectangele);

            // 遍历 Rectangle 类的特性
            foreach (Object attributes in type.GetCustomAttributes(false))
            {
                DebugInfo dbi = (DebugInfo)attributes;
                if (null != dbi)
                {
                    WriteLine("Bug no: {0}", dbi.BugNo);
                    WriteLine("Developer: {0}", dbi.Developer);
                    WriteLine("Last Reviewed: {0}", dbi.LastReview);
                    WriteLine("Remarks: {0}", dbi.Message);
                    WriteLine();
                }
            }

            // 遍历方法特性
            foreach (MethodInfo m in type.GetMethods())
            {
                WriteLine(m);
                foreach (Attribute a in m.GetCustomAttributes(true))
                {
                    //DebugInfo dbi = (DebugInfo)a;
                    DebugInfo dbi = a as DebugInfo;
                    if (null != dbi)
                    {
                        WriteLine("Bug no: {0}, for Method: {1}", dbi.BugNo, m.Name);
                        WriteLine("Developer: {0}", dbi.Developer);
                        WriteLine("Last Reviewed: {0}", dbi.LastReview);
                        WriteLine("Remarks: {0}", dbi.Message);
                        WriteLine();
                    }
                    else
                    {
                        WriteLine(a);
                        WriteLine("null");
                    }
                }
            }
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
