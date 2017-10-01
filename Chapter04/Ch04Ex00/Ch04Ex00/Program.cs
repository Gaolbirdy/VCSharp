using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch04Ex00
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            5的二进制是
            0000 0101
            30的二进制是
            0001 1110
            
            异或的结果 0001 1011
            */
            WriteLine(5 ^ 30);
            WriteLine(ToUInt32(true ^ false));
            WriteLine(false ^ false);
            WriteLine(1 ^ 1);
            WriteLine();

            /*
            5的二进制是
            0000 0101
            30的二进制是
            0001 1110
            
            与的结果 0000 0100
            */
            WriteLine(5 & 30);
            WriteLine(ToUInt32(true & false));
            WriteLine(false & false);
            WriteLine(1 & 0);
            WriteLine();

            /*
            5的二进制是
            0000 0101
            30的二进制是
            0001 1110
            
            或的结果 0001 1111
            */
            WriteLine(5 | 30);
            WriteLine(ToUInt32(true | false));
            WriteLine(true | false);
            WriteLine(1 | 0);
            WriteLine();

            int myInteger = 10;
            string resultString = (myInteger < 10) ? "Less than 10" : "Greater than or equal to 10";
            WriteLine(resultString);
            ReadKey();
        }
    }
}
