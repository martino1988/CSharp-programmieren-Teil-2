using System;

namespace _008_T2K7_Konto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie die Klasse Konto mit den folgenden Instanzvariablen
            //• Name des Kontoinhabers(string)
            //• Guthaben(double) – kann auch negativ sein
            //• Überziehungsrahmen(double)
            //Implementieren Sie Methoden für einzahlen und abheben.Bei der Abhebung muss der Überziehungsrahmen berücksichtigt werden. 
            //Implementieren Sie auch eine Methode um den derzeitigen Kontostand auszugeben.
            Console.Write("Kontoinhaber festlegen: ");
            string inh = Console.ReadLine();
            Console.Write("Guthaben festlegen: ");
            double guth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ueberziehungsrahmen festlegen: ");
            double ueber = Convert.ToDouble(Console.ReadLine());
            Konto k = new Konto(inh, guth, ueber);

            while (true)
            {
                Console.WriteLine("Menue:\n1. Einzahlen\n2.Auszahlen\n3.Kontoinformationen");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        k.Einzahlen(Betrag("Einzahlen"));
                        break;
                    case 2:
                        k.Auszahlen(Betrag("Auszahlen"));
                        break;
                    case 3:
                        k.InformationenAnzeigen();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
        public static double Betrag(string art)
        {
            Console.WriteLine("Betrag zum {0} eingeben: ", art);
            return Convert.ToDouble(Console.ReadLine());
            //oder:
            //double betr = Convert.ToDouble(Console.ReadLine());
            //return betr
        }


    }
    
}
