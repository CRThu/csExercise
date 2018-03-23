using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator
{
    class Program
    {
        // 迭代器
        // yield return <value>;
        public static IEnumerable SimpleList()
        {
            yield return "string 1";
            yield return "string 2";
            yield return "string 3";
        }

        static void Main(string[] args)
        {
            foreach (string item in SimpleList())
                Console.WriteLine(item);

            Console.WriteLine();
            Primes primesFrom2To1000 = new Primes(2, 1000);
            foreach (long i in primesFrom2To1000)
                Console.Write($"{i} ");
            Console.ReadKey();
        }
    }
}
