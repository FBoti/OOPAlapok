using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Alapok
{
    public class Hallgato : Szemely
    {
        private string neptunKod;

        public string NeptunKod
        {
            get => neptunKod;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Trim().Length == 6)
                {
                    neptunKod = value.Trim().ToUpper();
                }
                else
                {
                    Console.WriteLine($"[Hiba] A megadott Neptun-kód ('{value}') érvénytelen. Pontosan 6 karakterből kell állnia!");
                }
            }
        }

        public Hallgato(string nev, int eletkor, string neptunKod) : base(nev, eletkor)
        {
            this.NeptunKod = neptunKod;
        }

        public override void Bemutatkozas()
        {
            string kodInfo = string.IsNullOrEmpty(neptunKod) ? "még nincs megadva" : neptunKod;
            Console.WriteLine($"Üdv! {nev} vagyok, egyetemi hallgató. Neptun-kódom: {kodInfo}.");
        }
    }

}
