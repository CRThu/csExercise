using System;
using System.Collections.Generic;
using System.Diagnostics;   // 调试系列函数命名空间
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugOutputText
{
    class Program
    {
        static void Main(string[] args)
        {
            // 测试 Debug/Trace.WriteLine()
            Debug.WriteLine("WriteLine", "Debug");  // 仅在Debug下输出
            Trace.WriteLine("WriteLine", "Trace");  // Release下仍可输出

            // 输出文本到调试窗口
            int[] testArray = { 4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9 };
            int[] maxValIndices;    // Indices->Index
            int maxVal = Maxima(testArray, out maxValIndices);  // 传入testArray 传出maxValIndices
            WriteLine($"Maximum value {maxVal} found at element indices:");
            foreach (int index in maxValIndices)    // 遍历输出所有index
                WriteLine(index);

            // 测试 Debug/Trace.Assert()
            int myVal = 10;
            Debug.Assert(myVal > 15, "myVal >15 Assert.", "Debug Assertion.");
            Trace.Assert(myVal < 15, "myVal <15. Assert", "Trace Assertion.");
            ReadKey();
        }

        static int Maxima(int[] integers, out int[] indices)    // 取最值
        {
            Debug.WriteLine("Maximum value search started.");
            indices = new int[1];
            int maxVal = integers[0];
            indices[0] = 0;
            int count = 1;
            Debug.WriteLine($"Maximum value initialized to {maxVal},at element index 0.");  // 初始化为0元素
            for (int i = 1; i < integers.Length; i++)
            {
                Debug.WriteLine($"Now looking at element at index {i}.");
                if (integers[i] > maxVal)   // 找到极值
                {
                    maxVal = integers[i];
                    count = 1;
                    indices = new int[1];
                    indices[0] = i;
                    // 跟踪点
                    // 代码右键-断点-插入跟踪点-操作-将消息记录到输出窗口:~~
                    Debug.WriteLine($"Now maximum found. New value is {maxVal},at element index {i}.");
                }
                else
                {
                    if (integers[i] == maxVal)  // 极值相等 记录index
                    {
                        count++;
                        int[] oldIndices = indices;
                        indices = new int[count];
                        oldIndices.CopyTo(indices, 0);
                        indices[count - 1] = i;
                        Debug.WriteLine($"Duplicate maximum found at element index {i}.");
                    }
                }
            }
            // 可使用 $FUNCTION 输出函数名
            Trace.WriteLine($"Maximum value {maxVal} found, with {count} occurrences.");
            Debug.WriteLine("Maximum value search completed.");
            return maxVal;
        }
    }
}
