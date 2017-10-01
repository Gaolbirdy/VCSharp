using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Ch10Test01;

namespace Ch10Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClasss x = new MyDerivedClasss();
            x.ContainedString = "Hello";
            WriteLine(x.GetString());
            //MyClass y = new MyClass();
            //WriteLine(y.myString);    
            ReadKey();
        }
    }
}
