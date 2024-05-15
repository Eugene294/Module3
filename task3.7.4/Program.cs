using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3._7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как вас зовут? ");
            string name = Console.ReadLine();
            Console.Write("Сколько вам лет? ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Какой у вас любимый день недели? ");
            DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());

            Console.WriteLine($"Вас зовут {name}");
            Console.WriteLine($"Вам {age} лет");
            Console.WriteLine($"Ваш любимый день недели {day}");
        }
    }
}
