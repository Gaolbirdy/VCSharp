using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RectangleApplication
{
    //class Rectangle
    //{
    //    public double length;
    //    public double width;

    //    public double GetArea()
    //    {
    //        return length * width;
    //    }

    //    public void Display()
    //    {
    //        WriteLine("Length: {0}", length);
    //        WriteLine("width: {0}", width);
    //        WriteLine("Area: {0}", GetArea());
    //    }
    //}

    //class ExecuteRectangle
    //{
    //    static void Main(string[] args)
    //    {
    //        Rectangle r = new Rectangle();
    //        r.length = 14.5;
    //        r.width = 10.5;
    //        r.Display();
    //        ReadLine();
    //    }
    //}

    //class Rectangle
    //{
    //    private double length;
    //    private double width;

    //    public void Acceptdetails()
    //    {
    //        WriteLine("Enter Length: ");
    //        length = Convert.ToDouble(ReadLine());
    //        WriteLine("Enter width: ");
    //        width = Convert.ToDouble(ReadLine());
    //    }

    //    public double GetArea()
    //    {
    //        return length * width;
    //    }

    //    public void Display()
    //    {
    //        WriteLine("Length: {0}", length);
    //        WriteLine("width: {0}", width);
    //        WriteLine("Area: {0}", GetArea());
    //    }
    //}

    //class ExecuteRectangle
    //{
    //    static void Main(string[] args)
    //    {
    //        Rectangle r = new Rectangle();
    //        r.Acceptdetails();
    //        r.Display();
    //        ReadLine();
    //    }
    //}

    class Rectangle
    {
        internal double length;
        internal double width;

        double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            WriteLine("Length: {0}", length);
            WriteLine("width: {0}", width);
            WriteLine("Area: {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle
            {
                length = 12.5,
                width = 8.25
            };
            r.Display();
            ReadLine();
        }
    }
}
