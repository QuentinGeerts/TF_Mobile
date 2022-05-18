using System;

namespace Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule vehicule = new Vehicule();
            Vehicule vc = new VoitureCourse();       // Casting implicite
            Vehicule voiture = new Voiture();
            Vehicule bateau = new Bateau();
            object o = new Bateau();                 // Casting implicite

            Bateau b = (Bateau)bateau;               // Casting explicite
            Bateau b2 = (Bateau) o;                    // Casting explicite


            vehicule.SeDeplacer();
            Console.WriteLine();

            vc.SeDeplacer();
            Console.WriteLine();

            voiture.SeDeplacer();
            Console.WriteLine();

            b.SeDeplacer();
            Console.WriteLine();
        }
    }

    class Vehicule
    {


        public virtual void SeDeplacer()
        {
            Console.Write("Je me déplace ...");
        }

    }

    class Voiture : Vehicule
    {
        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.Write(" en voiture");
        }
    }

    class Bateau : Vehicule
    {

        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.Write(" en bateau");
        }
    }

    class VoitureCourse : Voiture
    {
        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.Write(" de course");
        }
    }
}
