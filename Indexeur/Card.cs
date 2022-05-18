using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexeur
{
    public enum Couleurs { Coeur, Pique, Trefle, Carreau }
    public enum Valeurs { Deux = 2, Trois, Quatre, Cinq, Six, Sept, Huit, Neuf, Dix, Valet, Dame, Roi, As }

    class Card
    {
        public Couleurs Couleur;
        public Valeurs Valeur;
    }
}
