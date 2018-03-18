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
        // IList接口
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }
        public void Remove(Animal newAnimal)
        {
            List.Remove(newAnimal);
        }
        // 索引符
        public Animal this[int animalIndex]
        {
            get { return (Animal)List[animalIndex]; }
            set { List[animalIndex] = value; }
        }
    }
    // Animals2集合
    // DictionaryBase类
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
}
