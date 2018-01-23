using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MainFunction
{
    class Program
    {
        // 四种Main函数:
        // static void Main()
        // static void Main(string[] args)
        // static int Main()
        // static int Main(string[] args)

        // 传入参数调试:项目-属性-调试-启动选项-命令行参数加入: 256 myfile.txt "a longer argument"

        static void Main(string[] args)
        {
            WriteLine($"{args.Length} command line arguments were specified:");
            foreach (string arg in args)
                WriteLine(arg);
            ReadKey();
        }
    }
}
