using System.Numerics;

namespace Esercizi_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeriContrario = { 1, 2, 3, 4, 5 };

            for (int i = numeriContrario.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numeriContrario[i]);
            }



            int[] numeriPari = { 10, 25, 33, 47, 52, 61, 78, 99 };

            Console.WriteLine("Elementi con indice pari:");
             for (int i = 0; i < numeriPari.Length; i += 2)
             {
                    Console.WriteLine(numeriPari[i]);
             }

            int[] numDispari = { 10, 25, 33, 47, 52, 61, 78, 99 };

            Console.WriteLine("Elementi dispari del vettore:");
            for (int i = 0; i < numDispari.Length; i++)
            {
                if (numDispari[i] % 2 != 0)
                {
                    Console.WriteLine(numDispari[i]);

                }
            }
        }

}
