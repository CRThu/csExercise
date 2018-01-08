using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, next;
            string userName;
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine($"welcome {userName}!");
            Console.WriteLine("Enter first number:");
            first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter next number:");
            next = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The + of {first}&{next}" + "=" + $"{first + next}.");
            Console.WriteLine($"The - of {first}&{next}" + "=" + $"{first - next}.");
            Console.WriteLine($"The * of {first}&{next}" + "=" + $"{first * next}.");
            Console.WriteLine($"The / of {first}&{next}" + "=" + $"{first / next}.");
            Console.WriteLine($"The % of {first}&{next}" + "=" + $"{first % next}.");
            Console.ReadKey();
        }
    }
}
