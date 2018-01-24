using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace structFunction
{
    struct CustomerName
    {
        public string firstName, lastName;
        public string Name() => firstName + " " + lastName;
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomerName myCustomer;
            myCustomer.firstName = "John";
            myCustomer.lastName = "Franklin";
            WriteLine($"{myCustomer.firstName} {myCustomer.lastName}");
            WriteLine(myCustomer.Name());
            ReadKey();
        }
    }
}
