using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace 线程实例_Abort__方法
{
    public class MyThread
    {
        public void Thread1()
        {
            //try
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        WriteLine(i);
            //        Thread.Sleep(200);
            //    }
            //}
            //catch (ThreadAbortException e)
            //{
            //    WriteLine(e.ToString());
            //}

            for (int i = 0; i < 10; i++)
            {
                WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }

    public class ThreadExample
    {
        public static void Main()
        {
            WriteLine("Start of Main");
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));

            t1.Start();
            t2.Start();

            try
            {
                t1.Abort();
                t2.Abort();
            }
            catch (ThreadAbortException tae)
            {
                WriteLine(tae.ToString());
            }

            WriteLine("End of Main");
        }
    }
}
