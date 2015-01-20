using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Asterisker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Rader
            for (int rad = 0; rad < 25; rad++)
            {
                // Mellanrum varannan rad
                if (rad % 2 == 0)
                {
                    Console.Write(" ");
                }

                // Färghantering
                switch (rad % 3)
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

                // Kolumner
                for (int kolumn = 0; kolumn < 39; kolumn++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();           
        }
    }
}
