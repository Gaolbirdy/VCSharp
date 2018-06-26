using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CalculatorApplication
{
    //class NumberManipulator
    //{
    //    public int FindMax(int num1, int num2)
    //    {
    //        int result;

    //        if (num1 > num2)
    //            result = num1;
    //        else
    //            result = num2;
    //        return result;
    //    }

    //    //static void Main(string[] args)
    //    //{
    //    //    int a = 101;
    //    //    int b = 199;
    //    //    int ret;
    //    //    NumberManipulator n = new NumberManipulator();

    //    //    ret = n.FindMax(a, b);
    //    //    WriteLine("Max value is : {0}", ret);
    //    //    ReadLine();
    //    //}
    //}

    //class Test
    //{
    //    static void Main(string[] args)
    //    {
    //        int a = 101;
    //        int b = 199;
    //        int ret;
    //        NumberManipulator n = new NumberManipulator();

    //        ret = n.FindMax(a, b);
    //        WriteLine("Max value is : {0}", ret);
    //        ReadLine();
    //    }
    //}

    //class NumberManipulator
    //{
    //    public int Factorial(int num)
    //    {
    //        int result;
    //        if (num == 1)
    //        {
    //            return 1;
    //        }
    //        else
    //        {
    //            result = Factorial(num - 1) * num;
    //            return result;
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        NumberManipulator n = new NumberManipulator();

    //        WriteLine("Factorial of 6 is: {0}", n.Factorial(6));
    //        WriteLine("Factorial of 7 is: {0}", n.Factorial(7));
    //        WriteLine("Factorial of 8 is: {0}", n.Factorial(8));

    //        ReadLine();
    //    }
    //}

    //class NumberManipulator
    //{
    //    public void Swap(int x, int y)
    //    {
    //        int temp;

    //        temp = x;
    //        x = y;
    //        y = temp;
    //    }

    //    static void Main(string[] args)
    //    {
    //        NumberManipulator n = new NumberManipulator();
    //        int a = 100;
    //        int b = 200;

    //        WriteLine("Before swap, value of a: {0}", a);
    //        WriteLine("Before swap, value of b: {0}", b);

    //        n.Swap(a, b);
    //        WriteLine("After swap, value of a: {0}", a);
    //        WriteLine("After swap, value of b: {0}", b);

    //        ReadLine();
    //    }
    //}

    //class NumberManipulator
    //{
    //    public void Swap(ref int x, ref int y)
    //    {
    //        int temp;

    //        temp = x;
    //        x = y;
    //        y = temp;
    //    }

    //    static void Main(string[] args)
    //    {
    //        NumberManipulator n = new NumberManipulator();
    //        int a = 100;
    //        int b = 200;

    //        WriteLine("Before swap, value of a: {0}", a);
    //        WriteLine("Before swap, value of b: {0}", b);

    //        n.Swap(ref a, ref b);
    //        WriteLine("After swap, value of a: {0}", a);
    //        WriteLine("After swap, value of b: {0}", b);

    //        ReadLine();
    //    }
    //}

    class NumberManipulator
    {
        public void GetValue(out int x)
        {
            int temp = 5;
            x = temp;
        }

        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 100;

            WriteLine("Before method call, value of a : {0}", a);
            n.GetValue(out a);

            WriteLine("After method call, value of a : {0}", a);
            ReadLine();
        }
    }
}
