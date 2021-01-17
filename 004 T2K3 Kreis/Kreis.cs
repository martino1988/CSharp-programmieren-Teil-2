using System;
using System.Collections.Generic;
using System.Text;

namespace _004_T2K3_Kreis
{
    class Kreis
    {
        //Eigenschaften
        double radius;

        public Kreis(double r)
        {
            radius = r;
        }

        //Konstruktor

        //Methoden

        public void printRadius()
        {
            Console.WriteLine("Radius: {0}", radius);
        }
        public void printFlaeche()
        {
            double flaeche = radius * radius * Math.PI;
            Console.WriteLine("Flaeche: {0} cm²", flaeche);
        }
        public void printUmfang()
        {
            double umfang = 2 * radius * Math.PI;
            Console.WriteLine("Umfang: {0} cm", umfang);
        }

        
    }
}
