using System;

namespace lab1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("leg1=");
            int leg1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("leg2=");
            int leg2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("area=" + (leg1 * leg2 / 2)+"   P="+(leg1+leg2+Math.Sqrt(leg1*leg1+leg2*leg2)));
            Console.ReadKey();

        }
    }
}
