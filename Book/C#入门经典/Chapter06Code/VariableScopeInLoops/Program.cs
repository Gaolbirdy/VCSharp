using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using static System.Convert;

namespace VariableScopeInLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string text = "";
            for (i = 0; i < 10; i++)
            {
                text = "Line " + Convert.ToString(i);
                WriteLine("{0}", text);
            }
            WriteLine("Last text output in loop: {0}", text);
            ReadKey();
        }
    }
}
