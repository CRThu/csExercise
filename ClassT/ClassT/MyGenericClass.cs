using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassT
{
    class MyGenericClass<T1,T2,T3> 
    {
        private T1 innerT1Object;
        public MyGenericClass(T1 item)
        {
            innerT1Object = item;
        }
        public T1 InnerT1Object
        {
            get { return innerT1Object; }
        }
        public MyGenericClass()
        {
            innerT1Object = default(T1);    // default 关键词
        }
    }
}
