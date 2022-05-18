using System;

namespace GestionBanque04_1.Model
{
    class Epargne
    {
        // Attributs
        private string _Numero;
        private double _Solde;
        private DateTime _DateDernierRetrait;
        private Personne _Titulaire;

        // Propriétés
        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public double Solde
        {
            get { return _Solde; }
            private set { _Solde = value; }
        }

        public DateTime DernierRetrait
        {
            get { return _DateDernierRetrait; }
            private set { _DateDernierRetrait = value; }
        }

        public Personne Titulaire
        {
            get { return _Titulaire; }
            set { _Titulaire = value; }
        }

        // Méthodes
        public void Retrait(double Montant)
        {
            if (Montant <= 0)
                return; //à remplacer plus tard par une exception

            if (Solde - Montant < 0)
                return; //à remplacer plus tard par une exception

            Solde -= Montant;
            DernierRetrait = DateTime.Now;
        }

        public void Depot(double Montant)
        {
            if (Montant <= 0)
                return; //à remplacer plus tard par une exception

            Solde += Montant;
        }

        // Surcharge d'opérateur
        public static double operator +(double Solde, Epargne c)
        {
            return Solde + ((c.Solde < 0.0) ? 0.0 : c.Solde);
        }
    }
}
