using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.Structures
{
    public struct Contact
    {
        public string Nom, Prenom, Surnom, AdresseMail;
    }

    public struct Message
    {
        public string Objet, Contenu;
        public Contact Destinataire, Expediteur;
        public DateTime HeureEnvoi;
        public bool AccuseReception;
    }
}
