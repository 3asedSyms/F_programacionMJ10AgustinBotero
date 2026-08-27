using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realizar un algoritmo que le pida al usuario por teclado numeros enteros al azar. Al usuario le corresponde ingresar la cantidad de numeros que va a introducir. El algoritmo debe escribir en pantalla:
             - La cantidad de numeros introducidos que son mayores que 0
             - La cantidad de numeros introducidos que son menores que 0
             - La cantidad de numeros iguales a 0 */

            /*int cantidadNumeros;
            int numero = 0;
            int contador = 0;
            int contadorPositivo = 0;
            int contadorNegativo = 0;
            int contadorCeros = 0;

            Console.WriteLine("Ingrese la cantidad de numeros a evaluar");
            cantidadNumeros = Convert.ToInt32(Console.ReadLine());


            while (contador < cantidadNumeros)
            {
                contador++;
                Console.WriteLine("Ingrese el numero a evaluar");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero > 0)
                {
                    contadorPositivo++;
                }
                else
                {
                    if (numero < 0)
                    {
                        contadorNegativo++;
                    }
                    else
                    {
                        contadorCeros++;
                    }
                }
            }
            Console.WriteLine("Ceros:" + contadorCeros);
            Console.WriteLine("Positivos:" + contadorPositivo);
            Console.WriteLine("Negativos:" + contadorNegativo);*/

            int n = 0;
            int contador = 1;
            int contadorPares = 0;
            
            Console.WriteLine("Ingrese el rango");
            n = int.Parse(Console.ReadLine());

            while (contador <= n)
            {
                if (contador % 2 == 0)
                {
                    contadorPares++;
                    Console.WriteLine($"{contador}");
                }
                contador++;
            }
            Console.WriteLine($"La cantidad de numeros pares de 1 a {n} es de: {contadorPares}");
        }
    }
}
