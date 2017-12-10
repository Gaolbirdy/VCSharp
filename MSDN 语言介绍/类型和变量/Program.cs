using System;
using static System.Console;

class BoxingExample
{
    static void Main()
    {
        int i = 123;
        WriteLine(i + " " + i.GetType());

        object o = i;   // Boxing
        WriteLine(i + " " + i.GetType());
        WriteLine(o + " " + o.GetType());

        int j = (int)o;
        WriteLine(o + " " + o.GetType());
        WriteLine(j + " " + j.GetType());
        ReadKey();
    }
}