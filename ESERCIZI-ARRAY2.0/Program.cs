
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



            // Esercizio 6
            Console.WriteLine("---------------------------------------------------------");

            int[] v1 = { 1, 5, -2, 9, 4 };
            int x = 3;
            int contaV2 = 0;
            int contaV3 = 0;

            // Primo ciclo per contare gli elementi per v2 e v3
            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] < x)
                {
                    contaV2++;
                }
                else
                {
                    contaV3++;
                }
            }
            // Creazione dei vettori v2 e v3 con le dimensioni corrette
            int[] v2 = new int[contaV2];
            int[] v3 = new int[contaV3];
            int indixV2 = 0, indixV3 = 0;

            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] < x)
                {
                    v2[indixV2] = v1[i];
                    indixV2++;
                }
                else
                {
                    v3[indixV3] = v1[i];
                    indixV3++;
                }
            }
           for(int i = 0; i < v2.Length; i++)
            {
               Console.Write($"[ {v2[i]} ]");
            }
            Console.WriteLine();
            for (int i = 0; i < v3.Length; i++)
            {
                Console.Write($"[ {v3[i]} ]");
            }
            Console.WriteLine();

            Console.Write("---------------------------------------------------------");





        }






    }
}
