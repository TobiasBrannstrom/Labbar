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
            do
            {
                // Anropa funktionen ReadInt
                int count = ReadInt("Ange antal löner att mata in: ");

                // Om count är större än eller lika med 2, kör ProcessSalaries och skicka med värdet i count
                if (count >= 2)
                {
                    ProcessSalaries(count);
                }

                else
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
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);

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
            int[] loner = new int[count];

            Console.WriteLine("");

            // Inmatning av löner
            for (int i = 0; i < loner.Length; i++)
            {
                loner[i] = ReadInt(string.Format("Ange lön nummer {0}: ", i + 1));
            }

            // Skapa en klon av arrayen och sortera den så att medianen kan räknas ut
            int[] lonerKlon = (int[])loner.Clone();

            Array.Sort(lonerKlon);

            // Uträkning av medianlön, medellön och lönespridning
            
            double medelLon = lonerKlon.Average(); // Uträkning av medellön
            int loneSpridning = lonerKlon.Max() - lonerKlon.Min(); // Uträkning av lönespridningen

            double median = 0;
            if (count % 2 == 0) // Uträkning av medianen om antalet löner är heltal
            {
                double mediantal1 = lonerKlon[(count / 2) - 1];
                double mediantal2 = lonerKlon[(count / 2)];
                median = (mediantal1 + mediantal2) / 2;
            }
            
            else // Uträkning av medianen om antalet löner är ett udda tal
            {
                int uddaLoner = lonerKlon[lonerKlon.Length / 2];
                median = uddaLoner;
            }
            
            // Utskrifter      
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Medianlön: {0, 25:C1}", median); // Median
            Console.WriteLine("Medellön: {0, 26:C1}", medelLon); // Medellön
            Console.WriteLine("Lönespridning: {0, 21:C1}", loneSpridning); // Lönespridning
            Console.WriteLine("------------------------------------");
            
            // Skriv ut de inmatade lönerna i en lista, osorterade
            for (int i = 0; i < count; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("");
                }
                Console.Write("{0, 6}", loner[i]);
            }
        }                                                           
     }
}

