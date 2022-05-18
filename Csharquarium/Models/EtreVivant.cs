using Csharquarium.Interfaces;

namespace Csharquarium.Models
{
    public class EtreVivant : IEtreVivant
    {
        #region Attributs
        private int _Pdv;
        #endregion

        #region Props
        public int Pdv { get; set; }
        public bool EstVivant { get { return Pdv > 0; } }
        #endregion

        public string Resumer()
        {
            throw new System.NotImplementedException();
        }
    }
}