using System;

namespace Mobile.Operateurs
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.MaxValue;
            int j;

            unchecked
            {
                j = i + 1;
            }
            
            Console.WriteLine(j);
        }
    }
}
