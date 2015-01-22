using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rita_Med_Asterisker
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 25; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" ");
                }

                switch (i % 3)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
               
                for (int y = 0; y < 39; y++)
                {
                    Console.Write("* ");
                }
               
               
                Console.ResetColor();
                Console.WriteLine();
            }
            
        
        }
    }

}

