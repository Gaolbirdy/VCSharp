using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ch07Ex00
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("WriteLine()", "Debug");
            Trace.WriteLine("WriteLine()", "Trace");
            int[] array = { 1, 2, 3, 4 };
            int myElem = array[4];
        }
    }
}
