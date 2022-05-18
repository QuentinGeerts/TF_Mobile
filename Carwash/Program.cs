using System;

namespace Carwarsh
{
    class Program
    {
        static void Main(string[] args)
        {
            Carwash c = new Carwash();
            Voiture v1 = new Voiture(Plaque: "1-ABC-123");
            //Voiture v2 = new Voiture(Plaque: "1-ABC-124");
            //Voiture v3 = new Voiture(Plaque: "1-ABC-125");
            
            c.Traiter(v1);

            //Console.WriteLine();

            //c.Traiter(v2);

            //Console.WriteLine();

            //c.Traiter(v3);
        }
    }
}
