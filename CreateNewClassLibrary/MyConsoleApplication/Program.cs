using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateNewClassLibrary;    // 添加类库

namespace MyConsoleApplication
{
    // 添加类库引用 : 引用 - 添加引用 - 项目 - 解决方案
    class Program
    {
        static void Main(string[] args)
        {
            MyExternalClass myObj = new MyExternalClass();
            Console.WriteLine(myObj.ToString());
            Console.ReadKey();
        }
    }
}
