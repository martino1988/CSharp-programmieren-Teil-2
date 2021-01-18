using System;
using System.Collections.Generic;
using System.Text;

namespace _005_T2K4_Ratespiel
{
    public class Ratespiel
    {
        //Instanzvariablen (nie public!)
        static int zufallsZahl;
        static Random r;

        static Spieler[] spielerarray;

        //Konstruktor

        public Ratespiel()
        {

        }

        //Methoden
        public static void Spiele()
        {
            r = new Random();
            zufallsZahl = r.Next(0, 10);

            spielerarray = new Spieler[3];
            Spieler s1 = new Spieler("Spieler1");
            Spieler s2 = new Spieler("Spieler2");
            Spieler s3 = new Spieler("Spieler3");

            spielerarray[0] = s1;
            spielerarray[1] = s2;
            spielerarray[2] = s3;

            bool erraten = false;
            string spielername = null;
            int gerateneZahl = 0;
            int runde = 1;
            while (!erraten)
            {
                Console.WriteLine("Runde: " + runde);
                foreach (var s in spielerarray)
                {
                    int geraten = s.RateZahl();
                    if(geraten == zufallsZahl)
                    {
                        erraten = true;
                        gerateneZahl = geraten;
                        spielername = s.Name();
                        break;
                    }
                }
                runde++;
            }
            Console.WriteLine("Sieger: " + spielername + ", gesuchte Zahl: " + zufallsZahl + ", geratene Zahl: " + gerateneZahl);

        }
    }
}
