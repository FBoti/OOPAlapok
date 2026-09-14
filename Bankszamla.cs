using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAlapok
{
    internal class Bankszamla
    {
        public uint Egyenleg {  get; set; }
        public void Betesz(int betet)
        {
            Egyenleg += (uint)betet;
        }
        public void Kivesz(int kivesz)
        {
            if (Egyenleg > 0) {
                Egyenleg -= (uint)kivesz;
            }
            else {
                Console.WriteLine("Nincs elég pénz a számlán.");
            }
        }

        public override string ToString()
        {
            return $"{Egyenleg}";
        }
    }
}
