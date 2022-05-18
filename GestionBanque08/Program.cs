using GestionBanque08.Model;
using System;
using System.Collections.Generic;

namespace GestionBanque08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Personnes
            Personne p = new Personne("John", "Doe", new DateTime(2000, 1, 1));
            Personne p2 = new Personne("Geerts", "Quentin", new DateTime(1996, 04, 03));

            // Courants & Epargne
            Courant c = new Courant("0000001", p);
            Courant c2 = new Courant("0000002", p);
            Courant c3 = new Courant("0000003", p2);
            Epargne e1 = new Epargne("0000004", p2);


            // Banques
            Banque b = new Banque();
            b.Nom = "Ma Banque";
            b.Ajouter(c);
            b.Ajouter(c2);
            b.Ajouter(c3);

            e1.Depot(50);
            e1.Retrait(100);
            e1.Retrait(50);

            Console.WriteLine(e1.Solde);

            b["0000001"].Depot(500);
            b["0000002"].Depot(500);
            b["0000001"].Retrait(300);

            b["0000003"].Depot(500);
            b["0000003"].Retrait(3);

            // Utilisation des interfaces
            IBanker banker = b["0000001"];
            banker.Depot(50);
            Console.WriteLine(banker.Solde);
            banker.Retrait(50);
            Console.WriteLine(banker.Solde);
            banker.AppliquerInteret();

            ICustomer customer = b["0000001"];
            customer.Depot(50);
            Console.WriteLine(customer.Solde);
            customer.Retrait(50);
            Console.WriteLine(customer.Solde);

            Console.WriteLine();

            Console.WriteLine("Avant les interêts : ");
            Console.WriteLine(b["0000001"].Solde);
            Console.WriteLine(b["0000002"].Solde);
            Console.WriteLine(b["0000003"].Solde);

            foreach (KeyValuePair<string, Compte> kvp in b.Compte)
            {
                kvp.Value.AppliquerInteret();
            }

            Console.WriteLine();

            Console.WriteLine("Après les interêts : ");
            Console.WriteLine(b["0000001"].Solde);
            Console.WriteLine(b["0000002"].Solde);
            Console.WriteLine(b["0000003"].Solde);

            Console.WriteLine();
            Console.WriteLine(b.AvoirDesComptes(p));
            Console.WriteLine(b.AvoirDesComptes(p2));
        }
    }
}
