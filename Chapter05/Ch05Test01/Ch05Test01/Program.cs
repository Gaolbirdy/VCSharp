using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;

namespace Ch05Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            short s = (short)i;
            short s2 = ToInt16(i);
            int i2 = s;

            bool bol = true;
            //string str = b;
            //string str = (string)b;
            string str = bol.ToString();
            string str2 = Convert.ToString(bol);
            WriteLine(str2);

            byte b = 0;
            float f = b;
            byte b2 = (byte)f;
            byte b3 = ToByte(f);
            f = ToSingle(b3);
            ReadKey();
        }
    }
}
