using static System.Console;
using static System.Convert;

//7，输入n(n<100)个数，找出其中最小的数，将它与最前面的数交换后输出这些数。

namespace 练习题5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = ReadLine();
            string[] strArray = str.Split(' ');
            float[] numArray = new float[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                numArray[i] = ToSingle(strArray[i]);
            }

            int minIndex = 0;
            float minNumber = numArray[minIndex];
            for (int i = 1; i < numArray.Length; i++)
            {
                if (numArray[i] < minNumber)
                {
                    minNumber = numArray[i];
                    minIndex = i;
                }
            }
            float temp = numArray[0];
            numArray[0] = minNumber;
            numArray[minIndex] = temp;
            WriteLine("找到最小值并和第0个元素交换后的数组：");
            foreach (float item in numArray)
            {
                Write(item + " ");
            }
            ReadKey();
        }
    }
}
