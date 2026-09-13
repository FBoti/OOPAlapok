using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Alapok
{
    public class BankSzamla
    {
        public decimal Egyenleg { get; private set; }

        public BankSzamla(decimal kezdoEgyenleg)
        {
            if (kezdoEgyenleg >= 0)
            {
                Egyenleg = kezdoEgyenleg;
            }
            else
            {
                Egyenleg = 0;
                Console.WriteLine("[Figyelem] A kezdőegyenleg nem lehet negatív, 0 Ft-tal hoztuk létre a számlát.");
            }
        }

        public void Betesz(decimal osszeg)
        {
            if (osszeg <= 0)
            {
                Console.WriteLine("[Hiba] Csak pozitív összeget tudsz befizetni!");
                return;
            }

            Egyenleg += osszeg;
            Console.WriteLine($"[Sikeres befizetés] +{osszeg:N0} Ft | Jelenlegi egyenleg: {Egyenleg:N0} Ft");
        }

        public void Kivesz(decimal osszeg)
        {
            if (osszeg <= 0)
            {
                Console.WriteLine("[Hiba] A felvenni kívánt összegnek pozitívnak kell lennie!");
                return;
            }

            if (Egyenleg >= osszeg)
            {
                Egyenleg -= osszeg;
                Console.WriteLine($"[Sikeres kifizetés] -{osszeg:N0} Ft | Új egyenleg: {Egyenleg:N0} Ft");
            }
            else
            {
                Console.WriteLine($"[Sikertelen kifizetés] A(z) {osszeg:N0} Ft felvételéhez nincs elegendő fedezeted (Egyenleg: {Egyenleg:N0} Ft).");
            }
        }
    }
}
