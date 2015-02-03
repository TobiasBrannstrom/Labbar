using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kylskåp
{
    class Program
    {

        private const string HorizontalLine = "==================================================";

        static private void Main(string[] args)
        {
            // Test 1
            Cooler coolerTest = new Cooler();
            ViewTestHeader("Test 1:\nTestar standardkonstruktorn.");
            Console.WriteLine(coolerTest.ToString());
            Console.WriteLine();

            // Test 2

            Cooler coolerTest2 = new Cooler(24.5m, 4);
            ViewTestHeader("Test 2:\nTestar konstruktorn med 2 parametrar, (24,5 och 4).");
            Console.WriteLine(coolerTest2.ToString());
            Console.WriteLine();

            // Test 3

            Cooler coolerTest3 = new Cooler(19.5m, 4, true, false);
            ViewTestHeader("Test 3:\nTestar konstruktorn med 4 parametrar, (24,5 och 4, True och False).");
            Console.WriteLine(coolerTest3.ToString());
            Console.WriteLine();

            // Test 4

            Cooler coolerTest4 = new Cooler(5.3m, 4, true, false);
            ViewTestHeader("Test 4:\nTest av påslaget kylskåp med metoden Tick. Dörren är stängd.\n");
            Run(coolerTest4);

            // Test 5
            Cooler coolerTest5 = new Cooler(5.3m, 4, false, false);
            ViewTestHeader("Test 5:\nTest av avslaget kylskåp med metoden Tick. Dörren är stängd.\n");
            Run(coolerTest5);

            // Test 6
            Cooler coolerTest6 = new Cooler(10.2m, 4, true, true);
            ViewTestHeader("Test 6:\nTest av påslaget kylskåp med metoden Tick. Dörren är öppen.\n");
            Run(coolerTest6);
         
            // Test 7
            Cooler coolerTest7 = new Cooler(19.7m, 4, false, true);
            ViewTestHeader("Test 7:\nTest av avslaget kylskåp med metoden Tick. Dörren är öppen.\n");
            Run(coolerTest7);

            // Test 8
            ViewTestHeader("Test 8:\nTestar att ett undantag kastas då innertemperaturen tilldelas ett felaktigt \nvärde.");
            try
            {
                Cooler coolerTest8 = new Cooler(50m, 4);
                Run(coolerTest8);
            }
            catch (Exception)
            {
                ViewErrorMessage("Innertemperaturn är inte i intervallet 0 - 45°C.");
            }

            // Test 9
            ViewTestHeader("Test 9:\nTestar att ett undantag kastas då måltemperaturen tilldelas ett felaktigt värde.");
            try
            {
                Cooler coolerTest9 = new Cooler(15m, 26);
                Run(coolerTest9);
            }
            catch (Exception)
            {
                ViewErrorMessage("Måltemperaturen är inte i intervallet 0 - 20°C.");
            }
        }

        static private void Run(Cooler cooler)
        {
            // Startvärde för testen
            Console.WriteLine(cooler.ToString());

            // Simulerar att kylskåpet går i 10 minuter
            for (int i = 0; i < 10; i++)
            {
                cooler.Tick();
                Console.WriteLine(cooler.ToString());
            }
            
            Console.WriteLine();
        }

        static private void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message); // skriv ut felmeddelanden från catchsatserna i test 8 & 9
            Console.ResetColor();
            Console.WriteLine();
        }

        static private void ViewTestHeader(string header)
        {
            Console.WriteLine(HorizontalLine);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(header); // skriv ut strängen medskickad från testerna
            Console.ResetColor();
        }
    }
}
