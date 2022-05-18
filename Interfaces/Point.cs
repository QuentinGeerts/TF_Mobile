using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Point : IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Display()
        {
            Console.WriteLine($"({X}:{Y})");
        }
    }
}
