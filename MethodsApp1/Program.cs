using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = Sum();
            Console.WriteLine(c);
            string s = Hello();
            Method1();
            Method2();
            Console.WriteLine(s);
            Console.ReadKey();
        }

        static string Hello()
        {
            return "Hello world";
        }

        static int Sum()
        {
            int x = 2;
            int y = 3;
            int z = x + y; // 5
            return z;
        }

        static void Method1()
        {
            Console.WriteLine("Method1");
        }

        static void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
}
