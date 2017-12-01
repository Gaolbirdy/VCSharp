using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int: {0}", sizeof(int));

            object obj;
            obj = 100; // 这是装箱
            int val = 0;
            val = (int)obj; // 这是拆箱
            Console.WriteLine("obj: {0}", obj);
            Console.WriteLine(obj.GetType());
            Console.WriteLine(val.GetType());

            dynamic d = 20;
            Console.WriteLine(d.GetType());
            d = "";
            Console.WriteLine(d.GetType());

            string str1 = @"C:\Windows";
            string str2 = "C:\\Windows";
            string str3 = @"<script type=""text/javascript"">
                <!--
                -->
            </script>";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);

            //char* cptr;
            //int* iptr;

            Console.ReadKey();
        }
    }
}
