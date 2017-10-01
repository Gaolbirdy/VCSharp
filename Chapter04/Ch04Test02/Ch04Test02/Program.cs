using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
namespace Ch04Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isRuning = true;
            //double max = 10;
            //while (isRuning)
            //{
            //    WriteLine("依次输入2个数字，最多只允许其中有1个数字大于{0}", max);
            //    Write("输入第1个数字：");
            //    double var1 = ToDouble(ReadLine());
            //    Write("输入第2个数字：");
            //    double var2 = ToDouble(ReadLine());
            //    isRuning = (var1 > max) && (var2 > max);
            //    //if (!((var1 > max) && (var2 > max)))
            //    //    isRuning = false;
            //    //if ((var1 > max) && (var2 > max))
            //    //    isRuning = true;
            //    //else
            //    //    isRuning = false;
            //}

            //bool isNumbersOk = false;
            //double max = 10;
            //while (!isNumbersOk)
            //{
            //    WriteLine("依次输入2个数字，最多只允许其中有1个数字大于{0}", max);
            //    Write("输入第1个数字：");
            //    double var1 = ToDouble(ReadLine());
            //    Write("输入第2个数字：");
            //    double var2 = ToDouble(ReadLine());
            //    isNumbersOk = !((var1 > max) && (var2 > max));
            //    //if (!((var1 > max) && (var2 > max)))
            //    //    isRuning = false;
            //    //if ((var1 > max) && (var2 > max))
            //    //    isRuning = true;
            //    //else
            //    //    isRuning = false;
            //}

            //double max = 10;
            //while (true)
            //{
            //    WriteLine("依次输入2个数字，最多只允许其中有1个数字大于{0}", max);
            //    Write("输入第1个数字：");
            //    double var1 = ToDouble(ReadLine());
            //    Write("输入第2个数字：");
            //    double var2 = ToDouble(ReadLine());
            //    if ((var1 > max) && (var2 > max))
            //        continue;
            //    break;
            //}

            //bool isNumbersOk = false;
            //double var1 = 0, var2 = 0;
            //double max = 10;
            //while (!isNumbersOk)
            //{
            //    WriteLine("依次输入2个数字，最多只允许其中有1个数字大于{0}", max);
            //    Write("输入第1个数字：");
            //    var1 = ToDouble(ReadLine());
            //    Write("输入第2个数字：");
            //    var2 = ToDouble(ReadLine());
            //    if (var1 <= 10 && var2 <= 10)
            //        isNumbersOk = true;
            //    else
            //    {
            //        if ((var1 > max) ^ (var2 > max))
            //            isNumbersOk = true;
            //    }
            //}
            //WriteLine("成功：{1}和{2}没有多个数字大于{0}", max,var1,var2);

            int arraySize;

            while (true)
            {
                Write("要输入多少个数：");
                if (int.TryParse(ReadLine(), out arraySize))
                    if(arraySize > 0)
                        break;
                    else
                        WriteLine("输入不合法，重新输入");
                else
                    WriteLine("输入不合法，重新输入");
            }

            double[] numbers = new double[arraySize];
            bool isNumberOk = false;
            while (!isNumberOk)
            {
                byte countOf10 = 0;
                for (int i = 0; i < arraySize; i++)
                {
                    Write($"输入第{i + 1}个数字：");
                    numbers[i] = ToDouble(ReadLine());
                    if (numbers[i] > 10)
                        countOf10++;
                    if (countOf10 >= 2)
                    {
                        WriteLine($"不允许有多个数字大于10，重新输入");
                        break;
                    }
                }
                if (countOf10 < 2)
                    isNumberOk = true;
            }
            foreach (var i in numbers)
            {
                Write(i + " ");
            }
            ReadKey();
        }
    }
}
