using System;
using System.Collections.Generic;

namespace Mobile.Callections.Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // -- LIST
            //List<int> list = new List<int>();

            //list.Add(5);
            //list.Add(3);
            //list.Add('\t');
            ////list.Add("string");
            ////list.Add(3.13);
            ////list.Add(new object());

            //Console.WriteLine(list[0]);

            //foreach (int value in list)
            //{
            //    Console.WriteLine(value);
            //}

            // -- DICTIONNARY

            //Dictionary<int, string> dico = new Dictionary<int, string>();

            //dico.Add(42, "Valeur 42");
            //dico.Add(666, "Nombre du diable");

            ////dico.Add("Salut", "Les amis");
            ////dico.Add(3.14, "pi");

            //foreach (KeyValuePair<int, string> kvp in dico)
            //{
            //    Console.WriteLine($"{kvp.Key} {kvp.Value}");
            //}

            //dico.Remove(42);

            //foreach (KeyValuePair<int, string> kvp in dico)
            //{
            //    Console.WriteLine($"{kvp.Key} {kvp.Value}");
            //}

            // -- QUEUE<T> - STACK<T>
            Queue<string> fileAttente = new Queue<string>(); // FIFO

            fileAttente.Enqueue("Quentin");
            fileAttente.Enqueue("Nicolas");
            fileAttente.Enqueue("Antoine");
            fileAttente.Enqueue("William");
            fileAttente.Enqueue("Francesco");
            fileAttente.Enqueue("Thomas");

            Stack<string> pileDossier = new Stack<string>();

            int length = fileAttente.Count;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Cela va être au tour de {fileAttente.Peek()} de déposer son dossier.");
                pileDossier.Push(fileAttente.Dequeue());
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Traitement du dossier de {pileDossier.Pop()}");
            }


        }
    }
}
