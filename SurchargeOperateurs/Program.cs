using System;
using System.Collections.Generic;

namespace SurchargeOperateurs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Différents fruits
            Fruit pomme = new Fruit() { Nom = "Pomme" };
            Fruit poire = new Fruit() { Nom = "Poire" };
            Fruit ananas = new Fruit() { Nom = "Ananas" };
            Fruit cerise = new Fruit() { Nom = "Cerise" };

            // -- Panier 1
            Panier p1 = new Panier();
            p1.AddFruit(pomme);
            p1.AddFruit(pomme);
            p1.AddFruit(cerise);

            Console.WriteLine("Panier 1 : ");

            foreach (Fruit fruit in p1.Fruit)
            {
                Console.WriteLine($"{fruit.Nom}");
            }

            Console.WriteLine();

            // -- Panier 2
            Panier p2 = new Panier();
            p2.AddFruit(ananas);
            p2.AddFruit(ananas);
            p2.AddFruit(poire);

            Console.WriteLine("Panier 2 : ");

            foreach (Fruit fruit in p2.Fruit)
            {
                Console.WriteLine($"{fruit.Nom}");
            }

            Console.WriteLine();

            // -- Panier total
            Panier total = p1 + p2;
            total = total + ananas;

            Console.WriteLine("Panier Total : ");

            foreach (Fruit fruit in total.Fruit)
            {
                Console.WriteLine($"{fruit.Nom}");
            }

            Console.WriteLine();
        }
    }

    public class Panier
    {
        private List<Fruit> _Fruits = new List<Fruit>();

        public List<Fruit> Fruit { get { return _Fruits; } }

        public static Panier operator +(Panier p1, Panier p2)
        {
            Panier result = new Panier();

            foreach (Fruit fruit in p1._Fruits)
            {
                result.AddFruit(fruit);
            }

            foreach (Fruit fruit in p2._Fruits)
            {
                result.AddFruit(fruit);
            }

            return result;
        }

        public static Panier operator +(Panier p, Fruit f)
        {
            p.AddFruit(f);
            return p;
        }

        public void AddFruit(Fruit fruit)
        {
            _Fruits.Add(fruit);
        }
    }

    public class Fruit
    {
        public string Nom { get; set; }
    }
}
