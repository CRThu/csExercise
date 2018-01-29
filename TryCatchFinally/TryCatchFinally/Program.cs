using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 8;
            try
            {
                j = j / i;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"i = {i}, j= {j}");
            }
            Console.ReadKey();
        }
    }
}