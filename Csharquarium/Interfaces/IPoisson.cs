using Csharquarium.Enums;

namespace Csharquarium.Interfaces
{
    public interface IPoisson : IEtreVivant
    {
        string Nom { get; set; }
        Sexe Sexe { get; }
    }
}
