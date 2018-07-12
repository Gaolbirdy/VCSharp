using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace 线程命名实例
{
    public class MyThread
    {
        public void Thread1()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t = Thread.CurrentThread;
                WriteLine(t.Name + " is running at: " + i);
            }
        }
    }

    public class ThreadExample
    {
        public static void Main()
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Name = "Thread1";
            t2.Name = "Thread2";
            t3.Name = "Thread3";
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
