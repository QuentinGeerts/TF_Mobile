using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructeurDestructeur
{
    class Eleve : Personne
    {
        List<double> _note;

        public string Immatriculation { get; set; }

        public Eleve()
        {
            _note = new List<double>();
        }

        public Eleve(string Nom, string Prenom, string Immatriculation) : base(Nom, Prenom)
        {
            _note = new List<double>();
            this.Immatriculation = Immatriculation;
        }

        public Eleve(string Nom, string Prenom, int Age, string Immatriculation) : base(Nom, Prenom, Age)
        {
            _note = new List<double>();
            this.Immatriculation = Immatriculation;
        }

        ~Eleve()
        {
            Console.WriteLine("Eleve détruit");
        }
    }
}
