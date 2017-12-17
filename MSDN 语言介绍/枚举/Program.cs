using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 枚举
{
    enum Color
    {
        Red,
        Green,
        Blue
    }

    enum Alignment: sbyte
    {
        Left = -1,
        Center = 0,
        Right = 1
    }

    class EnumExample
    {
        static void PrintColor(Color color)
        {
            switch (color)
            {
                case Color.Red:
                    WriteLine("Red");
                    break;
                case Color.Green:
                    WriteLine("Green");
                    break;
                case Color.Blue:
                    WriteLine("Blue");
                    break;
                default:
                    WriteLine("Unknown color");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Color c = Color.Red;
            PrintColor(c);
            PrintColor(Color.Blue);

            int i = (int)Color.Blue;
            WriteLine(i);
            Color color = (Color)2;
            WriteLine(color);

            Color cc = 0;

            ReadKey();
        }
    }
}
