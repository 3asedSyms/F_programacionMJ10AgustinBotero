using System;

namespace _12.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que le pida a un grupo de usuarios su nombre, numero de cuenta y saldo; para cada usuario se debe hacer lo siguiente:
            // 1. Si el saldo es mayor o igual 3.000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y "es apto para el crédito."
            // 2. Si el saldo es menor a 3.000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y "No es apto para el crédito."
            //El algoritmo debe permitir preguntar la informacion de usuarios, hasta que se le indique que ya no se desea preguntar más.
            //Además, el algoritmo debe permitir mostrar el número de usuarios a los que se les preguntó por la información, y debe mostrar el promedio de los saldos.

            /*string nombre;
            int nCuenta = 0;
            int saldo = 0;
            char respuesta;
            int contador = 0;
            float promedio = 0f;
            int acumulador = 0;


            do
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su numero de cuenta");
                nCuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su saldo");
                saldo = int.Parse(Console.ReadLine());

                if (saldo >= 3000000)
                {
                    Console.WriteLine($"{nombre}, {nCuenta}, {saldo}, es apto para el credito");
                }
                else
                {
                    Console.WriteLine($"{nombre}, {nCuenta}, {saldo}, NO! es apto para el credito");
                }
                acumulador += saldo;
                Console.WriteLine("¿Desea continuar? s o n");
                respuesta = char.Parse(Console.ReadLine());
                contador++;
            } while (respuesta == 's');
            promedio = acumulador / contador;
            
            Console.WriteLine("Se le preguntó a : " + contador + " usuario(s)");
            Console.WriteLine("El promedio de los saldos es: " + promedio);
*/



            //Crear un algoritmo que:
            // - Permita al usuario ingresar una contraseña
            // - Se repita hasta que ingrese la contraseña correcta(por ejemplo:1234)
            // - Mostrar cuántos intentos relizó

            int entrada = 0;
            int contraseña = 1234;
            int contador = 0;

            Console.WriteLine("Ingrese la contraseña:");
            do
            {
                entrada = int.Parse(Console.ReadLine());
                contador++;

                if (entrada != contraseña)
                {
                    Console.WriteLine("Intente otra vez:");
                }
            } while (entrada != contraseña);
            Console.WriteLine("Intentos: " + contador);
        }
    }
}
