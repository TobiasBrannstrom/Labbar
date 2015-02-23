using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solida_Volymer
{
    class Program
    {
        private static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                ViewMenu();

                try // La dit denna för att programmet inte skulle smälla om man inte skriver in siffror
                {
                    string menuChoice = Console.ReadLine();
                    int menuNumber = Convert.ToInt32(menuChoice);

                    if (menuNumber >= 0 && menuNumber <= 2)
                    {
                        switch (menuNumber)
                        {
                            case 0:
                                {
                                    return;
                                }
                            case 1:
                                {
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(" ╔══════════════════════════════════════════════╗ ");
                                    Console.WriteLine(" ║                    Kon                       ║ ");
                                    Console.WriteLine(" ╚══════════════════════════════════════════════╝ \n");
                                    Console.ResetColor();
                                    ViewSolidDetail(CreateSolid(SolidType.CircularCone));
                                    break;
                                }
                            case 2:
                                {
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(" ╔══════════════════════════════════════════════╗ ");
                                    Console.WriteLine(" ║                   Cylinder                   ║ ");
                                    Console.WriteLine(" ╚══════════════════════════════════════════════╝ \n");
                                    Console.ResetColor();
                                    ViewSolidDetail(CreateSolid(SolidType.Cylinder));
                                    break;
                                }
                        }
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("FEL! Du måste ange ett nummer mellan 0 och 2.\n");
                        Console.ResetColor();
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("FEL! Du måste ange ett nummer mellan 0 och 2.\n");
                    Console.ResetColor();
                }


                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Tryck valfri tangent för att börja om - ESC avslutar.");
                Console.ResetColor();

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        private static Solid CreateSolid(SolidType solidType)
        {
            double radius = ReadDoubleGreaterThanZero("Ange radien (r): ");
            double height = ReadDoubleGreaterThanZero("Ange höjden (h): ");

            Solid solid;

            if (solidType == SolidType.CircularCone)
            {
                solid = new CircularCone(radius, height);
            }
            else
            {
                solid = new Cylinder(radius, height);
            }
            return solid;

            //switch (solidType)
            //{
            //    case SolidType.CircularCone:
            //        CircularCone newCircularCone = new CircularCone(radius, height);
            //        return newCircularCone;

            //    case SolidType.Cylinder:
            //        Cylinder newCylinder = new Cylinder(radius, height);
            //        return newCylinder;

            //    default:
            //        throw new ArgumentException();

            //}
        }
        private static double ReadDoubleGreaterThanZero(string prompt)
        {

            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    double userInput = double.Parse(Console.ReadLine());
                    if (userInput > 0)
                    {
                        return userInput;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("FEL! Ange ett flyttal större än 0.");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("FEL! Ange ett flyttal större än 0.");
                    Console.ResetColor();
                }
            }
        }
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════════════╗ ");
            Console.WriteLine(" ║                                              ║ ");
            Console.WriteLine(" ║                 Solida volymer               ║ ");
            Console.WriteLine(" ║                                              ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════════════╝ \n");
            Console.ResetColor();
            Console.WriteLine("0. Avsluta.\n");
            Console.WriteLine("1. Kon.\n");
            Console.WriteLine("2. Cylinder.\n");
            for (int i = 0; i < 50; i++)
            {
                Console.Write("═");
            }
            Console.WriteLine();
            Console.Write("Ange ditt menyval [0-2]: ");
        }
        private static void ViewSolidDetail(Solid solid)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine(" ╔══════════════════════════════════════════════╗ ");
            Console.WriteLine(" ║                    Detaljer                  ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════════════╝ \n");
            Console.ResetColor();
            Console.WriteLine(solid.ToString());
            Console.WriteLine();
            for (int i = 0; i < 50; i++)
            {
                Console.Write("═");
            }
            Console.WriteLine("\n");
        }
    }
}