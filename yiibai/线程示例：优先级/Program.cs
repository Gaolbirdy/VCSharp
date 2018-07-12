using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace 线程示例_优先级
{
    public class MyThread
    {
        public void Thread1()
        {
            for (int i = 0; i < 3; i++)
            {
                Thread t = Thread.CurrentThread;
                WriteLine(t.Name + " is runing");
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
            t1.Name = "Highest-Thread";
            t2.Name = "Mormal-Thread";
            t3.Name = "Lowest-Thread";
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
            t3.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
