using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMember
{

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObj = new MyClass();
            Console.WriteLine($"Created myObj, Name = " + myObj.Name);
            Console.WriteLine();
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

            Console.WriteLine();
            Console.WriteLine("隐藏和重写测试 :");
            MyBaseClassNothing myBaseClassNothing1 = new MyDerivedClassNothing();    // 使用派生类构造函数构造基类
            myBaseClassNothing1.DoSomething();  // 基类的函数被隐藏
            MyBaseClassNothing myBaseClassNothing2 = new MyDerivedClassNew();   // 不加相当于new
            myBaseClassNothing2.DoSomething();  // 基类的函数被隐藏
            MyBaseClassVirtual myBaseClassVirtual = new MyDerivedClassOverride();   // 重写
            myBaseClassVirtual.DoSomething();   // 基类的函数被重写
            // base关键字
            MyBaseClassVirtual myBaseClassVirtualUsingBase = new MyDerivedClassUsingBaseOverride(); // 使用基类
            myBaseClassVirtualUsingBase.DoSomething();  // 派生类引用基类成员
            // this关键字
            MyTestClass myTestClass = new MyTestClass();
            myTestClass.DoSomething();
            // class嵌套
            Console.WriteLine();
            MyNestedClassA myNestObject = new MyNestedClassA();
            Console.WriteLine($"myNestObject.State = {myNestObject.State}");
            MyNestedClassA.MyNestedClassB myOtherNestObject = new MyNestedClassA.MyNestedClassB();
            myOtherNestObject.SetPrivateState(myNestObject, 999);
            Console.WriteLine($"myNestObject.State = {myNestObject.State}");
            // 接口
            Console.WriteLine();
            MyDerivedInterfaceClass myDerivedInterfaceClass = new MyDerivedInterfaceClass();
            myDerivedInterfaceClass.DoSomething();  // 基类MyInterfaceClass实现
            myDerivedInterfaceClass.DoSomethingElse();  // 派生类MyDerivedInterfaceClass实现

            IMyBaseInterface iMyBaseInterface = new MyDerivedInterfaceClass();
            iMyBaseInterface.DoSomething(); // 显式指定的调用方法
            iMyBaseInterface.DoSomethingElse(); // 隐式指定的调用方法

            // partial
            Console.WriteLine();
            PartialClass partialClass = new PartialClass();
            partialClass.DoSomething();

            Console.ReadKey();
        }
    }
}
