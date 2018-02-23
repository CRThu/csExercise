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
    // 类型定义成员是静止的
    // 若需要从基接口继承成员,使用new来定义
    interface IMyBaseInterface
    {
        // Interface members.
        int MyInt { get; set; }
        void DoSomething();
    }
    interface IMyDerivedInterface : IMyBaseInterface
    {
        new void DoSomething();
    }
}
