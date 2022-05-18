using System;
using System.Collections.Generic;

namespace Mobile.Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //PhoneNumber pn;

            //pn.nationalNumber = "+32";
            //pn.indicatif = 800;
            //pn.number = 336521;

            //Console.WriteLine($"{pn.nationalNumber}(0){pn.indicatif}/{pn.number}");

            //PhoneNumber pn2;
            //pn2.nationalNumber = "+32";
            //pn2.indicatif = 496;
            //pn2.number = 239048;

            Dictionary<string, Contact> maListeDeContacts = new Dictionary<string, Contact>();

            Contact c1;
            c1.Surnom = "Maman";
            c1.Nom = "NomMaman";
            c1.Prenom = "PrenomMaman";
            c1.AdresseMail = "maman@csharp.be";

            Contact c2;
            c2.Surnom = "Papa";
            c2.Nom = "NomPapa";
            c2.Prenom = "PrenomPapa";
            c2.AdresseMail = "Papa@csharp.be";

            Contact c3;
            c3.Surnom = "Moi";
            c3.Nom = "Nom";
            c3.Prenom = "Prenom";
            c3.AdresseMail = "moi@csharp.be";

            maListeDeContacts.Add(c1.AdresseMail, c1);
            maListeDeContacts.Add(c2.AdresseMail, c2);
            maListeDeContacts.Add(c3.AdresseMail, c3);

            //foreach (KeyValuePair<string, Contact> contact in maListeDeContacts)
            //{
            //    Console.WriteLine(contact.Key);
            //    Console.WriteLine($"{contact.Value.Nom} {contact.Value.Prenom} {contact.Value.Surnom} {contact.Value.AdresseMail}");
            //}

            Message message;
            message.Objet = "Coucou maman";
            message.Destinataire = maListeDeContacts[c1.AdresseMail];
            message.Expediteur = maListeDeContacts[c3.AdresseMail];
            message.Contenu = "";
            message.HeureEnvoi = DateTime.Now;
            message.AccuseReception = false;

            Console.WriteLine($"{message.Objet} {message.Destinataire.Surnom} {message.HeureEnvoi}");

        }

        public struct PhoneNumber
        {
            public string nationalNumber;
            public int indicatif;
            public int number;
        }
    }
}
