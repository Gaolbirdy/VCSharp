using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random r = new Random();;
            //while (true)
            //{
            //    Console.Write(r.Next(1000) + " ");
            //}

            Rand();
        }

        static void Rand()
        {
            Random gen = new Random();
            Console.Write(gen.Next(1000) + " ");
            Rand();
        }
    }
}
