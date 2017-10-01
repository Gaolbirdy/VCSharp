using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch07Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = {4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9};
            int[] maxValIndices;
            int maxVal = Maxima(testArray, out maxValIndices);

            //Debug.Assert(maxVal < 9, "最大值不是小于9", "Assertion 发生在 Main()");

            WriteLine($"Maximum value {maxVal} found at element indices:");
            foreach(int index in maxValIndices)
            {
                WriteLine(index);
            }
            ReadKey();
        }
        static int Maxima(int[] integers, out int[] indices)
        {
            Debug.WriteLine("________________________________________________________________");
            Debug.WriteLine("Maximum value search started.\n");
            int count = 1;
            //indices = new int[1];
            indices = new int[count];
            int maxVal = integers[0];
            indices[0] = 0;
            //Debug.WriteLine(string.Format($"Maximum value initialized to {maxVal}, at element index 0.\n"));
            for (int i = 1; i < integers.Length; i++ )
            {
                Debug.WriteLine(string.Format(
                    $"Now looking at element at index {i}."));
                if (integers[i] > maxVal)
                {
                    maxVal = integers[i];
                    count = 1;
                    //indices = new int[1];
                    indices = new int[count];
                    indices[0] = i;
                    Debug.WriteLine(string.Format(
                        $"New maximum found. New value is {maxVal}, at element index {i}.\n"));
                }
                else
                {
                    if (integers[i] == maxVal)
                    {
                        count++;
                        int[] oldIndices = indices;
                        indices = new int[count];
                        oldIndices.CopyTo(indices, 0);
                        indices[count - 1] = i;
                        Debug.WriteLine(string.Format(
                            $"Duplicate maximum found at element index {i}.\n"));
                    }
                }
            }
            Trace.WriteLine(string.Format(
                $"Maximum value {maxVal} found, with {count} occurrences."));
            Debug.WriteLine("Maximum value search completed.");
            Debug.WriteLine("________________________________________________________________");
            return maxVal;
        }
    }
}
