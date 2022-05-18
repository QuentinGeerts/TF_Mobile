using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    // internal
    enum Carburant { Diesel, Essence, Gaz }

    // Premier élément dans un namespace = Public ou Internal
    // Par défaut : Internal
    internal class Personne
    {

        // Par défaut : Private
        public string Nom;

        public Carburant c;

    }
}
