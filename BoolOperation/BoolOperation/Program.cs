using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using static ... 允许使用静态类的方法
using static System.Console;
using static System.Convert;

namespace BoolOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter an integer:");
            int myInt = ToInt32(ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            WriteLine($"isLessThan10:{isLessThan10}");
            WriteLine($"isBetween0And5:{isBetween0And5}");
            WriteLine($"is exactly one of above is true:{isLessThan10 ^ isBetween0And5}");
            ReadKey();
        }
    }
}
