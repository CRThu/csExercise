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
            Console.WriteLine("MyDerivedClass.MyDerivedClass(inti,int j)");
        }
    }   // 派生类

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyDerivedClass myObj = new MyDerivedClass();");
            // System.Object.Object()
            // MyBaseClass.MyBaseClass()
            // MyDerivedClass.MyDerivedClass()
            MyDerivedClass myObj = new MyDerivedClass();


        }
    }
}
