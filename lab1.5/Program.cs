using System;

namespace lab1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
             a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a=" + a + "   b=" + b);
            Console.ReadKey();
        }
    }
}
