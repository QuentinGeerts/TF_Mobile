using System;
using System.Collections;

namespace Mobile.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();

            //Console.WriteLine("Combien de valeurs voulez-vous enregistrer :");
            //int nbValues = int.Parse(Console.ReadLine());

            //for (int i = 0; i < nbValues; i++)
            //{
            //    Console.WriteLine($"Encodez la valeur {i + 1} :");
            //    Console.WriteLine("De quel type sera encoder la valeur : (string ou int)");

            //    bool isString = Console.ReadLine() == "string";

            //    if (isString)
            //    {
            //        list.Add(Console.ReadLine());
            //    } 
            //    else
            //    {
            //        list.Add(int.Parse(Console.ReadLine()));
            //    }
            //}

            //Console.WriteLine(" -- Affichage -- ");

            //foreach(object value in list)
            //{
            //    Console.WriteLine(value);
            //}

            // -- HashTable

            //Hashtable dico = new Hashtable();

            //dico.Add(3, "Riri");
            //dico.Add("Riri", 6);
            //dico.Add("Fifi", "Riri");

            //Console.WriteLine(dico["Riri"]);
            //Console.WriteLine(dico["Fifi"]);
            //Console.WriteLine(dico[0]);

            //dico.Remove("Riri");
            //Console.WriteLine(dico["Riri"]);

            //dico.Add("key", null);
            //Console.WriteLine(dico["key"]);
            //dico["key"] = "clé";
            //Console.WriteLine(dico["key"]);

            //Console.WriteLine(dico.Count);

            //foreach (DictionaryEntry element in dico)
            //{
            //    Console.WriteLine($"{element.Key} {element.Value}");
            //}

            // -- Queue / Stack --

            Queue q = new Queue(); // File d'attente => premier arrivé, premier parti
            Stack s = new Stack(); // Pile d'assiette => première posée, dernière retirée

            q.Enqueue("Premier élément");
            q.Enqueue("Deuxième élément");
            q.Enqueue("Troisième élément");

            s.Push("Assiette 1");
            s.Push("Assiette 2");
            s.Push("Assiette 3");

            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(s.Pop());

            Console.WriteLine(q.Peek());
            Console.WriteLine(s.Peek());
            Console.WriteLine(q.Peek());
            Console.WriteLine(s.Peek());
            Console.WriteLine(q.Peek());
            Console.WriteLine(s.Peek());

        }
    }
}
