using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace 方法
//{
//    class NumberManipulator
//    {
//        public int FindMax(int num1, int num2)
//        {
//            int result;
//            if (num1 > num2)
//                result = num1;
//            else
//                result = num2;

//            return result;
//        }

//        //static void Main()
//        //{
//        //    int a = 100;
//        //    int b = 200;
//        //    int ret;
//        //    NumberManipulator n = new NumberManipulator();

//        //    ret = n.FindMax(a, b);
//        //    Console.WriteLine("最大值是：{0}", ret);
//        //    Console.ReadLine();
//        //}
//    }

//    class Test
//    {
//        static void Main()
//        {
//            int a = 100;
//            int b = 200;
//            int ret;
//            NumberManipulator n = new NumberManipulator();

//            ret = n.FindMax(a, b);
//            Console.WriteLine("最大值是：{0}", ret);
//            Console.ReadLine();
//        }
//    }
//}

//namespace CalculatorApplication
//{
//    class NumberManipulator
//    {
//        public int factorial(int num)
//        {
//            int result;

//            if (num == 1)
//            {
//                return 1;
//            }
//            else
//            {
//                result = factorial(num - 1) * num;
//                return result;
//            }
//        }

//        static void Main()
//        {
//            NumberManipulator n = new NumberManipulator();
//            Console.WriteLine("6 的阶乘是：{0}", n.factorial(6));
//            Console.WriteLine("7 的阶乘是：{0}", n.factorial(7));
//            Console.WriteLine("8 的阶乘是：{0}", n.factorial(8));
//            Console.ReadKey();
//        }
//    }
//}

//namespace CalculatorApplication
//{
//    class NumberManipulator
//    {
//        public void Swap(int x, int y)
//        {
//            int temp;

//            temp = x;
//            x = y;
//            y = temp;
//        }

//        static void Main()
//        {
//            NumberManipulator n = new NumberManipulator();
//            int a = 100;
//            int b = 200;

//            Console.WriteLine("在交换之前，a 的值： {0}", a);
//            Console.WriteLine("在交换之前，b 的值： {0}", b);

//            n.Swap(a, b);

//            Console.WriteLine("在交换之后，a 的值： {0}", a);
//            Console.WriteLine("在交换之后，b 的值： {0}", b);

//            Console.ReadLine();
//        }
//    }
//}

//namespace CalculatorApplication
//{
//    class NumberManipulator
//    {
//        public void Swap(ref int x, ref int y)
//        {
//            int temp;

//            temp = x;
//            x = y;
//            y = temp;
//        }

//        static void Main()
//        {
//            NumberManipulator n = new NumberManipulator();
//            int a = 100;
//            int b = 200;

//            Console.WriteLine("在交换之前，a 的值： {0}", a);
//            Console.WriteLine("在交换之前，b 的值： {0}", b);

//            n.Swap(ref a, ref b);

//            Console.WriteLine("在交换之后，a 的值： {0}", a);
//            Console.WriteLine("在交换之后，b 的值： {0}", b);

//            Console.ReadLine();
//        }
//    }
//}

//namespace CalculatorApplication
//{
//    class NumberManipulator
//    {
//        public void GetValue(out int x)
//        {
//            int temp = 5;
//            x = temp;
//        }

//        static void Main()
//        {
//            NumberManipulator n = new NumberManipulator();
//            int a = 100;

//            Console.WriteLine("在方法调用之前，a 的值： {0}", a);

//            n.GetValue(out a);

//            Console.WriteLine("在方法调用之后，a 的值： {0}", a);
//            Console.ReadLine();
//        }
//    }
//}

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void GetValues(out int x, out int y)
        {
            Console.WriteLine("输入第一个值： ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第二个值： ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        static void Main()
        {
            NumberManipulator n = new NumberManipulator();
            int a, b;

            n.GetValues(out a, out b);

            Console.WriteLine("在方法调用之后，a 的值： {0}", a);
            Console.WriteLine("在方法调用之后，b 的值： {0}", b);
            Console.ReadLine();
        }
    }
}