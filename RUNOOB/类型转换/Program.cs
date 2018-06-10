using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;

namespace TypeConversionApplication
{
    //class ExplicitConversion
    //{
    //    static void Main(string[] args)
    //    {
    //        double d = 5673.74;
    //        int i;

    //        // 强制转换double为int
    //        i = (int)d;
    //        Console.WriteLine(i);
    //        Console.ReadKey();
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

            Console.WriteLine(i.ToString());
            Console.WriteLine(i.GetType());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(b.GetType());
            Console.ReadKey();
        }
    }
}
