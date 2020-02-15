using System;

namespace lab1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt16(Console.ReadLine());
            int a1 = a / 1000;
            int a2 = (a / 100)%10;
            int a3 = (a / 10) % 10;
            int a4 = a % 10;
            a = a1 * a2 * a3 * a4;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
