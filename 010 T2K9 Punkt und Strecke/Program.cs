using System;

namespace _010_T2K9_Punkt_und_Strecke
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt[] punkte = new Punkt[2];
            for (int i = 0; i < punkte.Length; i++)
            {
                punkte[i] = PunktFestlegen("Punkt " + (i+1));
            }
            foreach(Punkt a in punkte)
            {
                Console.WriteLine("Punkt: X: " + a.X + " Y: " + a.Y);
            }
            Strecke s = new Strecke(punkte[0], punkte[1]);
            double laenge = s.Laenge();
            Console.WriteLine("Länge der Strecke zwischen Punkt 1 ({0}/{1}) und Punkt 2 ({2}/{3}): {4}", punkte[0].X, punkte[0].Y, punkte[1].X, punkte[1].Y, laenge);

        }

        static Punkt PunktFestlegen(string v)
        {
            Console.Write(v + " festlegen:\nX Achse bestimmen: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y Achse bestimmen: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Punkt p = new Punkt(x, y);
            return p;
        }
    }
}
