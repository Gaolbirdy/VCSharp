using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch04Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i < 10; i++)
            {
                if ((i % 2) == 0)
                    continue;
                    //break;
                    //return;
                    //goto Label;
                WriteLine(i);
            }
            ReadKey();
        }
    }
}
