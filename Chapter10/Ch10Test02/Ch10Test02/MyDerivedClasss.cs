using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch10Test01;
using static System.Console;

namespace Ch10Test02
{
    class MyDerivedClasss : MyClass
    {
        public override string GetString() => base.GetString() + ", output from derived class";

        //protected void Test()
        //{
        //    MyClass a = new MyClass();
        //    //WriteLine(a.myString);
        //}
    }
}
