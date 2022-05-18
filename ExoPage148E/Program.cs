using System;

namespace ExoPage148E
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A l'aide d'une boucle "for" comptez de 0 à 20.0 en augmentant de 0.1, 
             * en utilisant des doubles, et afficher la valeur à chaque itération.
             * Remarquez-vous quelque chose de particulier ?
             */

            for (double i = 0; i <= 20.1; i += 0.1)
            {
                Console.WriteLine($"{string.Format("{0:0.0}", i)}");
            }

            //for (decimal i = 0; i <= 20; i += 0.1M)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 200; i++)
            //{
            //    Console.WriteLine($"{i/10.0}");
            //}

        }
    }
}
