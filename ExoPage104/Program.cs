using System;

namespace ExoPage104
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Parse()
            Console.WriteLine("Entrez un premier nombre : ");
            string snb1 = Console.ReadLine();

            Console.WriteLine("Entrez un deuxième nombre : ");
            string snb2 = Console.ReadLine();

            int nb1 = int.Parse(snb1);
            int nb2 = int.Parse(snb2);

            int total = nb1 + nb2;

            Console.WriteLine($"{nb1} + {nb2} = {total}");

            // 2. TryParse()
            Console.WriteLine("Entrez un premier nombre : ");
            string sn1 = Console.ReadLine();

            Console.WriteLine("Entrez un deuxième nombre : ");
            string sn2 = Console.ReadLine();

            int i, j;

            int.TryParse(sn1, out i);
            int.TryParse(sn2, out j);

            int total2 = i + j;

            Console.WriteLine($"{i} + {j} = {total2}");
        }
    }
}
