using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    // Animals集合
    // CollectionBase类和indexer索引符
    public class Animals : CollectionBase
    {
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }
        public void Remove(Animal newAnimal)
        {
            List.Remove(newAnimal);
        }
        public Animal this[int animalIndex]
        {
            get { return (Animal)List[animalIndex]; }
            set { List[animalIndex] = value; }
        }
    }
}
