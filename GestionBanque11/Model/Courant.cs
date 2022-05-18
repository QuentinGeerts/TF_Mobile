﻿using System;

namespace GestionBanque11.Model
{
    public class Courant : Compte
    {
        // Attributs
        private double _LigneDeCredit;

        // Propriétés
        public double LigneDeCredit
        {
            get { return _LigneDeCredit; }
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("La ligne de crédit doit être strictement positive.");

                _LigneDeCredit = value;
            }
        }

        // Constructeurs
        public Courant(string Numero, Personne Titulaire) : base(Numero, Titulaire)
        {

        }

        public Courant(string Numero, Personne Titulaire, double Solde) : base(Numero, Titulaire, Solde)
        {

        }

        // Méthodes
        public override void Retrait(double Montant)
        {
            bool ancienSoldeEstPositif = this.Solde >= 0;
            Retrait(Montant, LigneDeCredit);
            if (ancienSoldeEstPositif && this.Solde < 0) this.PassageEnNegatif();
        }

        protected override double CalculInteret()
        {
            return (Solde < 0) ? Solde * .0975 : Solde * .03;
        }
    }
}
