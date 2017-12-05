using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_4_ConsoleKeyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            int x = 5;
            int y = 5;

            ConsoleKeyInfo key;

            do
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine("*");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow) y = y - 1;
                if (key.Key == ConsoleKey.DownArrow) y = y + 1;
                if (key.Key == ConsoleKey.LeftArrow) x = x - 1;
                if (key.Key == ConsoleKey.RightArrow) x = x + 1;

            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
