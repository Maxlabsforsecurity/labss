using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(50);
            int b = rnd.Next(200);
            int c = rnd.Next(100);
            Console.WriteLine( a );
            Console.WriteLine(b);
            Console.WriteLine(c);
            if (  c>b && c>a) {
                Console.WriteLine("c is largest");
            }
            if (a<b  && b>c) {
                Console.WriteLine("b is largest");
                    };
            if (a>b && a>c) {
                Console.WriteLine("a is largest");
                    }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
