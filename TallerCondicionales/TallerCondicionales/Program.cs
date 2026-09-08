using System;
using System.Globalization;

namespace TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes.

            int numero1;
            int numero2;
            int numero3;

            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            numero3 = int.Parse(Console.ReadLine());

            if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3) //Son diferentes
            {
               if (numero1 > numero2 && numero1 > numero3) //numero1 es el mayor
                {
                    if (numero2 > numero3) //numero2 es el de en medio, numero3 es el menor
                    {
                        Console.WriteLine(numero3 + "," + numero2 + "," + numero1);
                    }
                    else //numero3 es el de en medio, numero2 es el menor
                    {
                        Console.WriteLine(numero2 + "," + numero3 + "," + numero1);
                    } 
                } else if (numero2 > numero3 && numero2 > numero1) //numero2 es el mayor
                {
                    if (numero1 > numero3) //numero1 es el de en medio, numero3 es el menor
                    {
                        Console.WriteLine(numero3 + "," + numero1 + "," + numero2);
                    }
                    else //numero3 es el de en medio, numero1 es el menor
                    {
                        Console.WriteLine(numero1 + "," + numero3 + "," + numero2);
                    }
                }
                else //numero3 es el mayor
                {
                    if (numero2 > numero1) // numero3 es el mayor, numero2 el de en medio, numero1 el menor
                    {
                        Console.WriteLine(numero1 + "," + numero2 + "," + numero3);
                    } 
                    else // numero 3 es el mayor, numero1 el de en medio, numero2 el menor
                    {
                        Console.WriteLine(numero2 + "," + numero1 + "," + numero3);
                    }
                }
            }
            else 
            {
                Console.WriteLine("Se deben ingresar numeros diferentes");
            }*/

            
            
            
            // 2. El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: Si cuenta con munición y se encuentra en estado invencible. Crear un programa que:
            //a. Permita ingresar por teclado si el personaje está en estado invencible (True).
            //b. La cantidad de munición que tiene el personaje en el momento será calculada por el sistema por medio de un número aleatorio, para ello utilizar la clase random de C#.
            //c. Si el estado del personaje es invencible (true) y su cantidad de munición está entre 1 y 10, mostrar un mensaje en la consola "El personaje está disparando", en caso contrario no hacer nada.
            
            char entrada; 
            bool estado;
            int  munición;
            
            Random rand = new Random();
            munición = rand.Next(1,10);

           Console.WriteLine("¿El personaje esta en estado invencible? s o n");
           entrada = char.Parse(Console.ReadLine());
           if (entrada == 's' && munición <= 10 && munición >= 1)
            {
                estado = true;
                Console.WriteLine("El personaje está disparando");
            }
            else
            {
                estado = false;
            }
            Console.WriteLine("Invencible: " + estado + "; Munición: " + munición);
          
            
        }
    }
}
