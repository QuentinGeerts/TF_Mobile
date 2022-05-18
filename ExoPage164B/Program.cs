using System;
using System.Collections.Generic;

namespace ExoPage164B
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Grâce à une boucle "for" et à l'aide d'une collection générique, 
             * calculez les x premiers nombres premiers (version optimisée).
             */

            Console.WriteLine("Combien de nombre premier voulez-vous afficher :");
            int userNumber = int.Parse(Console.ReadLine());

            List<int> premiers = new List<int>();

            for (int nbToAnalyse = 2; premiers.Count < userNumber; nbToAnalyse++)
            {
                bool isNbPremier = true;

                for (int diviseur = 2; diviseur < nbToAnalyse; diviseur++)
                {
                    if (nbToAnalyse % diviseur == 0) isNbPremier = false;
                }

                if (isNbPremier)
                {
                    premiers.Add(nbToAnalyse);
                }

            }

            foreach (int premier in premiers)
            {
                Console.WriteLine(premier);
            }

        }
    }
}
