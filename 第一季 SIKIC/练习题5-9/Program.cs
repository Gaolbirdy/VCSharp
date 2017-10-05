using static System.Console;

//9,作为泰课的老师，最盼望的日子就是每月的8号了，因为这一天是发工资的日子，养家糊口就靠它了，呵呵
//但是对于泰课财务处的工作人员来说，这一天则是很忙碌的一天，财务处的小云老师最近就在考虑一个问题：
//如果每个老师的工资额都知道，最少需要准备多少张人民币，才能在给每位老师发工资的时候都不用老师找零呢？
//这里假设老师的工资都是正整数，单位元，人民币一共有100元、50元、10元、5元、2元和1元六种。

namespace 练习题5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] salary = {2014, 1231, 24332, 34534, 345, 4243 };
            int[] faceValue = {100, 50, 10, 5, 2, 1 };
            int[] countEachValue = new int[faceValue.Length];
            int totalCount = 0;

            for (int i = 0; i < salary.Length; i++)
            {
                for (int j = 0; j < faceValue.Length; j++)
                {
                    totalCount += countEachValue[i];
                }
            }

            totalCount = Sum(countEachValue);
            Write(totalCount);
            ReadKey();
        }

        static int Sum(int[] intArray)
        {
            int sum = 0;
            foreach (int item in intArray)
            {
                sum += item;
            }
            return sum;
        }
    }
}
