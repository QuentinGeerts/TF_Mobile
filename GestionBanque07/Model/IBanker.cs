﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque07.Model
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
