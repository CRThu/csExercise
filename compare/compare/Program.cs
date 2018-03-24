using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare
{
    class Program
    {
        struct MyStruct
        {
            public int Val;
        }
        static void Main(string[] args)
        {
            // 封箱&拆箱
            MyStruct valType1 = new MyStruct();
            valType1.Val = 5;
            object refType = valType1;  // 封箱
            valType1.Val = 6;
            MyStruct valType2 = (MyStruct)refType;  // 拆箱
            Console.WriteLine($"valType2.Val = {valType2.Val}");
            
            Console.ReadKey();
        }
    }
}
