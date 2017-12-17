using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 结构
{
    struct PointStruct
    {
        public int x, y;

        public PointStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class PointClass
    {
        public int x, y;

        public PointClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Pointexample
    {
        static void Main(string[] args)
        {
            //Point[] points = new Point[100];
            //for (int i = 0; i < 100; i++)
            //{
            //    points[i] = new Point(i, i);
            //}

            PointStruct a = new PointStruct(10, 10);
            PointStruct b = a;
            a.x = 20;
            WriteLine(b.x);

            PointClass c = new PointClass(10, 10);
            PointClass d = c;
            c.x = 20;
            WriteLine(d.x);
            ReadKey();
        }
    }
}
