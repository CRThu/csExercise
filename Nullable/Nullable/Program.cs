using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = GetVector("vector1");
            Vector v2 = GetVector("vector2");
            Console.WriteLine($"{v1} + {v2} = {v1+v2}");
            Console.WriteLine($"{v1} - {v2} = {v1 - v2}");
            Console.ReadKey();
        }
        static Vector GetVector(string name)    // 处理为向量
        {
            Console.WriteLine($"Input {name} magnitude:");
            double? r = GetNullableDouble();
            Console.WriteLine($"Input {name} angle (in degrees):");
            double? theta = GetNullableDouble();
            return new Vector(r, theta);
        }
        static double? GetNullableDouble()  // 读行数据
        {
            double? result;
            string userInput = Console.ReadLine();
            try
            {
                result = double.Parse(userInput);
            }
            catch
            {
                result = null;
            }
            return result;
        }
    }
}
