using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking

{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int a = 10;

        //    if (a < 20)
        //    {
        //        Console.WriteLine("a 小于 20");
        //    }
        //    Console.WriteLine("a 的值是 {0}", a);
        //    Console.ReadKey();
        //}

        //static void Main()
        //{
        //    int a = 100;

        //    if (a < 20)
        //    {
        //        Console.WriteLine("a 小于 20");
        //    }
        //    else
        //    {
        //        Console.WriteLine("a 大于 20");
        //    }
        //    Console.WriteLine("a 的值是 {0}", a);
        //    Console.ReadLine();
        //}

        //static void Main()
        //{
        //    int a = 100;

        //    if (a == 10)
        //    {
        //        Console.WriteLine("a 的值是 10");
        //    }
        //    else if (a == 20)
        //    {
        //        Console.WriteLine("a 的值是 20");
        //    }
        //    else if (a == 30)
        //    {
        //        Console.WriteLine("a 的值是 30");
        //    }
        //    else
        //    {
        //        Console.WriteLine("没有匹配的值");
        //    }
        //    Console.WriteLine("a 的准确值是 {0}", a);
        //    Console.ReadKey();
        //}

        //static void Main()
        //{
        //    int a = 100;
        //    int b = 200;

        //    if (a == 100)
        //    {
        //        if (b == 200)
        //        {
        //            Console.WriteLine("a 的值是 100, 且 b 的值是 200");
        //        }
        //    }
        //    Console.WriteLine("a 的准确值是 {0}", a);
        //    Console.WriteLine("b 的准确值是 {0}", b);
        //    Console.ReadLine();
        //}

        //static void Main()
        //{
        //    char grade = 'B';

        //    switch (grade)
        //    {
        //        case 'A':
        //            Console.WriteLine("很棒！");
        //            break;
        //        case 'B':
        //        case 'C':
        //            Console.WriteLine("做得好");
        //            break;
        //        case 'D':
        //            Console.WriteLine("您通过了");
        //            break;
        //        case 'F':
        //            Console.WriteLine("最好再试一下");
        //            break;
        //        default:
        //            Console.WriteLine("无效的成绩");
        //            break;
        //    }
        //    Console.WriteLine("您的成绩是 {0}", grade);
        //    Console.ReadLine();
        //}

        static void Main()
        {
            int a = 100;
            int b = 200;

            switch (a)
            {
                case 100:
                    Console.WriteLine("这是外部 switch 的一部分");
                    switch (a)
                    {
                        case 100:
                            Console.WriteLine("这是内部 switch 的一部分");
                            break;
                    }
                    break;
            }
            Console.WriteLine("a 的准确值是 {0}", a);
            Console.WriteLine("b 的准确值是 {0}", b);
            Console.ReadLine();
        }
    }
}
