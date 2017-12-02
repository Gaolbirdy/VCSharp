using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApplication
{
    class ParamArray
    {
        public int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }

    class MyArray
    {
        static void Main(string[] args)
        {
            //int[] n = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    n[i] = i + 100;
            //}

            ////for (j = 0; j < 10; j++)
            ////{
            ////    Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            ////}

            //foreach (int j in n)
            //{
            //    int i = j - 100;
            //    Console.WriteLine("Element[{0}] = {1}", i, j);
            //}

            //int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };

            //int i, j;

            //for (i = 0; i < 5; i++)
            //{
            //    for (j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i,j]);
            //    }
            //}

            //int[][] a = new int[][] { new int[] { 0, 0 }, new int[] { 1, 2 },
            //    new int[] { 2, 4, 5 }, new int[] { 3, 6, 22, 123 }, new int[] { 4, 8 } };

            //int i, j;

            //for (i = 0; i < a.Length; i++)
            //{
            //    for (j = 0; j < a[i].Length; j++)
            //    {
            //        Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
            //    }
            //}

            //MyArray app = new MyArray();
            //int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            //double avg;

            //avg = app.GetAverage(balance, 5);

            //Console.WriteLine("平均值是： {0} ", avg);

            //ParamArray app = new ParamArray();
            //int[] nums = { 1, 2, 3 };
            //int sum = app.AddElements(nums);
            //Console.WriteLine("总和是： {0}", sum);

            //sum = app.AddElements(512, 720, 250, 567, 889);
            //Console.WriteLine("总和是： {0}", sum);

            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;

            Console.Write("原始数组： ");
            foreach (int  i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Reverse(temp);
            Console.Write("逆转数组： ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Sort(list);
            Console.Write("排序数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        double GetAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }

            avg = (double)sum / size;
            return avg;
        }
    }
}
