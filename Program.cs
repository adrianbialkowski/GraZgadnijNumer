using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZgadnijNumer
{
    class Program
    {
        static void Info()
        {
            string nazwa = "'Zgadnij numer'";
            string wersja = "1.0.0 ";
            string autor = " Adrian Bialkowski";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\n\t  Gra {nazwa}, wersja {wersja}by{autor}");
            Console.ResetColor();
        }

        static void Witaj()
        {
            Console.WriteLine("\n\nJak masz na imie?");
            Console.WriteLine();
            string imie = Console.ReadLine();
            Console.WriteLine("\n\nWitaj " + imie + ", zagrajmy w gre! :)");
        }

        static void JakiKolor(ConsoleColor kolor, string wiadomosc)
        {
            Console.ForegroundColor = kolor;
            Console.WriteLine(wiadomosc);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Info();
            Witaj();

            while (true)
            {
                Random losowa = new Random();
                int numer = losowa.Next(1, 20);
                int zgadywana = 0;

                Console.WriteLine("\nZgadnij numer pomiedzy 1 a 20");

                while (zgadywana != numer)
                {
                    string odpowiedz = Console.ReadLine();
                    if (!int.TryParse(odpowiedz, out zgadywana))
                    {
                        JakiKolor(ConsoleColor.DarkBlue, "Wprowadz NUMER od 1 do 20");
                        continue;
                    }
                    zgadywana = Int32.Parse(odpowiedz);
                    if (zgadywana != numer)
                    {
                        JakiKolor(ConsoleColor.Red, "Podany numer  jest nieprawidlowy, sprobuj jeszcze raz");
                    }
                }
                JakiKolor(ConsoleColor.Green, "Gratulacje, zgadles numer! :)");

                Console.WriteLine("Czy chcesz zagrac jeszcze raz? Y/N");

                ZlaOdpowiedz:

                string jeszczeRaz = Console.ReadLine().ToUpper();
                if (jeszczeRaz == "Y")
                    continue;
                else if (jeszczeRaz == "N")
                    return;
                else
                {
                    Console.WriteLine("Wprowadzono nieprawidlowa odpowiedz, wpisz Y na TAK lub N na NIE");
                    goto ZlaOdpowiedz;
                }


            }
        }
    }
}
