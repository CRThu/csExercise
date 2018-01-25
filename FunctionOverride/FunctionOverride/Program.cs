using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FunctionOverride
{
    class Program
    {
        // 重载函数的
        // 函数签名包括引用参数(例如:ref)
        // 函数签名不包括返回值

        // Func(int val)
        // Func(ref int val)
        // Func(int val,int val2)
        // Func(double val)

        static int MaxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
                if (intArray[i] > maxVal)
                    maxVal = intArray[i];
            return maxVal;
        }
        static double MaxValue(double[] doubleArray)
        {
            double maxVal = doubleArray[0];
            for (int i = 1; i < doubleArray.Length; i++)
                if (doubleArray[i] > maxVal)
                    maxVal = doubleArray[i];
            return maxVal;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            double[] myDoubleArray = { 1.2, 1.3, 5.5, 0.7, 5.8, 3.3 };
            int maxVal = MaxValue(myArray);
            double maxDoubleVal = MaxValue(myDoubleArray);
            WriteLine($"The maximum value in myArray is {maxVal}");
            WriteLine($"The maximum value in myDoubleArray is {maxDoubleVal}");
            ReadKey();
        }
    }
}
