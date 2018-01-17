using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace arrayVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            // 一维数组
            int[] myIntArray1 = new int[5];
            int[] myIntArray2 = new int[5] { 5, 9, 10, 2, 99 };
            string[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigle" };
            WriteLine($"Here are {friendNames.Length} of my friends:");
            for (int i = 0; i < friendNames.Length; i++)
                WriteLine(friendNames[i]);
            // 多维数组
            double[,] hillHeight1 = new double[3, 4];
            double[,] hillHeight2 = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 } };
            WriteLine("{0}", hillHeight2[1,3]);
            // 数组的数组/锯齿数组(jagged array)
            // 1.先初始化主数组再初始化子数组
            int[][] jaggedIntArray1=new int[2][];
            jaggedIntArray1[0] = new int[3];
            jaggedIntArray1[1] = new int[4];
            // 2.简化
            int[][] jaggedIntArray2 = { new int[] { 1, 2, 3 }, new int[] { 1 }, new int[] { 1, 2 } };
            WriteLine("{0}", jaggedIntArray2[2][1]);
            ReadKey();
        }
    }
}
