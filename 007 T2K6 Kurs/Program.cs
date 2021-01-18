using System;

namespace _007_T2K6_Kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie eine Klasse Kurs mit folgenden Instanzvariablen:
            //    • kursname(string)
            //    • kurspreis(double)
            //    • teilnehmer(string[10])
            //kursname und kurspreis werden über den Konstruktor gesetzt. Schreiben Sie Methoden zum Hinzufügen und Entfernen von Kursteilnehmern, sowie zur Ausgabe aller Kursdetails inklusive der Teilnehmernamen auf der Konsole.
            Kurs k = new Kurs("Programmieren in C#", 3900);
            while (true)
            {
                Console.WriteLine("\n-------------------------------------\nMenue:\n1. Teilnehmer hinzufügen\n2. Teilnehmer entfernen\n3. Kursdetails drucken");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //Hinzufügen
                        Console.WriteLine("Name des Kursteilnehmers:");
                        string name = Console.ReadLine();
                        bool result1 = k.TeilnehmerHinzufügen(name);
                        switch (result1)
                        {
                            case true:
                                Console.WriteLine("Teilnehmer hinzugefügt");
                                break;
                            case false:
                                Console.WriteLine("Hinzufügen fehlgeschalgen");
                                break;
                        }
                        break;
                    case 2:
                        //Entfernen
                        Console.WriteLine("Name des Kursteilnehmers der den Kurs verlässt:");
                        string name2 = Console.ReadLine();
                        bool result2 = k.TeilnehmerEntfernen(name2);
                        switch (result2)
                        {
                            case true:
                                Console.WriteLine("Teilnehmer entfernt");
                                break;
                            case false:
                                Console.WriteLine("Entfernen fehlgeschalgen");
                                break;
                        }
                        break;
                    case 3:
                        //Drucken
                        k.Drucken();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }

        }
    }
}
