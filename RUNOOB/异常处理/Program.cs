using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
//                Console.WriteLine("Exception caught: {0}", e);
//            }
//            finally
//            {
//                Console.WriteLine("Result: {0}", result);
//            }
//        }

//        static void Main(string[] args)
//        {
//            DivNumbers d = new DivNumbers();
//            d.Division(25, 0);
//            Console.ReadKey();
//        }
//    }
//}

namespace UserDefinedException
{
    class TestTemperature
    {
        static void Main()
        {
            Temperature temp = new Temperature();
            try
            {
                temp.ShowTemp();
            }
            catch (TempIsZeroExcetion e)
            {
                Console.WriteLine("TempIsZeroExcetion: {0}", e.Message);
                throw e;
            }
            Console.ReadKey();
        }
    }
}

public class TempIsZeroExcetion : ApplicationException
{
    public TempIsZeroExcetion(string message) : base(message)
    {
    }
}

public class Temperature
{
    int temperature = 0;

    public void ShowTemp()
    {
        if (temperature == 0)
        {
            throw (new TempIsZeroExcetion("Zero Temperature found"));
        }
        else
        {
            Console.WriteLine("Temperature: {0}", temperature);
        }
    }
}
