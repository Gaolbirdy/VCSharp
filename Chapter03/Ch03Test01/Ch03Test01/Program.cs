using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Super;
using Super.Smashing;

namespace Ch03Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            YourClass NameInSuperSpace = new YourClass(); // need using Super;
            Great NameInSmashingSpace = new Great(); // need using Super.Smashing;
            Fabulous.MyClass NameInFabulous = new Fabulous.MyClass();
            Console.WriteLine(NameInSuperSpace);
            Console.WriteLine(NameInSmashingSpace);
            Console.WriteLine(NameInFabulous);
            Console.WriteLine(NameInFabulous.NameInSmashingSpace);
            Console.WriteLine(NameInFabulous.S);
            Small.DoSomething(); // can used by using static Super.Smashing.Small;
            Console.ReadKey();
        }
    }
}
