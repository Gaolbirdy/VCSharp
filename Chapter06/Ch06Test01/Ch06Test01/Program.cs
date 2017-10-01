using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool myRef = false;
            string myOut;
            MyFunction(out myOut, ref myRef, 1, 2, 3, 4,2,3,4);
            Console.WriteLine(myRef);
            Console.WriteLine(myOut);
            Console.ReadKey();
        }

        static bool Write()
        {
            return true;
        }

        static void MyFunction(out string s, ref bool bol, params int[] nums)
        {
            foreach (var v in nums)
            {
                Console.Write(v + " ");
            }
            bol = true;
            s = "new";
        }
    }
}
