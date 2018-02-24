using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMember
{
    // 不允许使用public/private/protected/internal,所有接口成员都是隐式公共的
    // 接口成员不能包含代码体
    // 接口不能定义字段成员
    // 不能用static/virtual/abstract/sealed来定义接口成员
    // 类型定义成员是禁止的
    // 若需要从基接口继承成员,使用new来定义
    interface IMyBaseInterface
    {
        // Interface members.
        void DoSomething();
        void DoSomethingElse();
    }
    interface IMyDerivedInterface : IMyBaseInterface
    {
        int MyInt { get; /*set;*/ }
        new void DoSomething();
    }
    class MyInterfacePropertyClass: MyDerivedInterfaceClass, IMyDerivedInterface
    {
        public int MyInt { get; protected set; }    // 类的代码可以访问该存取器, 接口的代码不可以访问该存取器
    }
    // 可使用virtual/abstract来实现接口成员
    class MyInterfaceClass
    {
        public void DoSomething() => Console.WriteLine("MyInterfaceClass.DoSomething()");   // 可以在基类实现接口成员
    }
    class MyDerivedInterfaceClass : MyInterfaceClass, IMyBaseInterface
    {
        void IMyBaseInterface.DoSomething()=> Console.WriteLine("MyDerivedInterfaceClass.IMyBaseInterface.DoSomething()");  // 显式指定
        public void DoSomethingElse() => Console.WriteLine("MyDerivedInterfaceClass.DoSomethingElse()");    // 隐式指定
    }
    class MyVitualInterfaceClass : IMyBaseInterface
    {
        public virtual void DoSomething() => Console.WriteLine("MyVitualInterfaceClass.DoSomething()");
        public virtual void DoSomethingElse() => Console.WriteLine("MyVitualInterfaceClass.DoSomethingElse()");
    }
    class MyOverrideInterfaceClass : MyVitualInterfaceClass // override关键字通过接口访问基类或派生类都使用派生类代码
    {
        public override void DoSomething() => Console.WriteLine("MyOverrideInterfaceClass.DoSomething()");
    }
    class MyNewInterfaceClass : MyVitualInterfaceClass  // new关键字通过接口访问基类或派生类都使用基类代码
    {
        public new void DoSomething() => Console.WriteLine("MyNewInterfaceClass.DoSomething()");
    }
}
