namespace CourseAuto.Model
{
    public class Circuit
    {
        // Attributs
        private string _Nom;
        private double _Longueur;

        // Propriétés

        public string Nom { get => _Nom; set => _Nom = value; }
        public double Longueur { get => _Longueur; set => _Longueur = value; }

        // Constructeurs
        public Circuit(string nom, double longueur)
        {
            Nom = nom;
            Longueur = longueur;
        }

        // Méthodes
        public string SeDecrire()
        {
            return $"{Nom} - {Longueur} km";
        }
    }
}
