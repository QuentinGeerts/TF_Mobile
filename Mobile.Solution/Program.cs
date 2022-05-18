using System;

namespace Mobile.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // WriteLine
            Console.WriteLine("Hello ");
            Console.WriteLine("Mobile !");

            //// Write
            Console.Write("Hello ");
            Console.Write("Mobile !");

            //// Write + args
            Console.WriteLine("Bonjour {0} ! Aujourd'hui, nous sommes {1}.", "Mobile", "jeudi");

            // Clear
            Console.Clear();

            // ReadLine
            string s = Console.ReadLine();

            Console.WriteLine("Vous avez entré : {0}", s);
        }

    }
}
