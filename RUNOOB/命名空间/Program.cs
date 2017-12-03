using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//using SomeNameSpace;
using SomeNameSpace.Nested;
//using first_space;
//using second_space;


//namespace first_space
//{
//    class Namespace_c1
//    {
//        public void Func()
//        {
//            WriteLine("Inside first_space");
//        }
//    }
//}

//namespace second_space
//{
//    class Namespace_c1
//    {
//        public void Func()
//        {
//            WriteLine("Inside second_space");
//        }
//    }
//}

//class TestClass
//{
//    static void Main()
//    {
//        first_space.Namespace_c1 fc = new first_space.Namespace_c1();
//        second_space.Namespace_c1 sc = new second_space.Namespace_c1();
//        fc.Func();
//        sc.Func();
//        ReadKey();
//    }
//}

//namespace first_space
//{
//    class Abc
//    {
//        public void Func()
//        {
//            WriteLine("Inside first_space");
//        }
//    }
//}

//namespace second_space
//{
//    class Efg
//    {
//        public void Func()
//        {
//            WriteLine("Inside second_space");
//        }
//    }
//}

//class TestClass
//{
//    static void Main()
//    {
//        Abc fc = new Abc();
//        Efg sc = new Efg();
//        fc.Func();
//        sc.Func();
//        ReadKey();
//    }
//}

namespace SomeNameSpace
{
    public class MyClass
    {
        static void Main()
        {
            WriteLine("In SomeNameSpace");
            NestedNameSpaceClass.SayHello();
            ReadKey();
        }
    }

    namespace Nested
    {
        public class NestedNameSpaceClass
        {
            public static void SayHello()
            {
                WriteLine("In Nested");
            }
        }
    }
}

//class Tester
//{
//    static void Main()
//    {
//        NestedNameSpaceClass.SayHello();
//        ReadKey();
//    }
//}
