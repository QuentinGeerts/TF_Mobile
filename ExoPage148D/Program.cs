using System;

namespace ExoPage148D
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A l'aide de bouclde "for", afficher les 5 premières 
             * tables de multiplication en allant jusque "x20"
             * */


            for (int table = 1; table <= 5; table++)
            {
                Console.WriteLine($"Table de {table}");
                for (int number = 1; number <= 20; number++)
                {
                    Console.WriteLine($"{number} X {table} = {number * table}");
                }
                Console.WriteLine();
            }

        }
    }
}
