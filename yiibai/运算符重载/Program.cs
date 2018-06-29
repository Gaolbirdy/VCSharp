using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

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

        public static Box operator+ (Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }

        public static bool operator== (Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.height == rhs.height && lhs.length == rhs.length && lhs.breadth == rhs.breadth )
            {
                status = true;
            }
            return status;
        }

        public static bool operator!= (Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.height != rhs.height || lhs.length != rhs.length || lhs.breadth != rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator< (Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.height < rhs.height && lhs.length < rhs.length && lhs.breadth < rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.height > rhs.height && lhs.length > rhs.length && lhs.breadth > rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator <=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.height <= rhs.height && lhs.length <= rhs.length && lhs.breadth <= rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator >=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.height >= rhs.height && lhs.length >= rhs.length && lhs.breadth >= rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", length, breadth, height);
        }
    }

    class Tester
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();
            Box box4 = new Box();
            double volume = 0.0;

            box1.SetLength(6.0);
            box1.SetBreadth(7.0);
            box1.SetHeight(5.0);

            box2.SetLength(12.0);
            box2.SetBreadth(13.0);
            box2.SetHeight(10.0);

            WriteLine("Box 1: {0}", box1.ToString());
            WriteLine("Box 2: {0}", box2.ToString());

            volume = box1.GetVolume();
            WriteLine("Volume of Box1: {0}", volume);

            volume = box2.GetVolume();
            WriteLine("Volume of Box2: {0}", volume);

            box3 = box1 + box2;
            WriteLine("Box 3: {0}", box3.ToString());

            volume = box3.GetVolume();
            WriteLine("Volume of Box3: {0}", volume);

            if (box1 > box2)
                WriteLine("box1 is greater than box2");
            else
                WriteLine("box1 is not greater than box2");

            if (box1 < box2)
                WriteLine("box1 is less than box2");
            else
                WriteLine("box1 is not less than box2");

            if (box1 >= box2)
                WriteLine("box1 is greater or equal to box2");
            else
                WriteLine("box1 is not greater or equal to box2");

            if (box1 <= box2)
                WriteLine("box1 is less or equal to box2");
            else
                WriteLine("box1 is not less or equal to box2");

            if (box1 != box2)
                WriteLine("box1 is not equal to box2");
            else
                WriteLine("box1 is equal to box2");

            box4 = box3;
            if (box3 == box4)
                WriteLine("box3 is equal to box4");
            else
                WriteLine("box3 is not equal to box4");
        }
    }
}
