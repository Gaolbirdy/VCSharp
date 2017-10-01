using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch09Ex00
{
    class MyClass
    {
        public MyClass()
        {
            
        }
        private MyClass(int myInt)
        {

        }
        ~MyClass()
        {
            
        }
    }

    internal class MyClass1
    {

    }

    public class MyClass2
    {

    }

    public abstract class MyClass3
    {

    }

    public sealed class MyClass4
    {

    }

    public class MyBase
    {

    }

    public class MyClass5 : MyBase
    {

    }

    public interface IMyInterface : IMyBaseInterface, IMyBaseInterface2
    {

    }

    public interface IMySecondInterface
    {

    }

    public interface IMyBaseInterface
    {

    }

    public interface IMyBaseInterface2
    {

    }

    public class MyClass6 :MyBase, IMyInterface, IMySecondInterface
    {

    }

    public class MyBaseClass
    {
        public MyBaseClass()
        {
            WriteLine("MyBaseClass()");
        }
        public MyBaseClass(int i)
        {
            WriteLine("MyBaseClass(int i)");
        }
    }

    public class MyDerivedClass : MyBaseClass
    {
        public MyDerivedClass() : this(5, 6)
        {
            WriteLine("MyDerivedClass()");
        }        
        public MyDerivedClass(int i)
        {
            WriteLine("MyDerivedClass(int i)");
        }
        public MyDerivedClass(int i, int j) : base(i)
        {
            WriteLine("MyDerivedClass(int i, int j)");
        }
        

    }

    class Program
    {
        static void Main()
        {
            MyDerivedClass myObj = new MyDerivedClass();
            MyDerivedClass myObj1 = new MyDerivedClass(4);
            MyDerivedClass myObj2 = new MyDerivedClass(4, 8);
            ReadKey();
        }
    }
}
