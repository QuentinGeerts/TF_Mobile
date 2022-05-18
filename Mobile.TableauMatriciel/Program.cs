using System;

namespace Mobile.TableauMatriciel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] names = { { "Geerts", "Gioé", "Emmery"}, { "Quentin", "Fabio", "Nicolas"} };
            // {0} = nom ; {1} = prenom

            //Console.WriteLine($"Nom : {names[0, 0]} | Prénom : {names[1, 0]}");

            //Console.WriteLine(names.Length);

            for (int i = 0; i < names.Length / 2; i++)
            {
                Console.WriteLine($"Nom : {names[0, i]} | Prénom : {names[1, i]}");
            }

        }
    }
}
