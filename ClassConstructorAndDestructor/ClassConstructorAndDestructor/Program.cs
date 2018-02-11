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

    // TODO

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
