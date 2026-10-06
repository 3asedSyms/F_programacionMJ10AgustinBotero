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
             v}*/

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
            
            /*Random rnd = new Random();
            int[,] matriz = new int[5, 5];
            int[] frecuencia = new int [10];

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(1, 11);
                    Console.Write($" {matriz[i, j]} |");
                    switch (matriz[i, j])
                    {
                        case 1:
                            frecuencia[0]++;
                            break;
                        case 2:
                            frecuencia[1]++;
                            break;
                        case 3:
                            frecuencia[2]++;
                            break;
                        case 4:
                            frecuencia[3]++;
                            break;
                        case 5:
                            frecuencia[4]++;
                            break;
                        case 6:
                            frecuencia[5]++;
                            break;
                        case 7:
                            frecuencia[6]++;
                            break;
                        case 8:
                            frecuencia[7]++;
                            break;
                        case 9:
                            frecuencia[8]++;
                            break;
                        case 10:
                            frecuencia[9]++;
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------");
            for(int i = 0; i < frecuencia.Length; i++)
            {
                Console.Write($" {frecuencia[i]} |");
            }*/

            // 4. Crea un algoritmo que represente un tablero de juego 5x5 donde se coloquen 3 "X" en posiciones aleatorias. Luego, el algoritmo le debe permitir al usuario adivinar la posición de una "X". 
            
            char[,] tabla = new char[5, 5];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(tabla[i, j]);
                }
                Console.WriteLine();
            }

           
           


      // 5.
            /*int filas;
            int columnas;
            Console.WriteLine("Ingrese filas:");
            filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese columnas:");
            columnas = int.Parse(Console.ReadLine());

            int[,] enteros = new int [filas, columnas];
            for(int i = 0;i < enteros.GetLength(0); i++)
            {
                for(int j = 0;j < enteros.GetLength(1); j++)
                {
                    enteros[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < enteros.GetLength(0); i++)
            {
                for (int j = 0; j < enteros.GetLength(1); j++)
                {
                    Console.Write($" |{enteros[i, j]} |");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < enteros.GetLength(1); i++)
            {
                for (int j = 0; j < enteros.GetLength(0); j++)
                {
                    Console.Write($" |{enteros[j, i]} |");
                }
                Console.WriteLine();
            }*/
        }
    }
}
