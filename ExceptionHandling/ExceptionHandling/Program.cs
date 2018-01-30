using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExceptionHandling
{
    class Program
    {
        static string[] eTypes = { "none", "simple", "index", "nested index", "filter" };
        static void Main(string[] args)
        {
            foreach (string eType in eTypes)    // 遍历多个类型的异常处理
            {
                try
                {
                    WriteLine("Main() try block reached.");
                    WriteLine($"ThrowException(\"{eType}\") called.");
                    ThrowException(eType);
                    WriteLine("Main() try block continues.");
                }
                catch (System.IndexOutOfRangeException e) when (eType == "filter")  // 异常过滤器
                {
                    BackgroundColor = ConsoleColor.Red;
                    WriteLine($"Main() FILTERED System.IndexOutOfRange Exception catch block reached. Message:\n\"{e.Message}\"");
                    ResetColor();
                }
                catch (System.IndexOutOfRangeException e)   // 指定异常处理
                {
                    WriteLine($"Main() System.IndexOutOfRange Exception catch block reached. Message:\n\"{e.Message}\"");
                }
                catch   // 普通异常处理
                {
                    WriteLine("Main() general catch block reached.");
                }
                finally // 异常处理结束
                {
                    WriteLine("Main() finally block reached");
                }
                WriteLine();
            }
            ReadKey();
        }

        static void ThrowException(string exceptionType)
        {
            WriteLine($"ThrowException (\"{exceptionType}\") reached.");
            switch (exceptionType)
            {
                case "none":    // 不抛出异常
                    WriteLine("Not throwing an exception.");
                    break;
                case "simple":  // 抛出一般异常
                    WriteLine("Throwing System.Exception.");
                    throw new System.Exception();
                case "index":   // 抛出System.IndexOutOfRangeException异常
                    WriteLine("Throwing System.IndexOutOfRangeException.");
                    eTypes[5] = "error";    // 抛出越界错误
                    break;
                case "nested index":
                    try
                    {
                        WriteLine("ThrowException (\"nested index\") try block reached.");
                        WriteLine("ThrowExpection (\"index\") called.");
                        ThrowException("index");
                    }
                    catch
                    {
                        WriteLine("ThrowException (\"nested index\") general catch block reached.");
                        throw;  // 传递给主函数try块 产生等效index的异常
                    }
                    finally
                    {
                        WriteLine("ThrowException (\"nested index\") finally block reached.");
                    }
                    break;
                case "filter":  // 测试异常过滤器
                    try
                    {
                        WriteLine("ThrowException (\"filter\") try block reached.");
                        WriteLine("ThrowException (\"index\") called.");
                        ThrowException("index");
                    }
                    catch
                    {
                        WriteLine("ThrowException (\"filter\") general catch block reached.");
                        throw;  // 传递给主函数try块 产生等效index的异常 在主函数被异常过滤器捕获
                    }
                    break;
            }
        }
    }
}
