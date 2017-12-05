using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_3_Age_Definition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("How old are you?");
            int a = int.Parse(Console.ReadLine());
            if (a <= 10)
                Console.WriteLine("You're a child");
            else if (a > 10 && a <= 18)
                Console.WriteLine("You're a teenager");
            else if (a > 18 && a <= 50)
                Console.WriteLine("You're an adult");
            else if (a > 50)
                Console.WriteLine("You're ancient");
            else
                Console.WriteLine("");
        }
    }
}
