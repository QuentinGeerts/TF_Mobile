using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] ints = { 0, 1, 2, 3, 4, 5, 6 };

            MaClasse maClasse = new MaClasse();
            try
            {
                //double result = maClasse.Division(5, 0);

                //Console.WriteLine(ints[ints.Length]);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException");
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Others");
            }
            finally
            {
                Console.WriteLine("Toujours exécuté");
            }
            Console.WriteLine("Je continue");
            
        }
    }

    internal class MaClasse
    {
        public MaClasse()
        {

        }

        public double Division(int n1, int n2)
        {
            if (n2 == 0) throw new DivideByZeroException("Tu as essayé de diviser par 0.");
            return n1 / n2;
        }
    }
}
