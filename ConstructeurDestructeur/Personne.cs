namespace ConstructeurDestructeur
{
    internal class Personne
    {
        private string _nom;

        // Propriétés
        public string Prenom { get; set; }
        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
            }
        }
        public int Age { get; set; }


        public Personne()
        {

        }

        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }
        public Personne(string Nom, string Prenom, int Age)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Age = Age;
        }

        //public Personne(string nom, string prenom, int age)
        //{
        //    Nom = nom;
        //    Prenom = prenom;
        //    Age = age;
        //}

        ~Personne()
        {
            System.Console.WriteLine("Personne détruite");
        }


        public override string ToString()
        {
            return $"{Nom} {Prenom} a {Age} ans.";
        }
    }
}