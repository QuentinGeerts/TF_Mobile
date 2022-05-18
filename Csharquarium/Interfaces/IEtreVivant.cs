using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.Interfaces
{
    public interface IEtreVivant
    {
        // Props
        int Pdv { get; }
        bool EstVivant { get; }

        // Méthodes
        string Resumer();
    }
}
