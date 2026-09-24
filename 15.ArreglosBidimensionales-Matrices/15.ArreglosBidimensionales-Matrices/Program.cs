using System;
namespace _15.ArreglosBidimensionales_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 3];
            // numeros[2,1] = 10; no se puede almacenar porque el indice de la fila no existe
            // numeros[1, 3] = 15; no se puede almacenar porque el indice de la columna no existe
       /*     numeros[0, 0] = 12;
            numeros[0, 1] = 100;
            numeros[0, 2] = 56;
            numeros[1, 0] = 45;
            numeros[1, 1] = 8;
            numeros[1, 2] = 10;
            Console.WriteLine($"El valor almacenado en numeros[1, 0]: {numeros[1, 0]}");*/
            //Recorrer para llenar 
           /* char[,] simbolos = new char[3, 2];
            for (int i =0; i < 3; i++)//Recorre las filas
            {
                for (int j = 0; j < 2; j++)//Recorre las columnas
                {
                    Console.WriteLine($"Ingrese el caracter para simbolos[{i}, {j}]:");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }
            }*/
            //Recorrer para recuperar datos
            /*for (int i= 0; i<simbolos.GetLength(0); i++)//GetLength(0) devuelve el número de filas 
            {
                for (int j = 0; j<simbolos.GetLength(1); j++)//GetLength(1) devuelve el número de columnas
                {
                    Console.Write($" {simbolos[i, j]} |");
                }
                Console.WriteLine();
            }*/
            //Otra forma de declarar e inicializar matrices

            string[,] nombres = {
                                    {"Ana", "Juan", "Carlos", "Álvaro"},
                                    {"Pedro", "Ferney", "Yuli", "Félix"},
                                    {"Carla", "Alex", "Esteban", "Salomé"}
                                };

            // 1. Crear una mátriz[10, 20], en cada posición de la mátriz poner el número 100; Mostrar la mátriz en consola

            int[,] matriz = new int[10, 20];
            for(int i = 0; i <matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(" 100 |");
                }
                Console.WriteLine();
            }
            // 2. Escribe un programa que realice la suma de dos matrices de dimensiones 2x3.
            // Reguisitos del programa:
            // - Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas
            // - Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones(2x3)
            // - Calcular la matriz suma, el resultado de sumar cada elemento correspondiente de las dos matrices.
            // - Mostrar la matriz resultante de la suma en formato de matriz

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];

            for(int i = 0; i < matriz1.GetLength(0); i++)
            {
                for(int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] matrizSuma = {
                                    {matriz1[0,0] + matriz2[0,0], matriz1[0,1] + matriz2[0,1], matriz1[0,2] + matriz2[0,2]},
                                    {matriz1[1,0] + matriz2[1,0], matriz1[1,1] + matriz2[1,1], matriz1[1,2] + matriz2[1,2]},
                                };
            for(int i = 0; i < matrizSuma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSuma.GetLength(1); j++)
                {
                    Console.Write($" {matrizSuma[i, j]} |");
                }
                Console.WriteLine();
            }

        }
    }
}
