using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//using first_space;
//using second_space;
using first_space;
using first_space.second_space;

//namespace first_space
//{
//    class namespace_c1
//    {
//        public void Func()
//        {
//            WriteLine("Inside first_space");
//        }
//    }
//}

//namespace second_space
//{
//    class namespace_c1
//    {
//        public void Func()
//        {
//            WriteLine("Inside second_space");
//        }
//    }
//}

//public class TestClass
//{
//    public static void Main(string[] args)
//    {
//        first_space.namespace_c1 fc = new first_space.namespace_c1();
//        second_space.namespace_c1 sc = new second_space.namespace_c1();
//        fc.Func();
//        sc.Func();
//    }
//}

//namespace first_space
//{
//    class abc
//    {
//        public void Func()
//        {
//            WriteLine("Inside first_space");
//        }
//    }
//}

//namespace second_space
//{
//    class efg
//    {
//        public void Func()
//        {
//            WriteLine("Inside second_space");
//        }
//    }
//}

//class TestClass
//{
//    static void Main(string[] args)
//    {
//        abc fc = new abc();
//        efg sc = new efg();
//        fc.Func();
//        sc.Func();
//    }
//}


namespace first_space
{
    class abc
    {
        public void Func()
        {
            WriteLine("Inside first_space");
        }
    }

    namespace second_space
    {
        class efg
        {
            public void Func()
            {
                WriteLine("Inside second_space");
            }
        }
    }
}

class TestClass
{
    static void Main(string[] args)
    {
        abc fc = new abc();
        efg sc = new efg();
        fc.Func();
        sc.Func();
    }
}