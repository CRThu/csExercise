using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableType
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            string myStr,myAtStr,myFileStr;
            myInt = 123456;
            myStr = "\"myInt\" is";
            myAtStr = @"This string has a
line break.";
            myFileStr = @"C:\Users";
            Console.WriteLine($"{myStr} {myInt}");
            Console.WriteLine("This string has a\nline break.");
            Console.WriteLine(myAtStr);
            Console.WriteLine(myFileStr);
            Console.ReadKey();
        }
    }
}
