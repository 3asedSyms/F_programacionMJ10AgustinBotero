using System;

namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un algoritmo que lea tres numeros A, B, C y visualice en pantalla el valor mas grande. El usuario debe ingresar tres valores diferentes

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese tres números diferentes");
            Console.WriteLine("Número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Número 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Número 3: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " es el mayor");
                }
                else
                {
                    Console.WriteLine(num3 + " es el mayor");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2 + " es el mayor");
                }
                else
                {
                    Console.WriteLine(num3 + " es el mayor");
                }
                     
            }
        }
    }
}
