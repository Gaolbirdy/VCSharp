using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch11Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Create an Array type colletion of Animal objects and use it:");
            Animal[] animalArray = new Animal[2];
            Cow myCow1 = new Cow("Lea");
            animalArray[0] = myCow1;
            animalArray[1] = new Chicken("Noa");
            foreach (Animal myAnimal in animalArray)
            {
                WriteLine($"New {myAnimal.ToString()} object added to Array colletion, Name = {myAnimal.Name}");
                //WriteLine($"New {myAnimal} object added to Array colletion, Name = {myAnimal.Name}");
                //WriteLine($"New {myAnimal.GetType()} object added to Array colletion, Name = {myAnimal.Name}");
            }
            WriteLine($"Array collection contains {animalArray.Length} objects.");
            animalArray[0].Feed();
            ((Chicken)animalArray[1]).LayEgg(); //why (Chicken)
            WriteLine();

            WriteLine("Create an ArrayList type colletion of Animal objects and use it:");
            ArrayList animalArrayList = new ArrayList();
            Cow myCow2 = new Cow("Rual");
            animalArrayList.Add(myCow2);
            animalArrayList.Add(new Chicken("Andrea"));
            foreach (Animal myAnimal in animalArrayList)
            {
                WriteLine($"New {myAnimal.ToString()} object added to ArrayList colletion, Name = {myAnimal.Name}");
            }
            WriteLine($"ArrayList collection contains {animalArrayList.Count} objects.");
            ((Animal)animalArrayList[0]).Feed();
            ((Chicken)animalArrayList[1]).LayEgg();
            WriteLine();

            WriteLine("Additional manipulation of ArrayList:");
            animalArrayList.RemoveAt(0);
            //WriteLine(animalArrayList[0]);
            ((Animal)animalArrayList[0]).Feed();
            animalArrayList.AddRange(animalArray);
            //WriteLine(animalArrayList.Count);
            ((Chicken)animalArrayList[2]).LayEgg();
            WriteLine($"The animal called {myCow1.Name} is at " +
                $"index {animalArrayList.IndexOf(myCow1)}.");
            myCow1.Name = "Mary";
            WriteLine($"The animal is now called {((Animal)animalArrayList[1]).Name}.");
            WriteLine();

            WriteLine("Using custom collection class Animals:");
            Animals animalCollection = new Animals();
            animalCollection.Add(new Cow("Lea"));
            foreach (Animal myAnimal in animalCollection)
            {
                WriteLine($"New {myAnimal.ToString()} object added to custom collcetion, Name = {myAnimal.Name}");
            }
            animalCollection[0].Feed();
            ReadKey();
        }
    }
}
