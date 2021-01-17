using System;

namespace _003_T2K2_Uhrzeit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schreiben Sie eine Klasse zur Verwaltung der Uhrzeit und Ausgabe in der Form HH:MM:SS. 
            //Implementieren Sie Methoden zum Setzen der Uhrzeit und zur Ausgabe. 
            //Weiters soll es möglich sein zur eigenen Uhrzeit eine andere Uhrzeit zu addieren, 
            //von der eigenen Uhrzeit eine andere Uhrzeit zu subtrahieren und die Differenz zweier Uhrzeiten zu ermitteln (von der größeren Zeit subtrahieren).

            //Klassenname:
            //       Uhrzeit
            //----------------------
            //Istanzvariablen:   
            //    -sec : long
            //----------------------
            //Methoden:
            //  +Uhrzeit(hh : int, mm : int, ss : int)
            //  +SetUhrzeit(hh : int, mm : int, ss : int)
            //  +Add(t2 : Uhrzeit)
            //  +Sub(t2 : Uhrzeit)
            //  +Diff(t2 : Uhrzeit, out hh : int, out mm : int, out ss : int)
            //  +Drucken()
            bool chk = false;

            while (true)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Menü:");
                Console.WriteLine("1. Uhrzeit festlegen");
                Console.WriteLine("2. Uhrzeit addieren");
                Console.WriteLine("3. Uhrzeit subtrahieren");
                Console.WriteLine("4. Differenz berechnen");
                Console.WriteLine("5. (neue) Uhrzeit anzeigen");
                Console.WriteLine("-----------------------");
                int auswahl = Convert.ToInt32(Console.ReadLine());
                switch (auswahl)
                {
                    case 1:
                        //Uhrzeit festlegen + bool chk setzen
                        Console.Write("Stunden festlegen: ");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Minuten festlegen: ");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sekunden festlegen: ");
                        int s = Convert.ToInt32(Console.ReadLine());
                        bool c = Uhrzeit.setUhrzeit(h, m, s);
                        if (c == true)
                            chk = true;
                        break;
                    case 2:
                        //Uhrzeit addieren und chk überprüfen
                        if(chk == true)
                        {
                            Console.WriteLine("Uhrzeit zum Addieren eingeben:"); 
                            Console.Write("Stunden festlegen: ");
                            int hadd = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Minuten festlegen: ");
                            int madd = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Sekunden festlegen: ");
                            int sadd = Convert.ToInt32(Console.ReadLine());

                            Uhrzeit.Add(hadd, madd, sadd);
                        }
                        else
                            Console.WriteLine("Uhrzeit muss festgelegt werden");
                        break;
                    case 3:
                        //Uhrzeit subtrahieren und chk überprüfen
                        if (chk == true)
                        {
                            Console.WriteLine("Uhrzeit zum Addieren eingeben:");
                            Console.Write("Stunden festlegen: ");
                            int hsub = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Minuten festlegen: ");
                            int msub = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Sekunden festlegen: ");
                            int ssub = Convert.ToInt32(Console.ReadLine());

                            Uhrzeit.Sub(hsub, msub, ssub);
                        }
                        else
                            Console.WriteLine("Uhrzeit muss festgelegt werden");
                        break;
                    case 4:
                        //Differenz berechnen und chk überprüfen
                        if (chk == true)
                        {
                            Console.WriteLine("Uhrzeit zur Berechnung der Differenz eingeben:");
                            Console.Write("Stunden festlegen: ");
                            int hdiff = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Minuten festlegen: ");
                            int mdiff = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Sekunden festlegen: ");
                            int sdiff = Convert.ToInt32(Console.ReadLine());

                            Uhrzeit.Diff(hdiff, mdiff, sdiff);
                        }
                        else
                            Console.WriteLine("Uhrzeit muss festgelegt werden");
                        break;
                    case 5:
                        //Uhrzeit drucken und chk überprüfen
                        if (chk == true)
                        {
                            Uhrzeit.Drucken();
                        }
                        else
                            Console.WriteLine("Uhrzeit muss festgelegt werden");
                        break;
                    default:
                        //
                        Console.WriteLine("Error! Falsche Eingabe");
                        break;
                }
            }
        }
    }
}
