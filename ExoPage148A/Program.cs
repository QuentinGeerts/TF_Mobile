using System;

namespace ExoPage148A
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb1 = 0, nb2 = 1, temp;

            int i = 0;

            Console.Write($"{nb1}");

            while (i < 25)
            {
                Console.Write($", {nb2}");

                temp = nb1 + nb2;
                nb1 = nb2;
                nb2 = temp;

                i++;
            }
        }
    }
}
