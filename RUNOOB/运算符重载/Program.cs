using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOvlApplication
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double GetVolume()
        {
            return length * breadth * height;
        }

        public void SetLength(double len)
        {
            length = len;
        }

        public void SetBreadth(double bre)
        {
            breadth = bre;
        }

        public void SetHeight(double hei)
        {
            height = hei;
        }

        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }

        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.height == rhs.height && lhs.breadth == rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length != rhs.length || lhs.height != rhs.height || lhs.breadth != rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator <(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length < rhs.length && lhs.height < rhs.height && lhs.breadth < rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length > rhs.length && lhs.height > rhs.height && lhs.breadth > rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator <=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length <= rhs.length && lhs.height <= rhs.height && lhs.breadth <= rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length >= rhs.length && lhs.height >= rhs.height && lhs.breadth >= rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", length, breadth, height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();
            Box box4 = new Box();
            double volume;

            box1.SetLength(6.0);
            box1.SetBreadth(7.0);
            box1.SetHeight(5.0);

            box2.SetLength(12.0);
            box2.SetBreadth(13.0);
            box2.SetHeight(10.0);

            Console.WriteLine("box1: {0}", box1.ToString());
            Console.WriteLine("box2: {0}", box2.ToString());

            volume = box1.GetVolume();
            Console.WriteLine("box1 的体积： {0}", volume);

            volume = box2.GetVolume();
            Console.WriteLine("box2 的体积： {0}", volume);

            box3 = box1 + box2;
            Console.WriteLine("box3: {0}", box3.ToString());

            volume = box3.GetVolume();
            Console.WriteLine("box3 的体积： {0}", volume);

            if (box1 > box2)
                Console.WriteLine("box1 大于 box2");
            else
                Console.WriteLine("box1 不大于 box2");

            if (box1 < box2)
                Console.WriteLine("box1 小于 box2");
            else
                Console.WriteLine("box1 不小于 box2");

            if (box1 >= box2)
                Console.WriteLine("box1 大于等于 box2");
            else
                Console.WriteLine("box1 不大于等于 box2");

            if (box1 <= box2)
                Console.WriteLine("box1 小于等于 box2");
            else
                Console.WriteLine("box1 不小于等于 box2");

            if (box1 != box2)
                Console.WriteLine("box1 不等于 box2");
            else
                Console.WriteLine("box1 等于 box2");

            box4 = box3;
            if (box3 == box4)
                Console.WriteLine("box3 等于 box4");
            else
                Console.WriteLine("box3 不等于 box4");

            Console.ReadKey();
        }
    }
}
