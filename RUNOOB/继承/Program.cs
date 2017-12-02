using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace InheritanceApplication
//{
//    class Shape
//    {
//        protected int width;
//        protected int height;

//        public void SetWidth(int w)
//        {
//            width = w;
//        }

//        public void SetHeight(int h)
//        {
//            height = h;
//        }
//    }

//    class Rectangle : Shape
//    {
//        public int GetArea()
//        {
//            return (width * height);
//        }
//    }

//    class RectangleTester
//    {
//        static void Main()
//        {
//            Rectangle rect = new Rectangle();

//            rect.SetWidth(5);
//            rect.SetHeight(7);

//            Console.WriteLine("总面积：{0}", rect.GetArea());
//            Console.ReadKey();
//        }
//    }
//}


//namespace RectangleApplication
//{
//    class Rectangle
//    {
//        protected double length;
//        protected double width;

//        public Rectangle(double l, double w)
//        {
//            length = l;
//            width = w;
//        }

//        //public Rectangle()
//        //{

//        //}

//        public double GetArea()
//        {
//            return length * width;
//        }

//        public void Display()
//        {
//            Console.WriteLine("长度： {0}", length);
//            Console.WriteLine("宽度： {0}", width);
//            Console.WriteLine("面积： {0}", GetArea());
//        }
//    }

//    class Tabletop : Rectangle
//    {
//        private double cost;

//        public Tabletop(double l, double w) : base(l, w)
//        {

//        }

//        public double GetCost()
//        {
//            //double cost;
//            cost = GetArea() * 70;
//            return cost;
//        }

//        public void Display()
//        {
//            base.Display();
//            Console.WriteLine("成本： {0}", GetCost());
//        }
//    }

//    class ExecuteRectangle
//    {
//        static void Main()
//        {
//            Tabletop t = new Tabletop(4.5, 7.5);
//            t.Display();
//            Console.ReadKey();
//        }
//    }
//}

namespace InheritanceApplication
{
    class Shape
    {
        protected int width;
        protected int height;

        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h)
        {
            height = h;
        }
    }

    public interface PaintCost
    {
        int GetCost(int area);
    }

    class Rectangle : Shape, PaintCost
    {
        public int GetArea()
        {
            return (width * height);
        }

        public int GetCost(int area)
        {
            return area * 70;
        }
    }

    class RectangleTester
    {
        static void Main()
        {
            Rectangle rect = new Rectangle();
            int area;
            rect.SetWidth(5);
            rect.SetHeight(7);
            area = rect.GetArea();

            Console.WriteLine("总面积： {0}", rect.GetArea());
            Console.WriteLine("油漆总成本： ${0}", rect.GetCost(area));
            Console.ReadKey();
        }
    }
}