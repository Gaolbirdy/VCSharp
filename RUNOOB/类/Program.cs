using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace BoxApplication
//{
//    class Box
//    {
//        public double length;
//        public double breadth;
//        public double height;
//    }

//    class Boxtester
//    {
//        static void Main()
//        {
//            Box box1 = new Box();
//            Box box2 = new Box();
//            double volume = 0.0;

//            box1.length = 5.0;
//            box1.breadth = 6.0;
//            box1.height = 7.0;

//            box2.length = 10.0;
//            box2.breadth = 12.0;
//            box2.height = 13.0;

//            volume = box1.height * box1.length * box1.breadth;
//            Console.WriteLine("Box1 的体积： {0}", volume);

//            volume = box2.height * box2.length * box2.breadth;
//            Console.WriteLine("Box2 的体积： {0}", volume);
//            Console.ReadKey();
//        }
//    }
//}

//namespace BoxApplication
//{
//    class Box
//    {
//        private double length;
//        private double breadth;
//        private double height;

//        public void SetLength(double len)
//        {
//            length = len;
//        }

//        public void SetBreadth(double bre)
//        {
//            breadth = bre;
//        }

//        public void SetHeight(double hei)
//        {
//            height = hei;
//        }

//        public double GetVolume()
//        {
//            return length * breadth * height;
//        }
//    }

//    class Boxtester
//    {
//        static void Main()
//        {
//            Box box1 = new Box();
//            Box box2 = new Box();
//            double volume;

//            box1.SetLength(6.0);
//            box1.SetBreadth(7.0);
//            box1.SetHeight(5.0);

//            box2.SetLength(12.0);
//            box2.SetBreadth(13.0);
//            box2.SetHeight(10.0);

//            volume = box1.GetVolume();
//            Console.WriteLine("Box1 的体积： {0}", volume);

//            volume = box2.GetVolume();
//            Console.WriteLine("Box2 的体积： {0}", volume);

//            Console.ReadKey();
//        }
//    }
//}

//namespace LineApplication
//{
//    class Line
//    {
//        private double length;

//        public Line()
//        {
//            Console.WriteLine("对象已创建");
//        }

//        public Line(double len)
//        {
//            Console.WriteLine("对象已创建，length = {0}", len);
//            length = len;
//        }

//        ~Line()
//        {
//            Console.WriteLine("对象已删除");
//        }

//        public void SetLength(double len)
//        {
//            length = len;
//        }

//        public double GetLength()
//        {
//            return length;
//        }

//        static void Main()
//        {
//            Line line = new Line();
//            Console.WriteLine("线条的长度： {0}", line.GetLength());

//            line = new Line(10.0);
//            Console.WriteLine("线条的长度： {0}", line.GetLength());

//            line.SetLength(6.0);
//            Console.WriteLine("线条的长度： {0}", line.GetLength());
//            Console.ReadKey();
//        }
//    }
//}

//namespace StaticVarApplication
//{
//    class StaticVar
//    {
//        public static int num;

//        public void Count()
//        {
//            num++;
//        }

//        public int GetNum()
//        {
//            return num;
//        }
//    }

//    class StaticTester
//    {
//        static void Main()
//        {
//            StaticVar s1 = new StaticVar();
//            StaticVar s2 = new StaticVar();
//            s1.Count();
//            s1.Count();
//            s1.Count();
//            s2.Count();
//            s2.Count();
//            s2.Count();
//            Console.WriteLine("s1 的变量 num： {0}", s1.GetNum());
//            Console.WriteLine("s2 的变量 num： {0}", s2.GetNum());
//            Console.ReadKey();
//        }
//    }
//}

namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;

        public void Count()
        {
            num++;
        }

        public static int GetNum()
        {
            return num;
        }
    }

    class StaticTester
    {
        static void Main()
        {
            StaticVar s = new StaticVar();
            s.Count();
            s.Count();
            s.Count();
            Console.WriteLine("变量 num： {0}", StaticVar.GetNum());
            Console.ReadKey();
        }
    }
}
