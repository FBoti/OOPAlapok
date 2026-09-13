using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_Alapok
{
    public class Szemely
    {
        protected string nev;
        private int eletkor;

        public string Nev
        {
            get => nev;
            set => nev = value;
        }

        public int Kor
        {
            get => eletkor;
            set
            {
                if (value >= 0)
                {
                    eletkor = value;
                }
                else
                {
                    Console.WriteLine($"[Hiba] Hahó, {nev}! Az életkor nem lehet negatív szám ({value}). A módosítás elutasítva.");
                }
            }
        }

        public Szemely(string nev, int eletkor)
        {
            this.nev = nev;
            this.Kor = eletkor;
        }

        public virtual void Bemutatkozas()
        {
            Console.WriteLine($"Szia! A nevem {nev}, és {eletkor} éves vagyok.");
        }

        public override string ToString()
        {
            return $"{nev} ({eletkor} éves)";
        }
    }
}