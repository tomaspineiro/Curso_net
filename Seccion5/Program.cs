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
            // Bucle principal del menú
            do 
            {
                // Mostrar las opciones del menú
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Calcular Area");
                Console.WriteLine("2. Transformar grados a radianes");
                Console.WriteLine("3. Salir");
                Console.Write("Ingresa el número de opción: ");

                // Leer la opción del usuario
                opcion = Console.ReadLine();

                // Switch para manejar las diferentes opciones
                switch (opcion)
                {
                    case "1":
                        CalcularArea();
                        break;

                    case "2":
                        GradosARadianes();
                        break;

                    default:
                        Console.WriteLine("La opcion no es válida.");
                        break;
                }
            } while(opcion != "3"); // Continuar hasta que el usuario elija salir
        }

        // Método para calcular el área de diferentes figuras
        static void CalcularArea()
        {
            string opcion1;
            // Bucle para mostrar las opciones del cálculo del área
            do
            {
                // Mostrar las opciones de cálculo de área
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Calcular área de un círculo");
                Console.WriteLine("2. Calcular área de un cuadrado");
                Console.WriteLine("3. Calcular área de un triángulo");
                Console.WriteLine("4. Salir");
                Console.Write("Ingresa el número de opción: ");

                // Leer la opción del usuario
                opcion1 = Console.ReadLine();

                // Switch para manejar las diferentes opciones de cálculo del área
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
                        Console.WriteLine("La opcion no es válida.");
                        break;
                }
            } while (opcion1 != "4"); // Continuar hasta que el usuario elija salir
        }

        // Método para calcular el área de un círculo
        static void CalcularAreaCirculo()
        {
            Console.Write("Ingresa el radio del círculo: ");
            // Validar y leer el radio ingresado por el usuario
            if (!double.TryParse(Console.ReadLine(), out double radio) || radio <= 0)
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número positivo.");
                return;
            }

            // Calcular el área del círculo
            double area = Math.PI * Math.Pow(radio, 2);
            // Mostrar el resultado del cálculo del área
            Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
        }

        // Método para calcular el área de un cuadrado
        static void CalcularAreaCuadrado()
        {
            Console.Write("Ingresa el lado del cuadrado: ");
            // Validar y leer el lado ingresado por el usuario
            if (!double.TryParse(Console.ReadLine(), out double lado) || lado <= 0)
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número positivo.");
                return;
            }

            // Calcular el área del cuadrado
            double area = Math.Pow(lado, 2);
            // Mostrar el resultado del cálculo del área
            Console.WriteLine($"El área del cuadrado con lado {lado} es: {area}");
        }

        // Método para calcular el área de un triángulo
        static void CalcularAreaTriangulo()
        {
            Console.Write("Ingresa la base del triángulo: ");
            // Validar y leer la base ingresada por el usuario
            if (!double.TryParse(Console.ReadLine(), out double baseTriangulo) || baseTriangulo <= 0)
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número positivo.");
                return;
            }

            Console.Write("Ingresa la altura del triángulo: ");
            // Validar y leer la altura ingresada por el usuario
            if (!double.TryParse(Console.ReadLine(), out double altura) || altura <= 0)
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número positivo.");
                return;
            }

            // Calcular el área del triángulo
            double area = (baseTriangulo * altura) / 2;
            // Mostrar el resultado del cálculo del área
            Console.WriteLine($"El área del triángulo con base {baseTriangulo} y altura {altura} es: {area}");
        }

        // Método para transformar grados a radianes
        static void GradosARadianes()
        {
            Console.Write("Ingresa los grados a transformar a radianes: ");
            // Validar y leer los grados ingresados por el usuario
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
