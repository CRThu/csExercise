using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace switchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "benjamin";
            const string niceName = "andrea";
            const string sillyName = "ploppy";
            string name;
            WriteLine("What is your name?");
            name = ReadLine();
            switch(name.ToLower())
            {
                //C# switch的case一般情况下必须有break
                case myName:
                    WriteLine("You have the same name as me!");
                    break;
                case niceName:
                    WriteLine("My,what a nice name you have!");
                    break;
                case sillyName:
                    WriteLine("That's a very silly name");
                    break;
            }
            WriteLine($"Hello {name}!");
            ReadKey();
        }
    }
}
