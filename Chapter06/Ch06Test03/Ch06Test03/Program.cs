using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//using static Ch06Test03.MyClass;

namespace Ch06Test03
{
    class MyClass
    {
        public static void X()
        {
            WriteLine("委托调用别的类的静态方法");
        }
        public void Y()
        {
            WriteLine("委托调用别的类的实例方法");
        }
    }

    class Program
    {
        delegate void MyWrite(string str);
        delegate string MyReadLine();
        delegate ConsoleKeyInfo WaitKey();
        delegate void NonStatic();

        static void Main(string[] args)
        {
            MyClass t = new MyClass();
            NonStatic myNonStatic = new NonStatic(t.Y);
            myNonStatic();
            myNonStatic = MyClass.X;
            myNonStatic();

            MyWrite myDelegate = new MyWrite(WriteLine);
            MyReadLine read = ReadLine;
            string str = read();

            MyWrite write = WriteLine;
            write("myDelegate == WriteLine()");
            write(str);
            write = Write;
            write("myDelegate == Write()");
            write("a");
            write("a");
            write("a");
            write("a");

            WaitKey wait = ReadKey;
            wait();
        }
    }
}
