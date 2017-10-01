using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch11Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animalColletion = new Animals();
            animalColletion.Add(new Cow("Donna"));
            animalColletion.Add(new Chicken("Kevin"));
            foreach (Animal myAnimal in animalColletion)
            {
                myAnimal.Feed();
                WriteLine(myAnimal.GetType());
            }
            ReadKey();
        }
    }
}
