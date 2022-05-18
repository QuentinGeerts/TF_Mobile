using System;

namespace Mobile.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LENGTH = 50;
            int[] ints = new int[LENGTH];

            int nbElems = 0;
            bool again = true;

            while (nbElems < LENGTH && again)
            {
                Console.WriteLine("Entrez la valeur à ajouter dans le tableau :");
                ints[nbElems] = int.Parse(Console.ReadLine());
                nbElems++;
                Console.WriteLine("Voulez-vous encoder une nouvelle valeur : o/n");
                again = Console.ReadLine() == "o";
            }

            Console.WriteLine("\nAffichage du tableau");

            for (int index = 0; index < nbElems; index++)
            {
                Console.Write($"{ints[index]}");
                if (index < nbElems) Console.Write(", ");
            }
        }
    }
}
