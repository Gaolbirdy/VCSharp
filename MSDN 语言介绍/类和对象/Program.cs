using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//namespace 类和对象
//{
//    public class Point
//    {
//        public int x, y;

//        public Point(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }

//        static void Main()
//        {
//            Point p1 = new Point(0, 0);
//            Point p21 = new Point(10, 0);
//        }
//    }
//}

//namespace 类型参数
//{
//    public class Pair<TFirst, TSecond>
//    {
//        public TFirst First;
//        public TSecond Second;
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Pair<int, string> pair = new Pair<int, string>()
//            {
//                First = 1,
//                Second = "Two"
//            };
//            //Pair<char, bool> pair2 = new Pair<char, bool>();
//            WriteLine(pair.First);
//            WriteLine(pair.Second);
//            int i = pair.First; // TFirst is int
//            string s = pair.Second; // TSecond is string
//            WriteLine(i);
//            WriteLine(s);
//            ReadKey();
//        }
//    }
//}

//namespace 基类
//{
//    public class Point
//    {
//        public int x, y;

//        public Point(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }
//    }

//    public class Point3D : Point
//    {
//        public int z;

//        public Point3D(int x, int y, int z) : base(x, y)
//        {
//            this.z = z;
//        }

//        static void Main()
//        {
//            Point a = new Point(10, 20);
//            Point b = new Point3D(10, 20, 30);
//            ReadKey();
//        }
//    }
//}

//namespace 字段
//{
//    public class Color
//    {
//        public static readonly Color Black = new Color(0, 0, 0);
//        public static readonly Color White = new Color(255, 255, 255);
//        public static readonly Color Red = new Color(255, 0, 0);
//        public static readonly Color Green = new Color(0, 255, 0);
//        public static readonly Color Blue = new Color(0, 0, 255);

//        private byte r, g, b;

//        public Color(byte r, byte g, byte b)
//        {
//            this.r = r;
//            this.g = g;
//            this.b = b;
//        }
//    }
//}

namespace 方法
{
    //class RefExample
    //{
    //    static void Swap(ref int x, ref int y)
    //    {
    //        int temp = x;
    //        x = y;
    //        y = temp;
    //    }

    //    public static void Main()
    //    {
    //        int i = 1, j = 2;
    //        Swap(ref i, ref j);
    //        WriteLine($"i: {i} j: {j}");
    //        ReadKey();
    //    }
    //}

    class OutExample
    {
        static void Divide(int x, int y, out int result, out int remainder)
        {
            result = x / y;
            remainder = x % y;
        }

        public static void Main()
        {
            Divide(10, 3, out int res, out int rem);
            WriteLine("res: {0} rem: {1}", res, rem);
            ReadKey();
        }
    }
}