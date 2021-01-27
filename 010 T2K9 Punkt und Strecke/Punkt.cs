using System;
using System.Collections.Generic;
using System.Text;

namespace _010_T2K9_Punkt_und_Strecke
{
    class Punkt
    {
        private int x;
        private int y;

        //Instanzvariablen (nie public!)

        //Konstruktor
        public Punkt(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        //Methoden
        public int X { get { return x; } }
        public int Y { get { return y; } }
    }
}
