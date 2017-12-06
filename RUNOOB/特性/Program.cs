#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//namespace 特性
//{
//    [AttributeUsage(AttributeTargets.Class |
//        AttributeTargets.Constructor |
//        AttributeTargets.Field |
//        AttributeTargets.Method |
//        AttributeTargets.Property,
//        AllowMultiple = true)]
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}

public class MyClass
{
    [Conditional("DEBUG")]
    public static void Message(string msg)
    {
        Console.WriteLine(msg);
    }
}
