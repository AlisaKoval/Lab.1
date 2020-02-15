using System;

namespace lab1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt16(Console.ReadLine());
            int x1 = x / 100;
            int x2 = (x / 10) % 10;
            int x3 = x % 10;
            int reversed = x3*100+x2*10+x1;
            Console.WriteLine(reversed);
            Console.ReadKey();
        }
    }
}
