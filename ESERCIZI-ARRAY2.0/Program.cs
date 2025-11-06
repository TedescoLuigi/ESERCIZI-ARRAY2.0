
using System.Numerics;

namespace Esercizi_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esercizio 1
            Console.WriteLine("----------------------Esercizio 1----------------------");
            int[] numeriContrario = { 1, 2, 3, 4, 5 };

            for (int i = numeriContrario.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numeriContrario[i]);
            }


            //Esercizio 2
            Console.WriteLine("----------------------Esercizio 2----------------------");
            int[] numeriPari = { 10, 25, 33, 47, 52, 61, 78, 99 };

            Console.WriteLine("Elementi con indice pari:");
            for (int i = 0; i < numeriPari.Length; i += 2)
            {
                Console.WriteLine(numeriPari[i]);
            }


            //Esercizio 3
            Console.WriteLine("----------------------Esercizio 3----------------------");
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
            Console.WriteLine("----------------------Esercizio 6----------------------");

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
            // Stampa dei vettori v2 e v3
            for (int i = 0; i < v2.Length; i++)
             {
               Console.Write($"[ {v2[i]} ]");
             }

            Console.WriteLine();

             for (int i = 0; i < v3.Length; i++)
             {
                Console.Write($"[ {v3[i]} ]");
             }

            Console.WriteLine();

            Console.Write("---------------------esercizio inClasse 1-----------------------");

            Console.WriteLine();
            //esercizio inClasse 1
            //media,somma,min,max,indicemin,incicemax

            int[] vet1 = { 1, 25, 33, 7, 52, 61, 78, 99 };
            int somma = 0;
            int min = vet1[0];
            int max = vet1[0];
            int media = 0;
            int indiceMin = 0;
            int indiceMax = 0;
            for (int i = 0; i < vet1.Length; i++)
            {
                somma += vet1[i];

                if (vet1[i] < min)
                {
                    min = vet1[i];
                    indiceMin = i;
                }
                if (vet1[i] > max)
                {
                    max = vet1[i];
                    indiceMax = i;
                }


            }
            media = somma / vet1.Length;
            Console.WriteLine();
            Console.WriteLine($"La somma è: {somma}");
            Console.WriteLine($"La media è: {media}");
            Console.WriteLine($"Il valore minimo è: {min}");
            Console.WriteLine($"Il valore massimo è: {max}");
            Console.WriteLine($"L'indice del valore minimo è: {indiceMin}");
            Console.WriteLine($"L'indice del valore massimo è: {indiceMax}");

            Console.WriteLine();


            Console.Write("---------------------esercizio inClasse 2-----------------------");

            //esercizio inClasse 2
            //dati V1 e V2 creare V3 che sia la concatenazione di V1 e V2

            int[] V1 = { 1, 2, 3 ,4,5};
            int[] V2 = { 6,7,8,9,10};
            int[] V3 = new int[V1.Length + V2.Length];  
            
            for (int i = 0; i < V1.Length; i++)
            {
                V3[i] = V1[i];
            }
           for (int i = 0; i < V2.Length; i++)
           {
               V3[V1.Length + i] = V2[i];
           }    
           for (int i = 0; i < V3.Length; i++)
           {
                Console.Write($"[{V3[i]}]");
           }

                Console.WriteLine();
                Console.Write("-------------------------------------------------------------");



            

        }






    }
}
