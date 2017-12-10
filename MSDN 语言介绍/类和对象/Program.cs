using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类和对象
{
    //public class Point
    //{
    //    public int x, y;

    //    public Point(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }

    //    static void Main()
    //    {
    //        Point p1 = new Point(0, 0);
    //        Point p21 = new Point(10, 0);
    //    }
    //}

    public class Pair<TFirst, TSecond>
    {
        public TFirst First;
        public TSecond second;

        static void Main()
        {
            Pair<int,string> pair = new Pair<int, string> { First = 1, second = "two" };
            //Pair<char,bool> pair2 = new Pair<char, bool>();
            int i = pair.First; // TFirst is int
            string s = pair.second; // TSecond is string
        }
    }
}
