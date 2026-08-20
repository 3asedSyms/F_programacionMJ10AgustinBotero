using System;

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
            ingresar números diferentes.*/

            int numero1;
            int numero2;
            int numero3;

            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            numero3 = int.Parse(Console.ReadLine());

            switch ()
            {
                case 0.0f:

                    break;
            }

            /*if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3) //Son diferentes
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

        }
    }
}
