using System;

namespace lab1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double y = Math.Exp(-1 * t * b) * Math.Sin(a * t + b) - Math.Sqrt(Math.Abs(b * t + a));
            double s = b * Math.Sin(a *Math.Pow(t,2) * Math.Cos(2 * t)) - 1;
            Console.WriteLine("y=" + y + "   s=" + s);
            Console.ReadKey();
            }
        }
    }

