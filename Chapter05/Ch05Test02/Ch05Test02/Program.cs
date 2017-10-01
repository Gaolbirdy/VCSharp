using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Test02
{
    enum Color : short
    {
        Red = 1,
        Orange,
        Yellow = 2,
        Green,
        Indigo,
        Blue,
        Purple,
        Black,
        Write = 9,
        What = Red
    }

    class Program
    {
        static void Main(string[] args)
        {
            Color c;
            c = (Color)6;
            Color c2 = Color.Orange;
            WriteLine((short)Color.Yellow);
            WriteLine((Color)7);
            WriteLine((byte)c);
            WriteLine(c2);

            string str = Color.Black.ToString();
            str = Convert.ToString((Color)9);
            c2 = (Color)Enum.Parse(typeof(Color), "Green");
            Color c3 =(Color) Enum.Parse(typeof(Color), "2");
            WriteLine("c3 " + c3);
            WriteLine(str);
            WriteLine(c2);
            WriteLine((byte)Color.Black);
            WriteLine((Color)1);

            Color cA = Color.Orange;
            Color cB = Color.Yellow;
            WriteLine(cB);
            WriteLine((int)Color.What);
            WriteLine(cA == cB);
            ReadKey();
        }
    }
}
