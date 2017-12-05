using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //int a = 7;
            //int b = 8;
            //int c = 8;

            //if (a == 5)
            //    Console.WriteLine();
            //else if (b > a)
            //    Console.WriteLine();
            //else if (c == 8)
            //    Console.WriteLine();
            Console.WriteLine("Enter a secret number");
            int a = int.Parse(Console.ReadLine());
            int b = a / 100;
            int c = (a % 100 - a % 10) / 10;
            int d = a % 10;

            Console.WriteLine($"{b} {c} {d}");
            Console.WriteLine("Guess the number:");
            int e = int.Parse(Console.ReadLine());
            if (e == b)
                Console.WriteLine("Correct");
            else if (e == c)
                Console.WriteLine("Correct");
            else if (e == d)
                Console.WriteLine("Correct");
            else
                Console.WriteLine("You failed");




        }
    }
}
