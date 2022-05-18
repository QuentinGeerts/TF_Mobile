using System;

namespace ConstructeurDestructeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Eleve e1 = new Eleve();
            Eleve e2 = new Eleve("Geerts", "Quentin", "IOHDAZDN");
            Eleve e3 = new Eleve("Geerts", "Quentin", 25, "IOHDAZDN");

            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);

        }
    }

    
}
