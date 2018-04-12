using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalCollection = new List<Animal>();
            animalCollection.Add(new Cow("Rual"));
            animalCollection.Add(new Chicken("Donna"));
            foreach (Animal myAnimal in animalCollection)
                myAnimal.Feed();

            Console.WriteLine();

            // List<T> 的搜索和排序
            Vectors route = new Vectors();
            route.Add(new Vector(2.0, 90.0));
            route.Add(new Vector(1.0, 180.0));
            route.Add(new Vector(0.5, 45.0));
            route.Add(new Vector(2.5, 315.0));
            Console.WriteLine(route.Sum()); // 输出集合项

            // Comparison<Vector> sorter = new Comparison<Vector>(VectorDelegates.Compare);    // 创建排序委托
            // route.Sort(sorter);
            route.Sort(VectorDelegates.Compare);
            Console.WriteLine(route.Sum()); // 输出排序后的集合

            Predicate<Vector> searcher = new Predicate<Vector>(VectorDelegates.TopRightQuadrant);   // 创建搜索委托
            Vectors topRightQuadrantRoute = new Vectors(route.FindAll(searcher));
            Console.WriteLine(topRightQuadrantRoute.Sum());

            // Dictionary<K, V>
            Dictionary<string, int> things = new Dictionary<string, int>();
            // 不区分大小写比较字符串键
            // Dictionary<string, int> things = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);

            // 不允许相同的键
            things.Add("Green Things", 29);
            things.Add("Blue Things", 94);
            things.Add("Yellow Things", 34);
            things.Add("Red Thing", 52);
            things.Add("Brown Things", 27);

            foreach (string key in things.Keys)
                Console.WriteLine(key);
            foreach (int value in things.Values)
                Console.WriteLine(value);
            foreach (KeyValuePair<string, int> thing in things)
                Console.WriteLine($"{thing.Key} = {thing.Value}");

            Console.ReadKey();
        }
    }
}
