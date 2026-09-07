using System;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string nombre;
            int añosTrabajo;
            double añoActual;
            double añoAnterior;
            double promedio;
            const int sueldoBase = 2500000;
            double valorAumento;
            
            Console.WriteLine("Ingrese su nombre"); 
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de años trabajados en la empresa");
            añosTrabajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese calificacion del año anterior");
            añoAnterior = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese calificacion del año actual");
            añoActual = Convert.ToDouble(Console.ReadLine());
            promedio = (añoActual + añoAnterior) / 2;
            
            
            switch (añoAnterior)
            {
                case 0.0:
                case 0.4:
                case 0.6:
                case 1.0:
                    {
                        switch (añoActual)
                        {
                            case 0.0:
                            case 0.4:
                            case 0.6:
                            case 1.0:
                                {
                                    Console.WriteLine(nombre);
                                    Console.WriteLine(promedio);
                                    
                                    switch (añosTrabajo)
                                    {
                                        case 0:
                                            {
                                                valorAumento = sueldoBase * 0; //0%
                                                Console.WriteLine("0%");
                                                Console.WriteLine(valorAumento);
                                            }
                                            break;
                                        case 1:
                                        case 2:
                                        case 3:
                                        case 4:
                                        case 5:
                                            {
                                                if ( 0.0 <= promedio && promedio < 0.4)
                                                {
                                                    valorAumento = sueldoBase * 0.5; //5%
                                                    Console.WriteLine("5%");
                                                    Console.WriteLine(valorAumento);
                                                }
                                                else if (0.4 <= promedio && promedio < 0.6)
                                                {
                                                    valorAumento = sueldoBase * 0.1;//10%
                                                    Console.WriteLine("10%");
                                                    Console.WriteLine(valorAumento);
                                                }
                                            }
                                            break;
                                        default:
                                            valorAumento = sueldoBase * 0.3; //30%
                                            Console.WriteLine("30%");
                                            Console.WriteLine(valorAumento);
                                            break;
                                            
                                    
                        
                                    }
                                    break;
                                }
                            default:
                                Console.WriteLine("Error: calificación inválida. El programa terminará.");
                                break;
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Error: calificación inválida. El programa terminará.");
                    break;
            }
        
        }
    }
}
