using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//namespace ErrorHandlingApplication
//{
//    class DivNumbers
//    {
//        int result;

//        DivNumbers()
//        {
//            result = 0;
//        }

//        public void Division(int num1, int num2)
//        {
//            try
//            {
//                result = num1 / num2;
//            }
//            catch (DivideByZeroException e)
//            {
//                WriteLine("Exception caught: {0}", e);
//            }
//            finally
//            {
//                WriteLine("Result: {0}", result);
//            }
//        }

//        static void Main(string[] args)
//        {
//            DivNumbers d = new DivNumbers();
//            d.Division(25, 0);
//        }
//    }
//}


namespace UserDefinedException
{
    class TestTemperature
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.ShowTemp();
            }
            catch (TempIsZeroException e)
            {
                WriteLine("TempIsZeroException: {0}", e.Message);
                throw e;
            }
            ReadKey();
        }
    }
}

public class Temperature
{
    int temperature = 0;

    public void ShowTemp()
    {
        if (temperature == 0)
        {
            throw (new TempIsZeroException("Zero Temperature found"));
        }
        else
        {
            WriteLine("Temperature: {0}", temperature);
        }
    }
}

public class TempIsZeroException : Exception
{
    public TempIsZeroException(string message) : base(message)
    {

    }
}