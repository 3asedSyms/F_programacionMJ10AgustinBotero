using System;
namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // En el programa de ingeniería de sistemas, que cuenta con 15 estudiantes, se desa procesar información estadistica sobre la ocupación y el género de los alumnos
            // Utilizando obligatoriamente una estructura repetitiva, el programa debe realizar las siguientes acciones por cada estudiante:
            // 1. Ingreso de datos: Solicitar por teclado la ocupación del estudiante y su género. Para evitar errores de escritura, se deben utilizar códigos estandarizados:
            // - Ocupación: Digitar T si trabaja o E si estudia
            // - Género: Digitar H si es hombre o M si es mujer
            // 2. Calculo de Porcentajes: Al finalizar el ingreso de los 15 estudiantes, calcular y mostrar el porcentaje de estudiantes que trabajan y el porcentaje de los que estudian respecto al total del grupo.
            // 3. Cálculo de cruces (condicionales): A medida que se procesan los datos, determinar y mostrar:
            // - La cantidad total de mujeres que trabajan
            // - La cantidad total de hombres que estudian
            // 4. Reporte Final: Mostrar claramente en pantalla los porcentajes calculados y los dos conteos especificos solicitados.

            char genero;
            char ocupacion;
            int contador = 0;
            int contadorMujer = 0;
            int contadorHombre = 0;
            int contadorTrabajo = 0; ;
            int contadorEstudio = 0;
            int porcentajeEstudio = 0;
            int porcentajeTrabajo = 0;
            
            while (contador < 3)
            {
                Console.WriteLine("Digitar T si trabaja o E si estudia");
                ocupacion = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Digitar H si es hombre o M si es mujer");
                genero = Convert.ToChar(Console.ReadLine());
                contador++;

                if (ocupacion == 'T')
                {
                    contadorTrabajo++;
                    
                }
                else if(ocupacion == 'E')
                {
                    contadorEstudio++;
                    
                }
                if (genero == 'H')
                {
                    contadorHombre++;
                    Console.WriteLine(contadorHombre);
                }
                else if (genero == 'M')
                {
                    contadorMujer++;
                }



                Console.WriteLine("Mujeres: "+ contadorMujer);
                Console.WriteLine("Hombres: " + contadorHombre);

            }
            porcentajeEstudio = (contadorEstudio / 3) * 100;
            porcentajeTrabajo = (contadorTrabajo / 3) * 100;
            Console.WriteLine($"Trabaja :{porcentajeTrabajo}% ; Estudia: {porcentajeEstudio}%");


        }
    }
}
