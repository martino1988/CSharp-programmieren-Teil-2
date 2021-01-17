using System;

namespace _004_T2K3_Kreis
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Radius (in cm) eingeben:");
                double r = Convert.ToDouble(Console.ReadLine());

                Kreis k = new Kreis(r);

                k.printRadius();
                k.printUmfang();
                k.printFlaeche();
               
            }
        }
    }
}
