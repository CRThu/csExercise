using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DelegateReadLine
{
    class Program
    {
        delegate string ReadLineDelegate();
        static void Main(string[] args)
        {
            ReadLineDelegate readLine = new ReadLineDelegate(ReadLine);
            WriteLine("Type a string:");
            string userInput = readLine();
            WriteLine($"You typed: {userInput}");
            ReadKey();
        }
    }
}
