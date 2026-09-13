using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Alapok
{
    public class Dolgozo : Szemely
    {
        public decimal Ber { get; set; }

        public Dolgozo(string nev, int eletkor, decimal ber) : base(nev, eletkor)
        {
            Ber = ber;
        }

        public override void Bemutatkozas()
        {
            Console.WriteLine($"Jó napot! {nev} vagyok, munkavállaló. Havi fizetésem: {Ber:N0} Ft.");
        }
    }
}
