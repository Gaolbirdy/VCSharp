using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex02
{
    class Program
    {
        static int MaxValue(int[] intArray, out int maxIndex)
        {
            int maxVal = intArray[0];
            maxIndex = 0;
            for(int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                {
                    maxVal = intArray[i];
                    maxIndex = i;
                }
            }
            return maxVal;
        }

        static double MaxValue(double[] doubleArray, out int maxIndex)
        {
            double maxVal = doubleArray[0];
            maxIndex = 0;
            for (int i = 1; i < doubleArray.Length; i++)
            {
                if (doubleArray[i] > maxVal)
                {
                    maxVal = doubleArray[i];
                    maxIndex = i;
                }
            }
            return maxVal;
        }

        static double MaxValue(double[] doubleArray, int maxIndex)
        {
            double maxVal = doubleArray[0];
            maxIndex = 0;
            for (int i = 1; i < doubleArray.Length; i++)
            {
                if (doubleArray[i] > maxVal)
                {
                    maxVal = doubleArray[i];
                    maxIndex = i;
                }
            }
            return maxVal;
        }

        static void Main(string[] args)
        {
            int[] myIntArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxIndex;
            //int maxVal = MaxValue(myArray);
            WriteLine($"The maximum value in myIntArray is {MaxValue(myIntArray, out maxIndex)}.");
            WriteLine($"The first occurrence of this value is at element {maxIndex + 1}.");
            WriteLine();

            double x = 9.1;
            double[] myDoubleArray = { 1.1, 8.1, 3.1, 6.1, 2.1, 5.1, x++, x, 0.1, 2 };
            WriteLine($"The maximum value in myDoubleArray is {MaxValue(myDoubleArray, out maxIndex)}.");
            WriteLine($"The first occurrence of this value is at element {maxIndex + 1}.");
            

            ReadKey();
        }
    }
}
