using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BoxApplication
{
    //class Box
    //{
    //    public double length;
    //    public double breadth;
    //    public double height;
    //}

    //class BoxTester
    //{
    //    static void Main(string[] args)
    //    {
    //        Box box1 = new Box();
    //        Box box2 = new Box();
    //        double volume = 0.0;

    //        box1.height = 5.0;
    //        box1.length = 6.0;
    //        box1.breadth = 7.0;

    //        box2.height = 10.0;
    //        box2.length = 12.0;
    //        box2.breadth = 13.0;

    //        volume = box1.height * box1.length * box1.breadth;
    //        WriteLine("Volume of Box1 : {0}", volume);

    //        volume = box2.height * box2.length * box2.breadth;
    //        WriteLine("Volume of Box2 : {0}", volume);

    //    }
    //}

    //class Box
    //{
    //    private double length;
    //    private double breadth;
    //    private double height;

    //    public void SetLength(double len)
    //    {
    //        length = len;
    //    }

    //    public void SetBreadth(double bre)
    //    {
    //        breadth = bre;
    //    }

    //    public void SetHeight(double hei)
    //    {
    //        height = hei;
    //    }

    //    public double GetVolume()
    //    {
    //        return length * breadth * height;
    //    }
    //}

    //class BoxTester
    //{
    //    static void Main(string[] args)
    //    {
    //        Box box1 = new Box();
    //        Box box2 = new Box();
    //        double volume;

    //        box1.SetLength(6.0);
    //        box1.SetBreadth(7.0);
    //        box1.SetHeight(5.0);

    //        box2.SetLength(12.0);
    //        box2.SetBreadth(13.0);
    //        box2.SetHeight(10.0);

    //        volume = box1.GetVolume();
    //        WriteLine("Volume of Box1 : {0}", volume);

    //        volume = box2.GetVolume();
    //        WriteLine("Volume of Box2 : {0}", volume);

    //    }
    //}
}

//namespace LineApplication
//{
//    class Line
//    {
//        private double length;

//        public Line()
//        {
//            WriteLine("Object is being created");
//        }

//        public Line(double len)
//        {
//            WriteLine("Object is being created, length = {0}", len);
//            length = len;
//        }

//        ~Line()
//        {
//            WriteLine("Object is being deleted");
//        }

//        public void SetLength(double len)
//        {
//            length = len;
//        }

//        public double GetLength()
//        {
//            return length;
//        }

//        static void Main(string[] args)
//        {
//            Line line = new Line(100.0);
//            WriteLine("Length of line : {0}", line.GetLength());

//            line.SetLength(60.0);
//            WriteLine("Length of line : {0}", line.GetLength());
//        }
//    }
//}

namespace StaticVarApplication
{
    //class StaticVar
    //{
    //    public static int num;

    //    public void Count()
    //    {
    //        num++;
    //    }

    //    public int GetNum()
    //    {
    //        return num;
    //    }
    //}

    //class StaticTester
    //{
    //    static void Main(string[] args)
    //    {
    //        StaticVar s1 = new StaticVar();
    //        StaticVar s2 = new StaticVar();

    //        s1.Count();
    //        s1.Count();
    //        s1.Count();
    //        s2.Count();
    //        WriteLine("Variable num for s1: {0}", s1.GetNum());
    //        WriteLine("Variable num for s2: {0}", s2.GetNum());
    //    }
    //}

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
        static void Main(string[] args)
        {
            StaticVar s = new StaticVar();
            s.Count();
            s.Count();
            s.Count();
            WriteLine("Variable num: {0}", StaticVar.GetNum());
        }
    }
}