using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAlapok
{
    internal class Szemely
    {

        public string Nev { get; set; }

        public Szemely(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }
    }
}
