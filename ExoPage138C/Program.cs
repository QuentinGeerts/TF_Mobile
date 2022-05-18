using System;

namespace ExoPage138C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire le numéro de compte BBAN :");
            string bban = Console.ReadLine();
            string twoLast = bban.Substring(10, 2);
            string codeString = twoLast + twoLast + 111400;
            long codeNumber = long.Parse(codeString);
            short twoUnknows = (short)(98 - (codeNumber % 97));

            Console.WriteLine($"Le BBAN : {bban} converti en IBAN : BE{twoUnknows}{bban}");
        }
    }
}