using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TypeConversionApplication
{
    //class ExplicitConversion
    //{
    //    static void Main(string[] args)
    //    {
    //        double d = 9999.98;
    //        int i;

    //        i = (int)d;
    //        WriteLine(i);
    //        ReadKey();
    //    }
    //}

    class StringConversion
    {
        static void Main(string[] args)
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            WriteLine(i.ToString());
            WriteLine(f.ToString());
            WriteLine(d.ToString());
            WriteLine(b.ToString());
            ReadKey();
        }
    }
}
