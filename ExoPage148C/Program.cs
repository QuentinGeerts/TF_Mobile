using System;

namespace ExoPage148C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de nombre premier voulez-vous afficher :");
            int userNumber = int.Parse(Console.ReadLine());
            int nbFound = 0;

            for (int nbToAnalyse = 1; nbFound < userNumber; nbToAnalyse++)
            {
                bool isNbPremier = true;
                int nbDiv = 0;

                for (int diviseur = 1; diviseur <= nbToAnalyse; diviseur++)
                {
                    if (nbToAnalyse % diviseur == 0) nbDiv++;
                }

                isNbPremier = nbDiv == 2;

                if (isNbPremier)
                {
                    nbFound++;
                    Console.WriteLine(nbToAnalyse);
                }

            }
        }
    }
}
