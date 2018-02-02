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
        class CupOfCoffee : IDisposable, IHotDrink
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
                Console.WriteLine("CupOfCoffee:TestForInterface()!");
            }
            public void Dispose()
            {
                Console.WriteLine("CupOfCoffee:Dispose()!");
            }
        }   // CupOfCoffee类
        interface IEatFood
        {
            void EatFood();
        }   // IEatFood接口
        class Animal : IEatFood
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
        class Chicken : Animal
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
        class Cow : Animal
        {
            int Weight;
            public Cow(int weight)
            {
                this.Weight = weight;
            }
            public Cow()
            {
            }
            public static bool operator <(Cow cow1, Cow cow2)
            {
                Console.WriteLine("Cow:重载运算符<(cow1,cow2)");
                return cow1.Weight < cow2.Weight ? true : false;
            }
            public static bool operator >(Cow cow1, Cow cow2)
            {
                Console.WriteLine("Cow:重载运算符>(cow1,cow2)");
                return cow1.Weight > cow2.Weight ? true : false;
            }
            public void Moo()
            {
                Console.WriteLine("Cow:Moo()!");
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
            Cow myCow = new Cow();  // 派生类型变量
            Animal myAnimal = myCow;    // 派生类型变量赋给基本类型变量
            myAnimal.EatFood(); // 访问基类方法
            Cow myNewCow = (Cow)myAnimal;   // 转换为派生类变量
            myNewCow.Moo(); // 调用派生类方法

            // 接口的多态性
            IEatFood eatFoodInterface;
            eatFoodInterface = myAnimal;
            eatFoodInterface.EatFood();
            eatFoodInterface = myCow;
            eatFoodInterface.EatFood();

            // 集合
            Animal[] animals = new Animal[5];
            #endregion

            // 运算符重载
            Cow myCow1 = new Cow(100);
            Cow myCow2 = new Cow(200);
            Console.WriteLine("myCow1 < myCow2? " + (myCow1 < myCow2 ? "true" : "false"));
            Console.WriteLine("myCow1 > myCow2? " + (myCow1 > myCow2 ? "true" : "false"));

            // 事件
            // -

            // 引用类型和值类型
            // -

            Console.ReadKey();
        }
    }
}
