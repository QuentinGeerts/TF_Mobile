using System;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            //MaClasse m1 = new MaClasse();
            //m1.MaMethode();

            //Console.WriteLine();

            //MaClasse2 m2 = new MaClasse2();
            //m2.MaMethode();

            //Console.WriteLine();

            //MaClasse3 m3 = new MaClasse3();
            //m3.MaMethode();

            //Console.WriteLine();

            // Notion de polymorphisme
            MaClasse m4 = new MaClasse3();
            m4.MaMethode();

            //MaClasse m5 = new MaClasse2();
            //m5.MaMethode();

        }
    }

    public class MaClasse
    {
        public virtual void MaMethode() 
        {
            Console.WriteLine("MaClasse :");
            Console.WriteLine("Ma méthode");
        }
        
    }

    public class MaClasse2 : MaClasse // Sealed permet d'empêcher l'héritage
    {
        public override void MaMethode()
        {
            Console.WriteLine("MaClasse2 :");
            base.MaMethode();
            Console.WriteLine("MaMethode 2");
        }
    }

    public class MaClasse3 : MaClasse2
    {
        public new void MaMethode()
        {
            Console.WriteLine("MaClasse3 :");
            base.MaMethode();
            Console.WriteLine("MaMethode 3");

        }
    }
}
