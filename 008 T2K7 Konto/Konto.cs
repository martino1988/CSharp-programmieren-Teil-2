using System;
using System.Collections.Generic;
using System.Text;

namespace _008_T2K7_Konto
{
    class Konto
    {
        //Instanzvariablen
        string name;
        double guthaben;
        double ueberziehungsrahmen;

        //Konstruktor
        public Konto(string _name, double _guthaben, double _ueberziehungsrahmen)
        {
            name = _name;
            guthaben = _guthaben;
            ueberziehungsrahmen = _ueberziehungsrahmen;
        }

        //Methoden
        public void Einzahlen(double betrag)
        {
            if(betrag >= 0)
            {
                guthaben += betrag;
                Console.WriteLine("Betrag {0} Euro eingezahlt. Neues Guthaben: {1} Euro", betrag, guthaben);
            }
            else if(betrag < 0)
            {
                Console.WriteLine("Betrag muss positiv sein!");
            }
            else
                Console.WriteLine("Error Einzahlen");
            
        }
        public void Auszahlen(double betrag)
        {
            double differenz = guthaben - betrag;
            if ((differenz * -1) > ueberziehungsrahmen)
            {
                Console.WriteLine("Abbuchung von {0} Euro nicht möglich. Guthaben wäre {1} und würde den Überziehungsrahmen von {2} Euro überziehen.", betrag, differenz, ueberziehungsrahmen);
            }
            else if ((differenz * -1) <= ueberziehungsrahmen)
            {
                guthaben = differenz;
                Console.WriteLine("Abbuchung von {0} Euro erfolgreich! Neues Guthaben: {1} Euro", betrag, guthaben);
            }
        }
        public void InformationenAnzeigen()
        {
            Console.WriteLine("----------------\nKontoinhaber: {0}\nGuthaben: {1} Euro\nUeberziehungsrahmen: {2} Euro\n--------------", name, guthaben, ueberziehungsrahmen);
        }
    }
}
