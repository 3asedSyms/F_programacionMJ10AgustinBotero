using System;
namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego encuentre y muestre el valor máximo y mínimo de los números ingresados.
            
            int[] vector = new int[15];
            int maximo;
            int minimo;
            int record;


            for (int i = 0; i < vector.Length; i++)
            {
                
                Console.WriteLine($"Introduce el numero {i+1}:");
                
                vector[i] = Convert.ToInt16(Console.ReadLine());
                record = vector[i];
            }
        }
    }
}
