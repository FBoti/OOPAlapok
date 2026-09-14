using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAlapok
{
    internal class Dolgozo : Szemely
    {
        public int Ber {  get; set; }

        public void Kiir()
        {
            Console.WriteLine($"Én egy dolgozó vagyok: {Nev}, {Ber} Ft bérrel.");
        }
    }
}
