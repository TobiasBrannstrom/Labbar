using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaUppgift
{
    class Program
    {
        // Konstanter
        private const int KronorPerFemhundralapp = 500;
        private const int KronorPerHundralapp = 100;
        private const int KronorPerFemtiolapp = 50;
        private const int KronorPerTjugolapp = 20;
        private const int KronorPerTia = 10;
        private const int KronorPerFemma = 5;
        private const int KronorPerKrona = 1;
        
        static void Main(string[] args)
        {

            // deklarera variablar
            decimal summa = 0;
            int erhalletBelopp = 0;
            decimal vaxel = 0;
            decimal avrundatBelopp = 0;
            uint total = 0;

            // Indata

            while (true)
            {  
                try
                {
                    Console.Write("Ange totalsumma      : ");
                    summa = decimal.Parse(Console.ReadLine());
                    break;
                }
      
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nErhållet belopp är felaktigt!\n");
                    Console.ResetColor();  
                }

            }
            
            if (summa < 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nTotalsumman är för liten. Köpet kunde inte genomföras.\n");
                Console.ResetColor();  
                return;
            }
           
            while (true)
            {
                try              
                {                                     
                    Console.Write("Ange erhållet belopp : ");
                    erhalletBelopp = int.Parse(Console.ReadLine());
                    break;
                }
                catch(Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nErhållet belopp felaktigt!\n");
                    Console.ResetColor();  
                }
            }
            if (erhalletBelopp < summa)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nErhållet belopp är för litet. Köpet kunde inte genomföras.\n");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }

        


            // Öresavrundning

            total = (uint)Math.Round(summa);
            avrundatBelopp = total - (summa);

        
       
            // Växel

            vaxel = erhalletBelopp - total;

            // Utskrift

                  Console.WriteLine("\nKVITTO\n------------------------");
                  Console.WriteLine("\n{0, -15} : {1,15:c}", "Totalt", summa);
                //  Console.WriteLine("Öresavrundning   : {0}", avrundatBelopp);
                  Console.WriteLine("{0, -15} : {1,15:c}", "Öresavrundning", avrundatBelopp);
                  Console.WriteLine("{0, -15} : {1,15:c}", "Att betala", total);
                  Console.WriteLine("{0, -15} : {1,15:c}", "Kontant", erhalletBelopp);
                  Console.WriteLine("{0, -15} : {1,15:c}", "Tillbaka", vaxel);
                  Console.WriteLine("\n------------------------\n");
        
            // Sedlar och mynt tillbaks

            decimal value = vaxel;
            int omvandlat = (int)value;

            int kronor = omvandlat;
            int femhundring = 0;
            int hundring = 0;
            int femtiolapp = 0;
            int tjuga = 0;
            int tia = 0;
            int femma = 0;
            int krona = 0;
            int kvarvarandeKronor = 0;
            
            // Uppdelning av kronor i sedlar och mynt

            kvarvarandeKronor = kronor;
            
            femhundring = kvarvarandeKronor / KronorPerFemhundralapp;
            kvarvarandeKronor = kvarvarandeKronor % KronorPerFemhundralapp;
            
            hundring = kvarvarandeKronor / KronorPerHundralapp;
            kvarvarandeKronor = kvarvarandeKronor % KronorPerHundralapp;

            femtiolapp = kvarvarandeKronor / KronorPerFemtiolapp;
            kvarvarandeKronor = kvarvarandeKronor % KronorPerFemtiolapp;
            
            tjuga = kvarvarandeKronor / KronorPerTjugolapp;
            kvarvarandeKronor = kvarvarandeKronor % KronorPerTjugolapp;

            tia = kvarvarandeKronor / KronorPerTia;
            kvarvarandeKronor = kvarvarandeKronor % KronorPerTia;
          
            femma = kvarvarandeKronor / KronorPerFemma;
            kvarvarandeKronor = kvarvarandeKronor % KronorPerFemma;

            krona = kvarvarandeKronor / KronorPerKrona;
            kvarvarandeKronor = kvarvarandeKronor % KronorPerKrona;

            // Utskrift av resultatet
            /*Console.WriteLine("500-lappar  :  {0} \n100-lappar  :  {1}\n50-lappar   :  {2} \n20-lappar   :  {3}\n10-kronor   :  {4}\n5-kronor    :  {5} \n1-kronor    :  {6}\n\n\n",
                femhundring, hundring, femtiolapp, tjuga, tia, femma, krona);*/
            if (femhundring > 0)
            {
                Console.WriteLine("{0, -10} : {1}", "500-lappar", femhundring);
            }
            if (hundring > 0)
            {
                Console.WriteLine("{0, -10} : {1}", "100-lappar", hundring);
            }
            if (femtiolapp > 0)
            {
                Console.WriteLine("{0, -10} : {1}","50-lappar", femtiolapp);
            }
            if (tjuga > 0)
            {
                Console.WriteLine("{0, -10} : {1}", "20-lappar", tjuga);
            }
            if (tia > 0)
            {
                Console.WriteLine("{0, -10} : {1}","10-kronor", tia);
            }
            if (femma > 0)
            {
                Console.WriteLine("{0, -10} : {1}","5-kronor", femma);
            }
            if (krona > 0)
            {
                Console.WriteLine("{0, -10} : {1}","1-kronor", krona);
            }
        }
    }
}
