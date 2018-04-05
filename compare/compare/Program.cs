using System;
using System.Collections;
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
            Console.WriteLine();

            // 值比较
            // 运算符重载
            AddClass1 op1 = new AddClass1();
            op1.val = 5;
            AddClass1 op2 = new AddClass1();
            op2.val = 5;
            bool isSame = op1 == op2;   // 是否引用同一个对象, 非验证值相等
            AddClass1 op3 = op1 + op2;
            AddClass1 op4 = -op1;
            Console.WriteLine($"isSame = {isSame}.");
            Console.WriteLine($"op1.val + op2.val = {op3.val}.");
            Console.WriteLine($"-op1.val = {op4.val}.");
            Console.WriteLine();

            // 列表排序
            ArrayList list = new ArrayList();
            list.Add(new Person("Rual", 30));
            list.Add(new Person("Donna", 25));
            list.Add(new Person("Mary", 27));
            list.Add(new Person("Ben", 44));
            Console.WriteLine("Unsorted people:");
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"{(list[i] as Person).Name} ({(list[i] as Person).Age})");
            Console.WriteLine();
            Console.WriteLine("People sorted with nondefault comparer (by name):");
            list.Sort(PersonComparerName.Default);
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"{(list[i] as Person).Name} ({(list[i] as Person).Age})");

            // 转换
            ConvClass1 conv1 = new ConvClass1();
            conv1.val = 3;
            ConvClass2 conv2 = conv1;   // implicit 隐式转换
            ConvClass2 conv3 = new ConvClass2();
            conv3.val = 3;
            // conv3.val = 3e15;   // System.OverflowException
            ConvClass1 conv4 = (ConvClass1)conv3;   // explicit 显式转换

            // as
            Console.WriteLine();

            AsClassA MyAnimal = new AsClassA();
            AsClassD MyCow = MyAnimal as AsClassD;
            // MyAnimal ==null

            AsClassD MyCow2 = new AsClassD();
            AsClassA MyAnimal2 = MyCow2;
            AsClassD MyNewCow2 = MyAnimal2 as AsClassD;
            // MyNewCow2 包含 MyCow2引用
            MyCow2.MilkCow(MyCow2);
            MyCow2.MilkCow(MyNewCow2);

            Console.ReadKey();
        }
    }
}
