using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayApplication
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //double[] balance;
    //        double[] balance = new double[10];
    //        balance[0] = 1500.0;
    //        balance[1] = 1000.0;
    //        balance[2] = 2000.0;

    //        double[] balance2 = { 240.09, 524.19, 121.01 };

    //        int[] marks = new int[5] { 89, 98, 97, 87, 85 };
    //        int[] marks2 = new int[] { 100, 97, 96, 97, 95 };

    //        int[] score = marks2;
    //        WriteLine(score[0]);
    //        marks2[0] = 1;
    //        WriteLine(score[0]);
    //        score[0] = 5;
    //        WriteLine(score[0]);
    //        WriteLine(marks2[0]);

    //        ReadLine();
    //    }
    //}

    //class MyArray
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] n = new int[10];
    //        int i, j;

    //        for (i = 0; i < 10; i++)
    //        {
    //            n[i] = i + 100;
    //        }

    //        for (j = 0; j < 10; j++)
    //        {
    //            WriteLine("Element[{0}] = {1}", j, n[j]);
    //        }
    //    }
    //}

    //class MyArray
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] n = new int[10];

    //        for (int i = 0; i < 10; i++)
    //        {
    //            n[i] = i + 100;
    //        }

    //        foreach (int j in n)
    //        {
    //            int i = j - 100;
    //            WriteLine("Element[{0}] = {1}", i, j);
    //        }
    //    }
    //}

    //class MyArray
    //{
    //    //static void Main(string[] args)
    //    //{
    //    //    string[,] name;
    //    //    int[,,] m;

    //    //    int[,] a = new int[3, 4]
    //    //    {
    //    //        {0,1,2,3},
    //    //        {4,5,6,7},
    //    //        {8,9,10,11},
    //    //    };
    //    //    int val = a[2, 3];
    //    //    WriteLine(val);
    //    //}

    //    //static void Main(string[] args)
    //    //{
    //    //    int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
    //    //    int i, j;

    //    //    for (i = 0; i < 5; i++)
    //    //    {
    //    //        for (j = 0; j < 2; j++)
    //    //        {
    //    //            WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
    //    //        }
    //    //    }
    //    //}

    //    //static void Main(string[] args)
    //    //{
    //    //    int[][] scores = new int[5][];
    //    //    for (int i = 0; i < scores.Length; i++)
    //    //    {
    //    //        scores[i] = new int[4];
    //    //    }

    //    //    int[][] scores2 = new int[2][] { new int[] { 92, 93, 94 }, new int[] { 85, 66, 87, 88 } };
    //    //}

    //    //static void Main(string[] args)
    //    //{
    //    //    int[][] a = new int[][] { new int[] { 0, 0 }, new int[] { 1, 2 }, new int[] { 2, 4 }, new int[] { 3, 6 }, new int[] { 4, 8 } };
    //    //    int i, j;

    //    //    for (i = 0; i < 5; i++)
    //    //    {
    //    //        for (j = 0; j < 2; j++)
    //    //        {
    //    //            WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
    //    //        }
    //    //    }
    //    //}

    //    double GetAverage(int[] arr, int size)
    //    {
    //        int i;
    //        double avg;
    //        int sum = 0;
    //        for (i = 0; i < size; ++i)
    //        {
    //            sum += arr[i];
    //        }
    //        avg = (double)sum / size;
    //        return avg;
    //    }

    //    static void Main(string[] args)
    //    {
    //        MyArray app = new MyArray();
    //        int[] balance = new int[] { 1000, 2, 3, 17, 50 };
    //        double avg;

    //        avg = app.GetAverage(balance, 5);

    //        WriteLine("Average value is: {0}", avg);
    //    }
    //}

    //class ParamArray
    //{
    //    public int AddElements(params int[] arr)
    //    {
    //        int sum = 0;
    //        foreach (int i in arr)
    //        {
    //            sum += i;
    //        }
    //        return sum;
    //    }
    //}

    //class TestClass
    //{
    //    static void Main(string[] args)
    //    {
    //        ParamArray app = new ParamArray();
    //        int sum = app.AddElements(512, 720, 250, 567, 889);
    //        WriteLine("The sum is: {0}", sum);
    //        ReadKey();
    //    }
    //}

    class MyArray
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;
            Write("Original Arrat: ");

            foreach (int i in list)
            {
                Write(i + " ");
            }
            WriteLine();

            Array.Reverse(temp);
            Write("Reversed Array: ");

            foreach (int i in temp)
            {
                Write(i + " ");
            }
            WriteLine();

            Array.Sort(list);
            Write("Sorted Array: ");

            foreach (int i in list)
            {
                Write(i + " ");
            }
            WriteLine();
        }
    }
}
