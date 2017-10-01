using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//using static Ch10Ex00.MyClass3;

namespace Ch10Ex00
{
    class MyClass
    {
        public int MyInt;

        //Field used by property.
        private int myInt;
        // Property.
        public int MyIntProp
        {
            get
            {
                return myInt;
                // Property get code.
            }
            protected set
            {
                if (value >= 0 && value <= 10)
                    myInt = value;
                else
                    throw (new ArgumentOutOfRangeException("MyIntProp", value, "MyIntProp must be assigned a value between 0 and 10."));
                // Property set code.
            }
        }

        //Field used by property.
        private int myDoubleInt = 5;
        //Property.
        public int MyDoubleIntProp => (myDoubleInt * 2);

        public string MyString
        {
            get
            {
                return myString;
            }

            set
            {
                myString = value;
            }
        }

        private string myString;

        public int MyIntProp1
        {
            get;
            set;
        }

        public int MyIntProp2 { get; set; }

        public int MyProperty { get; set; }

        public int MyIntProp3 { get; private set; }

        public int MyIntProp4 { get; }

        public int MyIntProp5 { get; } = 9;

    }

    class MyClass1
    {
        public readonly int MyInt = 17;
    }

    class MyClass2
    {
        public static int MyInt;
    }

    class MyClass3
    {
        public static string GetString() => "Here is a string.";
    }

    public class MyClass4
    {
        private int someData;
        public int SomeData
        {
            get
            {
                return this.someData;
            }
        }
    }

    public class MyClass5
    {
        public class MyNestedClass
        {
            public int NestedClassField;
        }
    }

    public class MyBaseClass
    {
        public virtual void DoSomething()
        {

        }
    }

    public class MyDerivedClass : MyBaseClass
    {
        public override sealed void DoSomething()
        {
            
        }
    }

    public class MyDerivedClass2 : MyDerivedClass
    {
        
    }

    public class MyBaseClass1
    {
        public void DoSomething()
        {
            // Base implementation.
        }
    }

    public class MyDerivedClass1 : MyBaseClass1
    {
        new public void DoSomething()
        {
            // Derived class implementation, hides base implementation.
        }
    }

    public class MyBaseClass2
    {
        public virtual void DoSomething() => WriteLine("Base imp");
    }

    public class MyDerivedClass3 : MyBaseClass2
    {
        public override void DoSomething() => WriteLine("Derived imp");
    }

    public class MyBaseClass3
    {
        public virtual void DoSomething() => WriteLine("Base imp");
    }

    public class MyDerivedClass4 : MyBaseClass3
    {
        new public void DoSomething() => WriteLine("Derived imp");
    }

    public class MyDerivedClass5 : MyBaseClass3
    {
        public override void DoSomething()
        {
            // Derived class implementation, extends base class implementation.
            base.DoSomething();
            // More derived class implementation.
            WriteLine(this);
        }
    }

    interface IMyInterface
    {
        // Interface members.
        int MyInt { get; set; }
    }

    interface IMyBaseInterface
    {
        void DoSomething();
    }

    interface IMyDerivedInterface : IMyBaseInterface
    {
        new void DoSomething();
    }

    interface IMyInterface1
    {
        void DoSomething();
        void DoSomethingElse();
    }

    public class MyBaseClass4
    {
        public void DoSomething() { }
    }

    public class MyClass6 : MyBaseClass4, IMyInterface1
    {
        public void DoSomethingElse() { }
    }

    public class MyBaseClass5 : IMyInterface1
    {
        public virtual void DoSomething() { }
        public virtual void DoSomethingElse() { }
    }

    public class MyDerivedClass6 : MyBaseClass5
    {
        public override void DoSomething() { }
        new public void DoSomethingElse() { }
    }

    //显式实现接口成员
    public class MyBaseClass6 : IMyInterface1
    {
        void IMyInterface1.DoSomething() { }
        public void DoSomethingElse() { }
    }

    public interface IMyInterface2
    {
        int MyIntProperty { get; }
    }

    public class MyBaseClass7 : IMyInterface2
    {
        public int MyIntProperty { get; protected set; }
    }

    public partial class MyClass7
    {
        #region Fields
        private int myInt;
        #endregion

        #region Constructor
        public MyClass7() { myInt = 99; }
        #endregion

        #region Properties
        public int Myint
        {
            get { return myInt; }
            set { myInt = value; }
        }
        #endregion

        #region Methods
        static partial void MyPartialMethod();
        
        #endregion
    }

    public partial class MyClass7
    {
        #region Methods
        static partial void MyPartialMethod()
        {
            // Method implementation
        }
        #endregion
    }

    public partial class MyPartialClass
    {
        static partial void DoSomethingElse();
        static public void DoSomething()
        {
            WriteLine("DoSomething() execution started.");
            DoSomethingElse();
            WriteLine("DoSomething() execution finished.");
        }
    }

    public partial class MyPartialClass
    {
        static partial void DoSomethingElse() => WriteLine("DoSomethingElse() called.");
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(MyClass3.GetString());

            MyDerivedClass3 myObj = new MyDerivedClass3();
            MyBaseClass2 myBaseObj = new MyBaseClass2();
            myObj.DoSomething();
            myBaseObj.DoSomething();
            myBaseObj = myObj;
            myBaseObj.DoSomething();
            

            MyDerivedClass4 myObj1 = new MyDerivedClass4();
            MyBaseClass3 myBaseObj1 = new MyBaseClass3();
            myObj1.DoSomething();
            myBaseObj1.DoSomething();
            myBaseObj1 = myObj1;
            myBaseObj1.DoSomething();

            MyDerivedClass5 myObj2 = new MyDerivedClass5();
            myObj2.DoSomething();

            MyClass5.MyNestedClass myObj3 = new MyClass5.MyNestedClass();

            MyPartialClass.DoSomething();
            
            ReadKey();
            
        }
    }
}
