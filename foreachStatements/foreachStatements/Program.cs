using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace foreachStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach 只读
            // 一维数组
            string[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigle" };
            WriteLine($"Here are {friendNames.Length} of my friends:");
            foreach (string friendName in friendNames)
                WriteLine(friendName);
            WriteLine();
            // 多维数组
            double[,] hillHeight = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 } };
            foreach (double height in hillHeight)
                WriteLine("{0}", height);
            WriteLine();
            // 数组的数组/锯齿数组(jagged array)
            int[][] divisors1To10 = {
                new int[] {1},
                new int[] {1,2},
                new int[] {1,3},
                new int[] {1,2,4},
                new int[] {1,5},
                new int[] {1,2,3,6},
                new int[] {1,7},
                new int[] {1,2,4,8},
                new int[] {1,3,9},
                new int[] {1,2,5,10}};
            foreach (int[] divisorsOfInt in divisors1To10)
                foreach (int divisor in divisorsOfInt)
                    WriteLine(divisor);
            //字符串处理
            string myString = "A string";
            char[] myChars = myString.ToCharArray();
            foreach (char character in myString)
                WriteLine($"{character}");

            ReadKey();
        }
    }
}
