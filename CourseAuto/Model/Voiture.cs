using System;

namespace CourseAuto.Model
{
    public class Voiture
    {

        // Attributs
        private string _Marque;
        private string _Modele;
        private int _VitesseMin;
        private int _VitesseMax;

        // Propriétés
        public string Marque { get => _Marque; private set => _Marque = value; }
        public string Modele { get => _Modele; private set => _Modele = value; }
        public int VitesseMin { get => _VitesseMin; private set => _VitesseMin = value; }
        public int VitesseMax { get => _VitesseMax; private set => _VitesseMax = value; }


        // Constructeurs
        public Voiture(string marque, string modele)
        {
            Marque = marque;
            Modele = modele;
            VitesseMin = 100;
            VitesseMax = 150;
        }

        public Voiture(string marque, string modele, int vitesseMin, int vitesseMax)
        {
            Marque = marque;
            Modele = modele;
            VitesseMin = vitesseMin;
            VitesseMax = vitesseMax;
        }

        // Méthodes
        public string SeDecrire()
        {
            return $"{Marque} {Modele}";
        }

        public int FaireTour(Circuit circuit)
        {
            if (circuit is null) throw new ArgumentNullException(nameof(circuit));

            // Calcul du temps en seconde
            int vitesse = ObtenirVitesse();
            return (int)((circuit.Longueur / vitesse) * 3600);
        }

        private int ObtenirVitesse()
        {
            Random rng = new Random(Guid.NewGuid().GetHashCode());

            return rng.Next(VitesseMin, VitesseMax + 1);
        }
    }
}
