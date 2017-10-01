using static System.Console;

namespace Ch09Ex03
{
    class MyClass
    {
        public int val;
    }

    struct myStruct
    {
        public int val;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass objectA = new MyClass();
            MyClass objectB = new MyClass();
            WriteLine($"objectA == objectB? {objectA == objectB}");
            MyClass objectC = objectB;
            WriteLine($"objectC == objectB? {objectC == objectB}");
            objectB = objectA;
            WriteLine($"objectA == objectB? {objectA == objectB}");
            WriteLine($"objectA == objectC? {objectA == objectC}");
            WriteLine(objectA);
            WriteLine(objectB);

            WriteLine($"objectA.val = {objectA.val}");
            WriteLine($"objectB.val = {objectB.val}");
            WriteLine($"objectC.val = {objectC.val}");
            WriteLine();

            objectA.val = 10;
            WriteLine($"objectA.val = {objectA.val}");
            WriteLine($"objectB.val = {objectB.val}");
            WriteLine($"objectC.val = {objectC.val}");
            WriteLine();

            objectB.val = 20;
            myStruct structA = new myStruct();
            myStruct structB = structA;
            WriteLine(structA);
            WriteLine(structB);

            WriteLine($"structA.val = {structA.val}");
            WriteLine($"structB.val = {structB.val}");
            WriteLine();

            structA.val = 30;
            WriteLine($"structA.val = {structA.val}");
            WriteLine($"structB.val = {structB.val}");
            WriteLine();

            structB.val = 40;
            WriteLine($"objectA.val = {objectA.val}");
            WriteLine($"objectB.val = {objectB.val}");
            WriteLine($"objectC.val = {objectC.val}");
            WriteLine($"structA.val = {structA.val}");
            WriteLine($"structB.val = {structB.val}");
            WriteLine();

            structB = structA;
            WriteLine($"structA.val = {structA.val}");
            WriteLine($"structB.val = {structB.val}");

            ReadKey();
        }
    }
}
