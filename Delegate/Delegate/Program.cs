using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Delegate
{
    class Program
    {
        delegate double ProcessDelegate(double param1, double param2);      // 委托定义
        static double Multiply(double param1, double param2) => param1 * param2;
        static double Divide(double param1, double param2) => param1 / param2;
        static void Main(string[] args)
        {
            ProcessDelegate process;    // 委托类型声明变量
            WriteLine("Enter 2 numbers separated with a comma:");
            string input = ReadLine();
            int commaPos = input.IndexOf(',');  // 逗号分隔前后变量
            double param1 = ToDouble(input.Substring(0, commaPos));
            double param2 = ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));
            WriteLine("Enter M to multiply or D to divide:");
            input = ReadLine();
            // 委托变量 = 函数;
            // 委托变量 = new ProcessDelegate(函数);
            if (input == "M")
                //process = Multiply;
                process = new ProcessDelegate(Multiply);    // 初始化委托变量
            else
                //process = Divide;
                process = new ProcessDelegate(Divide);
            WriteLine($"Result: {process(param1, param2)}");
            ReadKey();
        }
    }
}
