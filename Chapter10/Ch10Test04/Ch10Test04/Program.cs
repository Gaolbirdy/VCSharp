using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch10Test04
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCopyableClass oldClass = new MyCopyableClass();
            MyCopyableClass newClass1 = oldClass.GetCopy();
            WriteLine(newClass1);
            oldClass.Name = "CopyClass";
            MyCopyableClass newClass2 = oldClass.GetCopy();
            oldClass.Name = "OldClass";
            WriteLine(newClass2.Name);
            WriteLine(oldClass == newClass2);

            ReadKey();
        }
    }
}
