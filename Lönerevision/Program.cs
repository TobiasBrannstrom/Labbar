using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lönerevision
{
    class Program
    {
        static private void Main(string[] args)
        {
        
            while (true)
            {
                try
                {
                    // Anropa funktionen ReadInt
                    int count = ReadInt("Ange antal löner att mata in: "); 

                    // Om count är större än 2, kör ProcessSalaries och skicka med värdet i count
                    if (count < 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        throw new Exception();
                    }
                    ProcessSalaries(count);
                }
                               
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Du måste ange minst 2 löner för att göra en beräkning.");
                    Console.ResetColor();
                }
                  
                // Fråga om användaren vill göra en ny beräkning eller avsluta programmet
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\nTryck på valfri tangent för en ny beräkning. Esc avslutar programmet.\n");
                Console.ResetColor();

                if(Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    return;
                }
            }
            
        }
        static private int ReadInt(string prompt)
        {
            // Hantera användarens input
            while(true)
            {
                Console.Write(prompt);
                string antal = Console.ReadLine();
                    
                try
                {
                    int amount = int.Parse(antal);
                    return amount;
                }

                // Om det inte är ett tal eller heltal
                catch(FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFel i inmatningen! \"{0}\" kan inte tolkas som ett heltal!\n", antal);
                    Console.ResetColor();
                }
            }
        }
            
        static private void ProcessSalaries(int count)
        {
            // Skapa en array med antal nummer som ligger i countvariabeln
            int[] antalLoner = new int[count];

            Console.WriteLine("");

            // Inmatning av löner
            for (int i = 0; i < antalLoner.Length; i++)
            {
                antalLoner[i] = ReadInt(string.Format("Ange lön nummer {0}: ", i + 1));

            }
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");

            // Skapa en klon av arrayen och sortera den så att medianen kan räknas ut
            int[] antalLonerKlon = (int[])antalLoner.Clone();

            Array.Sort(antalLonerKlon);

            // Räkna ut medianen om antalet löner är heltal
            if (count % 2 == 0)
            {
                int mediantal1 = antalLonerKlon[antalLonerKlon.Length / 2 - 1];
                int mediantal2 = antalLonerKlon[antalLonerKlon.Length / 2];
                Console.WriteLine("Medianlön: {0, 25:C0}", (mediantal1 + mediantal2) / 2);
            }
            // Räkna ut medianen om antalet löner är ett udda tal
            else
            {
                int median = antalLonerKlon[antalLonerKlon.Length / 2];
                Console.WriteLine("Medianlön: {0, 25:C0}", median);
            }
            // Räkna ut medellön och lönespridning
            Console.WriteLine("Medellön: {0, 26:C0}", antalLonerKlon.Average());
            Console.WriteLine("Lönespridning: {0, 21:C0}", antalLonerKlon.Max() - antalLonerKlon.Min());
            Console.WriteLine("------------------------------------");

            // Skriv ut de inmatade lönerna i en lista
            for (int i = 0; i < count; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("");
                }

                Console.Write("{0, 6}", antalLoner[i]);

            }
        }               
                                
            
     }
}

