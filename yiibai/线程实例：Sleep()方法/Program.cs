using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace 线程实例_Sleep__方法
{
    public class MyThread
    {
        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                string curTime = DateTime.Now.ToString();
                WriteLine("Thread1 at " + curTime + " => " + i);
                Thread.Sleep(500);
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
            t1.Start();
            t2.Start();
        }
    }
}
