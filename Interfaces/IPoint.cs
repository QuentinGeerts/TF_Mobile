using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IPoint
    {
        // Signatures de mes propriétés
        int X
        {
            get;
            set;
        }

        int Y
        {
            get;
            set;
        }

        // Prototype de la méthode
        void Display();
    }
}
