using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
namespace ifStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string comp;
            WriteLine("Enter a number:");
            double var1 = ToDouble(ReadLine());
            WriteLine("Enter another number:");
            double var2 = ToDouble(ReadLine());
            if (var1 < var2)
                comp = "less than";
            else
            {
                if (var1 == var2)
                    comp = "equal to";
                else
                    comp = "greater than";
            }
            WriteLine($"The first number is {comp} the second number.");
            ReadKey();
        }
    }
}
