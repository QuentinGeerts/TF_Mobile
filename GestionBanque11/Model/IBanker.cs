using System;

namespace GestionBanque11.Model
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
