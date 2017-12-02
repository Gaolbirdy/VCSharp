using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace PolymorphismApplication
//{
//    class Printdata
//    {
//        void Print(int i)
//        {
//            Console.WriteLine("Printing int: {0}", i);
//        }

//        void Print(float f)
//        {
//            Console.WriteLine("Printing float: {0}", f);
//        }

//        void Print(string s)
//        {
//            Console.WriteLine("Printing string: {0}", s);
//        }

//        static void Main(string[] args)
//        {
//            Printdata p = new Printdata();
//            p.Print(5);
//            p.Print(500.263f);
//            p.Print("Hello C#");
//            Console.ReadKey();
//        }
//    }
//}


//namespace PolymorphismApplication
//{
//    abstract class Shape
//    {
//        public abstract int Area();
//    }

//    class Rectangle : Shape
//    {
//        private int length;
//        private int width;

//        public Rectangle(int a = 0,int b = 0)
//        {
//            length = a;
//            width = b;
//        }

//        public override int Area()
//        {
//            Console.WriteLine("Rectangle 类的面积：");
//            return (width * length);
//        }
//    }

//    class RectangleTester
//    {
//        static void Main()
//        {
//            Rectangle r = new Rectangle(10, 7);
//            double a = r.Area();
//            Console.WriteLine("面积： {0}", a);
//            Console.ReadKey();
//        }
//    }
//}

namespace PolymorphismApplication
{
    class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }

        public virtual int Area()
        {
            Console.WriteLine("父类的面积：");
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }

        public override int Area()
        {
            Console.WriteLine("Rectangle 类的面积：");
            return (width * height);
        }
    }

    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {

        }

        public override int Area()
        {
            Console.WriteLine("Triangle 类的面积：");
            return (width * height / 2);
        }
    }

    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.Area();
            Console.WriteLine("面积： {0}", a);
        }
    }

    class Tester
    {
        static void Main()
        {
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);
            Shape s = new Shape(10, 3);
            c.CallArea(r);
            c.CallArea(t);
            c.CallArea(s);
            Console.ReadKey();
        }
    }
}