using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VariableConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortResult, shortVal = 4;
            int integerVal = 67;
            long longResult;
            float floatVal = 10.5F;
            double doubleResult, doubleVal = 99.999;
            string stringResult, stringVal = "17";
            bool boolVal = true;
            WriteLine("Variable Conversion Examples\n");
            doubleResult = floatVal * shortVal;
            WriteLine($"Implicit (隐式转换), -> double: {floatVal} * {shortVal} -> {doubleResult}");
            shortResult = (short)floatVal;
            WriteLine($"Explicit (显式转换), -> short: {floatVal} -> {shortResult}");
            stringResult = Convert.ToString(boolVal) + Convert.ToString(doubleVal);
            WriteLine($"Explicit (函数转换), -> string: \"{boolVal}\" + \"{doubleVal}\" -> {stringResult}");
            longResult = integerVal + Convert.ToInt64(stringVal);
            WriteLine($"Mixed (混合转换), -> long: {integerVal} + {stringVal} -> {longResult}");
            ReadKey();
            // checked/unchecked测试
            byte destinationVar;
            short sourceVar = 281;
            //destinationVar = unchecked((byte)sourceVar);
            destinationVar = checked((byte)sourceVar);
            WriteLine($"sourceVar val: {sourceVar}");
            WriteLine($"destination val: {destinationVar}");
            ReadKey();
        }
    }
}
