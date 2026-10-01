using System;
namespace TallerPreparacionMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por pantalla la suma de los elementos de cada columna.
            /*int[,] matriz = new int[5, 10];
            Random rnd = new Random();
            int columnas = 0;
            
            int acumulador = 0;


            for (int i = 0; i < matriz.GetLength(0); i++) // Llena matriz con numeros random
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = rnd.Next(0, 50);
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++) // Muestra la matriz en consola
            {
                for(int j = 0;j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------");
            for (int i = 4; i  1; i--)
            {
                for (int j = 0; j < matriz.GetLength(1); j=columnas)
                {
                    while (j < columnas)
                    {
                        columnas++;
                        acumulador += matriz[i, columnas];
                    }
                }    
                
                
                
                /*}
                Console.WriteLine();
            }
            Console.WriteLine() ;
            /*for (int j = 0; j < matriz.GetLength(1); j++)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    
                }
                Console.WriteLine();
            }*/

            // 2. Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la matriz con intercambio de filas.


            //Random rnd = new Random();
            /*int n, m, i, j;
            
            int columnas = 0;
          
       
            Console.WriteLine("Ingrese número de filas:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número de columnas:");
            m = int.Parse(Console.ReadLine());
            char[,] matriz = new char[n, m];

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.WriteLine($"Ingrese carácter para fila:{i + 1} columna:{j + 1}");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < n; i++)
            {
                for(j = 0;j < m; j++)
                {
                    Console.Write($"{matriz[i, j]}|");
                }
                Console.WriteLine();
            }

            char[,] matriz2 = new char[n, m];
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[0, j] = matriz[n, j];
                    Console.Write(matriz[n, j]);
                }
                Console.WriteLine();*/
            //}
            // 3. Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz 5x5 llena de números aleatorios
            /* El algoritmo debe permitir:
             * Usar la función Random para generar los números aleatorios
             * Crea un arreglo adicional para almacenar la frecuencia de cada número
             * Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número
             */
            int acumulador1 = 0;
            int acumulador2 = 0;
            int acumulador3 = 0;
            int acumulador4 = 0;
            int acumulador5 = 0;
            int acumulador6 = 0;
            int acumulador7 = 0;
            int acumulador8 = 0;
            int acumulador9 = 0;
            int acumulador10 = 0;
            Random rnd = new Random();
            int[,] matriz = new int[5, 5];
            int[] frecuencia = new int [10];

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(1, 11);
                    Console.Write($"{matriz[i, j]}|");
                    switch (matriz[i, j])
                    {
                        case 1:
                            acumulador1++;
                            break;
                        case 2:
                            acumulador2++;
                            break;
                        case 3:
                            acumulador3++;
                            break;
                        case 4:
                            acumulador4++;
                            break;
                        case 5:
                            acumulador5++;
                            break;
                        case 6:
                            acumulador6++;
                            break;
                        case 7:
                            acumulador7++;
                            break;
                        case 8:
                            acumulador8++;
                            break;
                        case 9:
                            acumulador9++;
                            break;
                        case 10:
                            acumulador10++;
                            break;
                    }
                }
                Console.WriteLine();
            }
            for(int i = 0; i < frecuencia.Length; i++)
            {
                frecuencia[i] = { { acumulador1, acumulador2 } }
                /*int[,] matrizSuma = {
                                {matriz1[0,0] + matriz2[0,0], matriz1[0,1] + matriz2[0,1], matriz1[0,2] + matriz2[0,2]},
                                {matriz1[1,0] + matriz2[1,0], matriz1[1,1] + matriz2[1,1], matriz1[1,2] + matriz2[1,2]},
                            };*/
            }
            



        }
    }
}
