using System;
using System.Text;

namespace Mobile.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration de variables
            int entier1, entier2;
            int entier3; 
            int entier4;

            //Console.WriteLine(entier2);

            // Affectation
            // Initialisastion = première affectation
            entier1 = 5;

            // Déclarer + initialiser
            int entier5 = 5, entier6 = 7;

            // Constante
            const int NOM_CONSTANTE = 5;

            // Nullable
            Nullable<int> i = null;
            int? j = null;

            // CTS
            int a = 5;
            Int32 b = 5;

            Console.WriteLine("a : {0}", a);
            Console.WriteLine("b : {0}", b);

            Console.Clear();

            // 
            var v1 = 5;
            var v2 = 'a';
            var v3 = 2.3;
            var v4 = true;
            var v5 = "Test";

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", 
                v1.GetType(), v2.GetType(), v3.GetType(), v4.GetType(), v5.GetType());

            var v6 = 3.14F;

            Console.WriteLine("{0}", v6.GetType());

            Console.Clear();

            var y = 100 / 200 * 5;
            var x = 100F / 200 * 5;

            Console.WriteLine("Y : {0}", y);
            Console.WriteLine("X : {0}", x);

            int y2 = 100 / 200 * 5;
            float x2 = 100F / 200 * 5;

            Console.WriteLine("Y : {0}", y2);
            Console.WriteLine("X : {0}", x2);

            Console.Clear();

            int value = 468_486_678;

            Console.WriteLine(value);

            Console.Clear();

            // Concaténation

            string p = "Quentin";
            string m1 = "Bonjour " + p;

            Console.WriteLine(m1);

            Console.Clear();

            // StringBuilder

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Le texte");
            sb1.Append(" construit.");

            StringBuilder sb2 = new StringBuilder();
            sb2.AppendLine("Le texte2");
            sb2.AppendLine(" construit.");

            string s_1 = sb1.ToString();
            string s_2 = sb2.ToString();

            Console.WriteLine(s_1);
            Console.WriteLine(s_2);

            Console.Clear();

            // string.Format

            string message = string.Format("Bonjour {0}", p);
            Console.WriteLine(message);

            Console.Clear();

            // String interpolation

            string m2 = $"Bonjour {p}";

            Console.WriteLine(m2);

        }
    }
}
