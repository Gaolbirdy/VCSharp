using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UnsafeCodeApplication
{
    //class Program
    //{
    //    unsafe static void Main(string[] args)
    //    {
    //        int* ip;
    //        double* dp;
    //        float* fp;
    //        char* ch;
    //    }
    //}

    class Program
    {
        //static unsafe void Main(string[] args)
        //{
        //    int var = 20;
        //    int* p = &var;

        //    WriteLine("Data is: {0}", var);
        //    WriteLine("Address is: {0}", (int)p);
        //    ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    unsafe
        //    {
        //        int var = 20;
        //        int* p = &var;

        //        WriteLine("Data is: {0}", var);
        //        WriteLine("Data is: {0}", p->ToString());
        //        WriteLine("Address is: {0}", (int)p);
        //    }
        //    ReadKey();
        //}

        //    class TestPointer
        //    {
        //        public unsafe void Swap(int* p, int* q)
        //        {
        //            int temp = *p;
        //            *p = *q;
        //            *q = temp;
        //        }

        //        public unsafe static void Main()
        //        {
        //            TestPointer p = new TestPointer();
        //            int var1 = 10;
        //            int var2 = 20;
        //            int* x = &var1;
        //            int* y = &var2;

        //            WriteLine("Before Swap: var1: {0}, var2: {1}", var1, var2);
        //            p.Swap(x, y);

        //            WriteLine("After Swap: var1: {0}, var2: {1}", var1, var2);
        //            ReadKey();
        //        }
        //    }
        //}

    }

    class TestPointer
    {
        public unsafe static void Main()
        {
            int[] list = { 10, 100, 200 };
            fixed (int* ptr = list)

                for (int i = 0; i < 3; i++)
                {
                    WriteLine("Address of list[{0}] = {1}", i, (int)(ptr + i));
                    WriteLine("Value of list[{0}] = {1}", i, *(ptr + i));
                    WriteLine("Value of list[{0}] = {1}", i, list[i]);
                    WriteLine();
                }
            ReadKey();
        }
    }
}
