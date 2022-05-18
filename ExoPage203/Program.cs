using System;

namespace ExoPage203
{
    class Program
    {
        static void Main(string[] args)
        {
            Carte[] cartes = new Carte[52];

            int i = 0;
            foreach (string couleur in Enum.GetNames(typeof(Couleur)))
            {
                foreach (string valeur in Enum.GetNames(typeof(Valeur)))
                {
                    cartes[i] = new Carte
                    {
                        Couleur = (Couleur)Enum.Parse(typeof(Couleur), couleur),
                        Valeur = (Valeur)Enum.Parse(typeof(Valeur), valeur)
                    };

                    Console.WriteLine($"{cartes[i].Couleur} {cartes[i].Valeur}");
                    i++;
                }
            }

        }
    }
}
