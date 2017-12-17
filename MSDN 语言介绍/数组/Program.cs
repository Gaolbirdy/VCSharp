using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 数组
{
    class ArrayExample
    {
        static void Main(string[] args)
        {
            //int[] a = new int[10];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = i * i;
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    WriteLine($"a[{i}] = {a[i]}");
            //}

            int[] a1 = new int[10];
            int[,] a2 = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
            int[,,] a3 = new int[10, 5, 2];

            int[][] a = new int[3][];
            a[0] = new int[10];
            a[1] = new int[5];
            a[5] = new int[20];

            int[] b = new int[] { 1, 2, 3 };
            int[] c = { 1, 2, 3 };

            int[] t = new int[3];
            t[0] = 1;
            t[1] = 2;
            t[2] = 3;
            int[] z = t;

            ReadKey();
        }
    }
}
