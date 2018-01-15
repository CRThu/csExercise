using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace enumVariable
{
    enum orientation : byte
    {
        east = 1,
        south = 2,
        west = 3,
        north = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            byte dirByte;
            string dirString;
            orientation myDir = orientation.north;
            WriteLine($"myDir = {myDir}");
            dirByte = (byte)myDir;
            dirString = Convert.ToString(myDir);
            WriteLine($"byte equivalent = {dirByte}");
            WriteLine($"string equivalent = {dirString}");
            // 强制类型转换测试
            WriteLine($"\nvalue = {4},orientation = {(orientation)4}.");
            // Tostring函数转换测试
            WriteLine($"myDir.ToString() = {myDir.ToString()}");
            // Parse函数转换测试
            // string类型转换至enum
            orientation ConvertDir = (orientation)Enum.Parse(typeof(orientation), "east");
            WriteLine($"\nConvertDir = {ConvertDir}");
            ReadKey();
        }
    }
}
