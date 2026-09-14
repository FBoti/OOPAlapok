using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAlapok
{
    internal class Hallgato : Szemely
    {
        private string neptunKod;
        public string NeptunKod
        {
            get { return neptunKod; }
            set { if (value.Length<=6) 
                    { neptunKod = value; } 
            }
        }
        public void Kiir()
        {
            Console.WriteLine($"Én egy hallgató vagyok:");
        }
    }
}
