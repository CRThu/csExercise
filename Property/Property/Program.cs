using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        class MyClass
        {
            // Field used by property.
            private int myInt;
            // Property.
            public int MyIntProp1   // 对MyInt字段进行访问
            {
                get { return myInt; }   // Property get code.
                set { myInt = value; }  // Property set code.
            }
            public int MyIntProp2   // 对MyInt字段进行检测, 若不符合抛出异常
            {
                set
                {
                    if (value >= 0 && value <= 10)
                        myInt = value;
                    else
                        throw (new ArgumentOutOfRangeException("MyIntProp2", value, "MyIntProp2得到0~10范围外的值."));
                }
            }
            public int MyIntProp3   // 对MyInt字段set方法进行限制
            {
                get { return myInt; }   // Property get code.
                protected set { myInt = value; }  // Property set code.
            }
            public int MyIntProp4 => (myInt * 2);   // 基于表达式的属性

            // 重构成员 refactoring
            public string MyString  // 自动生成
            {
                get { return myString; }
                set { myString = value; }
            }
            private string myString; // 右键 - 快速操作和重构

            // 自动属性
            // 键入prop后两次Tab
            public int MyProperty { get; set; }
            public int MyPropertyReadonly1 { get; }
            public int MyPropertyReadonly2 { get; } = 9;
        }
        static void Main(string[] args)
        {
            MyClass myObj = new MyClass();
            myObj.MyIntProp1 = 1;   // MyIntProp的set方法
            Console.WriteLine($"myObj.MyIntProp1.get : {myObj.MyIntProp1}");   // MyIntProp1的get方法
            Console.WriteLine();

            for (int i = -1; i <= 11; i++)
            {
                try
                {
                    Console.WriteLine($"myObj.MyIntProp2.set : " + i + ".");
                    myObj.MyIntProp2 = i;  // MyIntProp2的set方法
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            // myObj.MyIntProp3 = 1;   // MyIntProp3不可访问

            Console.WriteLine();
            Console.WriteLine($"myObj.MyIntProp1.get : {myObj.MyIntProp1}");   // MyIntProp1的get方法
            Console.WriteLine($"myObj.MyIntProp4.get : {myObj.MyIntProp4}");   // MyIntProp1的get方法

            Console.ReadKey();
        }
    }
}
