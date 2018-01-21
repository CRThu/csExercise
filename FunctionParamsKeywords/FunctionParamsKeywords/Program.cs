using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FunctionParamsKeywords
{
    class Program
    {
        // 传入参数数组/params
        // static <returnType> <FunctionName>(<p1Type> <p1Name>, ..., params <type>[] <name>)
        static int SumVals(params int[] vals)       // 参数的数量不受限制
        {
            int sum = 0;
            foreach (int val in vals)
                sum += val;
            return sum;
        }
        // 引用传递参数/ref
        // ref关键字指定参数后在函数调用时再次指定
        static void ShowDouble(ref int val) // 指定ref
        {
            val *= 2;
            WriteLine($"val doubled = {val}");
        }
        // 输出参数/out
        // out值会被覆盖
        // out关键字指定参数后在函数调用时再次指定
        static int MaxValue(int[] intArray,out int maxIndex)
        {
            int maxVal = intArray[0];
            maxIndex = 0;
            for(int i=1;i<intArray.Length;i++)
            {
                if(intArray[i]>maxVal)
                {
                    maxVal = intArray[i];
                    maxIndex = i;
                }
            }
            return maxVal;
        }

        static void Main(string[] args)
        {
            WriteLine("Test for params keyword:");
            WriteLine($"Summed Values = {SumVals(1, 5, 2, 9, 8)}.");

            WriteLine("Test for ref keyword:");
            int myNumber = 5;
            WriteLine($"myNumber = {myNumber}");
            ShowDouble(ref myNumber);   // 指定ref
            WriteLine($"myNumber = {myNumber}");

            WriteLine("Test for out keyword:");
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxIndex;
            WriteLine($"The maximum value in myArray is {MaxValue(myArray, out maxIndex)}");    // 指定out
            WriteLine($"The first occurrence of this value is at element {maxIndex + 1}");

            ReadKey();
        }
    }
}
