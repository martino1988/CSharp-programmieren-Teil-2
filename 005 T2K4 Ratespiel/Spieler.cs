using System;
using System.Collections.Generic;
using System.Text;

namespace _005_T2K4_Ratespiel
{
    class Spieler
    {
        //Instanzvariablen (nie public!)
        string name;
        Random r = new Random();

        //Konstruktor

        public Spieler(string _name)
        {
            name = _name;
        }

        //Methoden
        public int RateZahl()
        {
            int zahl = r.Next(0, 10);
            return zahl;
        }
        public string Name()
        {
            return name;
        }
    }
}
