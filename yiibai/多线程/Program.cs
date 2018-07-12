using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace MultithreadingApplication
{
    //class MainThreadProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        Thread th = Thread.CurrentThread;
    //        th.Name = "MainThread";
    //        WriteLine("This is {0}", th.Name);
    //        ReadKey();
    //    }
    //}

    //class ThreadCreationProgram
    //{
    //    public static void CallToChildThread()
    //    {
    //        WriteLine("Child thread starts");

    //        int sleepfor = 5000;
    //        WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
    //        Thread.Sleep(sleepfor);
    //        WriteLine("Child Thread resumes");
    //    }

    //    static void Main(string[] args)
    //    {
    //        ThreadStart childref = new ThreadStart(CallToChildThread);
    //        WriteLine("In Main: Creating the Child Thread");
    //        Thread childThread = new Thread(childref);
    //        childThread.Start();
    //        ReadKey();
    //    }
    //}

    class ThreadCreationProgram
    {
        public static void CallToChildThread()
        {
            try
            {
                WriteLine("Child Thread starts");

                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    WriteLine(counter);
                }

                WriteLine("Child Thread Completed");
            }
            catch (ThreadAbortException e)
            {
                WriteLine("Thread Abort Exception");
                //throw e;
            }
            finally
            {
                WriteLine("Could't catch the Thread Exception");

                //for (int counter = 0; counter <= 10; counter++)
                //{
                //    Thread.Sleep(500);
                //    WriteLine(counter);
                //}
            }


            //{
            //    WriteLine("Child Thread starts");

            //    for (int counter = 0; counter <= 10; counter++)
            //    {
            //        Thread.Sleep(500);
            //        WriteLine(counter);
            //    }

            //    WriteLine("Child Thread Completed");
            //}
        }

        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);

            WriteLine("In Main: Creating the Child Thread");
            Thread childThread = new Thread(childref);

            childThread.Start();

            Thread.Sleep(2000);
            //Thread.Sleep(2003);
            WriteLine(childThread.IsAlive);

            WriteLine("In Main: Aborting the Child Thread");

            childThread.Abort();

            WriteLine(childThread.IsAlive);
            WriteLine("In Main: End");

            ReadKey();
        }
    }
}
