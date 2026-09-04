using System;
namespace _13.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int acumulador = 0;

            for (int contador = 1; contador <= 5; contador++)
            {
                acumulador += contador;
            }
            Console.WriteLine("La suma de los primeros cinco números enteros es: " + acumulador);*/


            //Realizar un programa que permita mostrar por pantalla los números múltiplos de 5,
            //el usuario debe ingresar por el teclado el rango de números a evaluar.

            int n;
            int acumulador = 0;

            Console.WriteLine("Ingrese la cantidad de multiplos de 5 a evaluar: ");
            n = int.Parse(Console.ReadLine());

            
                for (int contador = 5; n > acumulador; contador += 5)
                {
                    acumulador++;
                    Console.WriteLine(contador);
                }
            
        }
    }
}
