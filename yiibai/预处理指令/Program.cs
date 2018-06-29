#define PI
#define DEBUG
#define VC_V10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



namespace PreprocessorDAppl
{
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //#if (PI)
    //            WriteLine("PI is defined");
    //#else
    //            WriteLine("PI is not defined");
    //#endif
    //            ReadKey();
    //        }
    //    }

    public class TestClass
    {
        public static void Main()
        {
#if (DEBUG && !VC_V10)
            WriteLine("DEBUG is defined");
#elif (!DEBUG && VC_V10)
            WriteLine("VC_V10 is defined");
#elif (DEBUG && VC_V10)
            WriteLine("DEBUG and VC_V10 are defined");
#else
            WriteLine("DEBUG and VC_V10 are not defined");
#endif
        }
    }
}
