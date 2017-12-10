using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

//namespace 局部变量声明
//{
//    class Declarations
//    {
//        static void Main(string[] args)
//        {
//            int a;
//            int b = 2, c = 3;
//            a = 1;
//            Write(a + b + c);
//            ReadKey();
//        }
//    }
//}

//namespace 局部常量声明
//{
//    class ConstantDeclarations
//    {
//        static void Main()
//        {
//            const float pi = 3.1415927f;
//            const int r = 25;
//            WriteLine(pi * r * r);
//            ReadKey();
//        }
//    }
//}

//namespace 表达式语句
//{
//    class Expressions
//    {
//        static void Main()
//        {
//            int i;
//            i = 123;
//            WriteLine(i);   // Expression statement
//            i++;    // Expression statement
//            WriteLine(i);   // Expression statement
//            ReadKey();
//        }
//    }
//}

//namespace if语句
//{
//    class IfStatement
//    {
//        static void Main(string[] args)
//        {
//            if (args.Length == 0)
//            {
//                WriteLine("No arguments");
//            }
//            else
//            {
//                WriteLine("One or more arguments");
//            }
//            ReadKey();
//        }
//    }
//}

//namespace switch语句
//{
//    class SwitchStatement
//    {
//        static void Main(string[] args)
//        {
//            int n = args.Length;
//            switch (n)
//            {
//                case 0:
//                    WriteLine("No arguments");
//                    break;
//                case 1:
//                    WriteLine("One arguments");
//                    break;
//                default:
//                    WriteLine($"{n} arguments");
//                    break;
//            }
//            ReadKey();
//        }
//    }
//}

//namespace while语句
//{
//    class WhileStatement
//    {
//        static void Main(string[] args)
//        {
//            int i = 0;
//            while (i < args.Length)
//            {
//                WriteLine(args[i]);
//                i++;
//            }
//            ReadKey();
//        }
//    }
//}

//namespace do语句
//{
//    class DoStatement
//    {
//        static void Main()
//        {
//            string s;
//            do
//            {
//                s = ReadLine();
//                WriteLine(s);
//            } while (!string.IsNullOrEmpty(s));
//        }
//    }
//}

//namespace for语句
//{
//    class ForStatement
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 0; i < args.Length; i++)
//            {
//                WriteLine(args[i]);
//            }
//            ReadKey();
//        }
//    }
//}

//namespace foreach语句
//{
//    class ForEachStatement
//    {
//        static void Main(string[] args)
//        {
//            foreach (string s in args)
//            {
//                WriteLine(s);
//            }
//            ReadKey();
//        }
//    }
//}

//namespace break语句
//{
//    class BreakStatement
//    {
//        static void Main()
//        {
//            while (true)
//            {
//                string s = ReadLine();
//                if (string.IsNullOrEmpty(s))
//                    break;
//                WriteLine(s);
//            }
//        }
//    }
//}

//namespace continue语句
//{
//    class ContinueStatement
//    {
//        static void Main(string[] args)
//        {
//            string[] strs= { "AA", "/BB", "CC", "/DD" };
//            args = strs;
//            for (int i = 0; i < args.Length; i++)
//            {
//                if (args[i].StartsWith("/"))
//                    continue;
//                WriteLine(args[i]);
//            }
//            ReadKey();
//        }
//    }
//}

//namespace goto语句
//{
//    class GoToStatement
//    {
//        static void Main(string[] args)
//        {
//            args = new string[] { "A", "B", "C"};
//            int i = 0;
//            goto check;
//            //WriteLine("被跳过");
//            loop:
//            WriteLine(args[i++]);
//            check:
//            if (i < args.Length)
//                goto loop;
//            ReadKey();
//        }
//    }
//}

//namespace return语句
//{
//    class ReturnStatement
//    {
//        static int Add(int a, int b)
//        {
//            return a + b;
//        }

//        static void Main()
//        {
//            WriteLine(Add(1, 2));
//            return;
//        }
//    }
//}

//namespace yield语句
//{
//    class YieldStatement
//    {
//        static IEnumerable<int> Range(int from, int to)
//        {
//            for (int i = from; i < to; i++)
//            {
//                yield return 1;
//            }
//            yield break;
//        }

//        static void Main()
//        {
//            foreach (int i in Range(-10, 10))
//            {
//                WriteLine(i);
//            }
//            ReadKey();
//        }
//    }
//}

//namespace throw和try语句
//{
//    class TryCatch
//    {
//        static double Divide(double x, double y)
//        {
//            //try
//            //{
//            //    if (y == 0)
//            //        throw new DivideByZeroException();
//            //}
//            //catch(DivideByZeroException e)
//            //{
//            //    WriteLine(e.Message);
//            //}
//            if (y == 0)
//                throw new DivideByZeroException();
//            return x / y;
//        }

//        static void Main(string[] args)
//        {
//            args = new string[] { "2", "0" };
//            try
//            {
//                if (args.Length != 2)
//                {
//                    throw new InvalidOperationException("Two numbers required");
//                }
//                double x = double.Parse(args[0]);
//                double y = double.Parse(args[1]);
//                WriteLine(Divide(x, y));
//            }
//            catch (InvalidOperationException e)
//            {
//                WriteLine(e.Message);
//            }
//            finally
//            {
//                WriteLine("Good bye!");
//            }
//            ReadKey();
//        }
//    }
//}

//namespace checked和unchecked语句
//{
//    class CheckedUnchecked
//    {
//        static void Main()
//        {
//            int x = int.MaxValue;
//            unchecked
//            {
//                WriteLine(x + 1);   // Overflow
//            }
//            checked
//            {
//                WriteLine(x + 1);   // Exception
//            }
//            ReadKey();
//        }
//    }
//}

//namespace lock语句
//{
//    class Account
//    {
//        decimal balance;
//        private readonly object sync = new object();

//        public void WithDraw(decimal amount)
//        {
//            lock (sync)
//            {
//                if (amount > balance)
//                {
//                    throw new Exception("Insufficient funds");
//                }
//                balance -= amount;
//            }
//        }

//        static void Main()
//        {
//            Account ac = new Account
//            {
//                balance = 100
//            };
//            ac.WithDraw(56);
//            WriteLine(ac.balance);
//            ac.WithDraw(56);
//            ReadKey();
//        }
//    }
//}

namespace using语句
{
    class UsingStatement
    {
        static void Main()
        {
            using (TextWriter w = File.CreateText("text.txt"))
            {
                w.WriteLine("Line one");
                w.WriteLine("Line two");
                w.WriteLine("Line trree");
            }
        }
    }
}