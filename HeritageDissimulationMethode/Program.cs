using System;

namespace HeritageDissimulationMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClasseDerivee cd = new ClasseDerivee();
            //Console.WriteLine(cd.MethodeRedefinie());
            //Console.WriteLine(cd.MethodeDissimulee());

            ClasseDeBase cb = new ClasseDerivee();      //notion de polymorphisme : tout les carrés sont des rectangles
            Console.WriteLine(cb.MethodeRedefinie());
            Console.WriteLine(cb.MethodeDissimulee());
        }
    }

    public class ClasseDeBase
    {
        public string MethodeDissimulee() { return "Dis : Je suis une classe de base."; }
        public virtual string MethodeRedefinie() { return "Red : Je suis une classe de base."; }
    }
    public class ClasseDerivee : ClasseDeBase
    {
        public new string MethodeDissimulee() { return base.MethodeDissimulee() + " Et aussi une classe dérivée."; }
        public override string MethodeRedefinie() { return base.MethodeRedefinie() + " Et aussi une classe dérivée."; }

    }
}
