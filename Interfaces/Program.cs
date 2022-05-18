using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point() { X = 5, Y = 5 };

            IPoint p2 = new Point() { X = 5, Y = 3 };

            p1.Display();

            p2.Display();
        }
    }
}
