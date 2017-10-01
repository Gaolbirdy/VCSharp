using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

//5，编写一个控制台程序，要求用户输入一组数字用空格间隔，对用户输入的数字从小到大输出。(Array.Sort方法和冒泡排序)

namespace 练习题5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = ReadLine();
            string[] strArray = str.Split(' ');
            float[] numArray = new float[strArray.Length];
            int index = 0;
            foreach (string item in strArray)
            {
                numArray[index] = ToSingle(item);
                index++;
            }

            float[] numArray2 = numArray;
            WriteLine("Array.Sort()排序结果：");
            Array.Sort(numArray2);
            foreach (float item in numArray)
            {
                Write(item + " ");
            }

            // 冒泡排序
            for (int i = 0; i < numArray.Length - 1; i++)
            {
                // 最大的数放在最后，从数组第一个元素arr[0]遍历至倒数第二个arr[arr.Length-2],拿该元素与它后面的元素比较并交换
                // j的每一轮遍历后，都能得到最后的arr[arr.Length - 1 - i]元素是最大的，而之前的元素仍是无序的
                for (int j = 0; j < numArray.Length - 1 - i; j++)
                {
                    if (numArray[j] > numArray[j + 1])
                    {
                        float temp;
                        temp = numArray[j];
                        numArray[j] = numArray[j + 1];
                        numArray[j + 1] = temp;
                    }
                }
            }
            WriteLine("\n冒泡排序排序结果：");
            foreach (float item in numArray)
            {
                Write(item + " ");

            }
            ReadKey();
        }
    }
}
