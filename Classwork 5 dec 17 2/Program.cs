using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_5_dec_17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            switch (a)
            {
                case 5:
                    Console.WriteLine($"{a} = 5");
                    break;
                case 6:
                    Console.WriteLine($"{a} = 6");
                    break;
                case 8:
                    Console.WriteLine($"{a} = 8");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
    }
}
