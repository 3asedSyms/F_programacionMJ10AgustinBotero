using System;
namespace TallerPreparacionCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Algoritmo que permita calcular el promedio de calificaciones, el algoritmo le permitirá al usuario introducir tantas calificaciones como así desee, en el momento en que seleccione que no desea continuar capturando calificaciones, el algoritmo debe presentar el promedio de las calificaciones capturadas previamente. 

            /*char respuesta;
            double calificacion;
            double promedio;
            int contador = 0;
            double acumulador = 0;

            Console.WriteLine("diga, s o n");
            respuesta = Convert.ToChar(Console.ReadLine());

            do
            {
                Console.WriteLine("Ingrese calificación");
                calificacion = Convert.ToDouble(Console.ReadLine());
                acumulador += calificacion;
                contador++;

                promedio = acumulador / contador;

                Console.WriteLine("diga, s o n");
                respuesta = Convert.ToChar(Console.ReadLine());

            } while (respuesta == 's');
            Console.WriteLine(promedio );*/

            // 2. Se requiere un algoritmo para mostrar por pantalla los divisores de un número ingresado por teclado.
            // Tener en cuenta que dados dos números enteros a y b, se dice que b es divisor de a si se cumple que al efectuar una división entera a/b el residuo es 0. En C#, utilizar el operador Mod para obtener el residuo de una división de dos números.
            //Ejemplo: Si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 2, 1 que son los divisores del número 6.

            /*int numero;

            Console.WriteLine("Ingrese un número");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int contador = numero; contador >= 1; contador--)
            {
                if (numero % contador == 0)
                {
                    Console.WriteLine(contador);
                }
            }*/



            // 3. Dados dos números enteros ingresados por teclado: b que es la base y e que es el eponente, se requiere calcular el resultado de la potenciación
            // Ejemplo: b = 2, e = 5 => 2^5 = 2*2*2*2*2 = 32
            // Mostrar por pantalla el resultado de la potenciación
            // Seguir pidiendo por teclado la base y el exponente y realizar la potenciación correspondiente, hasta que el usuario ingrese por teclado el carácter de escape 'n' 
        }
    }
}
