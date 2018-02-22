using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMember
{
    class MyNestedClassA
    {
        private int state = -1;
        public int State
        {
            get
            {
                return state;
            }
        }
        public class MyNestedClassB
        {
            public void SetPrivateState(MyNestedClassA target,int newState)
            {
                target.state = newState;
            }
        }
    }
}
