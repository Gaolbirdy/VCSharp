using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch11Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Primes primesFrom2to1000 = new Primes(2, 100000000);
            //primesFrom2to1000.GetEnumerator();
            foreach (long i in primesFrom2to1000)
            {
               Write($"{i} ");
            }
            ReadKey();
        }
    }
}
