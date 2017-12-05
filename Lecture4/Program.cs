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
            int b = (a % 10);
            int c = (a % 100);
            int d %


            Console.WriteLine("Guess the number:");
            int d = int.Parse(Console.ReadLine());
            if (d == a)
                Console.WriteLine("Correct");
            else if (d == b)
                Console.WriteLine("Correct");
            else if (d == c)
                Console.WriteLine("Correct");
            else
                Console.WriteLine("You failed");




        }
    }
}
