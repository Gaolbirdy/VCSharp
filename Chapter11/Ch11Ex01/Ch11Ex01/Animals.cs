using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ch11Ex01
{
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
        public Animal this[int animalIndex] // 与属性类似，对象名[index]
        {
            get { return (Animal)List[animalIndex]; }
            set { List[animalIndex] = value; }
        }
    }
}
