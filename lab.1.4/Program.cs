using System;

namespace lab._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            double angle = ((h + (m / 60.0) + (s / 3600)) / 12) * 360;
            Console.WriteLine(angle);
            Console.ReadKey();

        }
    }
}
