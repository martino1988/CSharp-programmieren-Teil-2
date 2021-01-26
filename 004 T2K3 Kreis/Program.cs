using System;

namespace _004_T2K3_Kreis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erstellen Sie eine Klasse für die Implementierung eines Kreises mit der Instanzvariable radius. 
            //Implementieren Sie Methoden zur Ausgabe des Radius, Berechnung von Fläche (A) und Umfang (U).
            //𝑈= 2∙𝑟∙𝜋
            //𝐴=𝑟∙𝑟∙𝜋
            while (true)
            {
                Console.WriteLine("Radius (in cm) eingeben:");
                double r = Convert.ToDouble(Console.ReadLine());

                Kreis k = new Kreis(r);

                k.printRadius();
                k.printUmfang();
                k.printFlaeche();
                k.
               
            }
        }
    }
}
