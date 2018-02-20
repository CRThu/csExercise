using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMember
{
    // 不写new可以隐藏基类, 但会产生警告CS0108
    class MyBaseClassNothing
    {
        public void DoSomething() => Console.WriteLine("MyBaseClassNothing.DoSomething()");
    }
    class MyDerivedClassNothing : MyBaseClassNothing
    {
        public void DoSomething() => Console.WriteLine("MyDerivedClassNothing.DoSomething()");  // CS0108
    }
    // 等同于使用new, 显式表明隐藏该成员
    class MyDerivedClassNew : MyBaseClassNothing
    {
        new public void DoSomething() => Console.WriteLine("MyDerivedClassNew.DoSomething()");
    }

    // virtual和override用于重写
    public class MyBaseClassVirtual
    {
        public virtual void DoSomething() => Console.WriteLine("MyBaseClassVirtual.DoSomething()");
    }
    public class MyDerivedClassOverride : MyBaseClassVirtual
    {
        public override void DoSomething() => Console.WriteLine("MyDerivedClassOverride.DoSomething()");
    }
}
