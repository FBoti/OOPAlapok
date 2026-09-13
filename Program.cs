using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Alapok
{
    class Program
    {
        static void Main(string[] args)
        {
            var sz1 = new Szemely("Kovács Péter", 30);
            Console.WriteLine($"Létrehozva: {sz1}");

            sz1.Kor = -5;
            Console.WriteLine($"Életkor teszt után az állapot: {sz1}\n");

            var szamla = new BankSzamla(10000);
            Console.WriteLine($"Nyitó egyenleg: {szamla.Egyenleg:N0} Ft");

            szamla.Betesz(5000);
            szamla.Kivesz(20000);
            szamla.Kivesz(8000);
            Console.WriteLine();

            var hallgatok = new List<Hallgato>
            {
                new Hallgato("Nagy Anna", 21, "ABC123"),
                new Hallgato("Tóth Gábor", 22, "XYZ789"),
                new Hallgato("Szabó Éva", 20, "HOSSZU_KOD")
            };

            foreach (var h in hallgatok)
            {
                Console.WriteLine($" - {h.Nev} (Neptun: {h.NeptunKod ?? "HIÁNYZIK"})");
            }
            Console.WriteLine();

            var resztvevok = new List<Szemely>
            {
                new Hallgato("Kiss Balázs", 23, "KLM456"),
                new Dolgozo("Varga Ilona", 45, 450000),
                new Szemely("Horváth Mária", 60)
            };

            foreach (var r in resztvevok)
            {
                r.Bemutatkozas();
            }
        }
    }
}
