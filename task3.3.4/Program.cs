using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3._3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(semaphore.red);
        }
        enum semaphore : short
        {
            red = 100,
            yellow = 200,
            green = 300

        }
    }
}
