using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPotenciaYPrimos
{
    class Program
    {
        static void Main()
        {
            string opcion;
            do 
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Calcular Area");
                Console.WriteLine("2. Transformar grados a radianes");
                Console.WriteLine("3. Salir");
                Console.Write("Ingresa el número de opción: ");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CalcularArea();
                        break;

                    case "2":
                        GradosARadianes();
                        break;

                    default:
                        Console.WriteLine("La opcion no es validad.");
                        break;
                }
            } while(opcion != "3");
        }

        static void CalcularArea()
        {
            string opcion1;
            do
            {
                
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Calcular área de un círculo");
                Console.WriteLine("2. Calcular área de un cuadrado");
                Console.WriteLine("3. Calcular área de un triángulo");
                Console.WriteLine("4. Salir");
                Console.Write("Ingresa el número de opción: ");

                opcion1 = Console.ReadLine();


                switch (opcion1)
                    {
                        case "1":
                            CalcularAreaCirculo();
                            break;

                        case "2":
                            CalcularAreaCuadrado();
                            break;

                        case "3":
                            CalcularAreaTriangulo();
                            break;

                        default:
                            Console.WriteLine("La opcion no es valida.");
                            break;


                    }
            } while (opcion1 != "4");

        }
        static void CalcularAreaCirculo()
        {
            Console.Write("Ingresa el radio del círculo: ");
            if (!double.TryParse(Console.ReadLine(), out double radio) || radio <= 0)
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número positivo.");
                return;
            }

            double area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
        }

        static void CalcularAreaCuadrado()
        {
            Console.Write("Ingresa el lado del cuadrado: ");
            if (!double.TryParse(Console.ReadLine(), out double lado) || lado <= 0)
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número positivo.");
                return;
            }

            double area = Math.Pow(lado, 2);
            Console.WriteLine($"El área del cuadrado con lado {lado} es: {area}");
        }

        static void CalcularAreaTriangulo()
        {
            Console.Write("Ingresa la base del triángulo: ");
            if (!double.TryParse(Console.ReadLine(), out double baseTriangulo) || baseTriangulo <= 0)
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número positivo.");
                return;
            }

            Console.Write("Ingresa la altura del triángulo: ");
            if (!double.TryParse(Console.ReadLine(), out double altura) || altura <= 0)
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número positivo.");
                return;
            }

            double area = (baseTriangulo * altura) / 2;
            Console.WriteLine($"El área del triángulo con base {baseTriangulo} y altura {altura} es: {area}");
        }

        static void GradosARadianes()
        {
            Console.Write("Ingresa los grados a transformar a radianes: ");
            if (!double.TryParse(Console.ReadLine(), out double grados))
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número.");
                return;
            }

            double radianes = grados * Math.PI / 180;
            Console.WriteLine($"{grados} grados equivalen a {radianes} radianes.");
        }

    }
}
