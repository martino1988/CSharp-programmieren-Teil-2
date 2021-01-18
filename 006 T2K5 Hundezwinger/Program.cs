using System;

namespace _006_T2K5_Hundezwinger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie die Klasse Hund mit Instanzvariablen für Name und Alter des Hundes. 
            //Weiters hat die Klasse Hund eine Methode Bellen(). 
            //Legen Sie ein Array mit 3 Hund Objekten an und lassen Sie dann alle Hunde bellen.

            Hund[] hundezwinger = new Hund[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Name eingeben:");
                string name = Console.ReadLine();
                Console.WriteLine("Alter eingeben:");
                int alter = Convert.ToInt32(Console.ReadLine());

                hundezwinger[i] = new Hund(alter, name);
            }

            foreach (Hund h in hundezwinger)
            {
                h.Bellen();
            }
        }
    }
}
