using System;

namespace _005_T2K4_Ratespiel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Das Programm umfasst folgende Klassen:
            //1.RatespielTest, enthält die Main Methode
            //2.Ratespiel, führt das Spiel durch und zwar in der Methode Spiele().In dieser Methode werden 3 Spieler erzeugt und eine Zufallszahl ausgedacht, welche die drei Spieler erraten sollen.Sobald einer der Spieler die Zufallszahl erraten hat, ist das Spiel zu Ende.
            //3.Spieler, kann eine Zahl raten
            //Beschränken Sie sich auf Zufallszahlen zwischen 0 und 9, welche wie folgt erzeugt werden können:
            //Random random = new Random();
            //int zufallsZahl = random.Next(0, 10);

            Console.WriteLine("Wie viele Spiele sollen gespielt werden?");
            int anz = Convert.ToInt32(Console.ReadLine());

            

            for (int i = 1; i <= anz; i++)
            {
                Console.WriteLine("------------------------------\nSpiel " + i + ":\n");
                Ratespiel.Spiele();
                Console.WriteLine("------------------------------\n");
            }


        }
    }
}
