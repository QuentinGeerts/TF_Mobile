using Csharquarium.Interfaces;
using System.Collections.Generic;

namespace Csharquarium
{
    public class Aquarium
    {
        #region Attributs
        private string _Nom;
        private int _MaxPoissons;
        private int _MaxAlgues;
        private List<IEtreVivant> _Residents;
        #endregion

        #region Props
        public string Nom { get => _Nom; set => _Nom = value; }
        public int MaxPoissons { get => _MaxPoissons; set => _MaxPoissons = value; }
        public int MaxAlgues { get => _MaxAlgues; set => _MaxAlgues = value; }
        public List<IEtreVivant> Residents { get => _Residents; set => _Residents = value; }
        #endregion



        #region CTOR
        public Aquarium(string nom, int maxPoissons, int maxAlgues)
        {
            Nom = nom;
            MaxPoissons = maxPoissons;
            MaxAlgues = maxAlgues;
        }
        #endregion

        #region Méthodes
        public void AjouterPoisson(IPoisson NouveauPoisson)
        {
            if (NouveauPoisson is not null && NouveauPoisson.EstVivant)
            {
                Residents.Add(NouveauPoisson);
                System.Console.WriteLine($"{NouveauPoisson} arrive dans l'aquarium");
            }
        }
        #endregion

    }
}