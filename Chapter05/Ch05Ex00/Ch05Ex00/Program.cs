using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Ex00
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort destinationVar;
            char sourceVar = 'a';
            destinationVar = sourceVar;
            WriteLine($"sourceVar val: {sourceVar} type: {sourceVar.GetType()}");
            WriteLine($"destinationVar val: {destinationVar} type: {destinationVar.GetType()}");
            WriteLine();

            sourceVar = (char)destinationVar;
            //sourceVar = ToChar(destinationVar);
            WriteLine($"sourceVar val: {sourceVar} type: {sourceVar.GetType()}");
            WriteLine($"destinationVar val: {destinationVar} type: {destinationVar.GetType()}");
            WriteLine();

            byte destinationVar2;
            short sourceVar2 = 281;
            destinationVar2 = unchecked((byte)sourceVar2);
            WriteLine($"sourceVar val: {sourceVar2} type: {sourceVar2.GetType()}");
            WriteLine($"destinationVar val: {destinationVar2} type: {destinationVar2.GetType()}");
            WriteLine();

            int myInt1 = 2147483647, myInt2 = 2;
            short myShort1 = 1, myShort2 = 2;
            float myFloat1 = 2.0f;
            long myLong1 = 2;
            WriteLine((myInt1 * myInt2).GetType());
            WriteLine((myShort1 * myShort2).GetType());
            WriteLine((myInt1 * myShort1).GetType());
            WriteLine((myInt1 * myFloat1).GetType());
            WriteLine((myInt1 * myLong1).GetType());
            ReadKey();
        }
    }
}
