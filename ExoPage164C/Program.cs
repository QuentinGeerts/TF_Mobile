using System;
using System.Collections.Generic;

namespace ExoPage164C
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Demandez à l'utilisateur d'introduire deux nombres au clavier et faites
             * l'addition de ces deux nombres en ne convertissant que caractère par caractères.
             * (Méthode "ToCharArray()" de la classe "string").
             */

            // Récupération des deux nombres
            string Number1 = Console.ReadLine();
            string Number2 = Console.ReadLine();

            // LIFO
            Stack<char> Q_N1 = new Stack<char>();
            Stack<char> Q_N2 = new Stack<char>();

            // Conversion des deux nombres en tableaux de char
            foreach (char digit in Number1.ToCharArray())
            {
                Q_N1.Push(digit);
            }
            foreach (char digit in Number2.ToCharArray())
            {

                Q_N2.Push(digit);
            }

            // Addition

            // Connaître le nombre de chiffres maximum dans un nombre
            int MaxNumbers = Q_N1.Count > Q_N2.Count ? Q_N1.Count : Q_N2.Count;
            int Report = 0;
            Stack<int> Digits = new Stack<int>();

            for (int i = 0; i < MaxNumbers; i++)
            {
                int N1 = Q_N1.Count > 0 ? int.Parse(Q_N1.Pop().ToString()) : 0;
                int N2 = Q_N2.Count > 0 ? int.Parse(Q_N2.Pop().ToString()) : 0;

                //Console.WriteLine($"{N1} & {N2}");

                int CurrentSum = N1 + N2 + Report;

                if (CurrentSum > 9 && i != MaxNumbers - 1)
                {
                    CurrentSum = CurrentSum - 10;
                    Report = 1;
                }

                Console.WriteLine($"{N1} + {N2} = {CurrentSum}");
                Console.WriteLine($"Report = {Report}");

                Digits.Push(CurrentSum);
            }

            int Result = int.Parse(string.Join("", Digits.ToArray()));

            Console.WriteLine($"{Number1} + {Number2} = {Result}");

        }
    }
}
