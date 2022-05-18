using System;

namespace GestionBanque08.Model
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
