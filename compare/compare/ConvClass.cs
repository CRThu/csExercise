using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare
{
   public class ConvClass1
    {
        public int val;
        // implicit 隐式转换
        public static implicit operator ConvClass2(ConvClass1 op1)
        {
            ConvClass2 returnVal = new ConvClass2();
            returnVal.val = op1.val;
            return returnVal;
        }
    }
    public class ConvClass2
    {
        public double val;
        // explicit 显式转换
        public static explicit operator ConvClass1(ConvClass2 op1)
        {
            ConvClass1 returnVal = new ConvClass1();
            checked { returnVal.val = (int)op1.val; };
            return returnVal;
        }
    }
}
