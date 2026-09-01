using System;
namespace _10.CiclosWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escribe un algoritmo en el que el computador elija un numero aleatorio entre 1 y 100.
            // El usuario debe adivinar el numero y el programa debe decirle si su intento es demasiado alto,
            // bajo o correcto.
            // Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el numero.
            // Utilizar la funcion random para elegir el numero aleatorio.

            Random rnd = new Random();
            int entrada;

            int numero = rnd.Next(1,101);
            Console.WriteLine("Adivine el número");
            entrada = int.Parse(Console.ReadLine());

            while (entrada != numero)
            {    
                if (entrada <= numero)
                {
                    Console.WriteLine("Muy bajo");
                }
                else if (entrada >= numero)
                {
                    Console.WriteLine("Muy alto");
                }
            entrada = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Correcto");
        }
    }
}
