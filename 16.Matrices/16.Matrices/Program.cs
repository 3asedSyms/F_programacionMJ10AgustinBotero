using System;
namespace _16.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* Diseñe un algoritmo que permita transformar una matriz numérica reemplazando todos sus elementos que sean menores a un valor umbral N, por dicho valor.
         
        Requerimientos:
        
         * 1. Solicitar al usuario las dimensiones de la matriz(número de filas y columnas).
         * 2. Capturar los valores numéricos para llenar la matriz.
         * 3. Solicitar el valor límite u objetivo (N)
         * 4. Recorrer la matriz y actualizar cualquier valor que cumpla la condición elemento < N.
         * 5. Mostrar la matriz resultante.*/

            int filas;
            int columnas;
            int umbral;
           

            Console.WriteLine("Ingrese numero de filas");
            filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero de columnas");
            columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];
            Console.WriteLine("Ingrese el umbral");
            umbral = int.Parse(Console.ReadLine());

            for (int i = 0; i < filas; i++)//filas
            {

                for (int j = 0; j < columnas; j++)
                {
                    
                    Console.WriteLine($"Ingrese numero para el indice:[{i}, {j}]");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (matriz[i, j] < umbral)
                    {
                        matriz [i, j] = umbral;
                    }
                    
                }
              
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0;j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j]} | ");
                }
                Console.WriteLine();
            }
        }

    }
}
