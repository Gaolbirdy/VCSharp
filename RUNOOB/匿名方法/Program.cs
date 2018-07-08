using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

delegate void NumberChanger(int n);
namespace DelegateAppl
{
    class TestDelegate
    {
        static int num = 10;

        public static void AddNum(int p)
        {
            num += p;
            WriteLine("Named Method: {0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            WriteLine("Named Method: {0}", num);
        }

        static void Main(string[] args)
        {
            NumberChanger nc = delegate (int x)
            {
                WriteLine("Anonymous Method: {0}", x);
            };

            nc(10);


            nc = new NumberChanger(AddNum);
            nc(5);

            nc = new NumberChanger(MultNum);
            nc(2);
            ReadKey();
        }
    }
}
