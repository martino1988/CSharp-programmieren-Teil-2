using System;
using System.Collections.Generic;
using System.Text;

namespace _010_T2K9_Punkt_und_Strecke
{
    class Strecke
    {
        //Instanzvariablen (nie public!)
        private Punkt punkt1;
        private Punkt punkt2;

        //Konstruktor
        public Strecke(Punkt _punkt1, Punkt _punkt2)
        {
            punkt1 = _punkt1;
            punkt2 = _punkt2;
        }

        //Methoden
        public double Laenge()
        {
            return Math.Sqrt(Math.Pow((punkt1.X-punkt2.X),2) + Math.Pow((punkt1.Y-punkt2.Y),2));
        }
    }
}
