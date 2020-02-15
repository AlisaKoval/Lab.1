using System;

namespace lab1._11
{
    class Program
    {
        enum type { А, И, Т};
        static void Main(string[] args)
        {
            const string tele = "Телепередачи";
            const string program = "Передача";
            const string key = "Ведущий";
            const string top = "Рейтинг";
            const string type = "Тип";
            const string x = "Перечисляемый тип:И-Игровая; А-аналитическая; Т-ток-шоу";
            string p1 = Console.ReadLine();
            string k1 = Console.ReadLine();
            int top1 = Convert.ToInt16( Console.ReadLine());
            type type1 = (type)Enum.Parse(typeof(type), Console.ReadLine());
            string p2 = Console.ReadLine();
            string k2 = Console.ReadLine();
            int top2 = Convert.ToInt16(Console.ReadLine());
            type type2 = (type)Enum.Parse(typeof(type), Console.ReadLine());
            string p3 = Console.ReadLine();
            string k3 = Console.ReadLine();
            int top3 = Convert.ToInt16(Console.ReadLine());
            type type3 = (type)Enum.Parse(typeof(type), Console.ReadLine());
            Console.WriteLine (tele+"\n"+program+"\t\t"+key+"\t\t"+top+" "+type+"\n"+p1+ "\t\t"+k1+ "\t"+top1+"\t"+type1+"\n"+p2+"\t"+k2+"\t"+top2+"\t"+type2+"\n"+p3+"\t\t"+k3+"\t"+top3+"\t"+type3+"\n"+x);
            Console.ReadKey();
         



        }
    }
}
