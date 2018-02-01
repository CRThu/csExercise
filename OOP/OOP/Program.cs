using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        interface IHotDrink
        {
            void TestForInterface();
        }   // IHotDrink接口
        class CupOfCoffee:IDisposable,IHotDrink
        {
            string BeanType;
            bool Instant;
            bool Milk;
            byte Sugar;
            string Description;

            public CupOfCoffee()
            {
            }

            public CupOfCoffee(string v)
            {
                this.Description = v;
            }

            byte AddSugar(byte amount)
            {
                Sugar++;
                return Sugar;
            }
            public void TestForInterface()
            {

            }
            public void Dispose()
            {

            }
        }   // CupOfCoffee类
        class Animal
        {
            public void EatFood()   // 均可调用 可变为虚拟成员
            {
                Console.WriteLine("Animal:EatFood()!");
            }
            protected void ProtectedEatFood()  // Animal不可调用
            {
                Console.WriteLine("Animal:ProtectedEatFood()!");
            }
        }   // 基类
        class Chicken:Animal
        {
            public void EatFood()   // 重写Animal:EatFood()
            {
                Console.WriteLine("Chicken:EatFood()!");
            }
            public void UseProtectedEatFood()
            {
                Console.Write("Chicken:UseProtectedEatFood->");
                ProtectedEatFood();  // 派生类可调用
            }
        }   // 派生类
        static void Main(string[] args)
        {
            #region 面向对象编程的含义
            // 构造函数
            CupOfCoffee myCup1 = new CupOfCoffee();    // 默认
            CupOfCoffee myCup2 = new CupOfCoffee("Blue Mountain");   //非默认

            // 析构函数
            // 用于在删除对象实例前完成的操作

            // 静态构造函数
            // 不能直接调用

            // 静态类
            Console.WriteLine("Helloworld!");   // Console
            #endregion

            #region OOP技术
            // 接口
            myCup1.TestForInterface();

            // 可删除的对象
            // IDisposable
            using (CupOfCoffee myCup3 = new CupOfCoffee("Blue Mountain"))
            {
                // ...
            }
            CupOfCoffee myCup4 = new CupOfCoffee();
            using (myCup4)
            {
                // ...
            }

            // 继承
            Animal animal = new Animal();
            animal.EatFood();
            Chicken chicken = new Chicken();
            chicken.EatFood();
            chicken.UseProtectedEatFood();

            // 抽象类
            // 抽象类不能被实例化

            // 多态
            // TODO
            #endregion

            Console.ReadKey();
        }
    }
}
