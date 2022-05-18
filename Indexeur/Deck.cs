using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexeur
{
    class Deck
    {
        private List<Card> _deck = new List<Card>();

        public Card this[int index]
        {
            get
            {
                Card c = null;
                if (index < _deck.Count && index >= 0)
                {
                    c = _deck[index];
                    _deck.Remove(c);
                }
                return c;
            }

            set
            {
                if (index < _deck.Count && index >= 0)
                {
                    _deck[index] = value;
                }
                else
                {
                    _deck.Add(value);
                }
            }
        }

        public Card this[Couleurs color, Valeurs val]
        {
            get
            {
                Card c = null;
                for (int i = 0; i < _deck.Count; i++)
                {
                    if (_deck[i].Couleur == color && _deck[i].Valeur == val)
                    {
                        c = _deck[i];
                        _deck.Remove(c);
                    }
                }
                return c;
            }
            set
            {
                Card c = null;

                foreach (Card card in _deck)
                {
                    if (card.Couleur == color && card.Valeur == val) c = card;
                }

                if (c is null) _deck.Add(new Card() { Couleur = color, Valeur = val });
            }
        }

        public void InitDeck()
        {
            foreach (string colorName in Enum.GetNames(typeof(Couleurs)))
            {
                foreach (string valueName in Enum.GetNames(typeof(Valeurs)))
                {
                    Card c = new Card();
                    c.Couleur = (Couleurs)Enum.Parse<Couleurs>(colorName);
                    c.Valeur = (Valeurs)Enum.Parse<Valeurs>(valueName);
                    _deck.Add(c);
                }
            }
        }
    }
}
