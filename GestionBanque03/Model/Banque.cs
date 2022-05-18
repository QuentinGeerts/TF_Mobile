using System.Collections.Generic;

namespace GestionBanque03.Model
{
    class Banque
    {
        public string Nom { get; set; }

        Dictionary<string, Courant> _Comptes = new Dictionary<string, Courant>();

        public Courant this[string Numero]
        {
            get
            {
                _Comptes.TryGetValue(Numero, out Courant courant);
                return courant;
            }
        }

        // Méthodes
        public void Ajouter (Courant compte)
        {
            if (_Comptes.TryAdd(compte.Numero, compte)) System.Console.WriteLine("Ajouté");
            else System.Console.WriteLine("Le compte existe déjà.");
        }

        public void Supprimer (string Numero)
        {
            _Comptes.Remove(Numero);
        }

        public double AvoirDesComptes (Personne titulaire)
        {
            double totalDesAvoirs = 0;

            foreach (KeyValuePair<string, Courant> kvp in _Comptes)
            {
                Courant compte = kvp.Value;
                if (compte.Titulaire == titulaire) totalDesAvoirs += compte;
            }

            return totalDesAvoirs;
        }
    }
}
