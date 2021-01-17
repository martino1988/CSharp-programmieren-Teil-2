using System;
using System.Windows;

namespace _002_T2K1_PC_ein_ausschalten
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schreiben Sie eine Klasse MeinPC, die einen PC repräsentiert. 
            //Der PC kann eingeschaltet oder ausgeschaltet sein. 
            //Schreiben Sie Methoden Einschalten() und Ausschalten() mit denen Sie den Zustand des PC verändern können
            //und die Eigenschaftsmethode Status() um den derzeitigen Zustand auf der Konsole ausgeben zu können. 
            //Schreiben Sie ein Main Programm, welches ein MeinPC Objekt erzeugt und dann mehrmals den Zustand des Objektes ändert. 
            //Berücksichtigen Sie auch, dass ein eingeschalteter PC nicht nochmals eingeschaltet werden bzw ein ausgeschalteter PC nicht nochmals ausgeschaltet werden kann. 
            //In diesem Fall sollten entsprechende Meldungen auf der Konsole ausgegeben werden.

            //Klassenname:
            //       MeinPC
            //----------------------
            //Istanzvariablen:   
            //    -status : bool
            //----------------------
            //Methoden:
            //  +Einschalten(): bool
            //  +Ausschalten(): bool
            //  +Status{get}: bool

            MeinPC pc = new MeinPC();

            bool checker = true;
            while (checker)
            {
                //Console.WriteLine("Status: " + pc.Status());
                Console.WriteLine("\n----------------\nMenü:\n1. Einschalten\n2. Ausschalten\n3. Status abfragen\n4. Beenden\n----------------\n");
                int auswahl = Convert.ToInt32(Console.ReadLine());
                switch (auswahl)
                {
                    case 1:
                        //Einschalten
                        if (pc.Status() == false)
                        {
                            pc.Einschalten();
                        }
                        else
                            Console.WriteLine("Einschalten nicht möglich! Status ist: " + pc.Status());
                        break;
                    case 2:
                        //Ausschalten
                        if (pc.Status() == true)
                        {
                            pc.Ausschalten();
                        }
                        else
                            Console.WriteLine("Ausschalten nicht möglich! Status ist: " + pc.Status());
                        break;
                    case 3:
                        //Staus anzeigen:
                        if (pc.Status() == true)
                        {
                            Console.WriteLine("PC ist eingeschaltet");
                        }
                        else if (pc.Status() == false)
                        {
                            Console.WriteLine("PC ist ausgeschaltet");
                        }

                        break;
                    case 4:
                        //beenden
                        checker = false;
                        break;
                    default:
                        //Fehlermeldung
                        Console.WriteLine("Error");
                        break;
                }
            }


        }
    }
}
