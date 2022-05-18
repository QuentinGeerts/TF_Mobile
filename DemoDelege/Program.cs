using System;

namespace DemoDelege
{

    delegate void MyDelegate(string s);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = null;

            myDelegate = EnFrancais;
            myDelegate += EnAnglais;

            if (myDelegate is not null)
                myDelegate.Invoke("Quentin"); // myDelegate();
        }

        static void EnFrancais(string prenom)
        {
            Console.WriteLine("Bonjour" + prenom);
        }
        static void EnAnglais(string prenom)
        {
            Console.WriteLine("Hello" + prenom);
        }
    }
}
