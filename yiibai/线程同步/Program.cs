using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace 线程同步
{
    class Printer
    {
        public void PrintTable()
        {
            lock (this)
            {
                for (int i = 0; i <= 5; i++)
                {
                    Thread t = Thread.CurrentThread;
                    Thread.Sleep(200);
                    WriteLine(t.Name + " " + i);
                }
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Printer p = new Printer();
            Thread t1 = new Thread(new ThreadStart(p.PrintTable));
            Thread t2 = new Thread(new ThreadStart(p.PrintTable));
            t1.Name = "Thread 1 : ";
            t2.Name = "Thread 2 : ";

            t2.Start();
            t1.Start();
        }
    }
}
