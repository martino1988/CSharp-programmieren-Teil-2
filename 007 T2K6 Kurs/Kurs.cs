using System;
using System.Collections.Generic;
using System.Text;

namespace _007_T2K6_Kurs
{
    class Kurs
    {
        //Instanzvariablen (nie public!)
        string kursname;
        double kurspreis;
        string[] teilnehmer = new string[10];

        //Konstruktor
        public Kurs(string _kursname, double _kurspreis)
        {
            kursname = _kursname;
            kurspreis = _kurspreis;
        }

        //Methoden
        public bool TeilnehmerEntfernen(string tn)
        {
            for (int i = 0; i < teilnehmer.Length; i++)
            {
                if (teilnehmer[i] == tn)
                {
                    teilnehmer[i] = null;
                    return true;
                }
            }
            return false;

        }
        public bool TeilnehmerHinzufügen(string tn)
        {
            for (int i = 0; i < teilnehmer.Length; i++)
            {
                if (teilnehmer[i] == null)
                {
                    teilnehmer[i] = tn;
                    return true;
                }
            }
            return false;
        }
        public void Drucken()
        {
            Console.WriteLine("Kurs '{0}' kostet {1} Euro und hat fogende Teilnehmer:", kursname, kurspreis);
            int z = 1;
            foreach (string tn in teilnehmer)
            {
                if(tn != null)
                {
                    Console.WriteLine(z + ". " + tn);
                    z++;
                }
            }
            Console.WriteLine("-----------------------------------");
        }
    }
}
