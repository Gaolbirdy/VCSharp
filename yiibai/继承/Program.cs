using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//namespace InheritanceApplication

//{
//    class Shape
//    {
//        public void SetWidth(int w)
//        {
//            width = w;
//        }

//        public void SetHeight(int h)
//        {
//            height = h;
//        }

//        protected int width;
//        protected int height;
//    }

//    class Rectangle : Shape
//    {
//        public int GetArea()
//        {
//            return width * height;
//        }
//    }

//    class RectangleTester
//    {
//        static void Main(string[] args)
//        {
//            Rectangle rect = new Rectangle();

//            rect.SetWidth(10);
//            rect.SetHeight(20);

//            WriteLine("Total area: {0}", rect.GetArea());
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

//        public double GetArea()
//        {
//            return length * width;
//        }

//        public void Display()
//        {
//            WriteLine("Length: {0}", length);
//            WriteLine("width: {0}", width);
//            WriteLine("Area: {0}", GetArea());
//        }
//    }

//    class Tabletop : Rectangle
//    {
//        private double cost;

//        public Tabletop(double l, double w) : base(l,w)
//        { }

//        public double GetCost()
//        {
//            double cost;
//            cost = GetArea() * 70;
//            return cost;
//        }

//        public void Display()
//        {
//            base.Display();
//            WriteLine("Cost: {0}", GetCost());
//        }
//    }

//    class ExecuteRectangle
//    {
//        static void Main(string[] args)
//        {
//            Tabletop t = new Tabletop(4.5, 7.5);
//            t.Display();
//        }
//    }
//}


namespace InheritanceApplication
{
    class Shape
    {
        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h)
        {
            height = h;
        }

        protected int width;
        protected int height;
    }

    public interface PaintCost
    {
        int GetCost(int area);
    }

    class Rectangle : Shape, PaintCost
    {
        public int GetArea()
        {
            return width * height;
        }

        public int GetCost(int area)
        {
            return area * 70;
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            int area;
            rect.SetWidth(5);
            rect.SetHeight(7);
            area = rect.GetArea();

            WriteLine("Total area: {0}", rect.GetArea());
            WriteLine("Total paint cost: ${0}", rect.GetCost(area));
        }
    }
}