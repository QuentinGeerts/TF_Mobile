using System;

namespace GestionBanque10.Model
{
    interface IBanker : ICustomer
    {
        // Propriétés
        Personne Titulaire { get; }
        string Numero { get; }

        // Méthode
        void AppliquerInteret();
    }
}
