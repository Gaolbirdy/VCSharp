using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch07Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            for (int i = 1; i < 10000; i++)
            {
                WriteLine(i);
                if (i == 5000)
                {
                    Write(myArray[6]);
                }
            }
        }
    }
}
