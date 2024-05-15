using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как вас зовут? ");
            string name = Console.ReadLine();
            Console.Write("Сколько вам лет? ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вас зовут {name} и вам {age} лет");
            Console.Write("Когда у вас день рождения? ");
            string birthday = Console.ReadLine();
            Console.WriteLine($"Ваш день рождения {birthday}");

        }
    }
}
