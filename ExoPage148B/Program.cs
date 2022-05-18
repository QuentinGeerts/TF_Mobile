using System;

namespace ExoPage148B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre à mettre en factoriel : ");
            int result = int.Parse(Console.ReadLine());

            for (int i = result; i > 1; i--)
            {
                result *= (i-1);
            }

            Console.WriteLine(result);
        }
    }
}
