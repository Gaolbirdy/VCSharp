using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

//namespace 线程实例
//{
//    public class MyThread
//    {
//        public static void Thread1()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                WriteLine("Thread1: " + i);
//            }
//        }
//    }

//    public class ThreadExample
//    {
//        public static void Main()
//        {
//            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
//            Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));
//            t1.Start();
//            t2.Start();
//        }
//    }
//}

//namespace 线程实例
//{
//    public class MyThread
//    {
//        private string name;

//        public MyThread(string name)
//        {
//            this.name = name;
//        }

//        public void Thread1()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                WriteLine(this.name + ": " + i);
//            }
//        }
//    }

//    public class ThreadExample
//    {
//        public static void Main()
//        {
//            MyThread mt = new MyThread("Thread1");
//            MyThread mt2 = new MyThread("Thread2");

//            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
//            Thread t2 = new Thread(new ThreadStart(mt2.Thread1));
//            t1.Start();
//            t2.Start();
//        }
//    }
//}

namespace 线程实例
{
    public class MyThread
    {
        public static void Method1()
        {
            for (int i = 0; i < 5; i++)
            {
                WriteLine("This is method1: " + i);
            }
        }

        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                WriteLine("This is method2: " + i);
            }
        }
    }

    public class ThreadExample
    {
        public static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(MyThread.Method1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Method2));
            t1.Start();
            t2.Start();
        }
    }
}
