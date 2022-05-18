using System;
using System.Collections.Generic;

namespace CourseAuto.Model
{
    public class Participant
    {
        // Attributs
        private string _Nom;
        private int _Numero;
        private Voiture _Voiture;
        private List<int> _TempsTour;

        // Propriétés
        public string Nom { get => _Nom; set => _Nom = value; }
        public int Numero { get => _Numero; set => _Numero = value; }
        public List<int> TempsTour { get => _TempsTour; set => _TempsTour = value; }
        public Voiture Voiture { get => _Voiture; set => _Voiture = value; }
        public int TempsTotal
        {
            get
            {
                int total = 0;
                foreach (int t in TempsTour)
                {
                    total += t;
                }
                return total;
            }
        }

        // Constructeurs
        public Participant(string nom, int numero, Voiture voiture)
        {
            if (voiture is null) throw new ArgumentNullException(nameof(voiture));

            Nom = nom;
            Numero = numero;
            Voiture = voiture;
            TempsTour = new List<int>();
        }

        // Méthodes
        public string SeDecrire()
        {
            return $"{Numero} {Nom}";
        }

        public void RealiserTour(Circuit circuit)
        {
            if (circuit is null) throw new ArgumentNullException(nameof(circuit));

            int temps = Voiture.FaireTour(circuit);
            TempsTour.Add(temps);
        }
    }
}
