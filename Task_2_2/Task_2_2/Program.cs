using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    class Program
    {
        static void Main(string [] args)
        {
            int day, month, year;
            Console.Write("Введите день:");
            day = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц:");
            month = int.Parse(Console.ReadLine());
            Console.Write("Введите две последние цифры года:");
            year = int.Parse(Console.ReadLine());

            if (day * month == year)
                Console.WriteLine("Это волшебная дата!");

            else
                Console.WriteLine("К сожалению, дата - обычная");

            Console.ReadKey();
        }
            
    }
}
