using System;

namespace lab._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            int d = (int)(x * 10) % 10;
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
