using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassAndStruct
{
    class MyClass
    {
        public int val;
    }
    struct myStruct
    {
        public int val;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // class 传引用
            MyClass objectA = new MyClass();
            MyClass objectB = objectA;  // 传指针
            objectA.val = 10;
            objectB.val = 20;
            WriteLine($"objectA.val = {objectA.val}");
            WriteLine($"objectB.val = {objectB.val}");
            // struct 传值
            myStruct structA = new myStruct();
            myStruct structB = structA; // 传值
            structA.val = 30;
            structB.val = 40;
            WriteLine($"structA.val = {structA.val}");
            WriteLine($"structB.val = {structB.val}");
            ReadKey();
        }
    }
}
