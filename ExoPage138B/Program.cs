using System;

namespace ExoPage138B
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Vérification d'un compte bancaire BBAN, si le compte est bon affichez OK sur la console sinon KO.
             * Le modulo des 10 premiers chiffres par 97 donne les 2 derniers. 
             * Sauf si le modulo = 0 dans ce cas les deux derniers chiffres sont 97.
             * (utilisez la méthode "substring" de la classe "string")
             * 
             */

            Console.WriteLine("Veuillez introduire votre code BBAN sans tiret : ");
            string bban = Console.ReadLine();

            string tenFirst = bban.Substring(0, 10);
            string twoLast = bban.Substring(10, 2);

            long tenNumber = long.Parse(tenFirst);
            short twoNumber = short.Parse(twoLast);

            if ((tenNumber % 97 == twoNumber) || ((tenNumber % 97 == 0) && (twoNumber == 97))) Console.WriteLine("OK");
            else Console.WriteLine("KO");

        }
    }
}
