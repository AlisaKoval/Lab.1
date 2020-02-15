using System;

namespace lab1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(x * (x * (x * (3 * x - 5) + 2) - 1) + 7);
            Console.ReadKey();

        }
    }
}
