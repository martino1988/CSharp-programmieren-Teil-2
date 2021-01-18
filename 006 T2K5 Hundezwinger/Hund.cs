using System;
using System.Collections.Generic;
using System.Text;

namespace _006_T2K5_Hundezwinger
{
    class Hund
    {
        //Instanzvariablen (nie public!)
        string name;
        int alter;
        //Konstruktor

        public Hund(int _alter, string _name)
        {
            name = _name;
            alter = _alter;
        }

        //Methoden
        public void Bellen()
        {
            if (alter == 1)
            {
                Console.WriteLine("Hund {0} ist {1} Jahr alt und macht wau wau", name, alter);
            }
            else
                Console.WriteLine("Hund {0} ist {1} Jahre alt und macht wau wau", name, alter);
        }
    }
}
