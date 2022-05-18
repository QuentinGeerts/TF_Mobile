using System;

namespace Mobile.Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type valeur => string
            int a = 3;
            bool b = true;
            float c = 3.4F;

            string d = a.ToString();

            Console.WriteLine(d);

            // string => type valeur

            Console.Clear();

            // -- CONVERT --
            string s1 = "12";

            int n1 = Convert.ToInt32(s1);

            Console.WriteLine("{0} : {1}", n1, n1.GetType());

            // -- PARSE --
            Console.Clear();

            string s2 = "true";

            bool booleen = bool.Parse(s2);

            Console.WriteLine("{0} : {1}", booleen, booleen.GetType());

            // -- TRYPARSE --
            Console.Clear();

            string s3 = "3a";

            int number;

            bool isSuccess = int.TryParse(s3, out number);

            Console.WriteLine("{0} {1} {2}", s3, number, isSuccess);

            // Conversion implicite

            char c1 = 'a';
            ushort us = c1;
            int i = 5;
            long l = i;
            double d1 = 3.14F;
            decimal dec = (decimal) d1;

            // Conversion explicite 

            Console.Clear();

            int total = 208;
            int copies = 52;

            int pourcent = (int)(100F / total * copies);

            Console.WriteLine(pourcent);

        }
    }
}
