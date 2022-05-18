using CourseAuto.Model;
using System;

namespace CourseAuto
{
    class Program
    {

        static void Main(string[] args)
        {
            // -- Création de la course
            Console.WriteLine("~~~ Création de la course ~~~");
            Circuit spa = new Circuit("Spa", 7.004);
            Course course = new Course("Correction", spa, 10);

            // -- Création des participants
            Console.WriteLine("~~~ Création des participants ~~~");
            Participant riri = new Participant("Riri", 0, new Voiture("Audi", "A5"));
            Participant fifi = new Participant("Fifi", 1, new Voiture("Fiat", "Punto"));
            Participant loulou = new Participant("Loulou", 2, new Voiture("Mini", "Cooper"));
            Participant picsou = new Participant("Picsou", 3, new Voiture("Bentley", "Continental", 120, 140));
            Participant donald = new Participant("Donald", 4, new Voiture("Volkswagen", "Golf", 90, 150));
            Participant daisy = new Participant("Daisy", 5, new Voiture("Ferrari", "488", 100, 160));

            Console.WriteLine("~~~ Ajouter des participants à la course ~~~");
            course.AjouterParticipant(riri);
            course.AjouterParticipant(fifi);
            course.AjouterParticipant(loulou);
            course.AjouterParticipant(picsou);
            course.AjouterParticipant(donald);
            course.AjouterParticipant(daisy);

            Console.WriteLine("~~~ Simulation de la course ~~~");
            string description = course.SeDecrire();
            Console.WriteLine(description);
            Console.WriteLine();
            Console.WriteLine("Appuyer sur \"Enter\" pour lancer la simulation...");
            Console.ReadLine();
            course.Simuler();

            Console.WriteLine("~~~ Affichage des temps au tour de chaque participants ~~~");
            for (int i = 0; i < course.NbTours; i++)
            {
                Console.WriteLine($"Résumé du tour {i + 1} : ");
                Console.WriteLine();

                foreach (Participant p in course.Participants)
                {
                    int min = p.TempsTour[i] / 60;
                    int sec = p.TempsTour[i] % 60;
                     
                    Console.WriteLine($" - {p.SeDecrire()} : {min:D2}\'{sec:D2}\".");
                }
                Console.ReadLine();
            }

            Console.WriteLine("~~~ Affichage des résultats ~~~");

            Participant vainqueur = course.ObtenirVainqueur();
            Console.WriteLine();

            Console.WriteLine($"Résumé de la course \"{course.Nom}\" est :");
            Console.WriteLine();
            foreach (Participant p in course.Participants)
            {
                int minute = p.TempsTotal / 60;
                int seconde = p.TempsTotal % 60;

                Console.WriteLine($" - {p.SeDecrire()} : {minute:D2}\'{seconde:D2}\".");
            }
            Console.WriteLine();

            Console.WriteLine($"Le vainqueur est {vainqueur.Nom} au bord d'une {vainqueur.Voiture.SeDecrire()}");

        }
    }
}
