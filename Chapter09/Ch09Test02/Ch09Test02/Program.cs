using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //B b = new B();
            A a = new D();
            //A a;
            //B b;

            //C c;
            //C c = new C();
            C c = C.CreaSelf();
        }
    }

    abstract class A
    {

    }

    static class B
    {

    }

    class C
    {
        private C() { }
        static public C CreaSelf()
        {
            //C self = new C();
            //return self;
            return new C();
        }
    }

    class D : A
    {

    }
}
