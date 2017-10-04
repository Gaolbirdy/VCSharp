﻿using System;
using static System.Console;
using static System.Convert;

//8，有n(n<=100)个整数，已经按照从小到大顺序排列好，现在另外给一个整数x，请将该数插入到序列中，并使新的序列仍然有序。
//	输出新的序列

namespace 练习题5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("输入一组整数：");
            string str = ReadLine();
            string[] strArray = str.Split(' ');
            int[] numArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                numArray[i] = ToInt32(strArray[i]);
            }

            Array.Sort(numArray);
            WriteLine("排序后：");
            foreach (int item in numArray)
            {
                Write(item + " ");
            }

            WriteLine("\n输入要插入的整数：");
            int newNum = ToInt32(ReadLine());
            int[] newnumArray = new int[numArray.Length + 1];
            for (int i = 0; i < numArray.Length; i++)
            {
                if(newNum < numArray[i])
                {
                    newnumArray[i] = newNum;
                    for (int j = i; j < numArray.Length; j++)
                    {
                        newnumArray[j + 1] = numArray[j];
                    }
                    break;
                }
                else
                {
                    newnumArray[i] = numArray[i];
                    if (i == numArray.Length - 1)
                    {
                        newnumArray[i + 1] = newNum;
                    }
                }
            }
            WriteLine("插入新数字后：");
            foreach (int item in newnumArray)
            {
                Write(item + " ");
            }
            ReadKey();
        }
    }
}
