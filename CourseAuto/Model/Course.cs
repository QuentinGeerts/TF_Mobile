using System;
using System.Collections.Generic;
using System.Text;

namespace CourseAuto.Model
{
    class Course
    {
        // Attributs
        private string _Nom;
        private Circuit _Circuit;
        private int _NbTours;
        private List<Participant> _Participants;

        // Propriétés
        public String Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }
        public Circuit Circuit
        {
            get { return _Circuit; }
            set { _Circuit = value; }
        }

        public int NbTours
        {
            get { return _NbTours; }
            set { _NbTours = value; }
        }

        public List<Participant> Participants
        {
            get { return _Participants; }
            private set { _Participants = value; }
        }

        // Constructeurs
        public Course(string nom, Circuit circuit, int nbTours)
        {
            if (circuit is null) throw new ArgumentNullException(nameof(circuit));

            Nom = nom;
            Circuit = circuit;
            NbTours = nbTours;
            Participants = new List<Participant>();
        }

        // Méthodes
        public void AjouterParticipant(Participant participant)
        {
            if (participant is null) throw new ArgumentNullException(nameof(participant));

            Participants.Add(participant);
        }

        public string SeDecrire()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine($"Course \"{Nom}\" sur le circuit : \"{Circuit.SeDecrire()}\"");
            info.AppendLine();
            info.AppendLine("Liste des participants : ");
            foreach (Participant p in Participants)
            {
                info.AppendLine($" - {p.SeDecrire()} en {p.Voiture.SeDecrire()}");
            }

            return info.ToString();
        }

        public void Simuler()
        {
            for (int i = 0; i < NbTours; i++)
            {
                foreach (Participant p in Participants)
                {
                    p.RealiserTour(Circuit);
                }
            }
        }

        public Participant ObtenirVainqueur()
        {
            Participant vainqueur = Participants[0];

            for (int i = 1; i < Participants.Count; i++)
            {
                Participant concurrent = Participants[i];

                if (vainqueur.TempsTotal > concurrent.TempsTotal)
                    vainqueur = concurrent;
            }

            return vainqueur;
        }
    }
}
