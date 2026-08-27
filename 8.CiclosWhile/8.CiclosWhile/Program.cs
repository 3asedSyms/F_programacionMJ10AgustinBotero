using System;

namespace _8.CiclosWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida numeros enteros positivos y los sume, hasta que se ingrese un numero entero negativo. Se debe mostrar por pantalla el total de la suma de los numeros ingresados.

            int numero = 0;
            int acumulador = 0;
            Console.WriteLine("Ingrese el numero a sumar");

            numero = Convert.ToInt32(Console.ReadLine());

            while (numero >= 0)
            {

                acumulador += numero;
                Console.WriteLine("Ingrese el numero a sumar");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(acumulador);


        }
    }
}
