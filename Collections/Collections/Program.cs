using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    // Collections中接口提供基本的集合功能
    // IEnumerable 可以迭代集合中的项
    // ICollection(继承与IEnumerable)可以获取集合项的个数, 并能把项复制到一个简单的数组类型中
    // IList(继承IEnumerable和ICollection)提供了集合的项列表, 允许访问这些项,并提供其他一些于项列表的基本功能
    // IDictionary(继承Ienumerable和ICollection)类似于IList, 但提供了可通过键值(而不是索引)访问的项列表
    // System.Array类实现了IList/ICollection/IEnumerable, 但不支持IList的一些更高级的功能, 它表示大小固定的项列表
    class Program
    {
        static void Main(string[] args)
        {
            // Array测试
            // 固定大小初始化数组
            Console.WriteLine("Create an Array type collection of Animal objects and use it:");
            Animal[] animalArray = new Animal[2];
            Cow myCow1 = new Cow("Lea");
            animalArray[0] = myCow1;
            animalArray[1] = new Chicken("Noa");
            foreach (Animal myAnimal in animalArray)
                Console.WriteLine($"New {myAnimal.ToString()} object added to Array collection, Name = {myAnimal.Name}");
            Console.WriteLine($"Array collection contains {animalArray.Length} objects.");
            animalArray[0].Feed();
            ((Chicken)animalArray[1]).LayEgg(); // 转换Chicken
            Console.WriteLine();
            // ArrayList测试
            // 可扩展大小
            Console.WriteLine("Create an ArrayList type collection of Animal objects and use it:");
            ArrayList animalArrayList = new ArrayList();
            Cow myCow2 = new Cow("Rual");
            animalArrayList.Add(myCow2);
            animalArrayList.Add(new Chicken("Andrea"));
            foreach (Animal myAnimal in animalArrayList)
                Console.WriteLine($"New {myAnimal.ToString()} object added to ArrayList collection, Name = {myAnimal.Name}");
            Console.WriteLine($"ArrayList collection contains {animalArrayList.Count} objects.");
            ((Animal)animalArrayList[0]).Feed();    // 转换Animal
            ((Chicken)animalArrayList[1]).LayEgg(); // 转换Chicken
            Console.WriteLine();
            Console.WriteLine("Additional manipulation of ArrayList:");
            animalArrayList.RemoveAt(0);    // 删除列表中第一项
            // animalArrayList.Remove(myCow2);  // 删除列表中指定项
            ((Animal)animalArrayList[0]).Feed();    // 转换为Animal
            animalArrayList.AddRange(animalArray);  // 增加数组
            ((Chicken)animalArrayList[2]).LayEgg(); // 转换Chicken
            Console.WriteLine($"The animal called {myCow1.Name} is at index {animalArrayList.IndexOf(myCow1)}.");
            myCow1.Name = "Mary";
            Console.WriteLine($"The animal is now called {((Animal)animalArrayList[1]).Name}");
            // 测试Animals类
            Console.WriteLine();
            Animals animalCollection = new Animals();
            animalCollection.Add(new Cow("Donna"));
            animalCollection.Add(new Chicken("Kevin"));
            foreach (Animal myAnimal in animalCollection)
                myAnimal.Feed();
            // 测试Animals2类
            Console.WriteLine();
            Animals2 animalCollection2 = new Animals2();
            animalCollection2.Add("Donna",new Cow("Donna"));
            animalCollection2.Add("Kevin", new Chicken("Kevin"));
            // 未实现简单迭代器
            // foreach (DictionaryEntry myEntry in animalCollection2)
            //    Console.WriteLine($"New {myEntry.Value.ToString()} object added to custom collection, Name = {((Animal)myEntry.Value).Name}");
            foreach (Animal myAnimal in animalCollection2)
                Console.WriteLine($"New {myAnimal.ToString()} object added to custom collection, Name = {myAnimal.Name}");
            Console.ReadKey();
        }
    }
}
