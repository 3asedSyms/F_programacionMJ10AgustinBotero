using System;

namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Orden de evaluación operadores númericos
            float dato1 = 4 * 3 / 2;
            float dato2 = 4f / 3 * 2;
            float dato3 = 4 * (2f / 3f);
            float dato4 = 4 + 6 * 3;
            float dato5 = 4 + 6 * (2 - 1);
            Console.WriteLine(dato2);

            //Operadores lógicos 
            
            //Conjunción - AND - Y - &&
            Console.WriteLine("TABLA CONJUNCIÓN");
            Console.WriteLine("V && V = " + (true && true));
            Console.WriteLine("V && F = " + (true && false));
            Console.WriteLine("F && V = " + (false && true));
            Console.WriteLine("F && F = " + (false && false));

            //Disyunción - OR - O - ||
            Console.WriteLine("TABLA CONJUNCIÓN");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || V = " + (false || true));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine("--------------");

            //Operador logico negación
            bool dato8 = true;
            bool dato9 = !dato8;

            //Operadores de comparación
            bool dato6 = 5 > 4;
            bool dato7 = 100 == 99;
            bool dato10 = 1002 != 102;
            bool dato11 = 10 >= 10;
            bool dato12 = 12 < 11 && 0 == 1;
            bool dato13 = dato8 && 0 != 10 || !dato10;
        }
    }
}
