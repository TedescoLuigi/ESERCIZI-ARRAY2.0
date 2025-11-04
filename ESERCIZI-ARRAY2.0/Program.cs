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

        }
    }
}
