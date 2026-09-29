using System;
namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego encuentre y muestre el valor máximo y mínimo de los números ingresados.

            /*int[] vector = new int[15];
            int maximo = 0;
            int minimo = 0;




            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Introduce el numero {i + 1}:");

                vector[i] = Convert.ToInt16(Console.ReadLine());
                if (i == 0)
                {
                    minimo = vector[i];
                    maximo = vector[i];
                }

                if (vector[i] > maximo)
                {
                    maximo = vector[i];
                }
                else if (vector[i] <= minimo)
                {
                    minimo = vector[i];
                }
                Console.WriteLine($"mayor:{maximo}, menor:{minimo}");
            }*/

            // 2. Escribir un algoritmo que permita:
            //  a. Crear dos vectores del mismo tamaño
            //  b. Llenarlos con números
            //  c. Comparar posición por posición
            //  d. Indicar cuántos elementos son iguales

            /*int[] vector1 = new int[3];
            int[] vector2 = new int [3];
            int acumulador = 0;

            for(int i = 0; i < vector1.Length; i++)
            {
                Console.WriteLine($"Ingrese valor a almacenar en indice: {i} posición: {i + 1}. (Vector 1)");
                vector1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vector2.Length; i++)
            {
                Console.WriteLine($"Ingrese valor a almacenar en indice: {i} posición: {i + 1}. (Vector 2)");
                vector2[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0;i < vector1.Length; i++)
            {
                for (int j = 0; j < vector2.Length; j++)
                {
                    if (vector1[i] == vector2[j])
                    {
                        acumulador++;
                    }
                }
            }
            Console.WriteLine(acumulador);*/



            /* 3. Escribir un algoritmo que permita:
             * a. Llenar un vector[20] con números enteros(positivos o negativos) ingresados por el usuario o generados aleatoriamente.
             * b. Calcular y mostrar el promedio aritmético de todos los elementos almacenados en el vector.
             * c. Recorrer nuevamente el vector para contar e indicar cúantos números son mayores que el promedio y cúantos son menores que este.
             * d. Mostrar en pantalla el vector completo junto con los resultados obtenidos.*/

            /*int[] vector = new int [20];
            double suma = 0;
            double promedio;
            int menorPromedio = 0;
            int mayorPromedio = 0;

            Random rand = new Random();
            
            for(int i = 0; i < vector.Length; i++)
            {
                vector[i] = rand.Next(-50, 100);
                Console.Write($"|{vector[i]}|");
                suma += vector[i];
            }
            promedio = Convert.ToDouble(suma/vector.Length);
            Console.WriteLine($"Promedio: {promedio}");
            for(int i = 0;i < vector.Length; i++)
            {
                if (vector[i] < promedio)
                {
                    menorPromedio++;
                }
                else
                {
                    mayorPromedio++;
                }
            }
            Console.WriteLine($"{menorPromedio} números menores y {mayorPromedio} números mayores al promedio");*/


             
            // 4. Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el orden de los elementos del vector. Se deben mostrar los dos vectores.

            /*int entrada;
            Console.WriteLine("Ingrese longitud del vector");
            entrada = Convert.ToInt32(Console.ReadLine());
            int j = entrada;
            char[] vector = new char[entrada];

            for(int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese posición:{i + 1}");
                vector[i] = Convert.ToChar(Console.ReadLine()); 
            }
            Console.Write("V:");
            for (int i = 0; i < vector.Length; i++)
            {
                
                Console.Write($"{vector[i]}|");
            }
            Console.WriteLine();
            Console.Write("-V:");
            while (j > 0)
            {
                j--;
                Console.Write($"{vector[j]}|");
            }*/


            // 5. Crear un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre 0 y 50. Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el vector resaltando el número en un color diferente. Si no se encuentra el número, se debe devolver y mostrar -1. 
            
            Random rand = new Random();
            int[] vector = new int[20];
            int nUsuario;
            int j = 0;

            Console.WriteLine("Ingrese número a buscar");
            nUsuario = int.Parse(Console.ReadLine());
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rand.Next(0, 20);
            }
            
            
            for (int i = 0; i <= vector.Length; i++)
            {
                Console.Write($"{vector[i]}|");
            }

            while (j < vector.Length)
            {
                if (vector[j] == nUsuario)
                {
                    break; 
                }
                j++;
            }
            
            
            



            /* 6. Esribir un algoritmo que permita:
             * a. Crear un vector con rango impar, exceptuando el 1.
             * b. Pedirle al usuario un número entero y almacenarlo en la mitad del vector.
             * c. Llenar la primera mitad del vector con los números menores al número almacenado en la posición de la mitad.
             * d. Llenar la parte inicial del vector, con los números menores al número almacenado en la posición de la mitad.
             */

            

        }
    }
}
