using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMember
{
    interface IMyInterface1 { }
    interface IMyInterface2 { }
    // 应用部分类的接口也会应用于整个类
    public partial class PartialClass : IMyInterface1
    {
        // 总是私有的, 且不能有返回值
        // 不能使用out参数, 可以使用ref参数
        // 不能使用virtual/abstract/override/new/sealed/extern修饰符
        // 用于编译代码时, 不实现方法则忽略方法调用,提高性能
        partial void DoSomethingElse(); 
        public void DoSomething()
        {
            Console.WriteLine("DoSomething() execution started.");
            DoSomethingElse();
            Console.WriteLine("DoSomething() execution finished.");
        }
    }
    public partial class PartialClass : IMyInterface2
    {
        // 可以不实现此方法
        // partial void DoSomethingElse() => Console.WriteLine("DoSomethingElse() called.");
    }
    // 等同于
    public class OtherPartialClass : IMyInterface1, IMyInterface2
    {

    }
}
