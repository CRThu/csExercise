using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace stringVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            // 可使用foreach 参考foreachStatements项目
            string myString = "A string";
            char myChar = myString[1]; //只读

            // 转换字符数组
            char[] myChars = myString.ToCharArray();

            // 输入字符串
            string myStringInput = ReadLine();
            WriteLine($"You typed {myStringInput.Length} characters.");

            // 去除空格
            myStringInput = myStringInput.Trim();
            myStringInput = myStringInput.TrimStart();
            myStringInput = myStringInput.TrimEnd();

            // 转换小写
            Write("转换小写:");
            if (myStringInput.ToLower() == "yes")
                WriteLine($"Get yes.");
            WriteLine(myStringInput.ToLower());

            // 去除指定字符
            Write("去除e,s字符:");
            char[] trimChars = { ' ', 'e', 's' };
            myStringInput = myStringInput.Trim(trimChars);
            WriteLine(myStringInput);

            // 字符串前后补齐
            WriteLine("字符串前后补齐:");
            string test = "Aligned";
            // 在字符串前/后添加空格至字符串长度x
            test = test.PadLeft(10);
            test = test.PadRight(15);
            Write(test);
            WriteLine("<-end.");
            // 在字符串前/后添加字符至字符串长度x
            test = "Aligned";
            test = test.PadLeft(10,'+');
            test = test.PadRight(15,'-');
            Write(test);
            WriteLine("<-end.");

            // 字符串分拆
            WriteLine("字符串分拆:");
            string testSplit = "This is a test.";
            char[] separator = { ' ' };
            string[] myWords;
            myWords = testSplit.Split(separator);
            foreach(string myWord in myWords)
                WriteLine($"{myWord}");

            ReadKey();
        }
    }
}
