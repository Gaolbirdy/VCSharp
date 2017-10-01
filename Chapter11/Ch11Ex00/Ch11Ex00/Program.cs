using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace Ch11Ex00
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Animals2 animalCollection2 = new Animals2();
            animalCollection2.Add("Animal0", new Animal("popo"));
            foreach (DictionaryEntry myEntry in animalCollection2)
            {
                WriteLine($"New {myEntry.Value.ToString()} object added to " +
                    $"custom collection, Name = {((Animal)myEntry.Value).Name}");
            }

            Animals3 animalCollection3 = new Animals3();
            animalCollection3.Add("Animal0", new Animal("gaolbird"));
            foreach (Animal myAnimal in animalCollection3)
            {
                WriteLine($"New {myAnimal.ToString()} object added to " +
                    $"custom collection, Name = {myAnimal.Name}");
            }

            foreach (string item in SimpleList())
            {
                WriteLine(item);
            }

            Cloner mySource = new Cloner(5);
            Cloner myTarget = (Cloner)mySource.Clone();
            WriteLine($"myTarget.MyContent.Val = {myTarget.MyContent.Val}");
            mySource.MyContent.Val = 2;
            WriteLine($"myTarget.MyContent.Val = {myTarget.MyContent.Val}");
            myTarget.MyContent.Val = 10;
            WriteLine($"myTarget.MyContent.Val = {myTarget.MyContent.Val}");
            WriteLine($"mySource.MyContent.Val = {mySource.MyContent.Val}");

            MyStruct valType1 = new MyStruct();
            valType1.Val = 5;
            IMyInterface refType = valType1;
            valType1.Val = 6;
            MyStruct valType2 = (MyStruct)refType;
            WriteLine($"valType2.Val = {valType2.Val}");
            WriteLine();

            AndClass1 op1 = new AndClass1();
            op1.Val = 5;
            AndClass1 op2 = new AndClass1();
            op2.Val = 5;
            //WriteLine(op1 + op2);
            AndClass1 op3 = op1 + op2;
            WriteLine(op3.Val);
            WriteLine((-op3).Val);
            bool op4 = op1 == op2;
            WriteLine(op4);
            WriteLine();

            AndClass2 op5 = new AndClass2();
            op5.Val = 5;
            AndClass3 op6 = new AndClass3();
            op6.Val = 5;
            AndClass4 op7 = op5 + op6;
            op7 = op6 + op5;
            WriteLine(op7.Val);
            WriteLine();
            

            string firstString = "Fisrt String";
            string secendString = "Second String";
            WriteLine($"Comparing '{firstString}' and '{secendString}' " + $"result: {Comparer.Default.Compare(firstString,secendString)}");
            int firstNumber = 35;
            int secondNumber = 13;
            WriteLine($"Comparing '{firstNumber}' and '{secondNumber}' " + $"result: {Comparer.Default.Compare(firstNumber, secondNumber)}");

            ConvClass1 op01 = new ConvClass1();
            op01.Val = 3;
            ConvClass2 op02 = op01;

            ConvClass2 op03 = new Ch11Ex00.ConvClass2();
            op03.Val = 3e5;
            ConvClass1 op04 = (ConvClass1)op03;
            test();
            ReadKey();
        }
        public static IEnumerable SimpleList()
        {
            yield return "string 1";
            yield return "string 2";
            //yield break;
            yield return "string 3";
            //yield return 1;
        }
        public static void test()
        {
            WriteLine(x.ToString());
        }
        public static ConvClass1 x = new ConvClass1();
    }

    public class ConvClass1
    {
        public int Val;
        public static implicit  operator ConvClass2(ConvClass1 op1)
        {
            ConvClass2 returnVal = new Ch11Ex00.ConvClass2();
            returnVal.Val = op1.Val;
            return returnVal;
        }
    }
    public class ConvClass2
    {
        public double Val;
        public string Str;
        public static explicit operator ConvClass1(ConvClass2 op1)
        {
            ConvClass1 returnVal = new Ch11Ex00.ConvClass1();
            checked { returnVal.Val = (int)op1.Val; };
            return returnVal;
        }
    }

    public class AndClass1
    {
        public int Val;
        public static AndClass1 operator +(AndClass1 op1, AndClass1 op2)
        {
            AndClass1 returnVal = new AndClass1();
            returnVal.Val = op1.Val + op2.Val;
            return returnVal;
        }
        public static AndClass1 operator -(AndClass1 op1)
        {
            AndClass1 returnVal = new AndClass1();
            returnVal.Val = -op1.Val;
            return returnVal;
        }
        public static bool operator >=(AndClass1 op1, AndClass1 op2) => (op1.Val >= op2.Val);
        public static bool operator <(AndClass1 op1, AndClass1 op2) => !(op1 >= op2);
        public static bool operator <=(AndClass1 op1, AndClass1 op2) => (op1.Val <= op2.Val);
        public static bool operator >(AndClass1 op1, AndClass1 op2) => !(op1 <= op2);

        public static bool operator ==(AndClass1 op1, AndClass1 op2) => (op1.Val == op2.Val);
        public static bool operator !=(AndClass1 op1, AndClass1 op2) => !(op1 == op2);
        public override bool Equals(object op1)
        {
            if(op1 is AndClass1)
                if(op1.GetType() == typeof(AndClass1))
                    return Val == ((AndClass1)op1).Val;
                else
                    throw new ArgumentException("Canot compare AndClass1 objects with object of type", op1.GetType().ToString());
            else
            {
                throw new ArgumentException("Canot compare AndClass1 objects with object of type", op1.GetType().ToString());
            }
        }
        public override int GetHashCode() => Val;
    }

    public class AndClass2
    {
        public int Val;
        public static AndClass4 operator +(AndClass2 op1,AndClass3 op2)
        {
            AndClass4 returnVal = new AndClass4();
            returnVal.Val = op1.Val + op2.Val;
            return returnVal;
        }
        public static AndClass4 operator +(AndClass3 op1, AndClass2 op2)
        {
            AndClass4 returnVal = new AndClass4();
            returnVal.Val = op1.Val + op2.Val;
            return returnVal;
        }
    }
    public class AndClass3
    {
        public int Val;
    }
    public class AndClass4
    {
        public int Val;
    }

    public class Animal
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal()
        {
            name = "The animal with no name";
        }
        public Animal(string newName)
        {
            name = newName;
        }
        public void Feed() => WriteLine($"{name} has been fed.");
    }

    public class Animals : CollectionBase
    {
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }
        public void Remove(Animal oldAnimal)
        {
            List.Remove(oldAnimal);
        }
        public Animals() { }
    }

    public class Animals2 : DictionaryBase
    {
        public void Add(string newID, Animal newAnimal)
        {
            Dictionary.Add(newID, newAnimal);
        }
        public void Remove(string animalID)
        {
            Dictionary.Remove(animalID);
        }
        public Animals2() { }
        public Animal this[string animalID]
        {
            get { return (Animal)Dictionary[animalID]; }
            set { Dictionary[animalID] = value; }
        }
    }

    public class Animals3 : DictionaryBase
    {
        public void Add(string newID, Animal newAnimal)
        {
            Dictionary.Add(newID, newAnimal);
        }
        public void Remove(string animalID)
        {
            Dictionary.Remove(animalID);
        }
        public Animals3() { }
        public Animal this[string animalID]
        {
            get { return (Animal)Dictionary[animalID]; }
            set { Dictionary[animalID] = value; }
        }
        public new IEnumerator GetEnumerator()
        {
            foreach (object animal in Dictionary.Values)
            {
                yield return (Animal)animal;
            }
        }
    }

    public class Content
    {
        public int Val;
    }

    public class Cloner : ICloneable
    {
        public Content MyContent = new Content();
        public Cloner(int newVal)
        {
            MyContent.Val = newVal;
        }
        public object GetCopy() => MemberwiseClone();
        public object Clone()
        {
            Cloner clonedCloner = new Cloner(MyContent.Val);
            return clonedCloner;
        }
    }

    interface IMyInterface { }
    
    struct MyStruct : IMyInterface
    {
        public int Val;
    }
}
