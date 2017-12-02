using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int a = 10;

        //    while (a < 20)
        //    {
        //        Console.WriteLine("a 的值：{0}", a);
        //        a++;
        //    }
        //    Console.ReadLine();
        //}

        //static void Main()
        //{
        //    for (int a = 10; a < 20; a++)
        //    {
        //        Console.WriteLine("a 的值： {0}", a);
        //    }
        //    Console.ReadLine();
        //}

        //static void Main()
        //{
        //    int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
        //    foreach (int element in fibarray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.ReadLine();

        //    for (int i = 0; i < fibarray.Length; i++)
        //    {
        //        Console.WriteLine(fibarray[i]);
        //    }
        //    Console.ReadLine();

        //    int count = 0;
        //    foreach (int element in fibarray)
        //    {
        //        count += 1;
        //        Console.WriteLine("Element #{0}: {1}", count, element);
        //    }
        //    Console.WriteLine("Number of elements in the array: {0}", count);
        //    Console.ReadLine();
        //}

        //static void Main()
        //{
        //    int a = 10;

        //    do
        //    {
        //        Console.WriteLine("a 的值：{0}", a);
        //        a = a + 1;
        //    } while (a < 20);

        //    Console.ReadLine();
        //}

        //static void Main()
        //{
        //    int i, j;

        //    for (i = 2;  i < 100; i++)
        //    {
        //        for (j = 2; j <= (i / j); j++)
        //        {
        //            Console.WriteLine("数字 {0}，j: {1}, (i / j): {2}", i, j, (i / j));
        //            if ((i % j) == 0)
        //                break;
        //        }
        //        if(j > (i / j))
        //            Console.WriteLine("{0} 是质数，j: {1}, (i / j): {2}", i, j, (i / j));
        //    }

        //    Console.ReadLine();
        //}

        //static void Main()
        //{
        //    for (; ; )
        //    {
        //        Console.WriteLine("Hey! I am Trapped");
        //    }
        //}

        //static void Main()
        //{
        //    int a = 10;

        //    while (a < 20)
        //    {
        //        Console.WriteLine("a 的值： {0}", a);
        //        a++;
        //        if (a > 15)
        //        {
        //            break;
        //        }
        //    }
        //    Console.ReadLine();
        //}

        static void Main()
        {
            int a = 10;

            do
            {
                if (a == 15)
                {
                    a = a + 1;
                    continue;
                }
                Console.WriteLine("a 的值：{0}", a);
                a++;
            } while (a < 20);

            Console.ReadLine();
        }
    }
}
