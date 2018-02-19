using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMember
{
    class MyClass
    {
        // 成员定义 :
        // static : 静态成员, class level, 所有实例共享
        // 修饰符 :
        // public : 成员可以由任何代码访问
        // private : 成员只能由类中的代码访问 (默认)
        // internal : 成员只能由定义它的程序集/项目的内部代码访问
        // protected : 成员只能由类或派生类的代码访问
        // 定义字段
        // const : 静态常量, 在声明时被初始化
        // readonly : 动态常量, 只能在执行构造函数的过程中赋值或初始化赋值语句赋值
        public int MyInt;
        public readonly int MyReadonlyInt = 17;
        public static int MyStaticInt;
        // 定义方法
        // virtual : 方法可以重写
        // abstract : 方法必须在非抽象的派生类中重写 (只用于抽象类中)
        // override : 方法重写了一个基类方法 (如果方法被重写, 就必须使用该关键字)
        // extern : 方法定义放在其他地方
        public string GetString() => "Here is a string, MyIntProp = " + MyIntProp;
        public override string ToString() => "Override : " + base.ToString();
        public virtual void DoString()
        {
            // Base implementation.
        }
        // 定义属性
        // Field used by property.
        private int MyPrivateInt;
        // Property.
        public int MyIntProp
        {
            // 访问器 get/set
            get
            {
                // Property get code.
                return MyPrivateInt;
            }
            // protected set
            set
            {
                // Property set code.
                if (value >= 0 && value <= 10)
                    MyPrivateInt = value;   // value 等于类型与属性相同的一个值
                else
                    throw (new ArgumentOutOfRangeException("MyIntProp", value, "MyIntProp must be assigned a value between 0 and 10."));
            }
        }
        // Field used by property.
        private int myDoubledInt = 5;
        // Property.
        public int MyDoubledIntProp => (myDoubledInt * 2);

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
    class MyDerivedClass : MyClass
    {
        public override sealed void DoString()  // sealed 指定不能再有派生类重写
        {
            // Derived class implementation, overrides base implementation.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObj = new MyClass();
            for (int i = -1; i <= 11; i++)
            {
                try
                {
                    Console.WriteLine($"{i} is testing :");
                    myObj.MyIntProp = i;    // 试图写入 MyIntProp 访问器
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception {e.GetType().FullName} thrown.");
                    Console.WriteLine($"{e.Message}");
                }
            }

            Console.WriteLine();

            Console.Write("myObj.ToString() : ");
            Console.WriteLine(myObj.ToString());

            Console.Write("myObj.MyDoubledIntProp = ");
            Console.WriteLine(myObj.MyDoubledIntProp);

            Console.ReadKey();
        }
    }
}
