using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;

namespace Ch06Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 3)
            {
                WriteLine("必须两个元素");
                ReadKey();
                return;
            }
            int myInt = ToInt32(args[0]);
            string str = args[1];
            WriteLine(myInt);
            WriteLine(str);
            ReadKey();
        }
    }
}
