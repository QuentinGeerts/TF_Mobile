using System;

namespace Mobile.Enu
{
    class Program
    {
        public enum Right { Execute, Write, Read };
        //                     0       1      2 

        [Flags] // Flags fonctionne avec des puissances de 2.
        public enum Droit { Execute = 1, Write = 2, Read = 4 };

        // Execute          0001
        // Write            0010
        // Read             0100
        // -----------------------
        //                  0111
        static void Main(string[] args)
        {
            Right right = Right.Execute;
            Right right2 = Right.Execute | Right.Write;
            Right right3 = Right.Execute | Right.Write | Right.Read;

            Console.WriteLine((int)right);      // => 0
            Console.WriteLine((int)right2);     // => 1
            Console.WriteLine((int)right3);     // => 3

            // Donc limité si plus de 3 valeurs

            Console.WriteLine("-------------------");

            Droit d = Droit.Execute;
            Droit d2 = Droit.Execute | Droit.Write;
            Droit d3 = Droit.Execute | Droit.Write | Droit.Read;

            Console.WriteLine(d);   // 0001 => 1
            Console.WriteLine(d2);  // 0011 => 3
            Console.WriteLine(d3);  // 0111 => 7

            if (d.HasFlag(Droit.Read))
            {
                Console.WriteLine("Accès au droit d'exécution");
            }

            Console.WriteLine(typeof(Right));

            foreach (string s in Enum.GetNames(typeof(Right)))
            {
                Console.WriteLine(s);
            }

            string write = "Write";

            Right d5 = (Right)Enum.Parse(typeof(Right), write);

            Console.WriteLine(d5);

            if (Enum.TryParse<Right>(write, out Right d6))
            {
                Console.WriteLine("Conversion réussie");
                Console.WriteLine(d6);
                Console.WriteLine((int) d6);
            }



        }
    }
}
