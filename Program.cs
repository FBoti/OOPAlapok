using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAlapok
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Hallgato h = new Hallgato();
            h.NeptunKod = "ABC123";
            h.Name = "Botond";
            h.Kiir();
            
            Dolgozo d = new Dolgozo();
            d.Name = "Ilona";
            d.Ber = 500000;
            d.Kiir();
            /*Bankszamla bank = new Bankszamla();
            bank.Betesz(1000);
            bank.Kivesz(500);
            Console.WriteLine(bank);
            Szemely sz = new Szemely();
            sz.Nev = "Botond";
            sz.Eletkor = 7000;
            Console.WriteLine(sz);*/
        }

    }
}
