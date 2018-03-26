using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare
{
    public class AddClass1
    {
        public int val;
        public static AddClass1 operator +(AddClass1 op1, AddClass1 op2) // 重载 +
        {
            AddClass1 returnVal = new AddClass1();
            returnVal.val = op1.val + op2.val;
            return returnVal;
        }
        public static AddClass1 operator -(AddClass1 op1)
        {
            AddClass1 returnVal = new AddClass1();
            returnVal.val = -op1.val;
            return returnVal;
        }
        public static bool operator >=(AddClass1 op1, AddClass1 op2) => (op1.val >= op2.val);
        public static bool operator <=(AddClass1 op1, AddClass1 op2) => (op1.val <= op2.val);
        public static bool operator <(AddClass1 op1, AddClass1 op2) => !(op1 >= op2);
        public static bool operator >(AddClass1 op1, AddClass1 op2) => !(op1 <= op2);
        // 通常需要重写 Object.Equals() 和 Object.GetHashCode()
        public static bool operator ==(AddClass1 op1, AddClass1 op2) => (op1.val == op2.val);
        public static bool operator !=(AddClass1 op1, AddClass1 op2) => !(op1 == op2);
        public override bool Equals(object op1)
        {
            if (op1 is AddClass1)
            // if (op1.GetType() == typeof(AddClass1))
                return val == ((AddClass1)op1).val;
            else throw new ArgumentException("Can't compare AddClass1 objects with objects of type " + op1.GetType().ToString());
        }
        public override int GetHashCode() => val;
    }
}
