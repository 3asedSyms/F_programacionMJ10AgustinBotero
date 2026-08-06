using System;

namespace _4.CondicionalesSimplesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTRUCTURAS DE CONTROL CONDICIONAL
            //Condicional simple
            //1. Crea un alfgoritmo que lea la edad del ususario, si un usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web"

            /*
            byte edad;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());
             if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
           */

            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona. Si el sueldo supera los 3000 pesos, mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos

            /*string nombre;
            decimal sueldo;
            
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sueldo");
            sueldo = Convert.ToDecimal(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine(nombre + ", debe abonar impuestos");
            }*/

            //1. Crea un alfgoritmo que lea la edad del ususario, si un usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web". De lo contrario, mostrar el mensaje: "No es apto para el contenido del sitio".


            /*byte edad;
             Console.WriteLine("Ingrese su edad");
             edad = Convert.ToByte(Console.ReadLine());
              if (edad >= 18)
             {
                 Console.WriteLine("Bienvenido a mi sitio web");
             }
             else
             {
                 Console.WriteLine("No es apto para el contenido del sitio");
             }
            */

            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona. Si el sueldo supera los 3000 pesos, mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. De lo contrario, mostrar el mensaje "Persona exenta de impuestos"

            /* string nombre;
             decimal sueldo;

             Console.WriteLine("Ingrese su nombre");
             nombre = Console.ReadLine();
             Console.WriteLine("Ingrese sueldo");
             sueldo = Convert.ToDecimal(Console.ReadLine());

             if (sueldo > 3000)
             {
                 Console.WriteLine(nombre + ", debe abonar impuestos");
             }
             else
             {
                 Console.WriteLine("Persona exenta de impuestos");
             }*/

            //Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número, informar su suma y diferencia, en caso contrario, informar el producto y la division del primer numero respecto al segundo numero

            float numero1;
            float numero2;

            Console.WriteLine("Ingrese numero 1");
            numero1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            numero2 = Convert.ToSingle(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine(numero1 + numero2);
                Console.WriteLine(numero1 - numero2);
            }
            else
            {
                Console.WriteLine(numero1 * numero2);
                Console.WriteLine(numero1 / numero2);
            }

        }
    }
}
