using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDefine
{
    // UML : 点击解决方案管理器-项目右键-查看-查看类图

        // internal & public
        class MyClass
        {
            // Class members.
        }
        internal class MyInternalClass
        {
            // Class members.
        }   // 不加修饰符相当于internal 只有当前项目中的代码才能访问
        public class MyPublicClass
        {
            // Class members.
        }   // 可由其他项目中的代码访问

        // abstract & sealed
        public abstract class MyPublicAbstractClass
        {
            // Class members, may be abstract.
        }   // 抽象的 不能实例化,只能继承,可以有抽象成员
        public sealed class MyPublicSealedClass
        {
            // Class members.
        }   // 密封的 只能实例化,不能继承

        // 继承
        public class MyBigClass : MyPublicClass, IMyInterface
        {
            // Class members.
        }

        // 接口
        // 不能使用 abstract 和 sealed 关键字,接口定义不包含实现代码,不能直接实例化,且必须是可以继承的
        interface IMyInterface
        {
            // Interface members.
        }   // 默认internal
        interface IMyPublicInterface
        {
            // Interface members.
        }   // 可以公开访问

    class Program
    {
        static void Main(string[] args)
        {
            MyBigClass myObj = new MyBigClass();
            Console.WriteLine(myObj.ToString());
            Console.ReadKey();
        }
    }
}
