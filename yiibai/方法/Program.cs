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

    class NumberManipulator
    {
        public int Factorial(int num)
        {
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = Factorial(num - 1) * num;
                return result;
            }
        }

        static void Main(string[] args)
        {


            ReadLine();
        }
    }
}
