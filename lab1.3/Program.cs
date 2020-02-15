using System;

namespace lab1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = Convert.ToInt32( Console.ReadLine());
            int h = s / 3600;
            int m= (s-h * 3600)/60;
            Console.WriteLine("h=" + (h)+ "  m=" + (m));
            Console.ReadKey();

        }
    }
}
