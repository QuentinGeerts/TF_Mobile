using System;

namespace Proprietes
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne quentin = new Personne();

            // Modifie les données
            quentin.Nom = "Geerts"; // Lecture seule
            quentin.Prenom = "Quentin";
            quentin.Age = 25;

            // Récupère
            Console.WriteLine($"{quentin.Nom} {quentin.Age}");

        }
    }

    class Personne
    {
        // Attributs
        private int _age;

        // Getter - Accesseur
        //public string GetNom ()
        //{
        //    return _nom;
        //}

        // Setter - Mutateur
        //public void SetNom(string value)
        //{
        //    _nom = value;
        //}


        // Propriétés

        // Lecture seule
        public string Nom { get; }
        // public string Nom { get; private set; }

        public string Prenom { get; set; }


        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0) _age = value;
                else _age = 0;
            }
        }
            
    }
}
