using System;

namespace GestionBanque11.Model
{
    interface ICustomer
    {
        // Propriété
        double Solde { get; }

        // Méthodes
        void Depot(double Montant);
        void Retrait(double Montant);

    }
}
