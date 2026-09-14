using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAlapok
{
    internal class Szemely
    {
        protected string Nev;
        public int Eletkor;

        /*public override string ToString()
        {
            return $"{Nev} + {Eletkor}";
        }*/

        public string Name
        {
            get { return Nev; }
            set { Nev = value; }
        }
        /*public int Age
        {
            get { return Eletkor; }
            set { Eletkor = value; }
        }
        /*public Szemely(string nev, int kor)
        {
            Nev = nev;
            Eletkor = kor;
        }
        public void Kiir()
        {
            Console.WriteLine($"{Nev} + {Eletkor}");
        }*/
    }
}
