using System;
using System.Collections;

namespace ExoPage164A
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Grace à une boucle "while" et à l'aide d'une collection, calculez les 
             * nombres premiers inférieur à un nombre entier entré au clavier
             */

            Console.WriteLine("Veuillez introduire un nombre que les nombre ne peuvent dépasser :");
            int maxValue = int.Parse(Console.ReadLine());

            Queue queue = new Queue();

            int value = 2;

            while ( value < maxValue )
            {
                bool isNbPremier = true;
                int diviseur = 2;

                while (diviseur < value)
                {
                    if (value % diviseur == 0) isNbPremier = false;
                    diviseur++;
                }

                if (isNbPremier) queue.Enqueue(value);

                value++;
            }

            foreach (int nbPremier in queue)
            {
                Console.WriteLine(nbPremier);
            }

        }
    }
}
