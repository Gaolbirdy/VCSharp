using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigle"};
            WriteLine($"Here are {friendNames.Length} of my friends:");
            foreach(string friendName in friendNames)
            {
                WriteLine(friendName);
            }
            WriteLine();

            int[] x = new int[] { 1, 2 };
            int[] y = new int[2] { 1, 2 };

            double[,] hillHeight;
            hillHeight = new double[3,4] { { 1, 2, 3, 4 },{ 2, 3, 4, 5 },{ 3, 4, 5, 6 } };
            WriteLine(hillHeight[2, 1]);

            foreach(double height in hillHeight)
            {
                WriteLine("{0}{1}", height, height);
                WriteLine(height.ToString() + height.ToString());
            }

            JaggedArray();
            ReadKey();
        }
        static void JaggedArray()
        {
            int[][] divisors1To10 = {  new int[] { 1 },
                                       new int[] { 1, 2 },
                                       new int[] { 1, 3 },
                                       new int[] { 1, 2, 4},
                                       new int[] { 1, 5 },
                                       new int[] { 1, 2, 3, 6 },
                                       new int[] { 1, 7 },
                                       new int[] { 1, 2, 4, 8 },
                                       new int[] { 1, 3, 9 },
                                       new int[] { 1, 2, 5, 10 } };
            WriteLine();
            foreach (int[] divisorsOfInt in divisors1To10)
            {
                foreach (int divisor in divisorsOfInt)
                {
                    //WriteLine(divisor);
                    Write(divisor + " ");
                }
                WriteLine();
            }

            int[][] jaggedIntArray, jaddedIntArray2, jaddedIntArray3, jaddedIntArray4, jaddedIntArray5;
            //jaggedArray = new int[3][4];
            //jaggedArray = new int[3][4] { {1,2,3 },{1 },{1,2 } };
            //jaggedArray = { { 1, 2, 3 }, { 1 }, { 1, 2 } };
            jaggedIntArray = new int[2][];
            jaggedIntArray[0] = new int[3] { 1,2,3};
            jaggedIntArray[1] = new int[] { 2,3,4,5};

            jaddedIntArray2 = new int[3][] { new int[3] { 1,2,3}, new int[1] { 1 }, new int[2] { 1, 2 } };
            jaddedIntArray3 = new int[][] { new int[3] { 1, 2, 3 }, new int[1] { 1 }, new int[2] { 1, 2 } };
            jaddedIntArray4 = new int[][] { new int[] { 1, 2, 3 }, new int[] { 1 }, new int[] { 1, 2 } };
            jaddedIntArray5 = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 1 }, new int[] { 1, 2 } };

            int[][] jaddedIntArray6 = new int[3][] { new int[3] { 1, 2, 3 }, new int[1] { 1 }, new int[2] { 1, 2 } };
            int[][] jaddedIntArray7 = { new int[] { 1, 2, 3 }, new int[] { 1 }, new int[] { 1, 2 } };
        }
    }
}