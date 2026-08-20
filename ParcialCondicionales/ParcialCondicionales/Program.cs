using System;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string nombre;
            int añosTrabajo;
            float añoActual = 0.0f;
            float añoAnterior = 0.0f;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de años trabajados en la empresa");
            añosTrabajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese calificacion del año actual");
            añoActual = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese calificacion del año anterior");
            añoAnterior = Single.Parse(Console.ReadLine());


            if (añoActual == 0.0f || añoActual == 0.4f || añoActual == 0.6f || añoActual == 1.0f)
            {
                if (añoAnterior == 0.0f || añoAnterior == 0.4f || añoAnterior == 0.6f || añoAnterior == 1.0f)
                {
                    float promedio = 0.0f;
             

                    promedio = añoActual + añoAnterior / 2;
                    Console.WriteLine(promedio);

                    
                }
                else
                {
                    Console.WriteLine("Error: calificación inválida. El programa terminará.");
                }
                

            }
            else
            {
                Console.WriteLine("Error: calificación inválida. El programa terminará.");
            }

        }
    }
}
