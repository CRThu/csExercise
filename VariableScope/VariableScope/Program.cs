using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VariableScope
{
    class Program
    {
        static string myString;
        static void Write()
        {
            string myString = "String defined in Write()";
            WriteLine("Now in Write()");
            WriteLine($"Local myString = {myString}");
            WriteLine($"Global myString = {Program.myString}");
        }

        static void Main(string[] args)
        {
            string myString = "String defined in Main()";
            Program.myString = "Global string";
            Write();
            WriteLine("\nNow in Main()");
            WriteLine($"Local myString = {myString}");
            WriteLine($"Global myString = {Program.myString}");

            WriteLine("\nTest in Loop:");
            int i = 0;
            string text = "";
            for (i = 0; i < 10; i++)
            {
                text = "Line " + Convert.ToString(i);
                WriteLine($"{text}");
            }
            WriteLine($"Last text output in loop: {text}");
            ReadKey();
        }
    }
}