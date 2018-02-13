using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorAndDestructor
{
    class MyPublicClass
    {
        public MyPublicClass()
        {
            // Constructor code.
        }   // 构造函数
    }
    class MyPrivateClass
    {
        private MyPrivateClass()
        {
            // Constructor code.
        }   // 私有构造函数,不可创建
    }
    class MyConstructorClass
    {
        public MyConstructorClass()
        {
            // Default constructor code.
        }
        public MyConstructorClass(int myInt)
        {
            // Default constructor code (uses myInt).
        }   // 添加非默认构造函数
    }
    class MyDestructorClass
    {
        ~MyDestructorClass()
        {
            // Destructor body.
        }   // 析构函数
    }

    // 使用基类的构造函数
    public class MyBaseClass
    {
        public MyBaseClass()
        {
            Console.WriteLine("MyBaseClass.MyBaseClass()");
        }
        public MyBaseClass(int i)
        {
            Console.WriteLine("MyBaseClass.MyBaseClass(int i)");
        }
    }   // 基类
    public class MyDerivedClass : MyBaseClass
    {
        public MyDerivedClass()
        {
            Console.WriteLine("MyDerivedClass.MyDerivedClass()");
        }
        public MyDerivedClass(int i)
        {
            Console.WriteLine("MyDerivedClass.MyDerivedClass(int i)");
        }
        public MyDerivedClass(int i,int j)
        {
            Console.WriteLine("MyDerivedClass.MyDerivedClass(int i, int j)");
        }
        public MyDerivedClass(int i, int j, int k) : base(i)
        {
            Console.WriteLine("MyDerivedClass.MyDerivedClass(int i, int j, int k) : base(i)");
        }       // 使用基类的(int i)构造函数
        public MyDerivedClass(int i, string k) : this(1, 2, 3)  // 使用当前类的(int i, int j, int k)构造函数
        {
            Console.WriteLine("MyDerivedClass.MyDerivedClass(int i, string k) : this(1, 2, 3)");
        }
    }   // 派生类

    class Program
    {
        static void Main(string[] args)
        {
            // 先基类构造函数到派生类构造函数

            Console.WriteLine("MyDerivedClass myObj1 = new MyDerivedClass();");
            // System.Object.Object()
            // MyBaseClass.MyBaseClass()
            // MyDerivedClass.MyDerivedClass()
            MyDerivedClass myObj1 = new MyDerivedClass();

            Console.WriteLine();

            Console.WriteLine("MyDerivedClass myObj2 = new MyDerivedClass(4);");
            // System.Object.Object()
            // MyBaseClass.MyBaseClass()
            // MyDerivedClass.MyDerivedClass(int i)
            MyDerivedClass myObj2 = new MyDerivedClass(4);

            Console.WriteLine();

            Console.WriteLine("MyDerivedClass myObj3 = new MyDerivedClass(4, 8);");
            // System.Object.Object()
            // MyBaseClass.MyBaseClass()
            // MyDerivedClass.MyDerivedClass(int i, int j)
            MyDerivedClass myObj3 = new MyDerivedClass(4, 8);

            Console.WriteLine();

            Console.WriteLine("MyDerivedClass myObj4 = new MyDerivedClass(4, 8, 12);");
            // System.Object.Object()
            // MyBaseClass.MyBaseClass(int i)
            // MyDerivedClass.MyDerivedClass(int i, int j, int k) : base(i)
            MyDerivedClass myObj4 = new MyDerivedClass(4, 8, 12);

            Console.WriteLine();

            Console.WriteLine("MyDerivedClass myObj5 = new MyDerivedClass(4,\"12\");");
            // System.Object.Object()
            // MyBaseClass.MyBaseClass(int i)
            // MyDerivedClass.MyDerivedClass(int i, int j, int k) : base(i)
            // MyDerivedClass(int i, string k) : this(1, 2, 3)
            MyDerivedClass myObj5 = new MyDerivedClass(4,"12");

            Console.ReadKey();
        }
    }
}
