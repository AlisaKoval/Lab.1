using System;

namespace lab1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int c1 = int.Parse(Console.ReadLine());
            int d1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());
            int d2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int b3 = int.Parse(Console.ReadLine());
            int c3 = int.Parse(Console.ReadLine());
            int d3 = int.Parse(Console.ReadLine());
            int main_det = a1 * b2 * c3 + a2 * b3 * c1 + b1 * c2 * a3 - c1 * b2 * a3 - b1 * a2 * c3 - c2 * b3 * a1;
            if (main_det == 0)
            {
                Console.WriteLine("no Solution");
            }
            else
            {
                int detx = d1 * b2 * c3 + d2 * b1 * c3 + b3 * c2 * d1 - c1 * b2 * d3 - d2 * b1 * c3 - b3 * c2 * d1;
                int dety = a1 * d2 * c3 + d1 * c2 * a3 + a2 * d3 * c1 - c1 * d2 * a3 - c2 * d3 * a1 - d1 * a2 * c3;
                int detz = a1 * b2 * d3 + a2 * b3 * d1 + b1 * d2 * a3 - d1 * b2 * a3 - b3 * d2 * a1 - a2 * b1 * d3;
                double x = detx / main_det;
                double y = dety / main_det;
                double z = detz / main_det;

                Console.WriteLine("x=" + x+ "  y=" + y +"   z=" + z);
                Console.ReadKey();
            }
        }
    }
}
