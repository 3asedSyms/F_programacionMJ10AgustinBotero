using System;
namespace _14.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numeros = new int[5];
            numeros[0] = 15;
            numeros[1] = 102;
            numeros[2] = 54;
            numeros[3] = 26;
            numeros[4] = 5;
            Console.WriteLine($"El número almacenado en la posición 4 con indice 3 es: {numeros[3]}");
            //Otras formas de declarar e inicializar vectores
            char[] simbolos = new char[] {'?', '/', 'o', '5' };
            bool[] valoresVerdad = {true, false, true, false, true, true};
            //Recorrer para llenar el vector de datos
            string[] nombres = new string[7];
            for (int i = 0; i < 7;i++ )
            {
                Console.WriteLine($"Ingrese el nombre para la P:{i + 1};I:{i} :");
                nombres[i] = Console.ReadLine();
            }
            Console.Clear();
            //Recorrer para recuperar datos almacenados
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"{nombres[i]} |");
            }*/

            //Crear arreglo llamado "Enteros" de 100 elementos asignar el numero 10 en cada una de las posiciones del arreglo. Leer el contenido de cada elemento y mostrarlo en pantalla.
           /* int[] enteros = new int[100];

            for (int i = 0; i < enteros.Length; i++)
            {
                enteros[i] = 10;
                Console.WriteLine($"{enteros[i]}");
            }
            Console.Clear();*/
            //Algoritmo que permita solicitar 10 números, los cuales serán almacenados en un arreglo. Al final, debe visualizar el promedio de esos números

           /* int[] arreglo = new int[10];
            double acumulador = 0;
            double promedio = 0;
           
            for(int i = 0; i < 10; i++)
            {
                arreglo[i] = int.Parse(Console.ReadLine());
                acumulador += arreglo[i];
            }
            promedio = Convert.ToDouble(acumulador / 10);
            Console.WriteLine(promedio);*/

            //Llene un arreglo con 15 números ingresados por teclado.Una vez registrado el total de valores, muestre en pantalla todos los elementos del arreglo. Finalmente determine cual es el número mayor y cual es el número menor, junto con la posición que ocupa dentro del arreglo.

            int[] arreglo = new int[15];
            
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Ingrese numero: ");
                arreglo[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(arreglo[0], arreglo[1],);
        }
    }
}
