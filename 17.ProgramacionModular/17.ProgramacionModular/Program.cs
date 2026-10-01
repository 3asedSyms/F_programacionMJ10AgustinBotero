using System;
namespace _17.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de fundamentos de programación");
            MostrarMensaje("Agustín");
            MostrarMensaje("Agustín", "Botero");
            Console.ReadKey();
            BorrarPantalla();
            
        }
        //Procedimientos sin parámetros
        static void BorrarPantalla()
        {
            Console.Clear();
        }
        //Procedimientos con parámetros
        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso de Fundamentos de Programación");
        }
        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso de Fundamentos de Programación");
        }
    }
}
