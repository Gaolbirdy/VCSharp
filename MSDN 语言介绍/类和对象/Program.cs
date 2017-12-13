using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//namespace 类和对象
//{
//    public class Point
//    {
//        public int x, y;

//        public Point(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }

//        static void Main()
//        {
//            Point p1 = new Point(0, 0);
//            Point p21 = new Point(10, 0);
//        }
//    }
//}

//namespace 类型参数
//{
//    public class Pair<TFirst, TSecond>
//    {
//        public TFirst First;
//        public TSecond Second;
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Pair<int, string> pair = new Pair<int, string>()
//            {
//                First = 1,
//                Second = "Two"
//            };
//            //Pair<char, bool> pair2 = new Pair<char, bool>();
//            WriteLine(pair.First);
//            WriteLine(pair.Second);
//            int i = pair.First; // TFirst is int
//            string s = pair.Second; // TSecond is string
//            WriteLine(i);
//            WriteLine(s);
//            ReadKey();
//        }
//    }
//}

//namespace 基类
//{
//    public class Point
//    {
//        public int x, y;

//        public Point(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }
//    }

//    public class Point3D : Point
//    {
//        public int z;

//        public Point3D(int x, int y, int z) : base(x, y)
//        {
//            this.z = z;
//        }

//        static void Main()
//        {
//            Point a = new Point(10, 20);
//            Point b = new Point3D(10, 20, 30);
//            ReadKey();
//        }
//    }
//}

//namespace 字段
//{
//    public class Color
//    {
//        public static readonly Color Black = new Color(0, 0, 0);
//        public static readonly Color White = new Color(255, 255, 255);
//        public static readonly Color Red = new Color(255, 0, 0);
//        public static readonly Color Green = new Color(0, 255, 0);
//        public static readonly Color Blue = new Color(0, 0, 255);

//        private byte r, g, b;

//        public Color(byte r, byte g, byte b)
//        {
//            this.r = r;
//            this.g = g;
//            this.b = b;
//        }
//    }
//}

namespace 方法
{
    //class RefExample
    //{
    //    static void Swap(ref int x, ref int y)
    //    {
    //        int temp = x;
    //        x = y;
    //        y = temp;
    //    }

    //    public static void Main()
    //    {
    //        int i = 1, j = 2;
    //        Swap(ref i, ref j);
    //        WriteLine($"i: {i} j: {j}");
    //        ReadKey();
    //    }
    //}

    //class OutExample
    //{
    //    static void Divide(int x, int y, out int result, out int remainder)
    //    {
    //        result = x / y;
    //        remainder = x % y;
    //    }

    //    public static void Main()
    //    {
    //        Divide(10, 3, out int res, out int rem);
    //        WriteLine("res: {0} rem: {1}", res, rem);
    //        ReadKey();
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        int x = 1, y = 2, z = 3;
    //        WriteLine("x={0} y={1} z={2}", x, y, z);

    //        string s = "x={0} y={1} z={2}";
    //        object[] args = new object[3];
    //        args[0] = x;
    //        args[1] = y;
    //        args[2] = z;
    //        WriteLine(s, args);
    //        ReadKey();
    //    }
    //}

    //class Squares
    //{
    //    public static void Main()
    //    {
    //        int i = 0;
    //        int j;
    //        while (i < 10)
    //        {
    //            j = i * i;
    //            WriteLine($"{i} x {i} = {j}");
    //            i = i + 1;
    //        }
    //        ReadKey();
    //    }
    //}

    //class Entity
    //{
    //    static int nextSerialNo;
    //    int serialNo;

    //    public Entity()
    //    {
    //        serialNo = nextSerialNo++;
    //    }

    //    public int GetSerialNo()
    //    {
    //        return serialNo;
    //    }

    //    public static int GetNextSerialNo()
    //    {
    //        return nextSerialNo;
    //    }

    //    public static void SetNextSerialNo(int value)
    //    {
    //        nextSerialNo = value;
    //    }
    //}
    //class EntityExample
    //{
    //    static void Main()
    //    {
    //        Entity.SetNextSerialNo(1000);
    //        Entity e1 = new Entity();
    //        Entity e2 = new Entity();
    //        WriteLine(e1.GetSerialNo());    // Outpus "1000"
    //        WriteLine(e2.GetSerialNo());    // Outpus "1001"
    //        WriteLine(Entity.GetNextSerialNo());    // Outpus "1002"
    //        ReadKey();
    //    }
    //}

    public abstract class Expression
    {
        // 虚方法
        public abstract double Evaluate(Dictionary<string, object> vars);
    }

    // 常量
    public class Constant : Expression
    {
        // 字段
        double value;

        // 构造方法
        public Constant(double value)
        {
            this.value = value;
        }

        // 重写方法 求值
        public override double Evaluate(Dictionary<string, object> vars)
        {
            return value;
        }
    }

    // 变量引用
    public class VariableReference : Expression
    {
        // 字段
        string name;

        // 构造方法
        public VariableReference(string name)
        {
            this.name = name;
        }

        // 重写方法 根据字典求值
        public override double Evaluate(Dictionary<string, object> vars)
        {
            object value = vars[name];
            if (value == null)
            {
                throw new Exception("Unknown variable: " + name);
            }
            return Convert.ToDouble(value);
        }
    }

    // 算术运算
    public class Operation : Expression
    {
        // 字段
        Expression left;
        char op;
        Expression right;

        // 构造方法
        public Operation(Expression left, char op, Expression right)
        {
            this.left = left;
            this.op = op;
            this.right = right;
        }

        // 重写方法
        public override double Evaluate(Dictionary<string, object> vars)
        {
            double x = left.Evaluate(vars);
            double y = right.Evaluate(vars);
            switch (op)
            {
                case '+': return x + y;
                case '-': return x - y;
                case '*': return x * y;
                case '/': return x / y;
            }
            throw new Exception("Unknown operator");
        }
    }

    class InheritanceExample
    {
        public static void Main()
        {
            Expression e = new Operation(
                new VariableReference("x"),
                '*',
                new Operation(
                    new VariableReference("y"),
                    '+',
                    new Constant(2)
                )
            );

            ReadKey();
        }
    }
}