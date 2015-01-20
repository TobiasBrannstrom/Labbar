using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lönerevision
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                try
                {
                    Console.Write("Ange antal löner att mata in: ");
                    count = int.Parse(Console.ReadLine());

                    if (count < 2)
                    {
                        Console.WriteLine("Du måste ange minst 2 löner att mata in");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Du måste mata in ett heltal!");
                    Console.ResetColor();
                }
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Tryck på valfri tangent för en ny beräkning. Esc avslutar programmet");
                Console.ResetColor();

                if(Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    return;
                }
            }
            ProcessSalaries();
        }
        static int ReadInt(string prompt)
         {

         }
        


 
        
        static void ProcessSalaries()
        {
           
        }               
                                
            
     }
}

