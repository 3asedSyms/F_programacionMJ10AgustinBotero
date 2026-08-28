using System;

namespace _7.Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoriitmo que permita generar los primeros 5 numeros enteros positivos, realizar y mostrar su suma

            /*int contador = 1;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador += contador;
                Console.WriteLine(contador);
                contador++;
            }
            Console.WriteLine(acumulador);*/




            //Algoritmo que permita calcular el factorial de un numero dado por el usuario

            int nUsuario;
            int contador = 1;
            int acumulador = 1;

            Console.WriteLine("Ingrese un numero:");
            nUsuario = int.Parse(Console.ReadLine());

            while (contador <= nUsuario)
            {
                Console.WriteLine(contador);
                acumulador *= contador;
                contador++;

                
            }
            Console.WriteLine(acumulador);

        }
    }
}
