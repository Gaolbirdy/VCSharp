using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 19;

            //WriteLine("Start while loop");
            //while (a < 29)
            //{
            //    WriteLine("value of a: {0}", a);
            //    a++;
            //}

            //for (int a = 1; a < 10; a = a + 1)
            //{
            //    WriteLine("value of a: {0}", a);
            //}

            //int a = 10;
            //do
            //{
            //    WriteLine("value of a: {0}", a);
            //    a = a + 1;
            //} while (a < 20);


            int i, j;
            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break;

                if (j > (i / j))
                    WriteLine("{0} is prime", i);
            }

            ReadLine();
        }
    }
}
