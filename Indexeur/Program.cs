using System;

namespace Indexeur
{
    class Program   
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.InitDeck();

            Card[] main = new Card[7];

            for (int i = 0; i < 7; i++)
            {
                main[i] = deck[0];
            }

            foreach (Card card in main)
            {
                Console.WriteLine($"Le {card.Valeur} de {card.Couleur}");
            }

            deck[-1] = main[3]; // 

            main[3] = deck[Couleurs.Coeur, Valeurs.As];

            Console.WriteLine($"Le {main[3].Valeur} de {main[3].Couleur}");

            //deck[Couleurs.Coeur, Valeurs.As] = null;

            //Console.WriteLine($"Le {deck[Couleurs.Coeur, Valeurs.As].Valeur} de {deck[Couleurs.Coeur, Valeurs.As].Couleur}");

        }
    }
}
