using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare
{
    interface IMyInterface { }
    class ClassA : IMyInterface { }
    class ClassB : IMyInterface { }
    class ClassC { }
    class ClassD : ClassA { }
    struct MyStruct : IMyInterface
    {
        public int Val;
    }
    class MyClass1
    {
        public int Val;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 封箱&拆箱

            // struct
            MyStruct valType1 = new MyStruct();
            valType1.Val = 5;
            // object 对象副本的引用
            object refType = valType1;  // 封箱
            valType1.Val = 6;
            MyStruct valType2 = (MyStruct)refType;  // 拆箱
            Console.WriteLine($"valType2.Val = {valType2.Val}");

            // class
            MyClass1 valType3 = new MyClass1();
            valType3.Val = 5;
            object refType2 = valType3;
            valType3.Val = 6;
            MyClass1 valType4 = (MyClass1)refType2;
            Console.WriteLine($"valType4.Val = {valType4.Val}");

            // struct 实现接口将值类型封箱到接口类型
            MyStruct valType5 = new MyStruct();
            valType5.Val = 5;
            IMyInterface refType3 = valType5;
            valType5.Val = 6;
            MyStruct valType6 = (MyStruct)refType3;
            Console.WriteLine($"valType6.Val = {valType6.Val}");
            Console.WriteLine();

            // is
            // <operand> is <type>
            Checker check = new Checker();
            ClassA try1 = new ClassA();
            ClassB try2 = new ClassB();
            ClassC try3 = new ClassC();
            ClassD try4 = new ClassD();
            MyStruct try5 = new MyStruct();
            object try6 = try5;
            Console.WriteLine("Analyzing ClassA type variable:");
            check.Check(try1);
            Console.WriteLine("\nAnalyzing ClassB type variable:");
            check.Check(try2);
            Console.WriteLine("\nAnalyzing ClassC type variable:");
            check.Check(try3);
            Console.WriteLine("\nAnalyzing ClassD type variable:");
            check.Check(try4);
            Console.WriteLine("\nAnalyzing MyStruct type variable:");
            check.Check(try5);
            Console.WriteLine("\nAnalyzing boxed MyStruct type variable:");
            check.Check(try6);

            Console.ReadKey();
        }
    }
}
