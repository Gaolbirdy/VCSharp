using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//namespace GenericApplication
//{
//    public class MyGenericArray<T>
//    {
//        private T[] array;

//        public MyGenericArray(int size)
//        {
//            array = new T[size + 1];
//        }

//        public T GetItem(int index)
//        {
//            return array[index];
//        }

//        public void SetItem(int index, T value)
//        {
//            array[index] = value;
//        }
//    }

//    class Tester
//    {
//        static void Main(string[] args)
//        {
//            MyGenericArray<int> intArray = new MyGenericArray<int>(5);

//            for (int i = 0; i < 5; i++)
//            {
//                intArray.SetItem(i, i * 10);
//            }

//            for (int i = 0; i < 5; i++)
//            {
//                Write(intArray.GetItem(i) + " ");
//            }
//            WriteLine();

//            MyGenericArray<char> charArray = new MyGenericArray<char>(5);

//            for (int i = 0; i < 5; i++)
//            {
//                charArray.SetItem(i, (char)(i + 97));
//            }

//            for (int i = 0; i < 5; i++)
//            {
//                Write(charArray.GetItem(i) + " ");
//            }
//            WriteLine();
//            ReadKey();
//        }
//    }
//}

//namespace GenericMethodAppl
//{
//    class Program
//    {
//        static void Swap<T>(ref T lhs, ref T rhs)
//        {
//            T temp;
//            temp = lhs;
//            lhs = rhs;
//            rhs = temp;
//        }

//        static void Main(string[] args)
//        {
//            int a, b;
//            char c, d;
//            a = 100;
//            b = 201;
//            c = 'Y';
//            d = 'B';

//            WriteLine("Int values before calling swap:");
//            WriteLine("a = {0}, b = {1}", a, b);
//            WriteLine("Char values before calling swap:");
//            WriteLine("c = {0}, d = {1}", c, d);

//            Swap<int>(ref a, ref b);
//            Swap<char>(ref c, ref d);

//            WriteLine("Int values after calling swap:");
//            WriteLine("a = {0}, b = {1}", a, b);
//            WriteLine("Char values after calling swap:");
//            WriteLine("c = {0}, d = {1}", c, d);
//        }
//    }
//}


delegate T NumberChanger<T>(T n);

namespace GenericDelegateAppl
{
    class TestDelegate
    {
        static int num = 101;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int GetNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

            nc1(25);
            WriteLine("Value of Num: {0}", GetNum());
            nc2(5);
            WriteLine("Value of Num: {0}", GetNum());
            ReadKey();
        }
    }
}