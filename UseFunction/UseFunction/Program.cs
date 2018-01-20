using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UseFunction
{
    class Program
    {
        static void WriteStr()
        {
            WriteLine("Text output from function.");
        }
        static double GetVal()
        {
            return 3.2;
        }
        static double Multiply(double myVal1, double myVal2)
        {
            return myVal1 * myVal2;
        }

        // 表达式体方法 使用Lambda箭头(=>)
        static double MultiplyLambda(double myVal1, double myVal2) => myVal1 * myVal2;

        static int MaxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
                if (intArray[i] > maxVal)
                    maxVal = intArray[i];
            return maxVal;
        }

        static void Main(string[] args)
        {
            WriteStr();
            WriteLine($"GetVal:\n{GetVal()}");
            WriteLine($"Multiply(3.2,3.3):\n{Multiply(3.2,3.3)}");
            WriteLine($"MultiplyLambda(3.2, 3.3):\n{MultiplyLambda(3.2, 3.3)}");
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            WriteLine($"The maximum value in {{ 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 }} is {MaxValue(myArray)}.");

            ReadKey();
        }
    }
}
